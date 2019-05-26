using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Requests.Workouts
{
    public class WorkoutPlanAddRequest
    {
        [Required]
        public string PlanName { get; set; }
        [Required]
        public string PlanDetails { get; set; }
        [Required]
        public int DurationTypeId { get; set; }
        [Required]
        public string RequiredFood { get; set; }
        //[Required]
        //public Boolean IsRecommended { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int CreatedById { get; set; }
        [Required]
        public int ModifiedById { get; set; }
        [Required]
        public List<WorkoutPlanDirectionTableUserDT> PlanDirections { get; set; }
        public string PlanImageURL { get; set; }
    }
}
