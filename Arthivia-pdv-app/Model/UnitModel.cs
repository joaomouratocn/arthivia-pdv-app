using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthivia_pdv_app.Model
{
    public class UnitModel
    {
        public Guid Id { get;  private set; }
        public string Name { get;  private set; }
        public bool enabled { get;  private set; }

        private UnitModel() { }

        public class Builder
        {
            private readonly UnitModel _unit = new UnitModel();
            public Builder WithId(Guid id)
            {
                _unit.Id = id;
                return this;
            }
            public Builder WithName(string name)
            {
                _unit.Name = name;
                return this;
            }
            public Builder WithEnabled(bool enabled)
            {
                _unit.enabled = enabled;
                return this;
            }
            public UnitModel Build()
            {
                if (_unit.Id == Guid.Empty)
                {
                    _unit.Id = Guid.NewGuid();
                }
                if (string.IsNullOrWhiteSpace(_unit.Name))
                {
                    throw new InvalidOperationException("Name cannot be null or empty.");
                }
                return _unit;
            }
        }
    }
}
