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
        BindingList<Category> getAll();
        Category? getById(Guid id);
        void add(string name);
        void update(Category category);

        void delete(Guid id);
    }
}
