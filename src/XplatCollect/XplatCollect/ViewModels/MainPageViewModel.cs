using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using Prism.Services;

namespace XplatCollect.ViewModels
{
    public sealed class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService
            , IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {
        }

        public override Task InitializeAsync(INavigationParameters parameters)
        {
            return base.InitializeAsync(parameters);
        }
    }
}
