using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Requests.Workouts
{
    public class BodyMeasurementTypeAddRequest
    {
        [Required]
        [MaxLength(50, ErrorMessage = "TypeDescription < 50 chars")]
        public string TypeName { get; set; }

        [MaxLength(500, ErrorMessage = "TypeDescription < 500 chars")]
        public string TypeDescription { get; set; }
    }
}
