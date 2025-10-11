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
        BindingList<Product> GetAll();
        Product? GetById(Guid id);
        void Add(Product user);
        void Update(Product user);
        void Delete(Guid id);
        public Product? getById(Guid Id);
    }
}
