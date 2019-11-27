using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule.DTOClasses
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("BeerProductionDB")
        {
        }

        public virtual DbSet<BatchReportDTO> BatchReports { get; set; }
        public virtual DbSet<EnvironmentalLogDTO> EnvironmentalLogs { get; set; }
        public virtual DbSet<StateLogDTO> StateLogs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BatchReportDTO>()
                .HasMany(e => e.EnvironmentalLogs)
                .WithRequired(e => e.BatchReport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BatchReportDTO>()
                .HasMany(s => s.StateLogs)
                .WithRequired(s => s.BatchReport)
                .WillCascadeOnDelete(false);
        }
    }
}
