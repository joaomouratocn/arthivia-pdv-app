using System.Diagnostics;
using Arthivia_pdv_app.Forms;

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
            miProductRegister.Enabled = false;

            SearchProducts searchProducts = new SearchProducts(this);
            searchProducts.TopLevel = false;
            searchProducts.Dock = DockStyle.Fill;

            panel.Controls.Add(searchProducts);
            searchProducts.Show();

            searchProducts.FormClosed += (s, args) =>
            {
                miProductRegister.Enabled = true;
            };
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miCalc_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Open Calc");
            Process.Start("calc.exe");
        }

        private void miCategoryRegister_Click(object sender, EventArgs e)
        {
            miCategoryRegister.Enabled = false;

            SearchCategories searchCategories = new SearchCategories(this);
            searchCategories.TopLevel = false;
            searchCategories.Dock = DockStyle.Fill;

            panel.Controls.Add(searchCategories);
            searchCategories.Show();

            searchCategories.FormClosed += (s, args) =>
            {
                miCategoryRegister.Enabled = true;
            };
        }
    }
}
