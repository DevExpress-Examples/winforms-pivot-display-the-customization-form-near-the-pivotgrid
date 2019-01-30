Namespace StandaloneCustomForm
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim fieldInfo25 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo26 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo27 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo28 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo29 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo30 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo31 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo32 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo33 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo34 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo35 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo36 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings3 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions3 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings3)
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
			Me.fieldCountry1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldProductName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldCategoryName1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldExtendedPrice1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldSalesPerson1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainerControl1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.DataSource = Me.excelDataSource1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldCountry1, Me.fieldProductName1, Me.fieldCategoryName1, Me.fieldExtendedPrice1, Me.fieldSalesPerson1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.Size = New System.Drawing.Size(465, 358)
			Me.pivotGridControl1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.pivotGridControl1.ShowingCustomizationForm += new DevExpress.XtraPivotGrid.CustomizationFormShowingEventHandler(this.pivotGridControl1_ShowingCustomizationForm);
			' 
			' excelDataSource1
			' 
			Me.excelDataSource1.Name = "excelDataSource1"
			Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
			fieldInfo25.Name = "CategoryName"
			fieldInfo25.Type = GetType(String)
			fieldInfo26.Name = "Country"
			fieldInfo26.Type = GetType(String)
			fieldInfo27.Name = "FirstName"
			fieldInfo27.Type = GetType(String)
			fieldInfo28.Name = "LastName"
			fieldInfo28.Type = GetType(String)
			fieldInfo29.Name = "ProductName"
			fieldInfo29.Type = GetType(String)
			fieldInfo30.Name = "Sales Person"
			fieldInfo30.Type = GetType(String)
			fieldInfo31.Name = "OrderDate"
			fieldInfo31.Type = GetType(Date)
			fieldInfo32.Name = "OrderID"
			fieldInfo32.Type = GetType(Double)
			fieldInfo33.Name = "Quantity"
			fieldInfo33.Type = GetType(Double)
			fieldInfo34.Name = "Discount"
			fieldInfo34.Type = GetType(Double)
			fieldInfo35.Name = "Extended Price"
			fieldInfo35.Type = GetType(Double)
			fieldInfo36.Name = "UnitPrice"
			fieldInfo36.Type = GetType(Double)
			Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo25, fieldInfo26, fieldInfo27, fieldInfo28, fieldInfo29, fieldInfo30, fieldInfo31, fieldInfo32, fieldInfo33, fieldInfo34, fieldInfo35, fieldInfo36})
			excelWorksheetSettings3.CellRange = Nothing
			excelWorksheetSettings3.WorksheetName = "Data"
			excelSourceOptions3.ImportSettings = excelWorksheetSettings3
			Me.excelDataSource1.SourceOptions = excelSourceOptions3
			' 
			' fieldCountry1
			' 
			Me.fieldCountry1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCountry1.AreaIndex = 0
			Me.fieldCountry1.Caption = "Country"
			Me.fieldCountry1.FieldName = "Country"
			Me.fieldCountry1.Name = "fieldCountry1"
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName1.AreaIndex = 1
			Me.fieldProductName1.Caption = "Product Name"
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldCategoryName1
			' 
			Me.fieldCategoryName1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName1.AreaIndex = 0
			Me.fieldCategoryName1.Caption = "Category Name"
			Me.fieldCategoryName1.FieldName = "CategoryName"
			Me.fieldCategoryName1.Name = "fieldCategoryName1"
			' 
			' fieldExtendedPrice1
			' 
			Me.fieldExtendedPrice1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice1.AreaIndex = 0
			Me.fieldExtendedPrice1.Caption = "Extended Price"
			Me.fieldExtendedPrice1.FieldName = "Extended Price"
			Me.fieldExtendedPrice1.Name = "fieldExtendedPrice1"
			' 
			' fieldSalesPerson1
			' 
			Me.fieldSalesPerson1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson1.AreaIndex = 1
			Me.fieldSalesPerson1.Caption = "Sales Person"
			Me.fieldSalesPerson1.FieldName = "Sales Person"
			Me.fieldSalesPerson1.Name = "fieldSalesPerson1"
			' 
			' splitContainerControl1
			' 
			Me.splitContainerControl1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(207)))), (CInt((CByte(221)))), (CInt((CByte(238)))))
			Me.splitContainerControl1.Appearance.Options.UseBackColor = True
			Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
			Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainerControl1.Name = "splitContainerControl1"
			Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl1)
			Me.splitContainerControl1.Panel1.Text = "Panel1"
			Me.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
			Me.splitContainerControl1.Panel2.Text = "Panel2"
			Me.splitContainerControl1.Size = New System.Drawing.Size(681, 358)
			Me.splitContainerControl1.SplitterPosition = 206
			Me.splitContainerControl1.TabIndex = 1
			Me.splitContainerControl1.Text = "splitContainerControl1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(681, 358)
			Me.Controls.Add(Me.splitContainerControl1)
			Me.Name = "Form1"
			Me.Text = "StandaloneCustomForm"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.Load += new System.EventHandler(this.Form1_Load);
			DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainerControl1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldCountry1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson1 As DevExpress.XtraPivotGrid.PivotGridField
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
	End Class
End Namespace

