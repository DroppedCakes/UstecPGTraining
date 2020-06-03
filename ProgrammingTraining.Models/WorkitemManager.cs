using ProgrammingTraining.Infrastructure;
using ProgrammingTraining.Infrastructure.Repositories;
using Reactive.Bindings;
using System;
using System.Collections.ObjectModel;
using Ustec.WpfHelpers;

namespace ProgrammingTraining.Models
{
    public class WorkitemManager : BindableModelBase
    {
        /// <summary>
        /// 現在の検査一覧
        /// </summary>
        public ObservableCollection<Workitem> Workitems { get; } = new ObservableCollection<Workitem>();

        /// <summary>
        /// 実施日付（自）
        /// </summary>
        public ReactivePropertySlim<DateTime?> Since = new ReactivePropertySlim<DateTime?>(null);

        /// <summary>
        /// 実施日付（至）
        /// </summary>
        public ReactivePropertySlim<DateTime?> Until = new ReactivePropertySlim<DateTime?>(null);

        /// <summary>
        /// 患者ID
        /// </summary>
        public ReactivePropertySlim<string> PatientId = new ReactivePropertySlim<string>(string.Empty);

        /// <summary>
        ///
        /// </summary>
        public void FetchWorkitems()
        {
            // var factory = new AbstractDbFactory():
            var repository = new StudyOrderRepository();
            var workitems = repository.FetchWorkitems(Since.Value, Until.Value, PatientId.Value);

            this.Workitems.AddRange(workitems);
        }

        /// <summary>
        ///
        /// </summary>
        public void ClearWorkitems()
        {
            this.Workitems.Clear();
        }
    }
}