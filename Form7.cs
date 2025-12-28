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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
<<<<<<< HEAD
            // Register click handler for Thanh toán button
            this.btnThanhToan.Click += BtnThanhToan_Click;
<<<<<<< Updated upstream
=======
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            // Open Form8 for payment
            using (var f8 = new Form8())
            {
                f8.ShowDialog(this);
            }
>>>>>>> Stashed changes
        }

        private void BtnThanhToan_Click(object sender, EventArgs e)
        {
            // Open Form8 for payment
            using (var f8 = new Form8())
            {
                f8.ShowDialog(this);
            }
=======
>>>>>>> parent of 2454973 (Them LINQ, EF theo Empty Code First model.)
        }
    }
}
