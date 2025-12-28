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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // --- QUAN TRỌNG: KẾT NỐI SỰ KIỆN THỦ CÔNG ---
            // Đoạn này giúp các nút hoạt động ngay cả khi bạn chưa click đúp trong Design
            this.Load += new EventHandler(Form4_Load);
            this.btnAddIteam.Click += new EventHandler(btnAddIteam_Click);     // Nút Thêm
            this.btnUpIteam.Click += new EventHandler(btnUpIteam_Click);       // Nút Sửa
            this.btnDeleteIteam.Click += new EventHandler(btnDeleteIteam_Click); // Nút Xóa
            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick); // Click bảng
            this.thoátToolStripMenuItem.Click += new EventHandler(thoátToolStripMenuItem_Click); // Nút Thoát
        }

        // 1. TỰ ĐỘNG NẠP DỮ LIỆU MẪU (Để test cho nhanh)
        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                // Thêm dữ liệu mẫu vào các cột: iditeam, nameiteam, gia, soluong
                dataGridView1.Rows.Add("SP001", "Bánh ChocoPie", "50000", "20");
                dataGridView1.Rows.Add("SP002", "Nước ngọt Coca", "10000", "50");
                dataGridView1.Rows.Add("SP003", "Mì tôm Hảo Hảo", "4000", "100");
                dataGridView1.Rows.Add("SP004", "Kẹo mút", "2000", "200");
            }
            catch (Exception) { }
        }

        // 2. NÚT THÊM (Lấy dữ liệu từ GroupBox nâu đưa xuống bảng)
        private void btnAddIteam_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu trống
                if (string.IsNullOrWhiteSpace(txtIdIteam.Text) || string.IsNullOrWhiteSpace(txtNameIteam.Text))
                {
                    MessageBox.Show("Vui lòng nhập Mã và Tên món hàng!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm dòng mới
                int n = dataGridView1.Rows.Add();

                // Đưa dữ liệu vào đúng tên cột đã định nghĩa trong Designer
                dataGridView1.Rows[n].Cells["iditeam"].Value = txtIdIteam.Text;
                dataGridView1.Rows[n].Cells["nameiteam"].Value = txtNameIteam.Text;
                dataGridView1.Rows[n].Cells["gia"].Value = txtGia.Text;
                dataGridView1.Rows[n].Cells["soluong"].Value = txtSoLuong.Text;

                ClearFields(); // Xóa trắng ô nhập
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // 3. NÚT SỬA (Cập nhật dòng đang chọn)
        private void btnUpIteam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                // Cập nhật lại giá trị các ô trong bảng
                row.Cells["iditeam"].Value = txtIdIteam.Text;
                row.Cells["nameiteam"].Value = txtNameIteam.Text;
                row.Cells["gia"].Value = txtGia.Text;
                row.Cells["soluong"].Value = txtSoLuong.Text;

                MessageBox.Show("Đã sửa thông tin thành công!", "Thông báo");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn món hàng cần sửa trong bảng!", "Thông báo");
            }
        }

        // 4. NÚT XÓA
        private void btnDeleteIteam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && !dataGridView1.CurrentRow.IsNewRow)
            {
                if (MessageBox.Show("Bạn chắc chắn muốn xóa món này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                    ClearFields();
                }
            }
        }

        // 5. CLICK VÀO BẢNG -> HIỆN LÊN GROUPBOX (Để xem hoặc sửa)
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Lấy dữ liệu từ bảng điền ngược lại vào Textbox
                txtIdIteam.Text = row.Cells["iditeam"].Value?.ToString();
                txtNameIteam.Text = row.Cells["nameiteam"].Value?.ToString();
                txtGia.Text = row.Cells["gia"].Value?.ToString();
                txtSoLuong.Text = row.Cells["soluong"].Value?.ToString();
            }
        }

        // 6. NÚT THOÁT
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hàm xóa trắng các ô nhập liệu
        private void ClearFields()
        {
            txtIdIteam.Clear();
            txtNameIteam.Clear();
            txtGia.Text = "0";
            txtSoLuong.Text = "0";
            txtIdIteam.Focus(); // Đưa con trỏ chuột về ô nhập Mã
        }
    }
}