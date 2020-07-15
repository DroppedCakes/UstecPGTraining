using Prism.Mvvm;
using ProgrammingTraining.Models;
using Reactive.Bindings;
using System.ComponentModel;
using System.Windows.Data;

namespace ProgrammingTraining.Worklist.ViewModels
{
    public class WorklistViewModel : BindableBase
    {
        private readonly WorkitemManager _workitemManager;
        private readonly TitleMessenger _titleMessenger;

        public ReadOnlyReactiveCollection<WorkitemViewModel> Studies;

        public ICollectionView StudiesView { get; }

        public ReactiveCommand ClearCommand { get; }

        public ReactiveCommand ReloadCommand { get; }

        /// <summary>
        /// Shell(MainWindow)のタイトル変更コマンド
        /// </summary>
        public ReactiveCommand ChangeTitleCommand { get; }

        /// <summary>
        ///
        /// </summary>
        public void ReloadWorkitems()
        {
            this._workitemManager.FetchWorkitems();
        }

        /// <summary>
        /// コンストラクタ
        /// DIでModel層を注入する
        /// </summary>
        /// <param name="workitemManager"></param>
        public WorklistViewModel(WorkitemManager workitemManager, TitleMessenger titleMessenger)
        {
            this._workitemManager = workitemManager;
            this._titleMessenger = titleMessenger;

            this.Studies = this._workitemManager.Workitems
                .ToReadOnlyReactiveCollection(x => new WorkitemViewModel(x));

            this.StudiesView = CollectionViewSource.GetDefaultView(this.Studies);

            this.ClearCommand = new ReactiveCommand()
                .WithSubscribe(this._workitemManager.ClearWorkitems);

            this.ReloadCommand = new ReactiveCommand()
                .WithSubscribe(() => this.ReloadWorkitems());

            this.ChangeTitleCommand = new ReactiveCommand()
                .WithSubscribe(() => this._titleMessenger.ChangeTitle("Worklist"));
        }

        public WorklistViewModel()
        {
        }
    }
}