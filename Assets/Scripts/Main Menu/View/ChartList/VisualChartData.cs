using System;
using TMPro;
using UnityEngine;

namespace Main_Menu.View.ChartList
{
    public class VisualChartData : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI chartNameText;

        private string chartName;
        private Action<string> onClick;

        public void Init(string chartName, Action<string> onClick)
        {
            gameObject.SetActive(true);
            this.onClick = onClick;
            this.chartName = chartName;
            chartNameText.text = chartName;
        }

        public void OnClick()
        {
            onClick.Invoke(chartName);
        }
    }
}