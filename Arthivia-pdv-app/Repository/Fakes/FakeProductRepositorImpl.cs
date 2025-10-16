using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arthivia_pdv_app.Model;

namespace Arthivia_pdv_app.Repository.Fakes
{
    internal class FakeProductRepositorImpl : ProductRepositoryInterface
    {
        private static FakeProductRepositorImpl? _instance;
        private static readonly object _lock = new object();

        private readonly BindingList<ProductModel> _products = new BindingList<ProductModel>();

        public static FakeProductRepositorImpl GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FakeProductRepositorImpl();
                    }
                }
            }
            return _instance;
        }

        private FakeProductRepositorImpl()
        {
            _products.Add(new ProductModel.Builder()
                .WithName("COCA COLA 2L")
                .withBarCode("7894900011515")
                .WithIsActive(true)
                .WithSalePrice(10.00m)
                .WithPurchasePrice(7.00m)
                .WithMarkupPercent(30.0m)
                .WithDescription("REFRIGERANTE COCA COLA 2L")
                .WithCategory(FakeCategoryReposityImpl.GetInstance().GetAll()[0])
                .WithUnit(FakeUnitRespositoryImpl.GetInstance().GetAll()[0])
                .Build());
        }

        public void Add(ProductModel product)
        {
            _products.Add(product);
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }

        public BindingList<ProductModel> GetAll()
        {
            var products = _products.Where(p  => p.IsActive).ToList();
            return new BindingList<ProductModel>(products);
        }

        public ProductModel? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Update(ProductModel user)
        {
            var findedProduct = GetById(user.Id);
            if (findedProduct != null)
            {
                var index = _products.IndexOf(findedProduct);
                _products[index] = user;
            }
        }
    }
}
