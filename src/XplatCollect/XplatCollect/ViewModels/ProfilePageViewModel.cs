using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using Prism.Services;
using XplatCollect.Models;

namespace XplatCollect.ViewModels
{
    public sealed class ProfilePageViewModel : ViewModelBase
    {
        public ProfilePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
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
    }
}
