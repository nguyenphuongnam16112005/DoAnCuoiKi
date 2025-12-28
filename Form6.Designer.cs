namespace QuanLyBanHang
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.label1 = new System.Windows.Forms.Label();
            this.SoLuong3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameIteam3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdIteam3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCTSLH = new System.Windows.Forms.DataGridView();
            this.SoLuonDaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnoutt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSLH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết số lượng hàng tồn";
            // 
            // SoLuong3
            // 
            this.SoLuong3.HeaderText = "Số Lượng còn lại";
            this.SoLuong3.MinimumWidth = 6;
            this.SoLuong3.Name = "SoLuong3";
            this.SoLuong3.Width = 125;
            // 
            // NameIteam3
            // 
            this.NameIteam3.HeaderText = "Tên Hàng";
            this.NameIteam3.MinimumWidth = 6;
            this.NameIteam3.Name = "NameIteam3";
            this.NameIteam3.Width = 125;
            // 
            // IdIteam3
            // 
            this.IdIteam3.HeaderText = "Mã món hàng";
            this.IdIteam3.MinimumWidth = 6;
            this.IdIteam3.Name = "IdIteam3";
            this.IdIteam3.Width = 125;
            // 
            // dgvCTSLH
            // 
            this.dgvCTSLH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvCTSLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTSLH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIteam3,
            this.NameIteam3,
            this.SoLuong3,
            this.SoLuonDaBan});
            this.dgvCTSLH.Location = new System.Drawing.Point(9, 108);
            this.dgvCTSLH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCTSLH.Name = "dgvCTSLH";
            this.dgvCTSLH.RowHeadersWidth = 51;
            this.dgvCTSLH.RowTemplate.Height = 24;
            this.dgvCTSLH.Size = new System.Drawing.Size(472, 355);
            this.dgvCTSLH.TabIndex = 1;
            // 
            // SoLuonDaBan
            // 
            this.SoLuonDaBan.HeaderText = "Số lượng hàng đã bán";
            this.SoLuonDaBan.MinimumWidth = 6;
            this.SoLuonDaBan.Name = "SoLuonDaBan";
            this.SoLuonDaBan.Width = 125;
            // 
            // btnoutt
            // 
            this.btnoutt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnoutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoutt.Location = new System.Drawing.Point(368, 488);
            this.btnoutt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnoutt.Name = "btnoutt";
            this.btnoutt.Size = new System.Drawing.Size(56, 19);
            this.btnoutt.TabIndex = 2;
            this.btnoutt.Text = "Thoát";
            this.btnoutt.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(490, 543);
            this.Controls.Add(this.btnoutt);
            this.Controls.Add(this.dgvCTSLH);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form6";
            this.Text = "chi tiết số lượng hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTSLH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIteam3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIteam3;
        private System.Windows.Forms.DataGridView dgvCTSLH;
        private System.Windows.Forms.Button btnoutt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuonDaBan;
    }
}