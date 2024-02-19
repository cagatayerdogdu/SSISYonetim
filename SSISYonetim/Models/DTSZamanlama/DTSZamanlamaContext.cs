using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SSISYonetim.Models.DTSZamanlama
{
    public partial class DTSZamanlamaContext : DbContext
    {
        public DTSZamanlamaContext()
        {
        }

        public DTSZamanlamaContext(DbContextOptions<DTSZamanlamaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DwhDosyaBilgileri> DwhDosyaBilgileri { get; set; }
        public virtual DbSet<TblSsis> TblSsis { get; set; }
        public virtual DbSet<TblSsisHataLog> TblSsisHataLogs { get; set; }
        public virtual DbSet<TblSsisgunluk> TblSsisGunluk { get; set; }
        public virtual DbSet<TblSsisgunlukCalismaAdimlari> TblSsisgunlukCalismaAdimlaris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source = LSR_ISB2SQLDWH.prd.mptsturkey.org,4022; Initial Catalog = DTSZamanlama; user = DTS; password = Efvgt6?%gs; Connection Timeout=0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CS_AS");

            modelBuilder.Entity<DwhDosyaBilgileri>(entity =>
            {
                entity.ToTable("DWH_DosyaBilgileri");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DosyaAdi).HasMaxLength(200);

                entity.Property(e => e.DosyaAdiHam).HasMaxLength(30);

                entity.Property(e => e.DosyaInsTim)
                    .HasColumnType("datetime")
                    .HasColumnName("Dosya_InsTim")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DosyaOlusturulmaTarihi).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblSsis>(entity =>
            {
                //entity.HasNoKey();
                entity.HasKey(e => e.KayitNo);

                entity.ToTable("tblSSIS");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Ad)
                    .HasMaxLength(75)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.AyinOzelGunleri)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.BaslamaSaati)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.DuzenlemeZamani)
                    .HasMaxLength(50)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.DuzenleyenKullanici)
                    .HasMaxLength(10)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.HaftaninGunleri)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.KayitKullanıci)
                    .HasMaxLength(20)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.KayitNo).ValueGeneratedOnAdd();

                entity.Property(e => e.KayitZamani)
                    .HasMaxLength(50)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Kontroller)
                    .HasMaxLength(999)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.KontrollerEski).HasMaxLength(999);

                entity.Property(e => e.KontrollerString)
                    .HasMaxLength(1200)
                    .HasColumnName("Kontroller_String");

                entity.Property(e => e.KullanilanDb)
                    .HasMaxLength(300)
                    .HasColumnName("KullanilanDB");

                entity.Property(e => e.KullanilanDosya).HasMaxLength(300);

                entity.Property(e => e.KullanilanTablolar).HasMaxLength(4000);

                entity.Property(e => e.KurumNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.RaporAdi).HasMaxLength(1000);

                entity.Property(e => e.TekrarlamaDakika)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.UpdateDbnotNull).HasColumnName("Update_DBNotNull");

                entity.Property(e => e.YilinOzelGunleri)
                    .HasMaxLength(100)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<TblSsisHataLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSSIS_HataLog");

                entity.Property(e => e.BaslangicZamani).HasColumnType("datetime");

                entity.Property(e => e.BitisZamani).HasColumnType("datetime");

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LogID");

                entity.Property(e => e.PaketAdi)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TaskAdi).HasMaxLength(100);
            });

            modelBuilder.Entity<TblSsisgunluk>(entity =>
            {
                entity.ToTable("tblSSISGunluk");

                entity.HasIndex(e => new { e.Gun, e.KayitNo }, "IX_tblSSISGunluk_01")
                    .HasFillFactor((byte)90);

                entity.HasIndex(e => new { e.Gun, e.Ad, e.Sonuc }, "IX_tblSSISGunluk_02")
                    .HasFillFactor((byte)90);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(200)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Ad)
                    .HasMaxLength(75)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.BaslamaSaat)
                    .HasMaxLength(10)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.BitisSaat)
                    .HasMaxLength(10)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Saat)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .UseCollation("Turkish_CI_AS");
            });

            modelBuilder.Entity<TblSsisgunlukCalismaAdimlari>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblSSISGunlukCalismaAdimlari");

                entity.Property(e => e.Aciklama)
                    .HasMaxLength(1000)
                    .UseCollation("Turkish_CI_AS");

                entity.Property(e => e.Gun).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Zaman).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
