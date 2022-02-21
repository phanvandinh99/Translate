namespace TraCuuTu.Areas.Customer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuTraTu")]
    public partial class LichSuTraTu
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string TaiKhoan { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaTu { get; set; }

        public DateTime? NgayTra { get; set; }

        public virtual NguoiDung NguoiDung { get; set; }

        public virtual TuVung TuVung { get; set; }
    }
}
