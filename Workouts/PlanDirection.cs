using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Domain.Workouts
{
    public class PlanDirection
    {
        public int Id { get; set; }
        public int DurationTypeId { get; set; }
        public string StepName { get; set; }
        public string Directions { get; set; }
        public string Requirements { get; set; }
    }
}
