<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PA_HESAP_FRM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PA_HESAP_FRM))
        Me.START_DATE = New System.Windows.Forms.DateTimePicker()
        Me.END_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.BTN_PRENT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        Me.CH_PA = New System.Windows.Forms.CheckBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'START_DATE
        '
        Me.START_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.START_DATE.Location = New System.Drawing.Point(131, 19)
        Me.START_DATE.Name = "START_DATE"
        Me.START_DATE.Size = New System.Drawing.Size(162, 29)
        Me.START_DATE.TabIndex = 0
        '
        'END_DATE
        '
        Me.END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.END_DATE.Location = New System.Drawing.Point(454, 19)
        Me.END_DATE.Name = "END_DATE"
        Me.END_DATE.Size = New System.Drawing.Size(172, 29)
        Me.END_DATE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "بداية الفترة :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(360, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "نهاية الفترة :"
        '
        'TXT_NAME
        '
        Me.TXT_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_NAME.DataSource = Me.BindingSource1
        Me.TXT_NAME.DisplayMember = "PA_NAME"
        Me.TXT_NAME.FormattingEnabled = True
        Me.TXT_NAME.Location = New System.Drawing.Point(141, 66)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(376, 29)
        Me.TXT_NAME.TabIndex = 6
        Me.TXT_NAME.ValueMember = "PA_NAME"
        '
        'BindingSource1
        '
        Me.BindingSource1.AllowNew = True
        Me.BindingSource1.DataMember = "PATIENT"
        Me.BindingSource1.DataSource = Me.PATIENTDATA
        Me.BindingSource1.Filter = "STAT=TRUE"
        '
        'PATIENTDATA
        '
        Me.PATIENTDATA.DataSetName = "PATIENTDATA"
        Me.PATIENTDATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXT_CODE
        '
        Me.TXT_CODE.Location = New System.Drawing.Point(526, 66)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(100, 29)
        Me.TXT_CODE.TabIndex = 7
        Me.TXT_CODE.Visible = False
        '
        'BTN_PRENT
        '
        Me.BTN_PRENT.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_PRENT.Appearance.Options.UseFont = True
        Me.BTN_PRENT.ImageOptions.Image = CType(resources.GetObject("BTN_PRENT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_PRENT.Location = New System.Drawing.Point(29, 118)
        Me.BTN_PRENT.Name = "BTN_PRENT"
        Me.BTN_PRENT.Size = New System.Drawing.Size(149, 48)
        Me.BTN_PRENT.TabIndex = 8
        Me.BTN_PRENT.Text = "عرض"
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(472, 121)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(142, 48)
        Me.BTN_EXIT.TabIndex = 9
        Me.BTN_EXIT.Text = "أغلاق"
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'CH_PA
        '
        Me.CH_PA.AutoSize = True
        Me.CH_PA.Checked = True
        Me.CH_PA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CH_PA.Location = New System.Drawing.Point(12, 68)
        Me.CH_PA.Name = "CH_PA"
        Me.CH_PA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CH_PA.Size = New System.Drawing.Size(123, 25)
        Me.CH_PA.TabIndex = 10
        Me.CH_PA.Text = "أسم المريض : "
        Me.CH_PA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CH_PA.UseVisualStyleBackColor = True
        '
        'PA_HESAP_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 186)
        Me.ControlBox = False
        Me.Controls.Add(Me.CH_PA)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_PRENT)
        Me.Controls.Add(Me.TXT_CODE)
        Me.Controls.Add(Me.TXT_NAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.END_DATE)
        Me.Controls.Add(Me.START_DATE)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "PA_HESAP_FRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "كشف حساب مريض معمل"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents START_DATE As DateTimePicker
    Friend WithEvents END_DATE As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_NAME As ComboBox
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents BTN_PRENT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
    Friend WithEvents CH_PA As CheckBox
End Class
