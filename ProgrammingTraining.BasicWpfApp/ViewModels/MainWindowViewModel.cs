using Prism.Commands;
using Prism.Mvvm;
using ProgrammingTraining.Infrastructure.Repositories;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Data;

namespace ProgrammingTraining.BasicWpfApp.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "WPF Basic Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly StudyOrderRepository _repository;

        public ObservableCollection<WorkitemViewModel> Workitems = new ObservableCollection<WorkitemViewModel>();

        public ICollectionView StudiesView { get; }

        #region Commands

        public DelegateCommand ReloadCommand { get; private set; }

        public DelegateCommand ClearCommand { get; private set; }

        #endregion Commands

        #region Methods

        private void ReloadWorkitems()
        {
            this.Workitems.Clear();
            var now = DateTime.Now;
            var items = this._repository.FetchWorkitems(now, now, "1");
            this.Workitems.AddRange(items.Select(i => new WorkitemViewModel(i)));
        }

        #endregion Methods

        public MainWindowViewModel()
        {
            this._repository = new StudyOrderRepository();
            this.StudiesView = CollectionViewSource.GetDefaultView(this.Workitems);

            this.ClearCommand = new DelegateCommand(
                // 実行内容
                () => { this.Workitems.Clear(); },
                // 実行可否
                () => true
            );

            this.ReloadCommand = new DelegateCommand(
                // 実行内容
                () => { this.ReloadWorkitems(); },
                // 実行可否
                () => true
            );
        }
    }
}