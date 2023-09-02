namespace QuanLyBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        public long MaChiTietHD { get; set; }

        [Required]
        [StringLength(50)]
        public string MaSach { get; set; }

        public int SoLuongMua { get; set; }

        public long MaHoaDon { get; set; }

        public bool? damua { get; set; }

        public virtual hoadon hoadon { get; set; }

        public virtual sach sach { get; set; }
    }
}
