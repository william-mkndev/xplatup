using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;
using Prism.Services;

namespace XplatCollect.ViewModels
{
    public sealed class ProfilePageViewModel : ViewModelBase
    {
        public ProfilePageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService) 
            : base(navigationService, pageDialogService)
        {
        }

        private string userName;
        public string UserName
        {
            get => userName;
            set => SetProperty(ref userName, value);
        }

        private string userBio;
        public string UserBio
        {
            get => userBio;
            set => SetProperty(ref userBio, value);
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
