namespace Arthivia_pdv_app
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            msMain = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            miCalc = new ToolStripMenuItem();
            miExit = new ToolStripMenuItem();
            msSale = new ToolStripMenuItem();
            miNewSale = new ToolStripMenuItem();
            produtosToolStripMenuItem = new ToolStripMenuItem();
            miProductRegister = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            gerênciaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            mainPanel = new Panel();
            miCategories = new ToolStripMenuItem();
            miCategoryRegister = new ToolStripMenuItem();
            miUnits = new ToolStripMenuItem();
            miUnitRegister = new ToolStripMenuItem();
            miUsers = new ToolStripMenuItem();
            miUserRegister = new ToolStripMenuItem();
            msMain.SuspendLayout();
            SuspendLayout();
            // 
            // msMain
            // 
            msMain.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, msSale, produtosToolStripMenuItem, relatóriosToolStripMenuItem, gerênciaToolStripMenuItem, sobreToolStripMenuItem });
            msMain.Location = new Point(0, 0);
            msMain.Name = "msMain";
            msMain.Size = new Size(800, 24);
            msMain.TabIndex = 0;
            msMain.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miCalc, miExit });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // miCalc
            // 
            miCalc.Name = "miCalc";
            miCalc.Size = new Size(137, 22);
            miCalc.Text = "Calculadora";
            miCalc.Click += miCalc_Click;
            // 
            // miExit
            // 
            miExit.Name = "miExit";
            miExit.Size = new Size(137, 22);
            miExit.Text = "Sair";
            miExit.Click += miExit_Click;
            // 
            // msSale
            // 
            msSale.DropDownItems.AddRange(new ToolStripItem[] { miNewSale });
            msSale.Name = "msSale";
            msSale.Size = new Size(51, 20);
            msSale.Text = "&Venda";
            // 
            // miNewSale
            // 
            miNewSale.Name = "miNewSale";
            miNewSale.Size = new Size(180, 22);
            miNewSale.Text = "Nova venda";
            // 
            // produtosToolStripMenuItem
            // 
            produtosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miProductRegister });
            produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            produtosToolStripMenuItem.Size = new Size(67, 20);
            produtosToolStripMenuItem.Text = "&Produtos";
            // 
            // miProductRegister
            // 
            miProductRegister.Name = "miProductRegister";
            miProductRegister.Size = new Size(180, 22);
            miProductRegister.Text = "Cadastro";
            miProductRegister.Click += miProductRegister_Click;
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "&Relatórios";
            // 
            // gerênciaToolStripMenuItem
            // 
            gerênciaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { miCategories, miUnits, miUsers });
            gerênciaToolStripMenuItem.Name = "gerênciaToolStripMenuItem";
            gerênciaToolStripMenuItem.Size = new Size(65, 20);
            gerênciaToolStripMenuItem.Text = "&Gerência";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "&Sobre";
            // 
            // mainPanel
            // 
            mainPanel.BackgroundImageLayout = ImageLayout.Stretch;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 24);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 426);
            mainPanel.TabIndex = 1;
            // 
            // miCategories
            // 
            miCategories.DropDownItems.AddRange(new ToolStripItem[] { miCategoryRegister });
            miCategories.Name = "miCategories";
            miCategories.Size = new Size(180, 22);
            miCategories.Text = "Categorias";
            // 
            // miCategoryRegister
            // 
            miCategoryRegister.Name = "miCategoryRegister";
            miCategoryRegister.Size = new Size(180, 22);
            miCategoryRegister.Text = "Cadastro";
            miCategoryRegister.Click += miCategoryRegister_Click;
            // 
            // miUnits
            // 
            miUnits.DropDownItems.AddRange(new ToolStripItem[] { miUnitRegister });
            miUnits.Name = "miUnits";
            miUnits.Size = new Size(180, 22);
            miUnits.Text = "Unidades";
            // 
            // miUnitRegister
            // 
            miUnitRegister.Name = "miUnitRegister";
            miUnitRegister.Size = new Size(180, 22);
            miUnitRegister.Text = "Cadastro";
            // 
            // miUsers
            // 
            miUsers.DropDownItems.AddRange(new ToolStripItem[] { miUserRegister });
            miUsers.Name = "miUsers";
            miUsers.Size = new Size(180, 22);
            miUsers.Text = "Usuários";
            // 
            // miUserRegister
            // 
            miUserRegister.Name = "miUserRegister";
            miUserRegister.Size = new Size(121, 22);
            miUserRegister.Text = "Cadastro";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(msMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msMain;
            MinimumSize = new Size(816, 489);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fácil-PDV";
            WindowState = FormWindowState.Maximized;
            msMain.ResumeLayout(false);
            msMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMain;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem miCalc;
        private ToolStripMenuItem miExit;
        private ToolStripMenuItem msSale;
        private ToolStripMenuItem miNewSale;
        private ToolStripMenuItem produtosToolStripMenuItem;
        private ToolStripMenuItem miProductRegister;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem gerênciaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private Panel mainPanel;
        private ToolStripMenuItem miCategories;
        private ToolStripMenuItem miCategoryRegister;
        private ToolStripMenuItem miUnits;
        private ToolStripMenuItem miUnitRegister;
        private ToolStripMenuItem miUsers;
        private ToolStripMenuItem miUserRegister;
    }
}
