using System.Collections.Generic;
using Main_Menu.Domain;
using Main_Menu.Model.Interfaces;
using Newtonsoft.Json;
using UnityEngine;

namespace Main_Menu.Model
{
    public class ChartManager : IChartManager
    {
        private const string ChartDataSaveKey = "ChartData";
        private List<ChartData> chartDatas;

        public void InitializeCharts()
        {
            if (string.IsNullOrEmpty(PlayerPrefs.GetString(ChartDataSaveKey)))
            {
                chartDatas ??= new List<ChartData>();
            }
            else
            {
                chartDatas ??= JsonConvert.DeserializeObject<List<ChartData>>(PlayerPrefs.GetString(ChartDataSaveKey));
            }
        }

        public List<ChartData> GetChartsData()
        {
            return chartDatas;
        }

        public ChartData GetChartData(string chartName)
        {
            return chartDatas.Find(c => c.Name == chartName);
        }

        public void AddPlanToChart(string chartName, int planId)
        {
            var chartData = GetChartData(chartName);
            if (chartData.PlanIds.Contains(planId)) return;

            chartData.PlanIds.Add(planId);
            Save();
        }

        public void RemovePlanFromChart(string chartName, int planId)
        {
            var chartData = GetChartData(chartName);
            if (chartData.PlanIds.Contains(planId) == false) return;

            chartData.PlanIds.Remove(planId);
            Save();
        }

        public bool AddNewChart(ChartData chartData)
        {
            if (chartDatas.Contains(chartData)) return false;

            chartDatas.Add(chartData);
            Save();
            return true;
        }

        public void RemoveChart(string chartName)
        {
            var index = chartDatas.FindIndex(c => c.Name == chartName);
            if (index == -1) return;

            chartDatas.RemoveAt(index);
            Save();
        }

        private void Save()
        {
            PlayerPrefs.SetString(ChartDataSaveKey, JsonConvert.SerializeObject(chartDatas));
        }
    }
}