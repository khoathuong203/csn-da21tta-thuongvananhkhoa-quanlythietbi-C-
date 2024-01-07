using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace CSN_QLTB
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<GIANGVIEN> GIANGVIENs { get; set; }
        public virtual DbSet<PHONG> PHONGs { get; set; }
        public virtual DbSet<SUDUNG> SUDUNGs { get; set; }
        public virtual DbSet<THIETBI> THIETBIs { get; set; }
        public virtual DbSet<THONGSO> THONGSOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.ID_GV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.TEN_GV)
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .HasMany(e => e.SUDUNGs)
                .WithRequired(e => e.GIANGVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.ID_PHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .Property(e => e.TEN_PHONG)
                .IsUnicode(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.SUDUNGs)
                .WithRequired(e => e.PHONG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONG>()
                .HasMany(e => e.GIANGVIENs)
                .WithMany(e => e.PHONGs)
                .Map(m => m.ToTable("O").MapLeftKey("ID_PHONG").MapRightKey("ID_GV"));

            modelBuilder.Entity<SUDUNG>()
                .Property(e => e.ID_TB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUDUNG>()
                .Property(e => e.ID_GV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SUDUNG>()
                .Property(e => e.ID_PHONG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THIETBI>()
                .Property(e => e.ID_TB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THIETBI>()
                .Property(e => e.TEN_TB)
                .IsUnicode(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.SUDUNGs)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.THONGSOes)
                .WithRequired(e => e.THIETBI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THIETBI>()
                .HasMany(e => e.PHONGs)
                .WithMany(e => e.THIETBIs)
                .Map(m => m.ToTable("THUOC").MapLeftKey("ID_TB").MapRightKey("ID_PHONG"));

            modelBuilder.Entity<THONGSO>()
                .Property(e => e.ID_THONGSO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONGSO>()
                .Property(e => e.ID_TB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONGSO>()
                .Property(e => e.TEN_THONGSO)
                .IsUnicode(false);

            modelBuilder.Entity<THONGSO>()
                .Property(e => e.GIA_TRI)
                .IsUnicode(false);
        }
    }
}
