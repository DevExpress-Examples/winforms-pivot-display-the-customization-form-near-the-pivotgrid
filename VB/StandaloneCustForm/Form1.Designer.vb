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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim FieldInfo1 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo2 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo3 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo4 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo5 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo6 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo7 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo8 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo9 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo10 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo11 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim FieldInfo12 As DevExpress.DataAccess.Excel.FieldInfo = New DevExpress.DataAccess.Excel.FieldInfo()
            Dim ExcelWorksheetSettings1 As DevExpress.DataAccess.Excel.ExcelWorksheetSettings = New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
            Dim ExcelSourceOptions1 As DevExpress.DataAccess.Excel.ExcelSourceOptions = New DevExpress.DataAccess.Excel.ExcelSourceOptions(ExcelWorksheetSettings1)
            Dim DataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim DataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.excelDataSource1 = New DevExpress.DataAccess.Excel.ExcelDataSource()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel1.SuspendLayout()
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'pivotGridControl1
            '
            Me.pivotGridControl1.DataSource = Me.excelDataSource1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCountry, Me.fieldProductName, Me.fieldCategoryName, Me.fieldExtendedPrice, Me.fieldSalesPerson})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(465, 358)
            Me.pivotGridControl1.TabIndex = 0
            '
            'excelDataSource1
            '
            Me.excelDataSource1.Name = "excelDataSource1"
            Me.excelDataSource1.ResultSchemaSerializable = resources.GetString("excelDataSource1.ResultSchemaSerializable")
            FieldInfo1.Name = "CategoryName"
            FieldInfo1.OriginalName = Nothing
            FieldInfo1.Type = GetType(String)
            FieldInfo2.Name = "Country"
            FieldInfo2.OriginalName = Nothing
            FieldInfo2.Type = GetType(String)
            FieldInfo3.Name = "FirstName"
            FieldInfo3.OriginalName = Nothing
            FieldInfo3.Type = GetType(String)
            FieldInfo4.Name = "LastName"
            FieldInfo4.OriginalName = Nothing
            FieldInfo4.Type = GetType(String)
            FieldInfo5.Name = "ProductName"
            FieldInfo5.OriginalName = Nothing
            FieldInfo5.Type = GetType(String)
            FieldInfo6.Name = "Sales Person"
            FieldInfo6.OriginalName = Nothing
            FieldInfo6.Type = GetType(String)
            FieldInfo7.Name = "OrderDate"
            FieldInfo7.OriginalName = Nothing
            FieldInfo7.Type = GetType(Date)
            FieldInfo8.Name = "OrderID"
            FieldInfo8.OriginalName = Nothing
            FieldInfo8.Type = GetType(Double)
            FieldInfo9.Name = "Quantity"
            FieldInfo9.OriginalName = Nothing
            FieldInfo9.Type = GetType(Double)
            FieldInfo10.Name = "Discount"
            FieldInfo10.OriginalName = Nothing
            FieldInfo10.Type = GetType(Double)
            FieldInfo11.Name = "Extended Price"
            FieldInfo11.OriginalName = Nothing
            FieldInfo11.Type = GetType(Double)
            FieldInfo12.Name = "UnitPrice"
            FieldInfo12.OriginalName = Nothing
            FieldInfo12.Type = GetType(Double)
            Me.excelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() {FieldInfo1, FieldInfo2, FieldInfo3, FieldInfo4, FieldInfo5, FieldInfo6, FieldInfo7, FieldInfo8, FieldInfo9, FieldInfo10, FieldInfo11, FieldInfo12})
            ExcelWorksheetSettings1.CellRange = Nothing
            ExcelWorksheetSettings1.WorksheetIndex = Nothing
            ExcelWorksheetSettings1.WorksheetName = "Data"
            ExcelSourceOptions1.ImportSettings = ExcelWorksheetSettings1
            Me.excelDataSource1.SourceOptions = ExcelSourceOptions1
            '
            'fieldCountry
            '
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry.AreaIndex = 0
            Me.fieldCountry.Caption = "Country"
            DataSourceColumnBinding1.ColumnName = "Country"
            Me.fieldCountry.DataBinding = DataSourceColumnBinding1
            Me.fieldCountry.Name = "fieldCountry"
            '
            'fieldProductName
            '
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            DataSourceColumnBinding2.ColumnName = "ProductName"
            Me.fieldProductName.DataBinding = DataSourceColumnBinding2
            Me.fieldProductName.Name = "fieldProductName"
            '
            'fieldCategoryName
            '
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            DataSourceColumnBinding3.ColumnName = "CategoryName"
            Me.fieldCategoryName.DataBinding = DataSourceColumnBinding3
            Me.fieldCategoryName.Name = "fieldCategoryName"
            '
            'fieldExtendedPrice
            '
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            DataSourceColumnBinding4.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = DataSourceColumnBinding4
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            '
            'fieldSalesPerson
            '
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson.AreaIndex = 1
            Me.fieldSalesPerson.Caption = "Sales Person"
            DataSourceColumnBinding5.ColumnName = "Sales Person"
            Me.fieldSalesPerson.DataBinding = DataSourceColumnBinding5
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            '
            'splitContainerControl1
            '
            Me.splitContainerControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
            Me.splitContainerControl1.Appearance.Options.UseBackColor = True
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Location = New System.Drawing.Point(0, 0)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            '
            'splitContainerControl1.Panel1
            '
            Me.splitContainerControl1.Panel1.Controls.Add(Me.pivotGridControl1)
            Me.splitContainerControl1.Panel1.Text = "Panel1"
            '
            'splitContainerControl1.Panel2
            '
            Me.splitContainerControl1.Panel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.splitContainerControl1.Panel2.Text = "Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(681, 358)
            Me.splitContainerControl1.SplitterPosition = 206
            Me.splitContainerControl1.TabIndex = 1
            Me.splitContainerControl1.Text = "splitContainerControl1"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(681, 358)
            Me.Controls.Add(Me.splitContainerControl1)
            Me.Name = "Form1"
            Me.Text = "StandaloneCustomForm"
            CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel1.ResumeLayout(False)
            CType(Me.splitContainerControl1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.splitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
		Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
		Private excelDataSource1 As DevExpress.DataAccess.Excel.ExcelDataSource
	End Class
End Namespace

