using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyBanHang.Models
{
    public class ChiTietDonHang
    {
        [Key]
        public int MaHD { get; set; } // ID tự tăng của bảng chi tiết

        public int MaDH { get; set; } // Khóa ngoại sang Đơn Hàng

        [StringLength(50)]
        public string MaMH { get; set; } // Khóa ngoại sang Mặt Hàng

        public int SoLuongMua { get; set; }
        public double ThanhTien { get; set; }

        [ForeignKey("MaDH")]
        public virtual DonHang DonHang { get; set; }

        [ForeignKey("MaMH")]
        public virtual MatHang MatHang { get; set; }
    }
}