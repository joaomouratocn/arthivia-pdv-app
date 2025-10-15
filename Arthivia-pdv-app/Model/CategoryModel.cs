using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthivia_pdv_app.Model
{
    public class CategoryModel
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Boolean enabled { get; private set; }

        private CategoryModel() { }

        public class Builder
        {
            private readonly CategoryModel _category = new CategoryModel();

            public Builder WithId(Guid id)
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
            {
                if (_category.Id == Guid.Empty)
                {
                    _category.Id = Guid.NewGuid();
                }
                if (string.IsNullOrWhiteSpace(_category.Name))
                {
                    throw new InvalidOperationException("Name cannot be null or empty.");
                }
                return _category;
            }
        }
    }
}
