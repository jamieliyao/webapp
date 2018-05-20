using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class CMDBContext : DbContext
    {
        public virtual DbSet<EventLogs> EventLogs { get; set; }
        public virtual DbSet<PrintRecords> PrintRecords { get; set; }

        public CMDBContext(DbContextOptions<CMDBContext> options)
            :base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventLogs>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.EventId).HasColumnName("EventID");
            });

            modelBuilder.Entity<PrintRecords>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DepNo).HasMaxLength(50);

                entity.Property(e => e.Depdesc).HasMaxLength(250);

                entity.Property(e => e.PrintClient).HasMaxLength(100);

                entity.Property(e => e.PrintDt).HasColumnType("datetime");

                entity.Property(e => e.PrintFileName).HasMaxLength(500);

                entity.Property(e => e.PrintServer).HasMaxLength(500);

                entity.Property(e => e.PrintUser).HasMaxLength(50);

                entity.Property(e => e.SubDepNo).HasMaxLength(250);

                entity.Property(e => e.TopDepNo).HasMaxLength(250);
            });
        }
    }
}
