namespace Arthivia_pdv_app.Forms.User
{
    partial class SearchUsers
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
            lblNameSearch = new Label();
            txtName = new TextBox();
            lblStatus = new Label();
            cbStatus = new ComboBox();
            btnSearch = new Button();
            btnClose = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            lbUsers = new ListBox();
            bsData = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bsData).BeginInit();
            SuspendLayout();
            // 
            // lblNameSearch
            // 
            lblNameSearch.AutoSize = true;
            lblNameSearch.Location = new Point(202, 9);
            lblNameSearch.Name = "lblNameSearch";
            lblNameSearch.Size = new Size(177, 15);
            lblNameSearch.TabIndex = 2;
            lblNameSearch.Text = "Nome de quem deseja procurar:";
            // 
            // txtName
            // 
            txtName.Location = new Point(202, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(440, 23);
            txtName.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Situação";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "ATIVOS", "INATIVOS" });
            cbStatus.Location = new Point(12, 27);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(171, 23);
            cbStatus.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(658, 27);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Procurar";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(713, 415);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 8;
            btnClose.Text = "Fechar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUpdate.Location = new Point(632, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Editar";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNew.Location = new Point(494, 415);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(132, 23);
            btnNew.TabIndex = 6;
            btnNew.Text = "Novo Usuário";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lbUsers
            // 
            lbUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUsers.DataSource = bsData;
            lbUsers.DisplayMember = "Name";
            lbUsers.FormattingEnabled = true;
            lbUsers.ItemHeight = 15;
            lbUsers.Location = new Point(12, 56);
            lbUsers.Name = "lbUsers";
            lbUsers.Size = new Size(776, 349);
            lbUsers.TabIndex = 5;
            lbUsers.ValueMember = "Id";
            // 
            // bsData
            // 
            bsData.DataSource = typeof(Model.UserModel);
            // 
            // SearchUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbUsers);
            Controls.Add(btnNew);
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(btnSearch);
            Controls.Add(cbStatus);
            Controls.Add(lblStatus);
            Controls.Add(txtName);
            Controls.Add(lblNameSearch);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "SearchUsers";
            Text = "SerachUser";
            Load += SerachUser_Load;
            ((System.ComponentModel.ISupportInitialize)bsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNameSearch;
        private TextBox txtName;
        private Label lblStatus;
        private ComboBox cbStatus;
        private Button btnSearch;
        private Button btnClose;
        private Button btnUpdate;
        private Button btnNew;
        private ListBox lbUsers;
        private BindingSource bsData;
    }
}