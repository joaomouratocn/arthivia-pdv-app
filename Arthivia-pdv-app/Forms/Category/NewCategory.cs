using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Arthivia_pdv_app.Model;
using Arthivia_pdv_app.Repository;
using Arthivia_pdv_app.Repository.Fakes;

namespace Arthivia_pdv_app.Forms
{
    public partial class NewCategory : Form
    {
        private CategoryRepositoryInterface categoryRepository;
        private Category currentCategory;

        public NewCategory(Category current)
        {
            InitializeComponent();
            this.currentCategory = current;
            categoryRepository = FakeCategoryReposityImpl.GetInstance();

            if (currentCategory != null)
            {
                txtCategoryName.Text = currentCategory.Name;
                txtCategoryName.SelectAll();
                this.Text = "Editar Categoria";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();
            if (categoryName.Equals(""))
            {
                lblInvalidCategory.Visible = true;
                return;
            }

            if (currentCategory == null)
            {
                categoryRepository.add(categoryName);
            }
            else 
            {
                var updatedCategory = new Category.Builder().WithId(currentCategory.Id).WithName(categoryName).WithEnabled(true).Build();
                categoryRepository.update(updatedCategory);
            }
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
