using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arthivia_pdv_app.Model;

namespace Arthivia_pdv_app.Repository
{
    internal interface ProductRepositoryInterface
    {
        BindingList<ProductModel> GetAll();
        ProductModel? GetById(int id);
        void Add(ProductModel user);
        void Update(ProductModel user);
        void Delete(int id);
    }
}
