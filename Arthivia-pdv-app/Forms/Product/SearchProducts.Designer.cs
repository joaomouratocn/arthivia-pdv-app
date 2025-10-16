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
            components = new System.ComponentModel.Container();
            lblCategory = new Label();
            comboBox1 = new ComboBox();
            lblSearch = new Label();
            textBox1 = new TextBox();
            btnSearch = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            btnAlter = new Button();
            btnDeletar = new Button();
            dgvProducts = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            bsData = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsData).BeginInit();
            SuspendLayout();
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(10, 9);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(66, 15);
            lblCategory.TabIndex = 0;
            lblCategory.Text = "Categorias:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(213, 23);
            comboBox1.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(239, 9);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(155, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Digite oque deseja procurar:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(239, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 23);
            textBox1.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(677, 27);
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
            btnClose.TabIndex = 9;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsert.Location = new Point(334, 415);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(109, 23);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Novo produto";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnAlter
            // 
            btnAlter.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAlter.Location = new Point(449, 415);
            btnAlter.Name = "btnAlter";
            btnAlter.Size = new Size(109, 23);
            btnAlter.TabIndex = 7;
            btnAlter.Text = "Alterar";
            btnAlter.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDeletar.Location = new Point(564, 415);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(109, 23);
            btnDeletar.TabIndex = 8;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoGenerateColumns = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn4 });
            dgvProducts.DataSource = bsData;
            dgvProducts.Location = new Point(10, 56);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(778, 353);
            dgvProducts.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            dataGridViewTextBoxColumn1.HeaderText = "Nome";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "BarCode";
            dataGridViewTextBoxColumn2.HeaderText = "Cod. Barras";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "SalePrice";
            dataGridViewTextBoxColumn3.HeaderText = "Preço Venda";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "UnitName";
            dataGridViewTextBoxColumn5.HeaderText = "Unidade";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "CategoryName";
            dataGridViewTextBoxColumn6.HeaderText = "Categoria";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "description";
            dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bsData
            // 
            bsData.DataSource = typeof(Model.ProductModel);
            // 
            // SearchProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(btnDeletar);
            Controls.Add(btnAlter);
            Controls.Add(btnInsert);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(textBox1);
            Controls.Add(lblSearch);
            Controls.Add(comboBox1);
            Controls.Add(lblCategory);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SearchProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produtos";
            WindowState = FormWindowState.Maximized;
            Load += SearchProducts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCategory;
        private ComboBox comboBox1;
        private Label lblSearch;
        private TextBox textBox1;
        private Button btnSearch;
        private Button btnClose;
        private Button btnInsert;
        private Button btnAlter;
        private Button btnDeletar;
        private DataGridView dgvProducts;
        private BindingSource bsData;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn barCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}