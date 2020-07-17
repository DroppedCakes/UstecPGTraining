using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using ProgrammingTraining.Login.Properties;
using Reactive.Bindings;
using System.Windows;
using System.Windows.Controls;
using Ustec.WpfHelpers.DialogService.Extensions;

namespace ProgrammingTraining.Login.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        private readonly IDialogService _dialogService;

        public ReactiveProperty<string> UserId { get; } = new ReactiveProperty<string>(string.Empty);

        public ReactiveCommand<PasswordBox> LoginCommand { get; }

        public ReactiveCommand ShutdownCommand { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="passwordBox"></param>
        private void Login(PasswordBox passwordBox)
        {
            passwordBox.Password = string.Empty;
            // TODO
            this._regionManager.RequestNavigate("ContentRegion", nameof(Worklist.Views.Worklist));
        }

        /// <summary>
        ///
        /// </summary>
        private void Shutdown()
        {
            if (this._dialogService.ShowConfirmationMessage(Resources.confirm_exit_application) == ButtonResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="regionManager"></param>
        /// <param name="dialogService"></param>
        public LoginViewModel(IRegionManager regionManager, IDialogService dialogService)
        {
            this._regionManager = regionManager;
            this._dialogService = dialogService;

            this.LoginCommand = new ReactiveCommand<PasswordBox>()
                .WithSubscribe(passwordBox => this.Login(passwordBox));

            this.ShutdownCommand = new ReactiveCommand()
                .WithSubscribe(this.Shutdown);
        }
    }
}