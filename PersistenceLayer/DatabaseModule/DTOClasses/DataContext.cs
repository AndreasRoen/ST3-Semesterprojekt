using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule.DTOClasses
{
    public class DataContext: DbContext
    {
        public DataContext():base("BeerProductionDB")
        {

        }

        public DbSet<BatchReportDTO> BatchReports { get; set; }
        public DbSet<EnvironmentalLogDTO> EnvironmentalLogs { get; set; }
        public DbSet<StateLogDTO> StateLogs { get; set; }
    }
}
