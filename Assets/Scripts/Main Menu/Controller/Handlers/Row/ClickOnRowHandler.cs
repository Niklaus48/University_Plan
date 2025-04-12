using Main_Menu.Mediator;
using Main_Menu.Model.Interfaces;
using Main_Menu.View.Table.MediatorData;
using Zenject;

namespace Main_Menu.Controller.Handlers.Row
{
    public class ClickOnRowHandler : IMainMenuMediatorHandler<ClickOnRowMediatorData, int>
    {
        [Inject] private PlanDetailController planDetailsController;
        [Inject] private IPlanManager planManager;
        
        public int handle(ClickOnRowMediatorData input)
        {
            planDetailsController.Open(planManager.GetPlanById(input.PlanId));
            return 0;
        }
    }
}