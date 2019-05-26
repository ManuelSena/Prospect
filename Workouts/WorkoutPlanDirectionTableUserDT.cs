using Prospect.Data.Structured;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect.Models.Requests.Workouts
{
    public class WorkoutPlanDirectionTableUserDT
    {
        [GenericTable(System.Data.SqlDbType.Int, "durationTypeId")]
        public int DurationTypeId { get; set; }
        [GenericTable(System.Data.SqlDbType.NVarChar, "stepName", 25)]
        public string StepName { get; set; }
        [GenericTable(System.Data.SqlDbType.NVarChar, "directions", 4000)]
        public string Directions { get; set; }
        [GenericTable(System.Data.SqlDbType.NVarChar, "requirements", 4000)]
        public string Requirements { get; set; }
    }
}
