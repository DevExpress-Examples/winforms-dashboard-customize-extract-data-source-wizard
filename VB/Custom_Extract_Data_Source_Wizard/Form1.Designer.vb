Namespace Custom_Extract_Data_Source_Wizard
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
			Me.components = New System.ComponentModel.Container()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.btn_RunWizard = New System.Windows.Forms.Button()
			Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.panel1.SuspendLayout()
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.btn_RunWizard)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(800, 46)
			Me.panel1.TabIndex = 0
			' 
			' btn_RunWizard
			' 
			Me.btn_RunWizard.Location = New System.Drawing.Point(12, 12)
			Me.btn_RunWizard.Name = "btn_RunWizard"
			Me.btn_RunWizard.Size = New System.Drawing.Size(160, 23)
			Me.btn_RunWizard.TabIndex = 0
			Me.btn_RunWizard.Text = "Run Wizard"
			Me.btn_RunWizard.UseVisualStyleBackColor = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.btn_RunWizard.Click += new System.EventHandler(this.btn_RunWizard_Click);
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(236)))), (CInt((CByte(239)))))
			Me.dashboardViewer1.Appearance.Options.UseBackColor = True
			Me.dashboardViewer1.DashboardSource = GetType(Custom_Extract_Data_Source_Wizard.Dashboard1)
			Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer1.Location = New System.Drawing.Point(0, 46)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.Size = New System.Drawing.Size(800, 404)
			Me.dashboardViewer1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.Controls.Add(Me.dashboardViewer1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.panel1.ResumeLayout(False)
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private panel1 As System.Windows.Forms.Panel
		Private WithEvents btn_RunWizard As System.Windows.Forms.Button
		Private dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
	End Class
End Namespace

