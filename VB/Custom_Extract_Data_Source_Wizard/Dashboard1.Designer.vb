Namespace Custom_Extract_Data_Source_Wizard
	Partial Public Class Dashboard1
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Dashboard1))
			Dim fieldInfo1 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo2 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo3 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo4 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo5 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo6 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo7 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo8 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim fieldInfo9 As New DevExpress.DataAccess.Excel.FieldInfo()
			Dim excelWorksheetSettings1 As New DevExpress.DataAccess.Excel.ExcelWorksheetSettings()
			Dim excelSourceOptions1 As New DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1)
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim valueMap1 As New DevExpress.DashboardCommon.ValueMap()
			Dim uniformScale1 As New DevExpress.DashboardCommon.UniformScale()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
			Me.dashboardExcelDataSource1 = New DevExpress.DashboardCommon.DashboardExcelDataSource()
			Me.choroplethMapDashboardItem1 = New DevExpress.DashboardCommon.ChoroplethMapDashboardItem()
			DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.choroplethMapDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' pivotDashboardItem1
			' 
			dimension1.DataMember = "State"
			Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension1})
			Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
			dimension2.DataMember = "Category"
			dimension3.DataMember = "Product"
			measure1.DataMember = "RevenueQTD (Sum)"
			Me.pivotDashboardItem1.DataItemRepository.Clear()
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem2")
			Me.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem3")
			Me.pivotDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
			Me.pivotDashboardItem1.Name = "Pivot 1"
			Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2, dimension3})
			Me.pivotDashboardItem1.ShowCaption = True
			Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure1})
			' 
			' dashboardExcelDataSource1
			' 
			Me.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1"
			Me.dashboardExcelDataSource1.FileName = "Sales.xlsx"
			Me.dashboardExcelDataSource1.Name = "Excel Data Source 1"
			Me.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable")
			fieldInfo1.Name = "Category"
			fieldInfo1.Type = GetType(String)
			fieldInfo2.Name = "Product"
			fieldInfo2.Type = GetType(String)
			fieldInfo3.Name = "State"
			fieldInfo3.Type = GetType(String)
			fieldInfo4.Name = "UnitsSoldYTD (Sum)"
			fieldInfo4.Type = GetType(Double)
			fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)"
			fieldInfo5.Type = GetType(Double)
			fieldInfo6.Name = "RevenueQTD (Sum)"
			fieldInfo6.Type = GetType(Double)
			fieldInfo7.Name = "RevenueQTDTarget (Sum)"
			fieldInfo7.Type = GetType(Double)
			fieldInfo8.Name = "RevenueYTD (Sum)"
			fieldInfo8.Type = GetType(Double)
			fieldInfo9.Name = "RevenueYTDTarget (Sum)"
			fieldInfo9.Type = GetType(Double)
			Me.dashboardExcelDataSource1.Schema.AddRange(New DevExpress.DataAccess.Excel.FieldInfo() { fieldInfo1, fieldInfo2, fieldInfo3, fieldInfo4, fieldInfo5, fieldInfo6, fieldInfo7, fieldInfo8, fieldInfo9})
			excelWorksheetSettings1.CellRange = Nothing
			excelWorksheetSettings1.WorksheetName = "Bike Data"
			excelSourceOptions1.ImportSettings = excelWorksheetSettings1
			Me.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1
			' 
			' choroplethMapDashboardItem1
			' 
			Me.choroplethMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.USA
			dimension4.DataMember = "State"
			Me.choroplethMapDashboardItem1.AttributeDimension = dimension4
			Me.choroplethMapDashboardItem1.AttributeName = "NAME"
			Me.choroplethMapDashboardItem1.ComponentName = "choroplethMapDashboardItem1"
			measure2.DataMember = "RevenueQTD (Sum)"
			Me.choroplethMapDashboardItem1.DataItemRepository.Clear()
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(measure2, "DataItem2")
			Me.choroplethMapDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0")
			Me.choroplethMapDashboardItem1.DataSource = Me.dashboardExcelDataSource1
			Me.choroplethMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.choroplethMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple
			valueMap1.Scale = uniformScale1
			valueMap1.AddDataItem("Value", measure2)
			Me.choroplethMapDashboardItem1.Maps.AddRange(New DevExpress.DashboardCommon.ChoroplethMap() { valueMap1})
			Me.choroplethMapDashboardItem1.Name = "Map 1"
			Me.choroplethMapDashboardItem1.ShowCaption = True
			Me.choroplethMapDashboardItem1.Viewport.BottomLatitude = 29.402150548555603R
			Me.choroplethMapDashboardItem1.Viewport.CenterPointLatitude = 39.071612840045134R
			Me.choroplethMapDashboardItem1.Viewport.CenterPointLongitude = -76.323994259210693R
			Me.choroplethMapDashboardItem1.Viewport.CreateViewerPaddings = False
			Me.choroplethMapDashboardItem1.Viewport.LeftLongitude = -85.207156062135525R
			Me.choroplethMapDashboardItem1.Viewport.RightLongitude = -67.440832456285847R
			Me.choroplethMapDashboardItem1.Viewport.TopLatitude = 47.578026190883833R
			' 
			' Dashboard1
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardExcelDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.pivotDashboardItem1, Me.choroplethMapDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.pivotDashboardItem1
			dashboardLayoutItem1.Weight = 58.307210031347964R
			dashboardLayoutItem2.DashboardItem = Me.choroplethMapDashboardItem1
			dashboardLayoutItem2.Weight = 41.692789968652036R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup1.DashboardItem = Nothing
			dashboardLayoutGroup1.Weight = 100R
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Dashboard"
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardExcelDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.choroplethMapDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private dashboardExcelDataSource1 As DevExpress.DashboardCommon.DashboardExcelDataSource
		Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
		Private choroplethMapDashboardItem1 As DevExpress.DashboardCommon.ChoroplethMapDashboardItem
	End Class
End Namespace
