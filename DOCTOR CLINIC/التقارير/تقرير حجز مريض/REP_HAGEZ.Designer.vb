<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REP_HAGEZ
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REP_HAGEZ))
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_PA_NAME = New System.Windows.Forms.ComboBox()
        Me.CH_PA = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_END_DATE = New System.Windows.Forms.DateTimePicker()
        Me.TXT_START_DATE = New System.Windows.Forms.DateTimePicker()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_VIWE = New DevExpress.XtraEditors.SimpleButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(529, 76)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(44, 27)
        Me.TXT_PA_CODE.TabIndex = 20
        Me.TXT_PA_CODE.Visible = False
        '
        'TXT_PA_NAME
        '
        Me.TXT_PA_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_PA_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_PA_NAME.DataSource = Me.BindingSource1
        Me.TXT_PA_NAME.DisplayMember = "PA_NAME"
        Me.TXT_PA_NAME.Enabled = False
        Me.TXT_PA_NAME.FormattingEnabled = True
        Me.TXT_PA_NAME.Location = New System.Drawing.Point(172, 76)
        Me.TXT_PA_NAME.Name = "TXT_PA_NAME"
        Me.TXT_PA_NAME.Size = New System.Drawing.Size(351, 27)
        Me.TXT_PA_NAME.TabIndex = 17
        Me.TXT_PA_NAME.ValueMember = "PA_NAME"
        '
        'CH_PA
        '
        Me.CH_PA.AutoSize = True
        Me.CH_PA.Location = New System.Drawing.Point(46, 80)
        Me.CH_PA.Name = "CH_PA"
        Me.CH_PA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CH_PA.Size = New System.Drawing.Size(124, 23)
        Me.CH_PA.TabIndex = 16
        Me.CH_PA.Text = "أسم المريض"
        Me.CH_PA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "نهاية الفترة :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "بداية الفترة :"
        '
        'TXT_END_DATE
        '
        Me.TXT_END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_END_DATE.Location = New System.Drawing.Point(413, 23)
        Me.TXT_END_DATE.Name = "TXT_END_DATE"
        Me.TXT_END_DATE.Size = New System.Drawing.Size(140, 27)
        Me.TXT_END_DATE.TabIndex = 13
        '
        'TXT_START_DATE
        '
        Me.TXT_START_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_START_DATE.Location = New System.Drawing.Point(154, 23)
        Me.TXT_START_DATE.Name = "TXT_START_DATE"
        Me.TXT_START_DATE.Size = New System.Drawing.Size(128, 27)
        Me.TXT_START_DATE.TabIndex = 12
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(408, 133)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(126, 40)
        Me.BTN_EXIT.TabIndex = 19
        Me.BTN_EXIT.Text = "أغلاق"
        '
        'BTN_VIWE
        '
        Me.BTN_VIWE.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VIWE.Appearance.Options.UseFont = True
        Me.BTN_VIWE.ImageOptions.Image = CType(resources.GetObject("BTN_VIWE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_VIWE.Location = New System.Drawing.Point(55, 133)
        Me.BTN_VIWE.Name = "BTN_VIWE"
        Me.BTN_VIWE.Size = New System.Drawing.Size(126, 40)
        Me.BTN_VIWE.TabIndex = 18
        Me.BTN_VIWE.Text = "عرض"
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
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'REP_HAGEZ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 219)
        Me.Controls.Add(Me.TXT_PA_CODE)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_VIWE)
        Me.Controls.Add(Me.TXT_PA_NAME)
        Me.Controls.Add(Me.CH_PA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_END_DATE)
        Me.Controls.Add(Me.TXT_START_DATE)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "REP_HAGEZ"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير حجز مريض"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_VIWE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_PA_NAME As ComboBox
    Friend WithEvents CH_PA As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_END_DATE As DateTimePicker
    Friend WithEvents TXT_START_DATE As DateTimePicker
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
End Class
