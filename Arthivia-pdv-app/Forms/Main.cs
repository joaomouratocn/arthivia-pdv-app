using System.Diagnostics;
using Arthivia_pdv_app.Forms;
using Arthivia_pdv_app.Forms.Units;
using Arthivia_pdv_app.Forms.User;

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
            openForm(miCategoryRegister, new SearchCategories());
        }

        public void miProductRegister_Click(object sender, EventArgs e)
        {
            openForm(miProductRegister, new SearchProducts());
        }

        private void miUnitRegister_Click(object sender, EventArgs e)
        {
            openForm(miUnitRegister, new SearchUnit());
        }

        private void miUserRegister_Click(object sender, EventArgs e)
        {
            openForm(miUserRegister, new SearchUsers());
        }

        private void openForm(ToolStripMenuItem toolStripMenuItem, Form form)
        {

            toolStripMenuItem.Enabled = false;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();

            form.FormClosed += (s, args) =>
            {
                toolStripMenuItem.Enabled = true;
            };

        }
    }
}
