using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Requests.Workouts
{
    public class PlanResultLogAddRequest
    {
        
        [Required]
        public int PlanResultId { get; set; }
        [Required]
        public int DirectionTypeId { get; set; }
        [Required]
        public double WeighIn { get; set; }
        [Required]
        [MaxLength(4000, ErrorMessage = "Max Character Count 4000")]
        public string Nutrition { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
