using DevExpress.DashboardCommon;
using DevExpress.DashboardCommon.DataSourceWizard;
using DevExpress.DashboardWin;
using DevExpress.DashboardWin.DataSourceWizard;
using DevExpress.DataAccess.UI.Wizard;
using DevExpress.XtraEditors;
using System;

namespace Custom_Extract_Data_Source_Wizard {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void btn_RunWizard_Click(object sender, EventArgs e) {
            EditExtractOptionsContext optionsContext = new EditExtractOptionsContext(this.GetActiveLookAndFeel(), this, dashboardViewer1.Dashboard.DataSources);
            optionsContext.WizardCustomization = new CustomExtractDataSourceWizardCustomizationService();
            ExtractDataSourceUIHelper.EditExtractOptions(new DashboardExtractDataSource() { FileName = "test.dat" }, optionsContext);
        }
    }

    public class CustomExtractDataSourceWizardCustomizationService : IExtractDataSourceWizardCustomization {
        public void CustomizeDataSourceWizard(IWizardCustomization<ExtractDataSourceModel> customization) {
            customization.RegisterPageView<ICreateExtractDataSourcePageView, CustomConfigureExtractDataSourcePageView>();
        }
    }

    public class CustomConfigureExtractDataSourcePageView : CreateExtractDataSourcePageView {
        public CustomConfigureExtractDataSourcePageView() : base() {                     
            this.checkEditExistingDataSource.Enabled = false;            
        }

        protected override void OnCheckEditExistingDataSourceCheckedChanged(object sender, EventArgs e) {
            base.OnCheckEditExistingDataSourceCheckedChanged(sender, e);
            TextEditFileName.Enabled = false;
        }
    }
}
