using System;
using System.Windows.Forms;

namespace StandaloneCustForm {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Binds the pivot grid to data.
            this.salesPersonTableAdapter.Fill(this.nwindDataSet.SalesPerson);

            // Sets the style of the Customization Form and invokes it.
            pivotGridControl1.OptionsCustomization.CustomizationFormStyle = 
                DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007;
            pivotGridControl1.FieldsCustomization();
        }

        private void pivotGridControl1_ShowingCustomizationForm(object sender, 
            DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs e) {

            // Sets the control which will own the Customization Form.
            e.ParentControl = splitContainerControl1.Panel2;

            // Sets the dock style applied to the Customization Form.
            e.CustomizationForm.Dock = DockStyle.Fill;
        }
    }
}
