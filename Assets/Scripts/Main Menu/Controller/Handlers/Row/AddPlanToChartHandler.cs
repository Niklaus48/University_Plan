using Main_Menu.Mediator;
using Main_Menu.View.Table.MediatorData;
using Zenject;

namespace Main_Menu.Controller.Handlers.Row
{
    public class AddPlanToChartHandler : IMainMenuMediatorHandler<AddPlanToChartMediatorData, int>
    {
        [Inject] private ChartListController chartListController;
        
        public int handle(AddPlanToChartMediatorData input)
        {
            chartListController.Open(input.PlanId);
            return 0;
        }
    }
}