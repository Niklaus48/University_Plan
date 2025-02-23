using System.Collections.Generic;
using Domain.Entities;
using Domain.Response;

namespace Main
{
    public interface IPlanManager
    {
        List<Plan> GetPlans(PlanFilter filter);
        void SetInitialPlans(GetPlansResponse plansResponse);
    }
}