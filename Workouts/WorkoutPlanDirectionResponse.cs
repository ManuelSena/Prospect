using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Domain.Workouts
{
    public class WorkoutPlanDirectionResponse : PlanDirection
    {
            public string DurationTypeName { get; set; }
            public int WorkoutPlanId { get; set; }
    }
}
