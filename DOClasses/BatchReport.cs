using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.DOClasses
{
    [Table("BatchReport")]
    public partial class BatchReport
    {
        public BatchReport()
        {
            EnvironmentalLogs = new HashSet<EnvironmentalLog>();
            StateLogs = new HashSet<StateLog>();
        }
        
        [Key]
        public int BatchReportID { get; set; }
        public int ProductType { get; set; }
        public int MachineSpeed { get; set; }
        public int TotalAmount { get; set; }
        public int? AcceptableAmount { get; set; }
        public int? DefectAmount { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime ProductionStartTime { get; set; }

        [Column(TypeName ="datetime2")]
        public DateTime? ProductionEndTime { get; set; }

        
        public virtual ICollection<StateLog> StateLogs { get; set; }
        
        public virtual ICollection<EnvironmentalLog> EnvironmentalLogs { get; set; }
    }
}
