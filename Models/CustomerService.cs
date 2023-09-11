namespace QuanLyBanSach.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


        public class CustomerService
        {
            public IEnumerable<loai> DanhSachLoai { get; set; }
            public IEnumerable<sach> DanhSachSach { get; set; }

        }
    }