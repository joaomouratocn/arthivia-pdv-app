using Arthivia_pdv_app.Repository;
using Arthivia_pdv_app.Repository.Fakes;


namespace Arthivia_pdv_app.Forms.Units
{
    public partial class SearchUnit : Form
    {
        private UnitRespositoryInterface unitRepository;

        public SearchUnit()
        {
            InitializeComponent();
            this.unitRepository = FakeUnitRespositoryImpl.GetInstance();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var formNewUnit = new NewUnit(null);
            this.Enabled = false;
            var result = formNewUnit.ShowDialog(this);
            this.Enabled = true;
            if (result == DialogResult.OK)
            {
                reload();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var formNewUnit = new NewUnit(bsData.Current as Model.UnitModel);
            this.Enabled = false;
            var result = formNewUnit.ShowDialog(this);
            this.Enabled = true;
            if (result == DialogResult.OK)
            {
                reload();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var current = bsData.Current as Model.UnitModel;
            if (current != null)
            {
                var result = MessageBox.Show(
                    $"Tem certeza que deseja excluir a unidade de medida '{current.Name}'?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    unitRepository.Delete(current.Id);
                    this.reload();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchUnit_Load(object sender, EventArgs e)
        {
            this.reload();
        }

        private void reload()
        {
            bsData.DataSource = unitRepository.GetAll();
            lbUnit.DataSource = bsData;
        }
    }
}
