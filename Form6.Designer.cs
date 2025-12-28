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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnoutt = new System.Windows.Forms.Button();
            this.SoLuonDaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết số lượng hàng";
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIteam3,
            this.NameIteam3,
            this.SoLuong3,
            this.SoLuonDaBan});
            this.dataGridView1.Location = new System.Drawing.Point(12, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(629, 437);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnoutt
            // 
            this.btnoutt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnoutt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnoutt.Location = new System.Drawing.Point(491, 601);
            this.btnoutt.Name = "btnoutt";
            this.btnoutt.Size = new System.Drawing.Size(75, 23);
            this.btnoutt.TabIndex = 2;
            this.btnoutt.Text = "Thoát";
            this.btnoutt.UseVisualStyleBackColor = true;
            // 
            // SoLuonDaBan
            // 
            this.SoLuonDaBan.HeaderText = "Số lượng hàng đã bán";
            this.SoLuonDaBan.MinimumWidth = 6;
            this.SoLuonDaBan.Name = "SoLuonDaBan";
            this.SoLuonDaBan.Width = 125;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(653, 668);
            this.Controls.Add(this.btnoutt);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "chi tiết số lượng hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameIteam3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIteam3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnoutt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuonDaBan;
    }
}