namespace Arthivia_pdv_app
{
    partial class NewProduct
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
            txtName = new TextBox();
            lblName = new Label();
            txtBarCode = new TextBox();
            lblBarCode = new Label();
            lblCategories = new Label();
            lblUnit = new Label();
            cbCategories = new ComboBox();
            cbUnit = new ComboBox();
            txtConstPrice = new TextBox();
            lblConstPrice = new Label();
            txtMarkup = new TextBox();
            lblSalePrice = new Label();
            txtSalePrice = new TextBox();
            lblMarkup = new Label();
            cbEnable = new CheckBox();
            label6 = new Label();
            textBox6 = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(17, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(443, 23);
            txtName.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nome:";
            // 
            // txtBarCode
            // 
            txtBarCode.Location = new Point(17, 71);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(550, 23);
            txtBarCode.TabIndex = 4;
            // 
            // lblBarCode
            // 
            lblBarCode.AutoSize = true;
            lblBarCode.Location = new Point(17, 53);
            lblBarCode.Name = "lblBarCode";
            lblBarCode.Size = new Size(100, 15);
            lblBarCode.TabIndex = 3;
            lblBarCode.Text = "Código de Barras:";
            // 
            // lblCategories
            // 
            lblCategories.AutoSize = true;
            lblCategories.Location = new Point(17, 97);
            lblCategories.Name = "lblCategories";
            lblCategories.Size = new Size(61, 15);
            lblCategories.TabIndex = 5;
            lblCategories.Text = "Categoria:";
            // 
            // lblUnit
            // 
            lblUnit.AutoSize = true;
            lblUnit.Location = new Point(309, 97);
            lblUnit.Name = "lblUnit";
            lblUnit.Size = new Size(113, 15);
            lblUnit.TabIndex = 7;
            lblUnit.Text = "Unidade de medida:";
            // 
            // cbCategories
            // 
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(17, 115);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(258, 23);
            cbCategories.TabIndex = 6;
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(309, 115);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(258, 23);
            cbUnit.TabIndex = 8;
            // 
            // txtConstPrice
            // 
            txtConstPrice.Location = new Point(17, 159);
            txtConstPrice.Name = "txtConstPrice";
            txtConstPrice.Size = new Size(158, 23);
            txtConstPrice.TabIndex = 10;
            // 
            // lblConstPrice
            // 
            lblConstPrice.AutoSize = true;
            lblConstPrice.Location = new Point(17, 141);
            lblConstPrice.Name = "lblConstPrice";
            lblConstPrice.Size = new Size(100, 15);
            lblConstPrice.TabIndex = 9;
            lblConstPrice.Text = "Preço de compra:";
            // 
            // txtMarkup
            // 
            txtMarkup.Location = new Point(409, 159);
            txtMarkup.Name = "txtMarkup";
            txtMarkup.Size = new Size(158, 23);
            txtMarkup.TabIndex = 14;
            // 
            // lblSalePrice
            // 
            lblSalePrice.AutoSize = true;
            lblSalePrice.Location = new Point(216, 141);
            lblSalePrice.Name = "lblSalePrice";
            lblSalePrice.Size = new Size(91, 15);
            lblSalePrice.TabIndex = 11;
            lblSalePrice.Text = "Preço de venda:";
            // 
            // txtSalePrice
            // 
            txtSalePrice.Location = new Point(216, 159);
            txtSalePrice.Name = "txtSalePrice";
            txtSalePrice.Size = new Size(158, 23);
            txtSalePrice.TabIndex = 12;
            // 
            // lblMarkup
            // 
            lblMarkup.AutoSize = true;
            lblMarkup.Location = new Point(409, 141);
            lblMarkup.Name = "lblMarkup";
            lblMarkup.Size = new Size(51, 15);
            lblMarkup.TabIndex = 13;
            lblMarkup.Text = "Markup:";
            // 
            // cbEnable
            // 
            cbEnable.AutoSize = true;
            cbEnable.Checked = true;
            cbEnable.CheckState = CheckState.Checked;
            cbEnable.Location = new Point(484, 31);
            cbEnable.Name = "cbEnable";
            cbEnable.Size = new Size(54, 19);
            cbEnable.TabIndex = 2;
            cbEnable.Text = "Ativo";
            cbEnable.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 194);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 15;
            label6.Text = "Código de Barras:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(17, 212);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(550, 156);
            textBox6.TabIndex = 16;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(492, 374);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(409, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // RegisterProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 411);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(cbEnable);
            Controls.Add(lblMarkup);
            Controls.Add(txtSalePrice);
            Controls.Add(txtMarkup);
            Controls.Add(lblSalePrice);
            Controls.Add(txtConstPrice);
            Controls.Add(lblConstPrice);
            Controls.Add(cbUnit);
            Controls.Add(cbCategories);
            Controls.Add(lblUnit);
            Controls.Add(lblCategories);
            Controls.Add(txtBarCode);
            Controls.Add(lblBarCode);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(600, 450);
            MinimumSize = new Size(600, 450);
            Name = "RegisterProduct";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastrar Produto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtName;
        private Label lblName;
        private TextBox txtBarCode;
        private Label lblBarCode;
        private Label lblCategories;
        private Label lblUnit;
        private ComboBox cbCategories;
        private ComboBox cbUnit;
        private TextBox txtConstPrice;
        private Label lblConstPrice;
        private TextBox txtMarkup;
        private Label lblSalePrice;
        private TextBox txtSalePrice;
        private Label lblMarkup;
        private CheckBox cbEnable;
        private Label label6;
        private TextBox textBox6;
        private Button btnCancel;
        private Button btnSave;
    }
}