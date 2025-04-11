using System.Collections.Generic;
using Domain.Entities;
using UnityEngine;

namespace Main_Menu.View.Table
{
    public class PlanOnTableApplier : MonoBehaviour
    {
        [SerializeField] private Row row;
        [SerializeField] private Transform rowsParent;

        private readonly List<Row> rows = new List<Row>();

        public void Init(List<Plan> plans)
        {
            HideAllRows();
            
            for (int i = rows.Count; i < plans.Count; i++)
            {
                var newRow = Instantiate(row, rowsParent);
                newRow.gameObject.SetActive(false);
                rows.Add(newRow);
            }

            int index = 0;
            foreach (var plan in plans)
            {
                rows[index].Init(plan);
                index++;
            }
        }

        private void HideAllRows()
        {
            foreach (var row in rows)
            {
                row.gameObject.SetActive(false);
            }
        }
    }
}