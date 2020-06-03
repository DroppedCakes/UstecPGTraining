using ProgrammingTraining.Infrastructure;
using Reactive.Bindings;
using System.Collections.ObjectModel;
using Ustec.WpfHelpers;

namespace ProgrammingTraining.Models
{
    public class WorkitemEditor : BindableModelBase
    {
        public ReactivePropertySlim<Workitem> WorkitemList = new ReactivePropertySlim<Workitem>();


    }
}
