using Common;
using Common.Interfaces;
using Domain.Response;
using Main_Menu.Model.Interfaces;
using Main_Menu.View.Table;
using UnityEngine;
using Zenject;

namespace Main_Menu.Controller
{
    public class PlanController : MonoBehaviour
    {
        [Inject] private readonly IPlanManager planManager;
        [Inject] private readonly INetworkManager networkManager;


        [SerializeField] private PlanOnTableApplier planOnTableApplier;

        private void Start()
        {
            string apiUrl = ConnectionData.ServerPath + ConnectionData.GetPlans;

            StartCoroutine(networkManager._SendRequestGet<GetPlansResponse>(apiUrl, (result) =>
            {
                if (result.Success == true)
                {
                    planManager.SetInitialPlans(result.data);
                    ShowPlansOnTable();
                }
            }));
        }

        public void ShowPlansOnTable()
        {
            planOnTableApplier.Init(planManager.GetPlans());
        }
    }
}