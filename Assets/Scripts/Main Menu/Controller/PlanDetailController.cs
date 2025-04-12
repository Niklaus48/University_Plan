using Domain.Entities;
using Main_Menu.View;
using Main_Menu.View.PlanDetails;
using UnityEngine;
using Zenject;

namespace Main_Menu.Controller
{
    public class PlanDetailController : MonoBehaviour
    {
        [Inject] private ChartListController chartListController;
        
        [SerializeField] private PlanDetailApplier planDetailApplier;

        private int planId;

        public void Open(Plan plan)
        {
            planId = plan.Id;
            planDetailApplier.Init(plan);
        }

        public void AddPlanToChart()
        {
            chartListController.Open(planId);
        }
    }
}