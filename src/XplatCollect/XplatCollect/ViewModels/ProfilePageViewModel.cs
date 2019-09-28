using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using XplatCollect.Models;
using XplatCollect.Services;

namespace XplatCollect.ViewModels
{
    public sealed class ProfilePageViewModel : ViewModelBase
    {
        private readonly IPersonService personService;

        public ProfilePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService
            , IPersonService personService)
            : base(navigationService, pageDialogService)
        {
            this.personService = personService;

            CreateProfileCommand = new DelegateCommand(async () => ExecuteCreateProfile())
                .ObservesCanExecute(() => IsNotBusy);
        }



        private string name;
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string bio;
        public string Bio
        {
            get => bio;
            set => SetProperty(ref bio, value);
        }

        private string avatar;
        public string Avatar
        {
            get => avatar;
            set => SetProperty(ref avatar, value);
        }

        private int collectionsQnt;
        public int CollectionsQnt
        {
            get => collectionsQnt;
            set => SetProperty(ref collectionsQnt, value);
        }

        private int itensQnt;
        public int ItensQnt
        {
            get => itensQnt;
            set => SetProperty(ref itensQnt, value);
        }

        private bool hasProfile;
        public bool HasProfile
        {
            get => hasProfile;
            set => SetProperty(ref hasProfile, value);
        }

        public ICommand CreateProfileCommand { get; }

        public override Task InitializeAsync(INavigationParameters parameters)
        {
            LoadPerson();

            return base.InitializeAsync(parameters);
        }

        protected override Task OnTabActive()
        {
            LoadPerson();

            return base.OnTabActive();
        }

        private void LoadPerson()
        {
            HasProfile = personService.HasPerson();

            if (HasProfile)
            {
                var person = personService.GetPerson();

                Name = person.Name;
                Bio = person.Bio;
                Avatar = person.Avatar;
            }
        }

        private async Task ExecuteCreateProfile()
        {
            await ExecuteBusyAction(async () =>
            {
                var person = Person.Create("Zé das cove"
                    , "Já coloco", "");

                personService.Add(person);

                LoadPerson();
            });
        }
    }
}
