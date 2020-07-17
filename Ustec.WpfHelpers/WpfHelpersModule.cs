using Prism.Ioc;
using Prism.Modularity;
using Ustec.WpfHelpers.DialogService.ViewModels;
using Ustec.WpfHelpers.DialogService.Views;

namespace Ustec.WpfHelpers
{
    public class WpfHelpersModeule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterDialogWindow<MahappsWindowForDialog>();
            containerRegistry.RegisterDialog<ConfirmedMessageBox, ConfirmedMessageBoxViewModel>();
        }
    }
}