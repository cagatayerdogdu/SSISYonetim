using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SSISYonetim.Models.SessionView
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

        public virtual DbSet<VwDwhSessionKontrol> VwDwhSessionKontrol { get; set; }

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

            modelBuilder.Entity<VwDwhSessionKontrol>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Dwh_SessionKontrol");

                entity.Property(e => e.ClientNetAddress)
                    .HasMaxLength(48)
                    .HasColumnName("client_net_address");

                entity.Property(e => e.ConnectTime)
                    .HasColumnType("datetime")
                    .HasColumnName("connect_time");

                entity.Property(e => e.Dbname)
                    .HasMaxLength(128)
                    .HasColumnName("DBname");

                entity.Property(e => e.HostName)
                    .HasMaxLength(128)
                    .HasColumnName("host_name");

                entity.Property(e => e.LoginName)
                    .IsRequired()
                    .HasMaxLength(128)
                    .HasColumnName("login_name");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("login_time");

                entity.Property(e => e.FarkDakika)
                    .HasColumnType("int")
                    .HasColumnName("FarkDakika");

                entity.Property(e => e.ProgramName)
                    .HasMaxLength(128)
                    .HasColumnName("program_name");

                entity.Property(e => e.SessionId).HasColumnName("session_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.Property(e => e.Text).HasColumnName("text");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
