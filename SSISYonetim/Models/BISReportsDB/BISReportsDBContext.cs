using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SSISYonetim.Models.BISReportsDB
{
    public partial class BISReportsDBContext : DbContext
    {
        public BISReportsDBContext()
        {
        }

        public BISReportsDBContext(DbContextOptions<BISReportsDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DwhdataFmserviceLog> DwhdataFmserviceLogs { get; set; }
        public virtual DbSet<TblDwhdataFmserviceXml> TblDwhdataFmserviceXmls { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = LSR_ISB2SQLDWH.prd.mptsturkey.org,4022; Initial Catalog = BISReportsDB; user = DTS; password = Efvgt6?%gs; Connection Timeout=0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<DwhdataFmserviceLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("DWHDataFMServiceLogs");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Method)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserIp).HasMaxLength(30);

                entity.Property(e => e.UserName).HasMaxLength(20);
            });

            modelBuilder.Entity<TblDwhdataFmserviceXml>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblDWHDataFMServiceXML");

                entity.Property(e => e.BinfileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("BINFileName");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.SsisfileName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("SSISFileName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
