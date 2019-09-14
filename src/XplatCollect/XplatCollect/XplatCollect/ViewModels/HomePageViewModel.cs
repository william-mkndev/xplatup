using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace XplatCollect.ViewModels
{
    public sealed class HomePageViewModel : ViewModelBase
    {
        private string title;

        public HomePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService) 
            : base(navigationService, pageDialogService)
        {
            
        }

        public string Title {
            get => title;
            set => SetProperty(ref title, value);
        }
    }
}
