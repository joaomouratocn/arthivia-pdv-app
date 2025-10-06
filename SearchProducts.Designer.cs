namespace Arthivia_pdv_app
{
    partial class SearchProducts
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
            lblTitle = new Label();
            lblCategory = new Label();
            comboBox1 = new ComboBox();
            lblSearch = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnClose = new Button();
            btnInsert = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(16, 37, 60);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Produtos";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 60);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(66, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Categorias:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(241, 60);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(155, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Digite oque deseja procurar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 23);
            textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(679, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Procurar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(679, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsert.Location = new Point(551, 415);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(109, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Novo produto";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 107);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 302);
            dataGridView1.TabIndex = 5;
            // 
            // SearchProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnInsert);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(lblSearch);
            Controls.Add(comboBox1);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SearchProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SearchProducts";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCategory;
        private ComboBox comboBox1;
        private Label lblSearch;
        private TextBox textBox1;
        private Button btnSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnClose;
        private Button btnInsert;
        private DataGridView dataGridView1;
    }
}