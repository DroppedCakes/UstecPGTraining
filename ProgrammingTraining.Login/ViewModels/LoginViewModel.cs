using Prism.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using System.Windows.Controls;

namespace ProgrammingTraining.Login.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public ReactiveProperty<string> UserId { get; } = new ReactiveProperty<string>(string.Empty);

        public ReactiveCommand<PasswordBox> LoginCommand { get; }

        private void Login(PasswordBox passwordBox)
        {
            passwordBox.Password = string.Empty;
            // TODO
            this._regionManager.RequestNavigate("ContentRegion", nameof(Worklist.Views.Worklist));
        }

        public LoginViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;

            this.LoginCommand = new ReactiveCommand<PasswordBox>()
                .WithSubscribe(passwordBox => this.Login(passwordBox));
        }
    }
}