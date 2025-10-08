using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arthivia_pdv_app.Forms
{
    public partial class NewPassword : Form
    {

        public NewPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string textPass = txtPassword.Text.Trim();
            string textConfirmPass = txtConfirmPass.Text.Trim();


            if (textPass.Equals(""))
            {
                lblInvalidPass.Visible = true;
                return;
            }
            else
            {
                lblInvalidPass.Visible = false;

            }

            if (textPass != textConfirmPass)
            {
                lblPassNotMacth.Visible = true;
            }
            else { 
                lblPassNotMacth.Visible = false;
                updatePass(textPass);
                this.Close();
            }
        }

        private void updatePass(string textPass)
        {
            //atualizar a senha no banco de dados
        }
    }
}
