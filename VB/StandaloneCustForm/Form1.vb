Imports System
Imports System.Windows.Forms

Namespace StandaloneCustomForm
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Binds the pivot grid to data.
			Me.salesPersonTableAdapter.Fill(Me.nwindDataSet.SalesPerson)

			' Sets the style of the Customization Form and invokes it.
			pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
			pivotGridControl1.FieldsCustomization()
		End Sub

		Private Sub pivotGridControl1_ShowingCustomizationForm(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.CustomizationFormShowingEventArgs) Handles pivotGridControl1.ShowingCustomizationForm

			' Sets the control which will own the Customization Form.
			e.ParentControl = splitContainerControl1.Panel2

			' Sets the dock style applied to the Customization Form.
			e.CustomizationForm.Dock = DockStyle.Fill
		End Sub
	End Class
End Namespace
