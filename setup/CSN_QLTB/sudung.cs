namespace CSN_QLTB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUDUNG")]
    public partial class SUDUNG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string ID_TB { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ID_GV { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string ID_PHONG { get; set; }

        public int? THOIGIAN_SD { get; set; }

        public virtual GIANGVIEN GIANGVIEN { get; set; }

        public virtual PHONG PHONG { get; set; }

        public virtual THIETBI THIETBI { get; set; }
    }
}
