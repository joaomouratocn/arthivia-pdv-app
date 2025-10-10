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
    public partial class SearchProducts : Form
    {
        private Main mainForm;
        public SearchProducts(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            RegisterProduct registerProduct = new RegisterProduct();
            registerProduct.TopLevel = false;

            mainForm.panel.Controls.Add(registerProduct);

            int x = (mainForm.panel.Width - registerProduct.Width) / 2;
            int y = (mainForm.panel.Height - registerProduct.Height) / 2;
            registerProduct.Location = new Point(x, y);

            registerProduct.BringToFront();
            registerProduct.Show();

            registerProduct.FormClosed += (sender, e) =>
            {
                this.Enabled = true;
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //implement search function
        }
    }
}
