using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Domain.Workouts
{
    public class WorkoutPlan
    {
        public int Id { get; set; }
        public string PlanName { get; set;}
        public string PlanDetails { get; set;}
        public int DurationTypeId { get; set; }
        //public Boolean IsRecommended { get; set; }
        public string RequiredFood { get; set; }
        public Boolean IsActive { get; set; }
        public int CreatedById { get; set; }
        public int ModifiedById { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string PlanImageURL { get; set; }
    }
}
