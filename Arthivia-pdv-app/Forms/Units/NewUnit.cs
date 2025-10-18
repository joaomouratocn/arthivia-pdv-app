using Arthivia_pdv_app.Model;
using Arthivia_pdv_app.Repository;
using Arthivia_pdv_app.Repository.Fakes;
using Arthivia_pdv_app.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arthivia_pdv_app.Forms.Units
{
    public partial class NewUnit : Form
    {
        private UnitModel? unit;
        private UnitRespositoryInterface unitRespository;

        public NewUnit(UnitModel? unit)
        {
            InitializeComponent();
            this.unitRespository = FakeUnitRespositoryImpl.GetInstance();
            this.unit = unit;

            if (this.unit != null)
            {
                this.Text = "Editar Unidade";
                txtNewUnit.Text = this.unit.Name;
                txtNewUnit.SelectAll();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string newName = txtNewUnit.Text.Trim();
            if (newName.Equals(""))
            {
                lblInvalidUnitName.Visible = true;
                return;
            }

            var normalizedText = Util.NormalizeText(newName);
            if (unit == null)
            {
                var newUnit = new UnitModel.Builder().WithName(normalizedText).WithEnabled(true).Build();
                unitRespository.Add(newUnit);
            }
            else
            {
                var updateUnit = new UnitModel.Builder().WithId(unit.Id).WithName(normalizedText).WithEnabled(true).Build();
                unitRespository.Update(updateUnit);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
