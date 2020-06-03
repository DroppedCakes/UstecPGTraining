using ProgrammingTraining.Infrastructure;
using Ustec.WpfHelpers;

namespace ProgrammingTraining.Worklist.ViewModels
{
    public class WorkitemViewModel : BindableModelBase
    {
        private readonly Workitem _workitem;

        public string PatientId { get => this._workitem.PatientId; }

        public string OrderNumber { get => this._workitem.OrderNumber; }

        public string NameKanji { get => this._workitem.NameKanji; }

        public WorkitemViewModel(Workitem workitem)
        {
            this._workitem = workitem;
        }
    }
}