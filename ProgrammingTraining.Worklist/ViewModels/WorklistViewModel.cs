using Prism.Mvvm;
using ProgrammingTraining.Models;
using Reactive.Bindings;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;

namespace ProgrammingTraining.Worklist.ViewModels
{
    public class WorklistViewModel : BindableBase
    {
        private readonly WorkitemManager _workitemManager;

        public ReadOnlyReactiveCollection<WorkitemViewModel> Studies;

        public ICollectionView StudiesView { get; }

        public ReactiveCommand ClearCommand { get; }

        public ReactiveCommand ReloadCommand { get; }

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
        public WorklistViewModel(WorkitemManager workitemManager)
        {
            this._workitemManager = workitemManager;

            this.Studies = this._workitemManager.Workitems
                .ToReadOnlyReactiveCollection(x => new WorkitemViewModel(x));

            this.StudiesView = CollectionViewSource.GetDefaultView(this.Studies);

            this.ClearCommand = new ReactiveCommand()
                .WithSubscribe(this._workitemManager.ClearWorkitems);

            this.ReloadCommand = new ReactiveCommand()
                .WithSubscribe(() => this.ReloadWorkitems());
        }

        public WorklistViewModel()
        {
        }
    }
}
