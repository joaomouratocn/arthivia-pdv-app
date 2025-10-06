using System.Diagnostics;

namespace Arthivia_pdv_app
{
    public partial class Main : Form
    {
        internal Panel panel;

        public Main()
        {
            InitializeComponent();
            panel = mainPanel;
        }

        public void miProductRegister_Click(object sender, EventArgs e)
        {
            miCategoriesRegister.Enabled = false;

            Products products = new Products(this);
            products.TopLevel = false;
            products.FormBorderStyle = FormBorderStyle.None;
            products.Dock = DockStyle.Fill;

            panel.Controls.Add(products);
            products.Show();

            products.FormClosed += (s, args) =>
            {
                miCategoriesRegister.Enabled = true;
            };
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miCalc_Click(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }
    }
}
