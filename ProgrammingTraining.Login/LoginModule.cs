using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using ProgrammingTraining.Login.ViewModels;

namespace ProgrammingTraining.Login
{
    public class LoginModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RequestNavigate("ContentRegion", nameof(Views.Login));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<LoginViewModel>();
            containerRegistry.RegisterForNavigation<Views.Login>();
        }
    }
}