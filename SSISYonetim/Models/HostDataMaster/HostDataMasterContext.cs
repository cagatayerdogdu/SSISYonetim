using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SSISYonetim.Models.HostDataMaster
{
    public partial class HostDataMasterContext : DbContext
    {
        public HostDataMasterContext()
        {
        }

        public HostDataMasterContext(DbContextOptions<HostDataMasterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblFileBilgileri> TblFileBilgileri { get; set; }
        public virtual DbSet<TblFtpControl> TblFtpControl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = 10.2.0.13,1433; Initial Catalog = HostDataMaster; user = DTS; password = Efvgt6?%gs; Connection Timeout=0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblFileBilgileri>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblFileBilgileri");

                entity.Property(e => e.DwhbinDosyaBilgi)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("DWHBinDosyaBilgi");

                entity.Property(e => e.HostFileAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Jcl)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("JCL");

                entity.Property(e => e.Jclsira)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JCLSira");

                entity.Property(e => e.Mcpadi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MCPadi");
            });

            modelBuilder.Entity<TblFtpControl>(entity =>
            {
                entity.HasKey(e => new { e.TstartDateTime, e.Tftpname })
                    .IsClustered(false);

                entity.ToTable("tblFtpControl");

                entity.HasIndex(e => new { e.TstartDateTime, e.Tftpname }, "PK_StartDate_FTPName")
                    .IsUnique()
                    .IsClustered()
                    .HasFillFactor((byte)90);

                entity.Property(e => e.TstartDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("TStartDateTime");

                entity.Property(e => e.Tftpname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TFTPName")
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Ssisstatus).HasColumnName("SSISStatus");

                entity.Property(e => e.TendDateTime)
                    .HasColumnType("datetime")
                    .HasColumnName("TEndDateTime");

                entity.Property(e => e.TnewDwhstatus).HasColumnName("TNewDWHStatus");

                entity.Property(e => e.Tstatus).HasColumnName("TStatus");

                entity.Property(e => e.Ttype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TType")
                    .IsFixedLength(true)
                    .UseCollation("Turkish_CI_AS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
