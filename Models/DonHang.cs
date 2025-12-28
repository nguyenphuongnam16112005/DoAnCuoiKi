using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.Models
{
    public class DonHang
    {
        [Key]
        public int MaDH { get; set; } // Tự động tăng

        public DateTime NgayBan { get; set; }

        // Quan hệ: Một đơn hàng có nhiều chi tiết
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}