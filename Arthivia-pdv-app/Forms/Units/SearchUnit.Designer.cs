namespace Arthivia_pdv_app.Forms.Units
{
    partial class SearchUnit
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
            lblSearchUnit = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            lbUnit = new ListBox();
            bsData = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsData).BeginInit();
            SuspendLayout();
            // 
            // lblSearchUnit
            // 
            lblSearchUnit.AutoSize = true;
            lblSearchUnit.Location = new Point(12, 9);
            lblSearchUnit.Name = "lblSearchUnit";
            lblSearchUnit.Size = new Size(151, 15);
            lblSearchUnit.TabIndex = 0;
            lblSearchUnit.Text = "Digite oque deseja procura:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(695, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(713, 26);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Procurar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(713, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(632, 415);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Deletar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.Location = new Point(551, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Alterar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnInsert.Location = new Point(439, 415);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(106, 23);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Nova Unidade";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // lbUnit
            // 
            lbUnit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUnit.DataSource = bsData;
            lbUnit.DisplayMember = "Name";
            lbUnit.FormattingEnabled = true;
            lbUnit.ItemHeight = 15;
            lbUnit.Location = new Point(12, 56);
            lbUnit.Name = "lbUnit";
            lbUnit.Size = new Size(776, 349);
            lbUnit.TabIndex = 7;
            lbUnit.ValueMember = "id";
            // 
            // bsData
            // 
            bsData.DataSource = typeof(Model.UnitModel);
            // 
            // SearchUnit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbUnit);
            Controls.Add(btnInsert);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearchUnit);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "SearchUnit";
            ShowIcon = false;
            Text = "Unidades de medida";
            Load += SearchUnit_Load;
            ((System.ComponentModel.ISupportInitialize)bsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSearchUnit;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private ListBox lbUnit;
        private BindingSource bsData;
    }
}