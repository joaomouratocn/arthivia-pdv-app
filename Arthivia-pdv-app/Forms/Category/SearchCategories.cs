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
        private CategoryRepositoryInterface categoryRepository;

        public SearchCategories()
        {
            InitializeComponent();
            this.categoryRepository = FakeCategoryReposityImpl.GetInstance();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            NewCategory newCategory = new NewCategory(null);
            this.Enabled = false;
            var result = newCategory.ShowDialog(this);
            this.Enabled = true;

            if (result == DialogResult.OK)
            {
                reload();
            }
        }

        private void SearchCategories_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void reload()
        {
            bsData.DataSource = categoryRepository.GetAll();
            lbCategories.DataSource = bsData;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var current = bsData.Current as Model.CategoryModel;
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
            var currentCategory = bsData.Current as Model.CategoryModel;
            if (currentCategory == null)
            {
                MessageBox.Show("Nenhuma categoria selecionada para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var formNewCategory = new NewCategory(currentCategory);
            this.Enabled = false;
            var result = formNewCategory.ShowDialog(this);
            this.Enabled = true;
            Console.WriteLine(result);

            if (result == DialogResult.OK)
            {
                reload();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
