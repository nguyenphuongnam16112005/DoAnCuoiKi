using QuanLyBanHang.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnthemhangthanhtoan.Click += btnthemhangthanhtoan_Click;
            this.btnhoantatthanhtoan.Click += btnhoantatthanhtoan_Click;
            this.btnvetrangchinh.Click += (s, e) => this.Close();
        }

        // 1. Thêm hàng vào giỏ (Grid trên Form 8) - Chưa lưu DB
        private void btnthemhangthanhtoan_Click(object sender, EventArgs e)
        {
            string maMH = txtmonhangthanhtoan.Text;
            int soLuongMua = int.Parse(txtsoluongthanhtoan.Text);

            using (var db = new QuanLyBanHangContext())
            {
                var mh = db.MatHangs.FirstOrDefault(m => m.MaMH == maMH);
                if (mh != null)
                {
                    // Tính thành tiền
                    double thanhTien = soLuongMua * mh.GiaBan;
                    // Thêm vào Grid hiển thị tạm
                    dataGridViewThanhtoan.Rows.Add(mh.MaMH, mh.TenMH, soLuongMua, mh.GiaBan, thanhTien);

                    // Tính tổng tiền đơn hàng
                    TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã hàng này!");
                }
            }
        }

        private void TinhTongTien()
        {
            double tong = 0;
            foreach (DataGridViewRow row in dataGridViewThanhtoan.Rows)
            {
                if (row.Cells[4].Value != null)
                    tong += double.Parse(row.Cells[4].Value.ToString());
            }
            txtTongGiathanhtoan.Text = tong.ToString("N0");
        }

        // 2. Nút THANH TOÁN - Lưu DB và Trừ Kho
        private void btnhoantatthanhtoan_Click(object sender, EventArgs e)
        {
            using (var db = new QuanLyBanHangContext())
            {
                using (var transaction = db.Database.BeginTransaction()) // Đảm bảo an toàn dữ liệu
                {
                    try
                    {
                        // A. Tạo Đơn Hàng mới
                        DonHang donHang = new DonHang() { NgayBan = DateTime.Now };
                        db.DonHangs.Add(donHang);
                        db.SaveChanges(); // Lưu để lấy MaDH tự sinh

                        // B. Duyệt qua từng món trong giỏ hàng (Grid)
                        foreach (DataGridViewRow row in dataGridViewThanhtoan.Rows)
                        {
                            if (row.IsNewRow) continue; // Bỏ qua dòng trống

                            string maMH = row.Cells[0].Value.ToString();
                            int slMua = int.Parse(row.Cells[2].Value.ToString());
                            double thanhTien = double.Parse(row.Cells[4].Value.ToString());

                            // C. Kiểm tra và Trừ Kho
                            var khoHang = db.MatHangs.FirstOrDefault(m => m.MaMH == maMH);
                            if (khoHang != null)
                            {
                                // --- LOGIC QUAN TRỌNG: Check tồn kho ---
                                if (khoHang.SoLuongTon < slMua)
                                {
                                    throw new Exception($"Món {khoHang.TenMH} chỉ còn {khoHang.SoLuongTon}, không đủ bán {slMua}!");
                                }

                                khoHang.SoLuongTon -= slMua;      // Trừ tồn kho
                                khoHang.SoLuongHienCo = khoHang.SoLuongTon; // Đồng bộ
                                khoHang.SoLuongDaBan += slMua;    // Cộng dồn đã bán
                            }

                            // D. Tạo Chi Tiết Đơn Hàng
                            ChiTietDonHang ct = new ChiTietDonHang()
                            {
                                MaDH = donHang.MaDH,
                                MaMH = maMH,
                                SoLuongMua = slMua,
                                ThanhTien = thanhTien
                            };
                            db.ChiTietDonHangs.Add(ct);
                        }

                        db.SaveChanges();      // Lưu tất cả thay đổi
                        transaction.Commit();  // Xác nhận giao dịch thành công

                        MessageBox.Show($"Thanh toán thành công! Mã đơn: {donHang.MaDH}");
                        dataGridViewThanhtoan.Rows.Clear();
                        txtTongGiathanhtoan.Text = "0";
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback(); // Nếu lỗi thì hoàn tác, không trừ kho bậy bạ
                        MessageBox.Show("Lỗi thanh toán: " + ex.Message);
                    }
                }
            }
        }
    }
}