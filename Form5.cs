using QuanLyBanHang.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Form5_Load;
            this.dtpChonNgay.ValueChanged += dtpChonNgay_ValueChanged;
            this.thoátToolStripMenuItem.Click += (s, e) => this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Thêm cột giá nếu chưa có trong Design
            if (dgvCTBH.Columns["colGia"] == null)
            {
                dgvCTBH.Columns.Add("colGia", "Giá Bán");
            }
            TaiDuLieuLichSu();
        }

        private void dtpChonNgay_ValueChanged(object sender, EventArgs e)
        {
            TaiDuLieuLichSu(); // Khi chọn ngày khác thì tải lại
        }

        // --- HÀM TẢI DỮ LIỆU THẬT TỪ SQL (Đã sửa logic cũ) ---
        private void TaiDuLieuLichSu()
        {
            try
            {
                dgvCTBH.Rows.Clear();
                DateTime ngayChon = dtpChonNgay.Value.Date;     // Lấy 00:00:00 của ngày chọn
                DateTime ngayMai = ngayChon.AddDays(1);         // Lấy 00:00:00 của ngày hôm sau

                using (var db = new QuanLyBanHangContext())
                {
                    // LINQ: Join 3 bảng để lấy thông tin đầy đủ
                    var query = from ct in db.ChiTietDonHangs
                                join dh in db.DonHangs on ct.MaDH equals dh.MaDH
                                join mh in db.MatHangs on ct.MaMH equals mh.MaMH
                                // Lọc đơn hàng trong khoảng ngày đã chọn
                                where dh.NgayBan >= ngayChon && dh.NgayBan < ngayMai
                                select new
                                {
                                    Ngay = dh.NgayBan,
                                    MaDon = ct.MaDH,
                                    MaHang = ct.MaMH,
                                    TenHang = mh.TenMH,
                                    SoLuong = ct.SoLuongMua,
                                    ThanhTien = ct.ThanhTien
                                };

                    var ketQua = query.ToList();

                    // Đổ dữ liệu vào Grid
                    foreach (var item in ketQua)
                    {
                        // Tính đơn giá (Thành tiền / Số lượng)
                        double donGia = item.SoLuong > 0 ? item.ThanhTien / item.SoLuong : 0;

                        dgvCTBH.Rows.Add(
                            item.Ngay.ToString("dd/MM/yyyy HH:mm"), // Cột Date
                            item.MaDon,                             // Cột Mã Đơn
                            item.MaHang,                            // Cột Mã Hàng
                            item.TenHang,                           // Cột Tên Hàng
                            item.SoLuong,                           // Cột Số Lượng
                            donGia.ToString("N0")                   // Cột Giá
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử: " + ex.Message);
            }
        }
    }
}