namespace Arthivia_pdv_app.Forms.User
{
    partial class NewUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblCPF = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            btnResetPass = new Button();
            btnSave = new Button();
            cbPermissions = new ComboBox();
            lblRole = new Label();
            lblEnable = new Label();
            cbEnable = new ComboBox();
            mktCpf = new MaskedTextBox();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(12, 9);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(99, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Nome Completo:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 27);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(305, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(12, 60);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(31, 15);
            lblCPF.TabIndex = 2;
            lblCPF.Text = "CPF:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(156, 78);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(161, 23);
            txtUserName.TabIndex = 5;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(156, 60);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(102, 15);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "Nome de Usuário:";
            // 
            // btnResetPass
            // 
            btnResetPass.Location = new Point(12, 159);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(111, 23);
            btnResetPass.TabIndex = 10;
            btnResetPass.Text = "Resetar senha";
            btnResetPass.UseVisualStyleBackColor = true;
            btnResetPass.Visible = false;
            btnResetPass.Click += btnResetPass_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(206, 159);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 23);
            btnSave.TabIndex = 11;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbPermissions
            // 
            cbPermissions.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPermissions.FormattingEnabled = true;
            cbPermissions.Location = new Point(12, 126);
            cbPermissions.Name = "cbPermissions";
            cbPermissions.Size = new Size(138, 23);
            cbPermissions.TabIndex = 7;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(12, 108);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(69, 15);
            lblRole.TabIndex = 6;
            lblRole.Text = "Permissões:";
            // 
            // lblEnable
            // 
            lblEnable.AutoSize = true;
            lblEnable.Location = new Point(156, 108);
            lblEnable.Name = "lblEnable";
            lblEnable.Size = new Size(38, 15);
            lblEnable.TabIndex = 8;
            lblEnable.Text = "Ativo:";
            // 
            // cbEnable
            // 
            cbEnable.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEnable.FormattingEnabled = true;
            cbEnable.Location = new Point(156, 126);
            cbEnable.Name = "cbEnable";
            cbEnable.Size = new Size(161, 23);
            cbEnable.TabIndex = 9;
            // 
            // mktCpf
            // 
            mktCpf.Location = new Point(12, 78);
            mktCpf.Name = "mktCpf";
            mktCpf.Size = new Size(138, 23);
            mktCpf.TabIndex = 3;
            mktCpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // NewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 193);
            Controls.Add(mktCpf);
            Controls.Add(lblEnable);
            Controls.Add(cbEnable);
            Controls.Add(lblRole);
            Controls.Add(cbPermissions);
            Controls.Add(btnSave);
            Controls.Add(btnResetPass);
            Controls.Add(txtUserName);
            Controls.Add(lblUserName);
            Controls.Add(lblCPF);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(349, 232);
            MinimumSize = new Size(349, 232);
            Name = "NewUser";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Novo Usuário";
            Load += NewUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblCPF;
        private MaskedTextBox mktCPF;
        private TextBox txtUserName;
        private Label lblUserName;
        private Button btnResetPass;
        private Button btnSave;
        private ComboBox cbPermissions;
        private Label lblRole;
        private Label lblEnable;
        private ComboBox cbEnable;
        private MaskedTextBox mktCpf;
    }
}