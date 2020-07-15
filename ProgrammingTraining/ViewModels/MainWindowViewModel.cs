using Prism.Mvvm;
using ProgrammingTraining.Models;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace ProgrammingTraining.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly TitleMessenger _titleMessenger;

        public ReactiveProperty<string> Title { get; }

        public MainWindowViewModel(TitleMessenger titleMessenger)
        {
            // Model
            this._titleMessenger = titleMessenger;

            // Model → VMの接続
            this.Title = this._titleMessenger
                .ObserveProperty(m => m.Title)
                .ToReactiveProperty();
        }
    }
}
