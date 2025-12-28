using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuanLyBanHang.Models
{
    public class MatHang
    {
        [Key]
        [StringLength(50)]
        public string MaMH { get; set; } // Mã món hàng (nhập tay, VD: SP01)

        [Required]
        [StringLength(100)]
        public string TenMH { get; set; }

        public double GiaBan { get; set; }

        public int SoLuongTon { get; set; }      // Số lượng thực tế dùng để tính toán
        public int SoLuongHienCo { get; set; }   // Giữ lại để hiển thị (đồng bộ với SoLuongTon)
        public int SoLuongDaBan { get; set; }

        // Quan hệ: Một mặt hàng có thể nằm trong nhiều chi tiết đơn hàng
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}