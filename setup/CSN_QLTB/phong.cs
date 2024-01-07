namespace CSN_QLTB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHONG")]
    public partial class PHONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONG()
        {
            SUDUNGs = new HashSet<SUDUNG>();
            GIANGVIENs = new HashSet<GIANGVIEN>();
            THIETBIs = new HashSet<THIETBI>();
        }

        [Key]
        [StringLength(10)]
        public string ID_PHONG { get; set; }

        [StringLength(30)]
        public string TEN_PHONG { get; set; }

        public int? SO_LUONG_GV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUDUNG> SUDUNGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIANGVIEN> GIANGVIENs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THIETBI> THIETBIs { get; set; }
    }
}
