
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Response;
using Main.Helpers;
using Newtonsoft.Json;
using UnityEngine;

namespace Main
{
    public class PlanManager : IPlanManager
    {
        private List<Plan> plans = new List<Plan>();


        public List<Plan> GetPlans(PlanFilter filter)
        {
            List<Plan> result = plans;

            if (filter.CourseName.Count > 0)
                result = result.Where(plan => filter.CourseName.Contains(plan.CourseName)).ToList();


            int start = string.IsNullOrEmpty(filter.StartDate) ? int.MinValue : DateConverter.ToDays(filter.StartDate);
            int end = string.IsNullOrEmpty(filter.EndDate) ? int.MaxValue : DateConverter.ToDays(filter.EndDate);
            result = result.Where(plan =>
                DateConverter.ToDays(plan.Date) >= start && DateConverter.ToDays(plan.Date) <= end).ToList();

            if (filter.Group.Count > 0)
                result = result.Where(plan => filter.Group.Contains(plan.Group)).ToList();
            
            if (filter.ProfessorName.Count > 0)
                result = result.Where(plan => filter.ProfessorName.Contains(plan.ProfessorName)).ToList();
            
            if (filter.UniversityName.Count > 0)
                result = result.Where(plan => filter.UniversityName.Contains(plan.UniversityName)).ToList();
            
            if (filter.DayOfWeek.Count > 0)
                result = result.Where(plan => filter.DayOfWeek.Contains(plan.DayOfWeek)).ToList();
            
            if (filter.Time.Count > 0)
                result = result.Where(plan => filter.Time.Contains(plan.Time)).ToList();
            
            if (filter.MajorName.Count > 0)
                result = result.Where(plan => filter.MajorName.Contains(plan.MajorName)).ToList();
            
            if (string.IsNullOrEmpty(filter.Status) == false)
                result = result.Where(plan => plan.Status == filter.Status).ToList();
            
            Debug.Log("Filter applied successfully, Result : " + JsonConvert.SerializeObject(result));
            
            return result;
        }

        public void SetInitialPlans(GetPlansResponse plansResponse)
        {
            plans = plansResponse.plans;
        }
    }
}