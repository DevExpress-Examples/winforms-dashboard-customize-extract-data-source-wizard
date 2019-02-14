Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardCommon.DataSourceWizard
Imports DevExpress.DashboardWin
Imports DevExpress.DashboardWin.DataSourceWizard
Imports DevExpress.DataAccess.UI.Wizard
Imports DevExpress.XtraEditors
Imports System

Namespace Custom_Extract_Data_Source_Wizard
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btn_RunWizard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_RunWizard.Click
			Dim optionsContext As New EditExtractOptionsContext(Me.GetActiveLookAndFeel(), Me, dashboardViewer1.Dashboard.DataSources)
			optionsContext.WizardCustomization = New CustomExtractDataSourceWizardCustomizationService()
			ExtractDataSourceUIHelper.EditExtractOptions(New DashboardExtractDataSource() With {.FileName = "test.dat"}, optionsContext)
		End Sub
	End Class

	Public Class CustomExtractDataSourceWizardCustomizationService
		Implements IExtractDataSourceWizardCustomization

		Public Sub CustomizeDataSourceWizard(ByVal customization As IWizardCustomization(Of ExtractDataSourceModel)) Implements IExtractDataSourceWizardCustomization.CustomizeDataSourceWizard
			customization.RegisterPageView(Of ICreateExtractDataSourcePageView, CustomConfigureExtractDataSourcePageView)()
		End Sub

	End Class

	Public Class CustomConfigureExtractDataSourcePageView
		Inherits CreateExtractDataSourcePageView

		Public Sub New()
			MyBase.New()
			Me.checkEditExistingDataSource.Enabled = False

		End Sub

		Protected Overrides Sub OnCheckEditExistingDataSourceCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			MyBase.OnCheckEditExistingDataSourceCheckedChanged(sender, e)
			TextEditFileName.Enabled = False
		End Sub

	End Class
End Namespace