namespace CSN_QLTB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("THONGSO")]
    public partial class THONGSO
    {
        [Key]
        [StringLength(10)]
        public string ID_THONGSO { get; set; }

        [Required]
        [StringLength(10)]
        public string ID_TB { get; set; }

        [StringLength(30)]
        public string TEN_THONGSO { get; set; }

        [StringLength(50)]
        public string GIA_TRI { get; set; }

        public virtual THIETBI THIETBI { get; set; }
    }
}
