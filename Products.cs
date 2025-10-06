using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arthivia_pdv_app
{
    public partial class Products : Form
    {
        private Main main;
        public Products(Main mainForm)
        {
            InitializeComponent();
            this.main = mainForm;
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            RegisterProduct registerProduct = new RegisterProduct();
            registerProduct.TopLevel = false;
            registerProduct.FormBorderStyle = FormBorderStyle.None;
            registerProduct.Dock = DockStyle.Fill;

            main.panel.Controls.Add(registerProduct);

            registerProduct.BringToFront();
            registerProduct.Show();
        }
    }
}
