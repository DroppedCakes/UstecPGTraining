using Prism.Ioc;
using Prism.Modularity;
using ProgrammingTraining.Worklist.ViewModels;

namespace ProgrammingTraining.Worklist
{
    public class WorklistModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<WorklistViewModel>();
            containerRegistry.RegisterForNavigation<Views.Worklist>();
        }
    }
}