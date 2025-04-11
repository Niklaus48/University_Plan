using System.Collections.Generic;
using Main_Menu.Domain;

namespace Main_Menu.Model.Interfaces
{
    public interface IChartManager
    {
        void InitializeCharts();
        List<ChartData> GetChartsData();
        ChartData GetChartData(string chartName);
        void AddPlanToChart(string chartName, int planId);
        void RemovePlanFromChart(string chartName, int planId);
        bool AddNewChart(ChartData chartData);
        void RemoveChart(string chartName);
    }
}