namespace QuanLyBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sach")]
    public partial class sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sach()
        {
            ChiTietHoaDons = new HashSet<ChiTietHoaDon>();
        }

        [Key]
        [StringLength(50)]
        public string masach { get; set; }

        [StringLength(50)]
        public string tensach { get; set; }

        public long? soluong { get; set; }

        public long? gia { get; set; }

        [StringLength(50)]
        public string maloai { get; set; }

        [StringLength(50)]
        public string sotap { get; set; }

        [StringLength(50)]
        public string anh { get; set; }

        public DateTime? NgayNhap { get; set; }

        [StringLength(50)]
        public string tacgia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; }

        public virtual loai loai { get; set; }
    }
}
