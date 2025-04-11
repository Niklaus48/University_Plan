using System;
using Main_Menu.Model.Interfaces;
using Main_Menu.View.ChartList;
using UnityEngine;
using Zenject;

namespace Main_Menu.Controller
{
    public class ChartListController : MonoBehaviour
    {
        [Inject] private IChartManager chartManager;
        
        [SerializeField] private ChartListApplier chartListApplier;

        private int planId = -1;

        private void Start()
        {
            chartManager.InitializeCharts();
        }

        public void Open(int planId = -1)
        {
            this.planId = planId;
            
            chartListApplier.Init(chartManager.GetChartsData(), (chartName) =>
            {
                if (this.planId == -1)
                {
                    //open chart detail
                }
                else
                {
                    chartManager.AddPlanToChart(chartName, this.planId);
                    this.planId = -1;
                }
            });
        }
    }
}