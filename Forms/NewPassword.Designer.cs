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
            txtPass = new TextBox();
            txtConfirmPass = new TextBox();
            lblConfirmPass = new Label();
            btnSave = new Button();
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
            // txtPass
            // 
            txtPass.Location = new Point(12, 32);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(201, 23);
            txtPass.TabIndex = 1;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(12, 89);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(201, 23);
            txtConfirmPass.TabIndex = 3;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Location = new Point(12, 71);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(144, 15);
            lblConfirmPass.TabIndex = 2;
            lblConfirmPass.Text = "Confirme sua nova senha:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 130);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(201, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Salvar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // NewPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 173);
            Controls.Add(btnSave);
            Controls.Add(txtConfirmPass);
            Controls.Add(lblConfirmPass);
            Controls.Add(txtPass);
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
        private TextBox txtPass;
        private TextBox txtConfirmPass;
        private Label lblConfirmPass;
        private Button btnSave;
    }
}