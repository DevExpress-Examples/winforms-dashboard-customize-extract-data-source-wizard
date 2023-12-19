<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/158844655/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830494)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Dashboard for WinForms - How to customize the Data Source Wizard and invoke it in the DashboardViewer

This example demonstrates how to customize Data Source Wizard pages and invoke a customized Wizard in the DashboardViewer.

The [ExtractDataSourceUIHelper.EditExtractOptions](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.ExtractDataSourceUIHelper.EditExtractOptions(DevExpress.DashboardCommon.DashboardExtractDataSource-DevExpress.DashboardWin.EditExtractOptionsContext)) static method invokes the [Data Source Wizard](https://docs.devexpress.com/Dashboard/17652/).
To customize the **Edit extract** page, the application uses the approach described in the [How to Customize Views and Presenters Corresponding to Wizard Pages](https://docs.devexpress.com/Dashboard/18293/) document.

![](https://github.com/DevExpress-Examples/how-to-customize-extractdatasource-wizard/blob/18.2.3%2B/images/Screenshot.png)

## Files to Review 

* [Form1.cs](./CS/Custom_Extract_Data_Source_Wizard/Form1.cs) (VB: [Form1.vb](./VB/Custom_Extract_Data_Source_Wizard/Form1.vb))

## Documentation

- [Data Source Wizard](http://docs.devexpress.com/Dashboard/17652)
- [How to Customize Views and Presenters Corresponding to Wizard Pages](http://docs.devexpress.com/Dashboard/18293)
- [Extract Data Source](https://docs.devexpress.com/Dashboard/115900/winforms-dashboard/winforms-designer/create-dashboards-in-the-winforms-designer/providing-data/extract-data-source)
