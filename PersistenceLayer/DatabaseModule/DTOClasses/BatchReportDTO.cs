using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule.DTOClasses
{
    [Table("BatchReport")]
    public class BatchReportDTO
    {
        [ForeignKey("StateLog")]
        public int BatchReportID { get; set; }
        public int ProductType { get; set; }
        public int MachineSpeed { get; set; }
        public int TotalAmount { get; set; }
        public int? AcceptableAmount { get; set; }
        public int? DefectAmount { get; set; }
        public DateTime ProductionStartTime { get; set; }
        public DateTime? ProductionEndTime { get; set; }

        public virtual StateLogDTO StateLog { get; set; }
        
        public ICollection<EnvironmentalLogDTO> EnvironmentalLogs { get; set; }
    }
}
