using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Domain.Workouts
{
    public class DurationType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public Boolean IsActive { get; set; }
        public int TotalPages { get; set; }
        public int PageNumber { get; set; }
    }
}
