using System;
using Common;
using Common.Interfaces;
using Domain.Response;
using Newtonsoft.Json;
using TMPro;
using UnityEngine;
using Zenject;

namespace Main
{
    public class PlanController : MonoBehaviour
    {
        [Inject] private readonly IPlanManager planManager;
        [Inject] private readonly INetworkManager networkManager;
        
        [SerializeField] TextMeshProUGUI plansText;


        private void Start()
        {
            string apiUrl = ConnectionData.ServerPath + ConnectionData.GetPlans;

            StartCoroutine(networkManager._SendRequestGet<GetPlansResponse>(apiUrl, (result) =>
            {
                if (result.Success == true)
                    planManager.SetInitialPlans(result.data);
            }));
        }

        public void Execute()
        {
            plansText.text = JsonConvert.SerializeObject(planManager.GetPlans(new PlanFilter()
            {
                Group = { "گروه الف" }
            }));
        }
    }
}