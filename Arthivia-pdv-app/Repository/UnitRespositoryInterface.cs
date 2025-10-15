using Arthivia_pdv_app.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthivia_pdv_app.Repository
{
    internal interface UnitRespositoryInterface
    {
        BindingList<UnitModel> GetAll();
        UnitModel? GetById(Guid id);
        void insert(UnitModel unit);
        void update(UnitModel unit);
        void delete(Guid id);
    }
}
