using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Domain.Workouts
{
    public class PlanResultLog
    {
        public int Id { get; set; }
        public int PlanResultId { get; set; }
        public int DirectionTypeId { get; set; }
        public double WeightIn { get; set; }
        public string Nutrition { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
