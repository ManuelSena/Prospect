using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Requests.Workouts
{
    public class PlanDirectionAddRequest
    {
        [Required]
        public int DurationTypeId { get; set; }
        [Required]
        public string StepName { get; set; }
        [Required]
        public string Directions { get; set; }
        [Required]
        public string Requirements { get; set; }
    }
}
