using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Requests.Workouts
{
    public class DurationTypeAddRequest
    {
        [Required]
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        [Required]
        public Boolean IsActive { get; set; }
    }
}
