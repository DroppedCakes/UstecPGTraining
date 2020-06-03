using Prism.Ioc;
using Prism.Modularity;
using ProgrammingTraining.Login;
using ProgrammingTraining.Models;
using ProgrammingTraining.Views;
using ProgrammingTraining.Worklist;
using System.Windows;

namespace ProgrammingTraining
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(new WorkitemManager());
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<LoginModule>(InitializationMode.WhenAvailable);
            moduleCatalog.AddModule<WorklistModule>(InitializationMode.WhenAvailable);
        }
    }
}
