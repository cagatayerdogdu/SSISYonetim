using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SSISYonetim.Models
{
    public partial class DWHLogDBContext : DbContext
    {
        public DWHLogDBContext()
        {
        }

        public DWHLogDBContext(DbContextOptions<DWHLogDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DwhDataFmserviceControlLog> DwhDataFmserviceControlLogs { get; set; }
        public virtual DbSet<PliConsoleErrorLog> PliConsoleErrorLogs { get; set; }
        public virtual DbSet<PliConsoleFileLog> PliConsoleFileLogs { get; set; }
        public virtual DbSet<WebApiLog> WebApiLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = LSR_ISB2SQLDWH.prd.mptsturkey.org,4022; Initial Catalog = DWHLogDB; user = DTS; password = Efvgt6?%gs; Connection Timeout=0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<DwhDataFmserviceControlLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("DwhDataFMService_Control_Log");

                entity.HasIndex(e => e.LogKayit, "IX_LogKayit__20221006")
                    .HasFillFactor((byte)95);

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.LogExeInfo)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'DwhDataFmService_Control.exe')");

                entity.Property(e => e.LogKayit)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StopMailGonderildi).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PliConsoleErrorLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("PliConsole_ErrorLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.HataMailGonderildi).HasDefaultValueSql("((0))");

                entity.Property(e => e.HataTarih)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaketDosyaAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PliConsoleFileLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("PliConsole_FileLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.KayitTarihi)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaketDosyaAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebApiLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("WebApi_Log");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.LogDurum)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogHata).IsUnicode(false);

                entity.Property(e => e.LogResponse).IsUnicode(false);

                entity.Property(e => e.LogUygulama)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogZaman)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
