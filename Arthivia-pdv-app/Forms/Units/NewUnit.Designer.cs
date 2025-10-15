namespace Arthivia_pdv_app.Forms.Units
{
    partial class NewUnit
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
            lblNewUnit = new Label();
            txtNewUnit = new TextBox();
            lblInvalidUnitName = new Label();
            btnInsert = new Button();
            SuspendLayout();
            // 
            // lblNewUnit
            // 
            lblNewUnit.AutoSize = true;
            lblNewUnit.Location = new Point(12, 9);
            lblNewUnit.Name = "lblNewUnit";
            lblNewUnit.Size = new Size(82, 15);
            lblNewUnit.TabIndex = 0;
            lblNewUnit.Text = "Insira o nome:";
            // 
            // txtNewUnit
            // 
            txtNewUnit.Location = new Point(12, 27);
            txtNewUnit.Name = "txtNewUnit";
            txtNewUnit.Size = new Size(214, 23);
            txtNewUnit.TabIndex = 1;
            // 
            // lblInvalidUnitName
            // 
            lblInvalidUnitName.AutoSize = true;
            lblInvalidUnitName.ForeColor = Color.IndianRed;
            lblInvalidUnitName.Location = new Point(12, 53);
            lblInvalidUnitName.Name = "lblInvalidUnitName";
            lblInvalidUnitName.Size = new Size(95, 15);
            lblInvalidUnitName.TabIndex = 2;
            lblInvalidUnitName.Text = "Unidade invalída";
            lblInvalidUnitName.Visible = false;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(12, 80);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(214, 23);
            btnInsert.TabIndex = 3;
            btnInsert.Text = "Salvar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // NewUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 118);
            Controls.Add(btnInsert);
            Controls.Add(lblInvalidUnitName);
            Controls.Add(txtNewUnit);
            Controls.Add(lblNewUnit);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(261, 157);
            MinimumSize = new Size(261, 157);
            Name = "NewUnit";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nova Unidade";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNewUnit;
        private TextBox txtNewUnit;
        private Label lblInvalidUnitName;
        private Button btnInsert;
    }
}