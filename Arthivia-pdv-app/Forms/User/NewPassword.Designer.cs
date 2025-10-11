namespace Arthivia_pdv_app.Forms
{
    partial class NewPassword
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
            lblInsertNewPass = new Label();
            lblConfirmPass = new Label();
            btnSave = new Button();
            lblPassNotMacth = new Label();
            lblInvalidPass = new Label();
            txtConfirmPass = new TextBox();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // lblInsertNewPass
            // 
            lblInsertNewPass.AutoSize = true;
            lblInsertNewPass.Location = new Point(12, 14);
            lblInsertNewPass.Name = "lblInsertNewPass";
            lblInsertNewPass.Size = new Size(140, 15);
            lblInsertNewPass.TabIndex = 0;
            lblInsertNewPass.Text = "Cadastre sua nova senha:";
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Location = new Point(12, 80);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(144, 15);
            lblConfirmPass.TabIndex = 3;
            lblConfirmPass.Text = "Confirme sua nova senha:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 157);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(201, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblPassNotMacth
            // 
            lblPassNotMacth.AutoSize = true;
            lblPassNotMacth.ForeColor = Color.IndianRed;
            lblPassNotMacth.Location = new Point(16, 124);
            lblPassNotMacth.Name = "lblPassNotMacth";
            lblPassNotMacth.Size = new Size(131, 15);
            lblPassNotMacth.TabIndex = 5;
            lblPassNotMacth.Text = "As senha não conferem";
            lblPassNotMacth.Visible = false;
            // 
            // lblInvalidPass
            // 
            lblInvalidPass.AutoSize = true;
            lblInvalidPass.ForeColor = Color.IndianRed;
            lblInvalidPass.Location = new Point(16, 58);
            lblInvalidPass.Name = "lblInvalidPass";
            lblInvalidPass.Size = new Size(83, 15);
            lblInvalidPass.TabIndex = 2;
            lblInvalidPass.Text = "Senha invalída";
            lblInvalidPass.Visible = false;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(12, 98);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.Size = new Size(201, 23);
            txtConfirmPass.TabIndex = 4;
            txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 32);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 195);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPass);
            Controls.Add(lblInvalidPass);
            Controls.Add(lblPassNotMacth);
            Controls.Add(btnSave);
            Controls.Add(lblConfirmPass);
            Controls.Add(lblInsertNewPass);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewPassword";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova senha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInsertNewPass;
        private Label lblConfirmPass;
        private Button btnSave;
        private Label lblPassNotMacth;
        private Label lblInvalidPass;
        private TextBox txtConfirmPass;
        private TextBox txtPassword;
    }
}