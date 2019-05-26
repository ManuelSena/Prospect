using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Requests.Workouts
{
    public class WorkoutPlanUpdateRequest : WorkoutPlanAddRequest
    {
        [Required]
        public int Id { get; set; }
    }
}
