using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arthivia_pdv_app.Model;

namespace Arthivia_pdv_app.Repository.Fakes
{
    internal class FakeCategoryReposityImpl : CategoryRepositoryInterface
    {
        private static FakeCategoryReposityImpl? _instance;
        private static readonly object _lock = new object();

        public static FakeCategoryReposityImpl GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FakeCategoryReposityImpl();
                    }
                }
            }
            return _instance;
        }

        private readonly BindingList<CategoryModel> _categories = new BindingList<CategoryModel>();

        private FakeCategoryReposityImpl()
        {
            _categories.Add(new CategoryModel.Builder().WithName("REFRIGERANTES").WithEnabled(true).Build());
            _categories.Add(new CategoryModel.Builder().WithName("CERVEJAS").WithEnabled(true).Build());
        }

        public void add(CategoryModel category)
        {
            _categories.Add(category);
        }

        public BindingList<CategoryModel> getAll()
        {
            var enableCategories = _categories.Where(c => c.enabled).ToList();

            return new BindingList<CategoryModel>(enableCategories);
        }

        public CategoryModel? getById(Guid id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            return category;
        }

        public void update(CategoryModel category)
        {
            var findedCategory = getById(category.Id);
            if (findedCategory != null)
            {
                var index = _categories.IndexOf(findedCategory);
                _categories[index] = category;
            }
        }

        public void delete(Guid id)
        {
            var category = getById(id);
            if (category != null)
            {
                var disableCategory = new CategoryModel.Builder().WithName(category.Name).WithEnabled(false).Build();
                _categories.Remove(category);
            }
        }
    }
}
