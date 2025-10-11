using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arthivia_pdv_app.Forms;
using Arthivia_pdv_app.Repository.Fakes;
using Arthivia_pdv_app.Services;

namespace Arthivia_pdv_app
{
    public partial class Login : Form
    {
        private UserService _userService;
        public Login()
        {
            InitializeComponent();
            FakeUserRepositorImpl userRepository = FakeUserRepositorImpl.GetInstance();
            _userService = new UserService(userRepository);    
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.ToUpper().Trim();
            string password = txtPassword.Text.ToUpper().Trim();

            if(username.Equals(""))
            {
                lblInvalidUser.Visible = true;
                return;
            }
            else
            {
                lblInvalidUser.Visible = false;
            }

            if (password.Equals(""))
            {
                lblInvalidPassword.Visible = true;
                return;
            }
            else
            {
                lblInvalidPassword.Visible = false;
            }

            switch(_userService.Authenticate(username, password)){
                case 0:
                    MessageBox.Show("Usuário não encontrado!");
                    break;
                case 1:
                    lblInvalidPassword.Visible = true;
                    break;
                case 2:
                    if (password == "1234")
                        using (var dialog = new NewPassword())
                        {
                            dialog.ShowDialog();
                        }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    break;
            }
            
        }
    }
}
