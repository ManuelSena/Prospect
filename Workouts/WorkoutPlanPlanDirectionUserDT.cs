using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Domain.Workouts
{
    public class WorkoutPlanPlanDirectionUserDT
    {
        public int Id { get; set; }
        public double DurationTypeId { get; set; }
        public string StepName { get; set; }
        public string Directions { get; set; }
        public int Requirements { get; set; }
    }
}
