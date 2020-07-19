<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LABTOLAB_V
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LABTOLAB_V))
        Me.TXT_START_DATE = New System.Windows.Forms.DateTimePicker()
        Me.TXT_END_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CH_MAML = New System.Windows.Forms.CheckBox()
        Me.CH_PA = New System.Windows.Forms.CheckBox()
        Me.TXT_MAML_NAME = New System.Windows.Forms.ComboBox()
        Me.TXT_PA_NAME = New System.Windows.Forms.ComboBox()
        Me.PATION_BINDING = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
        Me.TXT_MAML_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_VIWE = New DevExpress.XtraEditors.SimpleButton()
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_START_DATE
        '
        Me.TXT_START_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_START_DATE.Location = New System.Drawing.Point(122, 23)
        Me.TXT_START_DATE.Name = "TXT_START_DATE"
        Me.TXT_START_DATE.Size = New System.Drawing.Size(128, 29)
        Me.TXT_START_DATE.TabIndex = 0
        '
        'TXT_END_DATE
        '
        Me.TXT_END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_END_DATE.Location = New System.Drawing.Point(376, 23)
        Me.TXT_END_DATE.Name = "TXT_END_DATE"
        Me.TXT_END_DATE.Size = New System.Drawing.Size(140, 29)
        Me.TXT_END_DATE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "بداية الفترة :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "نهاية الفترة :"
        '
        'CH_MAML
        '
        Me.CH_MAML.AutoSize = True
        Me.CH_MAML.Location = New System.Drawing.Point(23, 93)
        Me.CH_MAML.Name = "CH_MAML"
        Me.CH_MAML.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CH_MAML.Size = New System.Drawing.Size(100, 25)
        Me.CH_MAML.TabIndex = 4
        Me.CH_MAML.Text = "أسم المعمل"
        Me.CH_MAML.UseVisualStyleBackColor = True
        '
        'CH_PA
        '
        Me.CH_PA.AutoSize = True
        Me.CH_PA.Location = New System.Drawing.Point(14, 139)
        Me.CH_PA.Name = "CH_PA"
        Me.CH_PA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CH_PA.Size = New System.Drawing.Size(109, 25)
        Me.CH_PA.TabIndex = 5
        Me.CH_PA.Text = "أسم المريض"
        Me.CH_PA.UseVisualStyleBackColor = True
        '
        'TXT_MAML_NAME
        '
        Me.TXT_MAML_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_MAML_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_MAML_NAME.Enabled = False
        Me.TXT_MAML_NAME.FormattingEnabled = True
        Me.TXT_MAML_NAME.Location = New System.Drawing.Point(140, 89)
        Me.TXT_MAML_NAME.Name = "TXT_MAML_NAME"
        Me.TXT_MAML_NAME.Size = New System.Drawing.Size(351, 29)
        Me.TXT_MAML_NAME.TabIndex = 6
        '
        'TXT_PA_NAME
        '
        Me.TXT_PA_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_PA_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_PA_NAME.DataSource = Me.PATION_BINDING
        Me.TXT_PA_NAME.DisplayMember = "PA_NAME"
        Me.TXT_PA_NAME.Enabled = False
        Me.TXT_PA_NAME.FormattingEnabled = True
        Me.TXT_PA_NAME.Location = New System.Drawing.Point(140, 139)
        Me.TXT_PA_NAME.Name = "TXT_PA_NAME"
        Me.TXT_PA_NAME.Size = New System.Drawing.Size(351, 29)
        Me.TXT_PA_NAME.TabIndex = 7
        Me.TXT_PA_NAME.ValueMember = "PA_NAME"
        '
        'PATION_BINDING
        '
        Me.PATION_BINDING.AllowNew = True
        Me.PATION_BINDING.DataMember = "PATIENT"
        Me.PATION_BINDING.DataSource = Me.PATIENTDATA
        Me.PATION_BINDING.Filter = "STAT=TRUE"
        '
        'PATIENTDATA
        '
        Me.PATIENTDATA.DataSetName = "PATIENTDATA"
        Me.PATIENTDATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXT_MAML_CODE
        '
        Me.TXT_MAML_CODE.Location = New System.Drawing.Point(497, 89)
        Me.TXT_MAML_CODE.Name = "TXT_MAML_CODE"
        Me.TXT_MAML_CODE.Size = New System.Drawing.Size(44, 29)
        Me.TXT_MAML_CODE.TabIndex = 10
        Me.TXT_MAML_CODE.Visible = False
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(497, 135)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(44, 29)
        Me.TXT_PA_CODE.TabIndex = 11
        Me.TXT_PA_CODE.Visible = False
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(376, 199)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(126, 40)
        Me.BTN_EXIT.TabIndex = 9
        Me.BTN_EXIT.Text = "أغلاق"
        '
        'BTN_VIWE
        '
        Me.BTN_VIWE.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VIWE.Appearance.Options.UseFont = True
        Me.BTN_VIWE.ImageOptions.Image = CType(resources.GetObject("BTN_VIWE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_VIWE.Location = New System.Drawing.Point(23, 199)
        Me.BTN_VIWE.Name = "BTN_VIWE"
        Me.BTN_VIWE.Size = New System.Drawing.Size(126, 40)
        Me.BTN_VIWE.TabIndex = 8
        Me.BTN_VIWE.Text = "عرض"
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'LABTOLAB_V
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 265)
        Me.Controls.Add(Me.TXT_PA_CODE)
        Me.Controls.Add(Me.TXT_MAML_CODE)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_VIWE)
        Me.Controls.Add(Me.TXT_PA_NAME)
        Me.Controls.Add(Me.TXT_MAML_NAME)
        Me.Controls.Add(Me.CH_PA)
        Me.Controls.Add(Me.CH_MAML)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_END_DATE)
        Me.Controls.Add(Me.TXT_START_DATE)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "LABTOLAB_V"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAB TO LAB"
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_START_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_END_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CH_MAML As System.Windows.Forms.CheckBox
    Friend WithEvents CH_PA As System.Windows.Forms.CheckBox
    Friend WithEvents TXT_MAML_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents TXT_PA_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_VIWE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_MAML_CODE As System.Windows.Forms.TextBox
    Friend WithEvents TXT_PA_CODE As System.Windows.Forms.TextBox
    Friend WithEvents PATION_BINDING As BindingSource
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
End Class
