using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using ProgrammingTraining.Models.ViewModels;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgrammingTraining.Detail.ViewModels
{
    public class DetailViewModel : BindableBase,INavigationAware
    {
        private readonly IRegionManager _regionManager;

        public ReactiveProperty<WorkitemViewModel> Workitem { get; }

        public ReactivePropertySlim<string> PatientId { get; }
        public ReactivePropertySlim<string> NameKanji { get; }

        public DetailViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;

            this.Workitem = new ReactiveProperty<WorkitemViewModel>();
            this.PatientId = new ReactivePropertySlim<string>();
            this.NameKanji = new ReactivePropertySlim<string>();
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            // NavigationContextよりWorkitemを取得する
            this.Workitem.Value = navigationContext.Parameters["Workitem"] as WorkitemViewModel;
            this.PatientId.Value = this.Workitem.Value.PatientId;
            this.NameKanji.Value = this.Workitem.Value.NameKanji;
        }

        public bool IsNavigationTarget(NavigationContext navigationContext) => true;

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}
