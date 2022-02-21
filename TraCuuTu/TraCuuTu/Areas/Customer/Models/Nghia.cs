namespace TraCuuTu.Areas.Customer.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nghia")]
    public partial class Nghia
    {
        [Key]
        public int MaNghia { get; set; }

        [Column("Nghia")]
        [Required]
        [StringLength(50)]
        public string Nghia1 { get; set; }

        public int? MaTu { get; set; }

        public int? MaNgonNgu { get; set; }

        public virtual NgonNgu NgonNgu { get; set; }

        public virtual TuVung TuVung { get; set; }
    }
}
