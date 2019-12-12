using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.DOClasses
{
    [Table("EnvironmentalLog")]
    public partial class EnvironmentalLogDO
    {
        [Key]
        [Column("EnvironmentalLogID", Order = 0)]
        public int EnvironmentalLogID { get; set; }
        [Required]
        [Column("BatchReportID", Order = 1)]
        public int BatchID { get; set; }
        public virtual BatchDO BatchReport { get; set; }
        [Required]
        [Column("Temperature", Order = 2)]
        public double Temperature { get; set; }
        [Required]
        [Column("Vibration", Order = 3)]
        public double Vibration { get; set; }
        [Required]
        [Column("Humidity", Order = 4)]
        public double Humidity { get; set; }
        [Required]
        [Column("Time", TypeName = "datetime2", Order = 5)]
        public DateTime Time { get; set; }
        
        
    }
}
