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
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            lblUser = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnAcessar = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.market;
            pictureBox1.Location = new Point(93, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(208, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(93, 177);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(208, 23);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(93, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(208, 23);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(93, 203);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(42, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Senha:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(93, 159);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(101, 15);
            lblUser.TabIndex = 3;
            lblUser.Text = "Nome de usuário:";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnAcessar
            // 
            btnAcessar.BackColor = Color.LimeGreen;
            btnAcessar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcessar.ForeColor = Color.White;
            btnAcessar.Location = new Point(93, 250);
            btnAcessar.Name = "btnAcessar";
            btnAcessar.Size = new Size(208, 30);
            btnAcessar.TabIndex = 2;
            btnAcessar.Text = "Acessar";
            btnAcessar.UseVisualStyleBackColor = false;
            btnAcessar.Click += btnAcessar_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Firebrick;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(93, 286);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(208, 30);
            btnExit.TabIndex = 2;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 361);
            Controls.Add(lblUser);
            Controls.Add(lblPassword);
            Controls.Add(btnExit);
            Controls.Add(btnAcessar);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(430, 400);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
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
        private Button btnExit;
    }
}