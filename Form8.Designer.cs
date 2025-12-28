namespace QuanLyBanHang
{
    partial class Form8
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.label1 = new System.Windows.Forms.Label();
            this.gbthanhtoan = new System.Windows.Forms.GroupBox();
            this.dataGridViewThanhtoan = new System.Windows.Forms.DataGridView();
            this.IdIteamthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonhangthanhtoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giagoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tonggia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmonhangthanhtoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTongGiathanhtoan = new System.Windows.Forms.TextBox();
            this.txtsoluongthanhtoan = new System.Windows.Forms.TextBox();
            this.btnthemhangthanhtoan = new System.Windows.Forms.Button();
            this.btnsuahangthanhtoan = new System.Windows.Forms.Button();
            this.btnxoahangthanhtoan = new System.Windows.Forms.Button();
            this.btnhoantatthanhtoan = new System.Windows.Forms.Button();
            this.btnvetrangchinh = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gbthanhtoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanhtoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mặt hàng thanh toán";
            // 
            // gbthanhtoan
            // 
            this.gbthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbthanhtoan.Controls.Add(this.btnxoahangthanhtoan);
            this.gbthanhtoan.Controls.Add(this.btnsuahangthanhtoan);
            this.gbthanhtoan.Controls.Add(this.btnthemhangthanhtoan);
            this.gbthanhtoan.Controls.Add(this.txtsoluongthanhtoan);
            this.gbthanhtoan.Controls.Add(this.label4);
            this.gbthanhtoan.Controls.Add(this.txtmonhangthanhtoan);
            this.gbthanhtoan.Controls.Add(this.label3);
            this.gbthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbthanhtoan.Location = new System.Drawing.Point(17, 130);
            this.gbthanhtoan.Name = "gbthanhtoan";
            this.gbthanhtoan.Size = new System.Drawing.Size(505, 258);
            this.gbthanhtoan.TabIndex = 1;
            this.gbthanhtoan.TabStop = false;
            this.gbthanhtoan.Text = "Nhập mã hàng cần thanh toán";
            // 
            // dataGridViewThanhtoan
            // 
            this.dataGridViewThanhtoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThanhtoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIteamthanhtoan,
            this.tenmonhangthanhtoan,
            this.SoLuongThanhToan,
            this.giagoc,
            this.Tonggia});
            this.dataGridViewThanhtoan.Location = new System.Drawing.Point(528, 130);
            this.dataGridViewThanhtoan.Name = "dataGridViewThanhtoan";
            this.dataGridViewThanhtoan.RowHeadersWidth = 51;
            this.dataGridViewThanhtoan.RowTemplate.Height = 24;
            this.dataGridViewThanhtoan.Size = new System.Drawing.Size(881, 528);
            this.dataGridViewThanhtoan.TabIndex = 2;
            // 
            // IdIteamthanhtoan
            // 
            this.IdIteamthanhtoan.HeaderText = "Mã món hàng";
            this.IdIteamthanhtoan.MinimumWidth = 6;
            this.IdIteamthanhtoan.Name = "IdIteamthanhtoan";
            this.IdIteamthanhtoan.Width = 125;
            // 
            // tenmonhangthanhtoan
            // 
            this.tenmonhangthanhtoan.HeaderText = "Tên hàng";
            this.tenmonhangthanhtoan.MinimumWidth = 6;
            this.tenmonhangthanhtoan.Name = "tenmonhangthanhtoan";
            this.tenmonhangthanhtoan.Width = 125;
            // 
            // SoLuongThanhToan
            // 
            this.SoLuongThanhToan.HeaderText = "Số lượng";
            this.SoLuongThanhToan.MinimumWidth = 6;
            this.SoLuongThanhToan.Name = "SoLuongThanhToan";
            this.SoLuongThanhToan.Width = 125;
            // 
            // giagoc
            // 
            this.giagoc.HeaderText = "Giá gốc";
            this.giagoc.MinimumWidth = 6;
            this.giagoc.Name = "giagoc";
            this.giagoc.Width = 125;
            // 
            // Tonggia
            // 
            this.Tonggia.HeaderText = "Tổng giá";
            this.Tonggia.MinimumWidth = 6;
            this.Tonggia.Name = "Tonggia";
            this.Tonggia.Width = 125;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 689);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tổng Đơn  :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập mã hàng :";
            // 
            // txtmonhangthanhtoan
            // 
            this.txtmonhangthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtmonhangthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmonhangthanhtoan.Location = new System.Drawing.Point(140, 33);
            this.txtmonhangthanhtoan.Name = "txtmonhangthanhtoan";
            this.txtmonhangthanhtoan.Size = new System.Drawing.Size(334, 27);
            this.txtmonhangthanhtoan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nhập số lượng :";
            // 
            // txtTongGiathanhtoan
            // 
            this.txtTongGiathanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTongGiathanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongGiathanhtoan.Location = new System.Drawing.Point(921, 691);
            this.txtTongGiathanhtoan.Name = "txtTongGiathanhtoan";
            this.txtTongGiathanhtoan.Size = new System.Drawing.Size(215, 27);
            this.txtTongGiathanhtoan.TabIndex = 4;
            this.txtTongGiathanhtoan.Text = "000.000";
            this.txtTongGiathanhtoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtsoluongthanhtoan
            // 
            this.txtsoluongthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsoluongthanhtoan.Location = new System.Drawing.Point(140, 77);
            this.txtsoluongthanhtoan.Name = "txtsoluongthanhtoan";
            this.txtsoluongthanhtoan.Size = new System.Drawing.Size(118, 27);
            this.txtsoluongthanhtoan.TabIndex = 3;
            this.txtsoluongthanhtoan.Text = "0";
            // 
            // btnthemhangthanhtoan
            // 
            this.btnthemhangthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnthemhangthanhtoan.Location = new System.Drawing.Point(20, 140);
            this.btnthemhangthanhtoan.Name = "btnthemhangthanhtoan";
            this.btnthemhangthanhtoan.Size = new System.Drawing.Size(80, 29);
            this.btnthemhangthanhtoan.TabIndex = 4;
            this.btnthemhangthanhtoan.Text = "Thêm";
            this.btnthemhangthanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnsuahangthanhtoan
            // 
            this.btnsuahangthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsuahangthanhtoan.Location = new System.Drawing.Point(140, 140);
            this.btnsuahangthanhtoan.Name = "btnsuahangthanhtoan";
            this.btnsuahangthanhtoan.Size = new System.Drawing.Size(80, 29);
            this.btnsuahangthanhtoan.TabIndex = 4;
            this.btnsuahangthanhtoan.Text = "Sửa";
            this.btnsuahangthanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnxoahangthanhtoan
            // 
            this.btnxoahangthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnxoahangthanhtoan.Location = new System.Drawing.Point(20, 190);
            this.btnxoahangthanhtoan.Name = "btnxoahangthanhtoan";
            this.btnxoahangthanhtoan.Size = new System.Drawing.Size(80, 29);
            this.btnxoahangthanhtoan.TabIndex = 4;
            this.btnxoahangthanhtoan.Text = "Xóa";
            this.btnxoahangthanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnhoantatthanhtoan
            // 
            this.btnhoantatthanhtoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnhoantatthanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhoantatthanhtoan.Location = new System.Drawing.Point(17, 416);
            this.btnhoantatthanhtoan.Name = "btnhoantatthanhtoan";
            this.btnhoantatthanhtoan.Size = new System.Drawing.Size(110, 35);
            this.btnhoantatthanhtoan.TabIndex = 5;
            this.btnhoantatthanhtoan.Text = "Thanh toán";
            this.btnhoantatthanhtoan.UseVisualStyleBackColor = true;
            // 
            // btnvetrangchinh
            // 
            this.btnvetrangchinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnvetrangchinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvetrangchinh.Location = new System.Drawing.Point(412, 416);
            this.btnvetrangchinh.Name = "btnvetrangchinh";
            this.btnvetrangchinh.Size = new System.Drawing.Size(110, 35);
            this.btnvetrangchinh.TabIndex = 5;
            this.btnvetrangchinh.Text = "Trang chủ";
            this.btnvetrangchinh.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 714);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1421, 24);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.tải_xuống;
            this.ClientSize = new System.Drawing.Size(1421, 738);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnvetrangchinh);
            this.Controls.Add(this.btnhoantatthanhtoan);
            this.Controls.Add(this.txtTongGiathanhtoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewThanhtoan);
            this.Controls.Add(this.gbthanhtoan);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "nhập mặt hàng thanh toán";
            this.gbthanhtoan.ResumeLayout(false);
            this.gbthanhtoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThanhtoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbthanhtoan;
        private System.Windows.Forms.DataGridView dataGridViewThanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIteamthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhangthanhtoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn giagoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tonggia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmonhangthanhtoan;
        private System.Windows.Forms.TextBox txtsoluongthanhtoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTongGiathanhtoan;
        private System.Windows.Forms.Button btnxoahangthanhtoan;
        private System.Windows.Forms.Button btnsuahangthanhtoan;
        private System.Windows.Forms.Button btnthemhangthanhtoan;
        private System.Windows.Forms.Button btnhoantatthanhtoan;
        private System.Windows.Forms.Button btnvetrangchinh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}