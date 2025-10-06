namespace Arthivia_pdv_app
{
    partial class Products
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
            label1 = new Label();
            btnNewProduct = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Produtos";
            // 
            // btnNewProduct
            // 
            btnNewProduct.Location = new Point(598, 415);
            btnNewProduct.Name = "btnNewProduct";
            btnNewProduct.Size = new Size(190, 23);
            btnNewProduct.TabIndex = 1;
            btnNewProduct.Text = "Novo produto";
            btnNewProduct.UseVisualStyleBackColor = true;
            btnNewProduct.Click += btnNewProduct_Click;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNewProduct);
            Controls.Add(label1);
            Name = "Products";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNewProduct;
    }
}