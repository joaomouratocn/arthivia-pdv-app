using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthivia_pdv_app.Model
{
    public class CategoryModel
    {
        public int Id { get; private set; } = 0;
        public string Name { get; private set; }

        public Boolean enabled { get; private set; }

        private CategoryModel() { }

        public class Builder
        {
            private readonly CategoryModel _category = new CategoryModel();

            public Builder WithId(int id)
            {
                _category.Id = id;
                return this;
            }

            public Builder WithName(string name)
            {
                _category.Name = name;
                return this;
            }

            public Builder WithEnabled(Boolean enabled)
            {
                _category.enabled = enabled;
                return this;
            }

            public CategoryModel Build()
            {return _category;}
        }
    }
}
