using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arthivia_pdv_app.Model;

namespace Arthivia_pdv_app.Repository
{
    internal interface CategoryRepositoryInterface
    {
        BindingList<CategoryModel> GetAll();
        CategoryModel? getById(int id);
        void add(CategoryModel category);
        void update(CategoryModel category);
        void delete(int id);
    }
}
