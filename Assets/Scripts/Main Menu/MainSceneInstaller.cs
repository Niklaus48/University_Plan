using Main_Menu.Controller;
using Main_Menu.Controller.Handlers.Row;
using Main_Menu.Mediator;
using Main_Menu.Model;
using Main_Menu.Model.Interfaces;
using Main_Menu.View.Table.MediatorData;
using UnityEngine;
using Zenject;

namespace Main_Menu
{
    public class MainSceneInstaller : MonoInstaller
    {
        [SerializeField] private ChartDetailController chartDetailController;
        [SerializeField] private ChartListController chartListController;
        [SerializeField] private PlanController planController;
        [SerializeField] private PlanDetailController planDetailController;
        
        public override void InstallBindings()
        {
            MainMenuMediatorManager.Initialize(Container);

            Container.Bind<IMainMenuMediatorHandler<ClickOnRowMediatorData, int>>().To<ClickOnRowHandler>()
                .AsTransient();
            Container.Bind<IMainMenuMediatorHandler<AddPlanToChartMediatorData, int>>().To<AddPlanToChartHandler>()
                .AsTransient();

            Container.Bind<IPlanManager>().To<PlanManager>().AsSingle().NonLazy();
            Container.Bind<IChartManager>().To<ChartManager>().AsSingle().NonLazy();

            Container.Bind<ChartDetailController>().FromInstance(chartDetailController).AsSingle().NonLazy();
            Container.Bind<ChartListController>().FromInstance(chartListController).AsSingle().NonLazy();
            Container.Bind<PlanController>().FromInstance(planController).AsSingle().NonLazy();
            Container.Bind<PlanDetailController>().FromInstance(planDetailController).AsSingle().NonLazy();
        }
    }
}