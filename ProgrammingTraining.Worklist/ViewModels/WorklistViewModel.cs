using Prism.Mvvm;
using ProgrammingTraining.Models;
using Reactive.Bindings;
using System.ComponentModel;
using System.Windows.Data;
using System.Linq;
using System;

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

        #region Filtering

        public ReactiveProperty<string> TextFilter { get; } = new ReactiveProperty<string>(string.Empty);

        /// <summary>
        /// フィルター
        /// trueである検査のみワークリストに表示する
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        private bool WorkitemFilter(object o)
        {
            var study = o as WorkitemViewModel;
            var filterText = this.TextFilter.Value;

            if (!study.NameKanji.StartsWith(filterText)
                && !study.NameWKana.StartsWith(filterText)
                && !study.PatientId.StartsWith(filterText)
                && !study.OrderNumber.StartsWith(filterText))
            {
                return false;
                //  NOTREACHED
            }

            return true;
        }

        /// <summary>
        /// Filter結果を反映するために、
        /// ICollectionViewの再描画を行う
        /// </summary>
        private void Refresh()
        {
            this.StudiesView.Refresh();
        }

        #endregion Filtering

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
            this.StudiesView.Filter = this.WorkitemFilter;

            this.ClearCommand = new ReactiveCommand()
                .WithSubscribe(this._workitemManager.ClearWorkitems);

            this.ReloadCommand = new ReactiveCommand()
                .WithSubscribe(() => this.ReloadWorkitems());

            this.ChangeTitleCommand = new ReactiveCommand()
                .WithSubscribe(() => this._titleMessenger.ChangeTitle("Worklist"));

            this.TextFilter.Subscribe(_ => this.Refresh());
        }

        public WorklistViewModel()
        {
        }
    }
}