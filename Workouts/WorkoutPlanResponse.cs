using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Domain.Workouts
{
    public class WorkoutPlanResponse : WorkoutPlan
    {
        public string CreatorPhoto { get; set; }
        public string CreatorFirstName { get; set; }
        public string CreatorLastName { get; set; }
        public string ModifierFirstName { get; set; }
        public string ModifierLastName { get; set; }
        public List<WorkoutPlanDirectionResponse> PlanDirections { get; set; }
    }
}
