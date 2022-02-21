using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TraCuuTu.Areas.Customer.Models
{
    public partial class EFTranslate : DbContext
    {
        public EFTranslate()
            : base("name=EFTranslate")
        {
        }

        public virtual DbSet<LichSuTraTu> LichSuTraTus { get; set; }
        public virtual DbSet<Nghia> Nghias { get; set; }
        public virtual DbSet<NgonNgu> NgonNgus { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<Quyen> Quyens { get; set; }
        public virtual DbSet<TuVung> TuVungs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LichSuTraTu>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.MatKhau)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .Property(e => e.HoVaTen)
                .IsUnicode(false);

            modelBuilder.Entity<NguoiDung>()
                .HasMany(e => e.LichSuTraTus)
                .WithRequired(e => e.NguoiDung)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TuVung>()
                .Property(e => e.TaiKhoan)
                .IsUnicode(false);

            modelBuilder.Entity<TuVung>()
                .HasMany(e => e.LichSuTraTus)
                .WithRequired(e => e.TuVung)
                .WillCascadeOnDelete(false);
        }
    }
}
