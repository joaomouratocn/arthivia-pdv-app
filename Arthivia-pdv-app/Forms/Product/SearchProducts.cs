using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Arthivia_pdv_app.Forms;
using Arthivia_pdv_app.Repository;
using Arthivia_pdv_app.Repository.Fakes;

namespace Arthivia_pdv_app
{
    public partial class SearchProducts : Form
    {
        private ProductRepositoryInterface userRepository = FakeProductRepositorImpl.GetInstance();
        public SearchProducts()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            using (var newProduct = new NewProduct())
            {
                this.Enabled = false;
                var result = newProduct.ShowDialog(this);
                this.Enabled = true;

                if (result == DialogResult.OK)
                {
                    reload();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //implement search function
        }

        private void reload()
        {
            bsData.DataSource = userRepository.GetAll();
            lbProducts.DataSource = bsData;
        }

        private void SearchProducts_Load(object sender, EventArgs e)
        {
            reload();
        }
    }
}
