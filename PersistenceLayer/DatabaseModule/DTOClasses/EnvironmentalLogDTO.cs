using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule.DTOClasses
{
    [Table("EnvironmentalLog")]
    public class EnvironmentalLogDTO
    {
        public int EnvironmentalLogID { get; set; }
        
        public BatchReportDTO BatchReport { get; set; }

        public float Temperature { get; set; }
        public float Vibration { get; set; }
        public float Humidity { get; set; }
        public DateTime Time { get; set; }
        
    }
}
