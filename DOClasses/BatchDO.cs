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
    public partial class BatchDO
    {
        public BatchDO()
        {
            EnvironmentalLogs = new HashSet<EnvironmentalLogDO>();
            StateLogs = new HashSet<StateLogDO>();
            StateDictionary = new Dictionary<int, TimeSpan>();
        }

        [Key]
        [Column("BatchReportID", Order = 0)]
        public int BatchReportID { get; set; }
        [Required]
        [Column("ProductType", Order = 1)]
        public int ProductType { get; set; }
        [Required]
        [Column("ProductionSpeed", Order = 2)]
        public int ProductionSpeed { get; set; }
        [Required]
        [Column("BatchSize", Order = 3)]
        public int BatchSize { get; set; }
        [Column("AcceptableProducts", Order = 4)]
        public int? AcceptableProducts { get; set; }
        [Column("DefectProducts", Order = 5)]
        public int? DefectProducts { get; set; }

        [Column("ProductionStartTime", TypeName = "datetime2", Order = 6)]
        public DateTime ProductionStartTime { get; set; }

        [Column("ProductionEndTime", TypeName = "datetime2", Order = 7)]
        public DateTime? ProductionEndTime { get; set; }
        public virtual ICollection<StateLogDO> StateLogs { get; set; }
        public virtual ICollection<EnvironmentalLogDO> EnvironmentalLogs { get; set; }
        [NotMapped]
        public Dictionary<int, TimeSpan> StateDictionary { get; set; }
        [NotMapped]
        public Dictionary<DateTime, float> TemperatureDictionary { get; set; }
        [NotMapped]
        public Dictionary<DateTime, float> HumidityDictionary { get; set; }
    }
}
