using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            // Thiết lập để Form luôn hiển thị ở chính giữa màn hình khi mở
            this.StartPosition = FormStartPosition.CenterScreen;

            // Đăng ký sự kiện (để đảm bảo code chạy dù bạn quên click trong Design)
            this.Load += new System.EventHandler(this.Form6_Load);

            // Lưu ý: Nếu nút của bạn tên khác 'btnoutt', dòng dưới sẽ báo lỗi. 
            // Hãy đảm bảo nút Thoát tên là btnoutt hoặc sửa lại code cho khớp.
            if (this.btnoutt != null)
            {
                this.btnoutt.Click += new System.EventHandler(this.btnoutt_Click);
            }
        }

        // --- SỰ KIỆN LOAD FORM ---
        private void Form6_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Xóa dữ liệu cũ
                dataGridView1.Rows.Clear();

                // 2. Thêm dữ liệu mẫu
                // Cấu trúc cột: Mã (0) | Tên (1) | Tồn kho (2) | Đã bán (3)
                dataGridView1.Rows.Add("MH001", "Bánh ngọt ABC", "45", "120");
                dataGridView1.Rows.Add("MH002", "Nước giải khát", "12", "350"); // Tồn 12 (<15) -> Sẽ đỏ
                dataGridView1.Rows.Add("MH003", "Kẹo mút trái cây", "8", "210"); // Tồn 8 (<15) -> Sẽ đỏ
                dataGridView1.Rows.Add("MH004", "Sữa tươi không đường", "60", "85");

                // 3. Kiểm tra và tô màu cảnh báo
                KiemTraHangSapHet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu: " + ex.Message, "Lỗi hệ thống");
            }
        }

        // --- SỰ KIỆN NÚT THOÁT ---
        private void btnoutt_Click(object sender, EventArgs e)
        {
            this.Close(); // Đóng Form6 quay về Form3
        }

        // --- HÀM TÔ MÀU CẢNH BÁO HÀNG SẮP HẾT ---
        private void KiemTraHangSapHet()
        {
            try
            {
                // Tên cột số lượng tồn kho trong Design (Name)
                string tenCotTonKho = "SoLuong3";

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.IsNewRow) continue; // Bỏ qua dòng trống cuối cùng

                    // Lấy ô chứa giá trị tồn kho
                    DataGridViewCell cell = null;

                    // Cách 1: Tìm theo tên cột "SoLuong3"
                    if (dataGridView1.Columns.Contains(tenCotTonKho))
                    {
                        cell = row.Cells[tenCotTonKho];
                    }
                    // Cách 2: Nếu không tìm thấy tên, lấy theo thứ tự (Cột thứ 3 -> index 2)
                    else
                    {
                        if (row.Cells.Count > 2) cell = row.Cells[2];
                    }

                    // Xử lý kiểm tra giá trị
                    if (cell != null && cell.Value != null)
                    {
                        int tonKho;
                        // Chuyển đổi dữ liệu sang số nguyên
                        if (int.TryParse(cell.Value.ToString(), out tonKho))
                        {
                            // Nếu tồn kho < 15 thì tô màu nền hồng, chữ đỏ
                            if (tonKho < 15)
                            {
                                row.DefaultCellStyle.BackColor = Color.MistyRose;
                                row.DefaultCellStyle.ForeColor = Color.Red;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Không hiện lỗi để tránh làm phiền người dùng, chỉ ghi log nếu cần
                Console.WriteLine("Lỗi tô màu: " + ex.Message);
            }
        }
    }
}