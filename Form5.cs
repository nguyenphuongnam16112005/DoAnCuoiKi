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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            // --- TỰ ĐỘNG KẾT NỐI SỰ KIỆN (Không cần chỉnh trong Design) ---
            this.Load += new EventHandler(Form5_Load);

            // Sự kiện cho nút thoát
            this.thoátToolStripMenuItem.Click += new EventHandler(thoátToolStripMenuItem_Click);

            // Sự kiện cho nút "Liệt kê theo giá" (TSMIform5)
            this.TSMIform5.Click += new EventHandler(TSMIform5_Click);

            // Sự kiện cho nút "Liệt kê theo số lượng"
            this.liệtKêTheoSốLượngBánRaToolStripMenuItem.Click += new EventHandler(liệtKêTheoSốLượngBánRaToolStripMenuItem_Click);

            // Sự kiện khi chọn ngày
            this.dtpChonNgay.ValueChanged += new EventHandler(dtpChonNgay_ValueChanged);
        }

        // 1. Khi Form mở lên: Cấu hình thêm cột Giá và nạp dữ liệu
        private void Form5_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            // Kiểm tra và thêm cột "Giá" vì trong Designer chưa có
            if (dataGridView1.Columns["colGia"] == null)
            {
                DataGridViewTextBoxColumn colGia = new DataGridViewTextBoxColumn();
                colGia.Name = "colGia";
                colGia.HeaderText = "Giá Bán";
                dataGridView1.Columns.Add(colGia);
            }

            // Nạp dữ liệu lần đầu
            TaiDuLieuVaoBang();
        }

        // 2. Hàm nạp dữ liệu giả lập (Sau này thay bằng SQL)
        private void TaiDuLieuVaoBang()
        {
            try
            {
                dataGridView1.Rows.Clear();
                string ngayChon = dtpChonNgay.Value.ToString("dd/MM/yyyy");

                // Giả lập dữ liệu: Ngày | Mã | Tên | Số Lượng | Giá
                // Lưu ý: Số lượng và Giá phải để dạng số (int/double) để sắp xếp đúng
                if (dtpChonNgay.Value.Day % 2 != 0) // Ví dụ ngày lẻ
                {
                    dataGridView1.Rows.Add(ngayChon, "SP001", "Bánh ngọt", 10, 50000);
                    dataGridView1.Rows.Add(ngayChon, "SP002", "Nước suối", 50, 10000);
                    dataGridView1.Rows.Add(ngayChon, "SP003", "Kẹo mút", 5, 2000);
                }
                else // Ngày chẵn
                {
                    dataGridView1.Rows.Add(ngayChon, "SP004", "Bánh mì", 20, 15000);
                    dataGridView1.Rows.Add(ngayChon, "SP005", "Sữa tươi", 100, 8000);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // 3. Xử lý nút THOÁT
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult hoi = MessageBox.Show("Bạn muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (hoi == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // 4. Xử lý nút LIỆT KÊ THEO GIÁ (TSMIform5)
        private void TSMIform5_Click(object sender, EventArgs e)
        {
            // Sắp xếp theo cột Giá (cột code tự thêm vào lúc Load)
            if (dataGridView1.Columns["colGia"] != null)
            {
                dataGridView1.Sort(dataGridView1.Columns["colGia"], ListSortDirection.Descending); // Giảm dần
                MessageBox.Show("Đã sắp xếp theo Giá giảm dần.", "Thông báo");
            }
        }

        // 5. Xử lý nút LIỆT KÊ THEO SỐ LƯỢNG
        private void liệtKêTheoSốLượngBánRaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trong Designer, cột số lượng tên là "SoLuong2"
            if (dataGridView1.Columns["SoLuong2"] != null)
            {
                dataGridView1.Sort(dataGridView1.Columns["SoLuong2"], ListSortDirection.Descending);
                MessageBox.Show("Đã sắp xếp theo Số lượng bán ra.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy cột 'SoLuong2'.");
            }
        }

        // 6. Xử lý khi ĐỔI NGÀY -> Tự nạp lại dữ liệu
        private void dtpChonNgay_ValueChanged(object sender, EventArgs e)
        {
            TaiDuLieuVaoBang();
        }
    }
}