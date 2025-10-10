namespace Arthivia_pdv_app.Forms
{
    partial class SearchCategories
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
            bsData = new BindingSource(components);
            btnInsert = new Button();
            btnClose = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lbCategories = new ListBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)bsData).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsert.Location = new Point(335, 417);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(109, 23);
            btnInsert.TabIndex = 4;
            btnInsert.Text = "Nova Categoria";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(680, 417);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(109, 23);
            btnClose.TabIndex = 7;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(678, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(109, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Procurar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(647, 23);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(12, 11);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(155, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Digite oque deseja procurar:";
            // 
            // lbCategories
            // 
            lbCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCategories.DataSource = bsData;
            lbCategories.DisplayMember = "Name";
            lbCategories.FormattingEnabled = true;
            lbCategories.ItemHeight = 15;
            lbCategories.Location = new Point(12, 58);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(777, 349);
            lbCategories.TabIndex = 3;
            lbCategories.ValueMember = "id";
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.Location = new Point(450, 417);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(109, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Alterar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(565, 417);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(109, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // SearchCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lbCategories);
            Controls.Add(btnInsert);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SearchCategories";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categorias";
            WindowState = FormWindowState.Maximized;
            Load += SearchCategories_Load;
            ((System.ComponentModel.ISupportInitialize)bsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnInsert;
        private Button btnClose;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label lblSearch;
        private BindingSource bsData;
        private ListBox lbCategories;
        private Button btnUpdate;
        private Button btnDelete;
    }
}