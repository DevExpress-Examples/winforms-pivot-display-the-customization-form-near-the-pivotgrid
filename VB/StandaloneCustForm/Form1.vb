Imports System
Imports System.Windows.Forms

Namespace StandaloneCustomForm
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			excelDataSource1.FileName = "SalesPerson.xlsx"
			excelDataSource1.Fill()

			' Set the Customization Form style and show the form.
			pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
			pivotGridControl1.FieldsCustomization()
		End Sub

		Private Sub pivotGridControl1_ShowingCustomizationForm(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs) Handles pivotGridControl1.ShowingCustomizationForm
			' Set the control that owns the Customization Form.
			e.ParentControl = splitContainerControl1.Panel2

			e.CustomizationForm.Dock = DockStyle.Fill
		End Sub
	End Class
End Namespace
