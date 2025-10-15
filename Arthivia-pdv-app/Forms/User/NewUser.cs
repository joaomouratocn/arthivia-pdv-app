using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arthivia_pdv_app.Model;
using Arthivia_pdv_app.Repository;
using Arthivia_pdv_app.Repository.Fakes;
using Arthivia_pdv_app.util;

namespace Arthivia_pdv_app.Forms.User
{
    public partial class NewUser : Form
    {
        private UserModel? _userModel;
        private readonly UserRepositoryInterface userRepository = FakeUserRepositorImpl.GetInstance();

        public NewUser(UserModel? userModel)
        {
            InitializeComponent();
            this._userModel = userModel;

            if (this._userModel != null)
            {
                this.Text = "Editar Usuário";
                txtFullName.Text = this._userModel.Name;
                mktCpf.Text = this._userModel.CPF;
                txtUserName.Text = this._userModel.Username;
                cbPermissions.SelectedItem = this._userModel.Role;
                cbEnable.SelectedItem = this._userModel.Status;

                btnResetPass.Visible = true;
            }
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            cbEnable.DataSource = Enum.GetValues(typeof(util.UserStatus));
            cbEnable.SelectedItem = UserStatus.ATIVO;
            cbPermissions.DataSource = Enum.GetValues(typeof(util.UserRole));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string cpf = mktCpf.Text.Trim();
            string userName = txtUserName.Text.Trim();
            UserStatus status = (UserStatus)cbEnable.SelectedItem;
            UserRole role = (UserRole)cbPermissions.SelectedItem;

            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Por favor, insira o nome completo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Por favor, insira o nome de usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine(Util.CpfValidator(cpf));
            if (!Util.CpfValidator(cpf))
            {
                MessageBox.Show("Por favor, insira um CPF válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbPermissions.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione uma permissão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_userModel != null)
            {
                var updatedUser = new UserModel.Builder()
                    .WithId(this._userModel.Id)
                    .WithName(Util.NormalizeText(fullName))
                    .WithCPF(cpf)
                    .WithUsername(Util.NormalizeText(userName))
                    .WithPassword(this._userModel.Password)
                    .WithRole(role)
                    .WithIsActive(status)
                    .WithCreatedAt(this._userModel.CreatedAt)
                    .WithUpdatedAt(DateTime.Now)
                    .Build();

                userRepository.Update(updatedUser);
            }
            else
            {
                var newUser = new UserModel.Builder()
                    .WithName(Util.NormalizeText(fullName))
                    .WithCPF(cpf)
                    .WithUsername(Util.NormalizeText(userName))
                    .WithPassword("1234567") // Senha padrão
                    .WithIsActive(status)
                    .WithRole(role)
                    .WithCreatedAt(DateTime.Now)
                    .WithUpdatedAt(DateTime.Now)
                    .Build();

                userRepository.Add(newUser);
            }
            MessageBox.Show("Usuário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (_userModel != null) {
                var result = MessageBox.Show($"Tem certeza que deseja redefinir a senha para '{_userModel.Name}'?", "Confirmar Redefinição de Senha", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var updatedUser = new UserModel.Builder()
                        .WithId(this._userModel.Id)
                        .WithName(this._userModel.Name)
                        .WithCPF(this._userModel.CPF)
                        .WithUsername(this._userModel.Username)
                        .WithPassword("1234567") // Senha padrão
                        .WithRole(this._userModel.Role)
                        .WithIsActive(this._userModel.Status)
                        .WithCreatedAt(this._userModel.CreatedAt)
                        .WithUpdatedAt(DateTime.Now)
                        .Build();
                    userRepository.Update(updatedUser);
                    MessageBox.Show("Senha redefinida com sucesso para '1234567'!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
