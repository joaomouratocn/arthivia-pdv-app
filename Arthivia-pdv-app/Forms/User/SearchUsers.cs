using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arthivia_pdv_app.Forms.Units;
using Arthivia_pdv_app.Repository;
using Arthivia_pdv_app.Repository.Fakes;

namespace Arthivia_pdv_app.Forms.User
{
    public partial class SearchUsers : Form
    {
        private UserRepositoryInterface userRepository;
        public SearchUsers()
        {
            InitializeComponent();
            userRepository = FakeUserRepositorImpl.GetInstance();
        }

        private void SerachUser_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            bsData.DataSource = userRepository.GetAll();
            lbUsers.DataSource = bsData;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var currentUser = bsData.Current as Model.UserModel;
            if (currentUser == null)
            {
                MessageBox.Show("Nenhuma categoria selecionada para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var formNewUser = new NewUser(currentUser);
            this.Enabled = false;
            var result = formNewUser.ShowDialog(this);
            this.Enabled = true;
            if (result == DialogResult.OK)
            {
                reload();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var formNewUser = new NewUser(null);
            this.Enabled = false;
            var result = formNewUser.ShowDialog(this);
            this.Enabled = true;
            if (result == DialogResult.OK)
            {
                reload();
            }
        }
    }
}
