using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule.DTOClasses
{
    [Table("EnvironmentalLog")]
    public partial class EnvironmentalLogDTO
    {
        [Key]
        public int EnvironmentalLogID { get; set; }
        
        public int BatchReportID { get; set; }

        public double Temperature { get; set; }
        public double Vibration { get; set; }
        public double Humidity { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime Time { get; set; }
        
        public virtual BatchReportDTO BatchReport { get; set; }
    }
}
