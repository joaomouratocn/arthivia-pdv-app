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

        private readonly BindingList<Product> _products = new BindingList<Product>();

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
            // Constructor logic here, if needed
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public BindingList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Product? getById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product user)
        {
            throw new NotImplementedException();
        }
    }
}
