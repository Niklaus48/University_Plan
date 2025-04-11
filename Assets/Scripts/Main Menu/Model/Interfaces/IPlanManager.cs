using System.Collections.Generic;
using Domain.Entities;
using Domain.Response;
using Main.Domain;

namespace Main_Menu.Model.Interfaces
{
    public interface IPlanManager
    {
        List<Plan> GetPlans(PlanFilter filter = null);
        void SetInitialPlans(GetPlansResponse plansResponse);
    }
}