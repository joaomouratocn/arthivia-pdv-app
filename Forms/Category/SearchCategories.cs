using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arthivia_pdv_app.Repository;
using Arthivia_pdv_app.Repository.Fakes;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Arthivia_pdv_app.Forms
{
    public partial class SearchCategories : Form
    {
        public Main mainForm;
        private CategoryRepositoryInterface categoryRepository;

        public SearchCategories(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.categoryRepository = FakeCategoryReposityImpl.GetInstance();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (var newCategory = new NewCategory(null))
            {
                this.Enabled = false;
                var result = newCategory.ShowDialog(this);
                this.Enabled = true;

                if (result == DialogResult.OK)
                {
                    reload();
                }
            }
        }

        private void SearchCategories_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void reload()
        {
            bsData.DataSource = categoryRepository.getAll();
            lbCategories.DataSource = bsData;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var current = bsData.Current as Model.Category;
            if (current != null)
            {
                var result = MessageBox.Show(
                    $"Tem certeza que deseja excluir a categoria '{current.Name}'?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    categoryRepository.delete(current.Id);
                    this.reload();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var newCategory = new NewCategory(bsData.Current as Model.Category))
            {
                this.Enabled = false;
                var result = newCategory.ShowDialog(this);
                this.Enabled = true;
                Console.WriteLine(result);

                if (result == DialogResult.OK)
                {
                    reload();
                }
            }
        }
    }
}
