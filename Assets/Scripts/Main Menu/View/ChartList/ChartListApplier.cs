using System;
using System.Collections.Generic;
using Main_Menu.Domain;
using Main.Domain;
using UnityEngine;

namespace Main_Menu.View.ChartList
{
    public class ChartListApplier : MonoBehaviour
    {
        [SerializeField] private VisualChartData visualChartData;
        [SerializeField] private Transform visualChartsParent;
        
        private readonly List<VisualChartData> visualCharts = new List<VisualChartData>();
        
        public void Init(List<ChartData> chartDatas, Action<string> onChartClick)
        {
            for (int i = visualCharts.Count; i < chartDatas.Count; i++)
            {
                var newVisualChart = Instantiate(visualChartData, visualChartsParent);
                newVisualChart.gameObject.SetActive(false);
                visualCharts.Add(newVisualChart);
            }

            int index = 0;
            foreach (var chartData in chartDatas)
            {
                visualCharts[index].Init(chartData.Name, onChartClick);
                index++;
            }
        }

        private void OnDisable()
        {
            foreach (var visualChart in visualCharts)
            {
                visualChart.gameObject.SetActive(false);
            }
        }
    }
}