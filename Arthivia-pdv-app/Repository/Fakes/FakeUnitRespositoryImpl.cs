using Arthivia_pdv_app.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthivia_pdv_app.Repository.Fakes
{
    internal class FakeUnitRespositoryImpl : UnitRespositoryInterface
    {
        private static FakeUnitRespositoryImpl? instance;
        private static readonly object _lock = new object();

        public static FakeUnitRespositoryImpl GetInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new FakeUnitRespositoryImpl();
                    }
                }
            }
            return instance;
        }

        private readonly BindingList<UnitModel> _units = new BindingList<UnitModel>();

        private FakeUnitRespositoryImpl()
        {
            _units.Add(new UnitModel.Builder().WithName("UN").WithEnabled(true).Build());
            _units.Add(new UnitModel.Builder().WithName("KG").WithEnabled(true).Build());
            _units.Add(new UnitModel.Builder().WithName("LT").WithEnabled(true).Build());
        }

        public void delete(int id)
        {
            var finded = GetById(id);
            if(finded != null)
            {
                var index = _units.IndexOf(finded);
                var disabledUnit = new UnitModel.Builder()
                    .WithId(finded.Id)
                    .WithName(finded.Name)
                    .WithEnabled(false)
                    .Build();
                _units[index] = disabledUnit;
            }
        }

        public BindingList<UnitModel> GetAll()
        {
            var findedUnits = _units.Where(u => u.enabled).ToList();
            return new BindingList<UnitModel>(findedUnits);
        }

        public UnitModel? GetById(int id)
        {
            var finded = _units.FirstOrDefault(u => u.Id == id);
            return finded;
        }

        public void insert(UnitModel unit)
        {
            _units.Add(unit);
        }

        public void update(UnitModel unit)
        {
            var finded = GetById(unit.Id);
            if (finded != null)
            {
                var index = _units.IndexOf(finded);
                _units[index] = unit;
            }
        }
    }
}
