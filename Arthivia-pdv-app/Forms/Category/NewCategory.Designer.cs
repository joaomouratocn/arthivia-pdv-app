namespace Arthivia_pdv_app.Forms
{
    partial class NewCategory
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
            lblCategoryName = new Label();
            btnRegister = new Button();
            txtCategoryName = new TextBox();
            lblInvalidCategory = new Label();
            SuspendLayout();
            // 
            // lblCategoryName
            // 
            lblCategoryName.AutoSize = true;
            lblCategoryName.Location = new Point(12, 7);
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Size = new Size(111, 15);
            lblCategoryName.TabIndex = 0;
            lblCategoryName.Text = "Nome da categoria:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 79);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(275, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(12, 25);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(275, 23);
            txtCategoryName.TabIndex = 1;
            // 
            // lblInvalidCategory
            // 
            lblInvalidCategory.AutoSize = true;
            lblInvalidCategory.ForeColor = Color.IndianRed;
            lblInvalidCategory.Location = new Point(16, 51);
            lblInvalidCategory.Name = "lblInvalidCategory";
            lblInvalidCategory.Size = new Size(85, 15);
            lblInvalidCategory.TabIndex = 2;
            lblInvalidCategory.Text = "Nome invalído";
            lblInvalidCategory.Visible = false;
            // 
            // NewCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 120);
            Controls.Add(lblInvalidCategory);
            Controls.Add(txtCategoryName);
            Controls.Add(btnRegister);
            Controls.Add(lblCategoryName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "NewCategory";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Categoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCategoryName;
        private Button btnRegister;
        private TextBox txtCategoryName;
        private Label lblInvalidCategory;
    }
}