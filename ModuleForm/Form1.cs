using Data;
using System.Linq;

namespace ModuleForm
{
    public partial class Form1 : Form
    {

        private List<Medicine> Medicines { get; set; }

        public FunContext context { get; set; }
        public Form1()
        {
            context = new FunContext();
            InitializeComponent();
            LoadForm();

            bool isInitialRun = false;
            if (isInitialRun)
            {
                new MockData(context);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnGetMedicine_Click(object sender, EventArgs e)
        {
        }

        private void LoadForm()
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = context.Medicines.ToList();

            cbMedicines.DataSource= bindingSource;
            cbMedicines.DisplayMember = "Name";
            cbMedicines.ValueMember = "Id";
            cbMedicines.SelectedIndex = 0;
        }
    }
}