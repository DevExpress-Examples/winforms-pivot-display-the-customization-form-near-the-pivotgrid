using System;
using System.Windows.Forms;

namespace StandaloneCustomForm
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            excelDataSource1.FileName = "SalesPerson.xlsx";
            excelDataSource1.Fill();

            // Set the Customization Form style and show the form.
            pivotGridControl1.OptionsCustomization.CustomizationFormStyle = 
                DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            pivotGridControl1.FieldsCustomization();
        }

        private void pivotGridControl1_ShowingCustomizationForm(object sender, 
            DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs e) {
            // Set the control that owns the Customization Form.
            e.ParentControl = splitContainerControl1.Panel2;

            e.CustomizationForm.Dock = DockStyle.Fill;
        }
    }
}
