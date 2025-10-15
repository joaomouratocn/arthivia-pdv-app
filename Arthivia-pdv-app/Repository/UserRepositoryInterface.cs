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
        BindingList<UserModel> GetAll();
        UserModel? GetById(Guid id);
        void Add(UserModel user);
        void Update(UserModel user);
        void Delete(Guid id);
    }
}
