using Prism.Mvvm;
using Prism.Regions;
using ProgrammingTraining.Infrastructure;
using ProgrammingTraining.Models.ViewModels;
using Reactive.Bindings;

namespace ProgrammingTraining.Detail.ViewModels
{
    public class DetailViewModel : BindableBase, INavigationAware
    {
        private readonly IRegionManager _regionManager;

        public ReactiveProperty<WorkitemViewModel> Workitem { get; }

        public ReactivePropertySlim<string> PatientId { get; }
        public ReactivePropertySlim<string> NameKanji { get; }

        public ReactiveCommand NavigateWorklistCommand { get; }

        private void NavigateWorklist()
        {
            this._regionManager.RequestNavigate(RegionNames.ContentRegion, RegionNames.Worklist);
        }

        public DetailViewModel(IRegionManager regionManager)
        {
            this._regionManager = regionManager;

            this.Workitem = new ReactiveProperty<WorkitemViewModel>();
            this.PatientId = new ReactivePropertySlim<string>();
            this.NameKanji = new ReactivePropertySlim<string>();

            this.NavigateWorklistCommand = new ReactiveCommand()
                .WithSubscribe(() => this.NavigateWorklist());
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