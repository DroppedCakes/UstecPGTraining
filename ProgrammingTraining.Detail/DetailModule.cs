using Prism.Ioc;
using Prism.Modularity;
using ProgrammingTraining.Detail.ViewModels;

namespace ProgrammingTraining.Detail
{
    public class DetailModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<DetailViewModel>();
            containerRegistry.RegisterForNavigation<Views.Detail>();
        }
    }
}