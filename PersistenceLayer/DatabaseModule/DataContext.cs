﻿using BeerProductionSystem.DOClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProductionSystem.PersistenceLayer.DatabaseModule
{
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("BeerProductionDB")
        {
        }

        public virtual DbSet<BatchDO> BatchReports { get; set; }
        public virtual DbSet<EnvironmentalLogDO> EnvironmentalLogs { get; set; }
        public virtual DbSet<StateLogDO> StateLogs { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BatchDO>()
                .HasMany(e => e.EnvironmentalLogs)
                .WithRequired(e => e.BatchReport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BatchDO>()
                .HasMany(s => s.StateLogs)
                .WithRequired(s => s.BatchReport)
                .WillCascadeOnDelete(false);
        }
    }
}
