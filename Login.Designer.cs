namespace Arthivia_pdv_app
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblUser = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnAcessar = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.market;
            pictureBox1.Location = new Point(40, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(40, 162);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(296, 23);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(40, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(296, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(40, 213);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Senha:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(40, 144);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(101, 15);
            lblUser.TabIndex = 0;
            lblUser.Text = "Nome de usuário:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = SystemColors.Control;
            btnAcessar.FlatStyle = FlatStyle.System;
            btnAcessar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcessar.ForeColor = Color.Black;
            btnAcessar.Location = new Point(40, 285);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(296, 23);
            btnAcessar.TabIndex = 4;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(40, 188);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 5;
            label1.Text = "Nome de usuário inválido";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(40, 257);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Senha Inválida";
            label2.Visible = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 361);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblUser);
            Controls.Add(lblPassword);
            Controls.Add(btnAcessar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(400, 400);
            MinimumSize = new Size(400, 400);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fácil-PDV";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label lblPassword;
        private Label lblUser;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnAcessar;
        private Label label1;
        private Label label2;
    }
}