using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arthivia_pdv_app.Model;

namespace Arthivia_pdv_app.Repository
{
    internal interface UserRepositoryInterface
    {
        BindingList<User> GetAll();
        User? GetById(Guid id);
        void Add(User user);
        void Update(User user);
        void Delete(Guid id);
        public User? getById(Guid Id);
    }
}
