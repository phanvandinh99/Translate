namespace TraCuuTu.Areas.Customer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TuVung")]
    public partial class TuVung
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TuVung()
        {
            LichSuTraTus = new HashSet<LichSuTraTu>();
            Nghias = new HashSet<Nghia>();
        }

        [Key]
        public int MaTu { get; set; }

        [Required]
        public string TenTu { get; set; }

        [StringLength(200)]
        public string API { get; set; }

        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuTraTu> LichSuTraTus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nghia> Nghias { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }
    }
}
