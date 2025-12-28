namespace QuanLyBanHang
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.xemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIform5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.liệtKêTheoSốLượngBánRaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpChonNgay = new System.Windows.Forms.DateTimePicker();
            this.dgvCTBH = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdIteam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameIteam2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBH)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            this.menuStrip1.Size = new System.Drawing.Size(857, 30);
=======
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(643, 28);
>>>>>>> Stashed changes
=======
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(643, 28);
>>>>>>> Stashed changes
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // xemToolStripMenuItem
            // 
            this.xemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIform5,
            this.toolStripSeparator1,
            this.liệtKêTheoSốLượngBánRaToolStripMenuItem,
            this.toolStripSeparator2,
            this.thoátToolStripMenuItem});
            this.xemToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.images__2_;
            this.xemToolStripMenuItem.Name = "xemToolStripMenuItem";
            this.xemToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.xemToolStripMenuItem.Text = "Xem";
            // 
            // TSMIform5
            // 
            this.TSMIform5.Name = "TSMIform5";
            this.TSMIform5.Size = new System.Drawing.Size(277, 26);
            this.TSMIform5.Text = " Liệt kê theo giá";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(274, 6);
            // 
            // liệtKêTheoSốLượngBánRaToolStripMenuItem
            // 
            this.liệtKêTheoSốLượngBánRaToolStripMenuItem.Name = "liệtKêTheoSốLượngBánRaToolStripMenuItem";
            this.liệtKêTheoSốLượngBánRaToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.liệtKêTheoSốLượngBánRaToolStripMenuItem.Text = "Liệt kê theo số lượng bán ra";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(274, 6);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Image = global::QuanLyBanHang.Properties.Resources.images1;
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.thoátToolStripMenuItem.Text = "thoát";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chi tiết bán hàng";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please nhập ngày :";
            // 
            // dtpChonNgay
            // 
            this.dtpChonNgay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpChonNgay.Location = new System.Drawing.Point(160, 158);
            this.dtpChonNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpChonNgay.Name = "dtpChonNgay";
            this.dtpChonNgay.Size = new System.Drawing.Size(242, 27);
            this.dtpChonNgay.TabIndex = 3;
            // 
            // dgvCTBH
            // 
            this.dgvCTBH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCTBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.IdIteam2,
            this.NameIteam2,
            this.SoLuong2});
            this.dgvCTBH.Location = new System.Drawing.Point(10, 202);
            this.dgvCTBH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCTBH.Name = "dgvCTBH";
            this.dgvCTBH.RowHeadersWidth = 51;
            this.dgvCTBH.RowTemplate.Height = 24;
            this.dgvCTBH.Size = new System.Drawing.Size(624, 347);
            this.dgvCTBH.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.HeaderText = "DATE";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // IdIteam2
            // 
            this.IdIteam2.HeaderText = "Mã món hàng";
            this.IdIteam2.MinimumWidth = 6;
            this.IdIteam2.Name = "IdIteam2";
            this.IdIteam2.Width = 125;
            // 
            // NameIteam2
            // 
            this.NameIteam2.HeaderText = "Tên hàng";
            this.NameIteam2.MinimumWidth = 6;
            this.NameIteam2.Name = "NameIteam2";
            this.NameIteam2.Width = 125;
            // 
            // SoLuong2
            // 
            this.SoLuong2.HeaderText = "Số Lượng";
            this.SoLuong2.MinimumWidth = 6;
            this.SoLuong2.Name = "SoLuong2";
            this.SoLuong2.Width = 125;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.tải_xuống1;
            this.ClientSize = new System.Drawing.Size(643, 558);
            this.Controls.Add(this.dgvCTBH);
            this.Controls.Add(this.dtpChonNgay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.Text = "Kho và tổng đơn";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTBH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMIform5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem liệtKêTheoSốLượngBánRaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpChonNgay;
        private System.Windows.Forms.DataGridView dgvCTBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIteam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIteam2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong2;
    }
}