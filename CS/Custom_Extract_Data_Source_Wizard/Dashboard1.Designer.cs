namespace Custom_Extract_Data_Source_Wizard
{
    partial class Dashboard1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard1));
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo1 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo2 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo3 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo4 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo5 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo6 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo7 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo8 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.FieldInfo fieldInfo9 = new DevExpress.DataAccess.Excel.FieldInfo();
            DevExpress.DataAccess.Excel.ExcelWorksheetSettings excelWorksheetSettings1 = new DevExpress.DataAccess.Excel.ExcelWorksheetSettings();
            DevExpress.DataAccess.Excel.ExcelSourceOptions excelSourceOptions1 = new DevExpress.DataAccess.Excel.ExcelSourceOptions(excelWorksheetSettings1);
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ValueMap valueMap1 = new DevExpress.DashboardCommon.ValueMap();
            DevExpress.DashboardCommon.UniformScale uniformScale1 = new DevExpress.DashboardCommon.UniformScale();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
            this.dashboardExcelDataSource1 = new DevExpress.DashboardCommon.DashboardExcelDataSource();
            this.choroplethMapDashboardItem1 = new DevExpress.DashboardCommon.ChoroplethMapDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExcelDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choroplethMapDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pivotDashboardItem1
            // 
            dimension1.DataMember = "State";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension1});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            dimension2.DataMember = "Category";
            dimension3.DataMember = "Product";
            measure1.DataMember = "RevenueQTD (Sum)";
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension1, "DataItem2");
            this.pivotDashboardItem1.DataItemRepository.Add(measure1, "DataItem3");
            this.pivotDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            this.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact;
            this.pivotDashboardItem1.Name = "Pivot 1";
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2,
            dimension3});
            this.pivotDashboardItem1.ShowCaption = true;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure1});
            // 
            // dashboardExcelDataSource1
            // 
            this.dashboardExcelDataSource1.ComponentName = "dashboardExcelDataSource1";
            this.dashboardExcelDataSource1.FileName = "Sales.xlsx";
            this.dashboardExcelDataSource1.Name = "Excel Data Source 1";
            this.dashboardExcelDataSource1.ResultSchemaSerializable = resources.GetString("dashboardExcelDataSource1.ResultSchemaSerializable");
            fieldInfo1.Name = "Category";
            fieldInfo1.Type = typeof(string);
            fieldInfo2.Name = "Product";
            fieldInfo2.Type = typeof(string);
            fieldInfo3.Name = "State";
            fieldInfo3.Type = typeof(string);
            fieldInfo4.Name = "UnitsSoldYTD (Sum)";
            fieldInfo4.Type = typeof(double);
            fieldInfo5.Name = "UnitsSoldYTDTarget (Sum)";
            fieldInfo5.Type = typeof(double);
            fieldInfo6.Name = "RevenueQTD (Sum)";
            fieldInfo6.Type = typeof(double);
            fieldInfo7.Name = "RevenueQTDTarget (Sum)";
            fieldInfo7.Type = typeof(double);
            fieldInfo8.Name = "RevenueYTD (Sum)";
            fieldInfo8.Type = typeof(double);
            fieldInfo9.Name = "RevenueYTDTarget (Sum)";
            fieldInfo9.Type = typeof(double);
            this.dashboardExcelDataSource1.Schema.AddRange(new DevExpress.DataAccess.Excel.FieldInfo[] {
            fieldInfo1,
            fieldInfo2,
            fieldInfo3,
            fieldInfo4,
            fieldInfo5,
            fieldInfo6,
            fieldInfo7,
            fieldInfo8,
            fieldInfo9});
            excelWorksheetSettings1.CellRange = null;
            excelWorksheetSettings1.WorksheetName = "Bike Data";
            excelSourceOptions1.ImportSettings = excelWorksheetSettings1;
            this.dashboardExcelDataSource1.SourceOptions = excelSourceOptions1;
            // 
            // choroplethMapDashboardItem1
            // 
            this.choroplethMapDashboardItem1.Area = DevExpress.DashboardCommon.ShapefileArea.USA;
            dimension4.DataMember = "State";
            this.choroplethMapDashboardItem1.AttributeDimension = dimension4;
            this.choroplethMapDashboardItem1.AttributeName = "NAME";
            this.choroplethMapDashboardItem1.ComponentName = "choroplethMapDashboardItem1";
            measure2.DataMember = "RevenueQTD (Sum)";
            this.choroplethMapDashboardItem1.DataItemRepository.Clear();
            this.choroplethMapDashboardItem1.DataItemRepository.Add(measure2, "DataItem2");
            this.choroplethMapDashboardItem1.DataItemRepository.Add(dimension4, "DataItem0");
            this.choroplethMapDashboardItem1.DataSource = this.dashboardExcelDataSource1;
            this.choroplethMapDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.choroplethMapDashboardItem1.InteractivityOptions.MasterFilterMode = DevExpress.DashboardCommon.DashboardItemMasterFilterMode.Multiple;
            valueMap1.Scale = uniformScale1;
            valueMap1.AddDataItem("Value", measure2);
            this.choroplethMapDashboardItem1.Maps.AddRange(new DevExpress.DashboardCommon.ChoroplethMap[] {
            valueMap1});
            this.choroplethMapDashboardItem1.Name = "Map 1";
            this.choroplethMapDashboardItem1.ShowCaption = true;
            this.choroplethMapDashboardItem1.Viewport.BottomLatitude = 29.402150548555603D;
            this.choroplethMapDashboardItem1.Viewport.CenterPointLatitude = 39.071612840045134D;
            this.choroplethMapDashboardItem1.Viewport.CenterPointLongitude = -76.323994259210693D;
            this.choroplethMapDashboardItem1.Viewport.CreateViewerPaddings = false;
            this.choroplethMapDashboardItem1.Viewport.LeftLongitude = -85.207156062135525D;
            this.choroplethMapDashboardItem1.Viewport.RightLongitude = -67.440832456285847D;
            this.choroplethMapDashboardItem1.Viewport.TopLatitude = 47.578026190883833D;
            // 
            // Dashboard1
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.IDashboardDataSource[] {
            this.dashboardExcelDataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.pivotDashboardItem1,
            this.choroplethMapDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem1.Weight = 58.307210031347964D;
            dashboardLayoutItem2.DashboardItem = this.choroplethMapDashboardItem1;
            dashboardLayoutItem2.Weight = 41.692789968652036D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup1.DashboardItem = null;
            dashboardLayoutGroup1.Weight = 100D;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboardExcelDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choroplethMapDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.DashboardCommon.DashboardExcelDataSource dashboardExcelDataSource1;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
        private DevExpress.DashboardCommon.ChoroplethMapDashboardItem choroplethMapDashboardItem1;
    }
}
