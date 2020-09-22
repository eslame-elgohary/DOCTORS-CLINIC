<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ERADAT_REP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ERADAT_REP))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_END_DATE = New System.Windows.Forms.DateTimePicker()
        Me.TXT_START_DATE = New System.Windows.Forms.DateTimePicker()
        Me.TXT_MASROUFL_NAME = New System.Windows.Forms.ComboBox()
        Me.CH_MASROUF = New System.Windows.Forms.CheckBox()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_VIWE = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_MASROUFL_CODE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "نهاية الفترة :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "بداية الفترة :"
        '
        'TXT_END_DATE
        '
        Me.TXT_END_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_END_DATE.Location = New System.Drawing.Point(375, 19)
        Me.TXT_END_DATE.Name = "TXT_END_DATE"
        Me.TXT_END_DATE.Size = New System.Drawing.Size(140, 29)
        Me.TXT_END_DATE.TabIndex = 5
        '
        'TXT_START_DATE
        '
        Me.TXT_START_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_START_DATE.Location = New System.Drawing.Point(121, 19)
        Me.TXT_START_DATE.Name = "TXT_START_DATE"
        Me.TXT_START_DATE.Size = New System.Drawing.Size(128, 29)
        Me.TXT_START_DATE.TabIndex = 4
        '
        'TXT_MASROUFL_NAME
        '
        Me.TXT_MASROUFL_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_MASROUFL_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_MASROUFL_NAME.Enabled = False
        Me.TXT_MASROUFL_NAME.FormattingEnabled = True
        Me.TXT_MASROUFL_NAME.Location = New System.Drawing.Point(146, 67)
        Me.TXT_MASROUFL_NAME.Name = "TXT_MASROUFL_NAME"
        Me.TXT_MASROUFL_NAME.Size = New System.Drawing.Size(369, 29)
        Me.TXT_MASROUFL_NAME.TabIndex = 9
        '
        'CH_MASROUF
        '
        Me.CH_MASROUF.AutoSize = True
        Me.CH_MASROUF.Location = New System.Drawing.Point(32, 69)
        Me.CH_MASROUF.Name = "CH_MASROUF"
        Me.CH_MASROUF.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CH_MASROUF.Size = New System.Drawing.Size(101, 25)
        Me.CH_MASROUF.TabIndex = 8
        Me.CH_MASROUF.Text = "توريد معين"
        Me.CH_MASROUF.UseVisualStyleBackColor = True
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(399, 120)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(126, 40)
        Me.BTN_EXIT.TabIndex = 11
        Me.BTN_EXIT.Text = "أغلاق"
        '
        'BTN_VIWE
        '
        Me.BTN_VIWE.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_VIWE.Appearance.Options.UseFont = True
        Me.BTN_VIWE.ImageOptions.Image = CType(resources.GetObject("BTN_VIWE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_VIWE.Location = New System.Drawing.Point(31, 120)
        Me.BTN_VIWE.Name = "BTN_VIWE"
        Me.BTN_VIWE.Size = New System.Drawing.Size(126, 40)
        Me.BTN_VIWE.TabIndex = 10
        Me.BTN_VIWE.Text = "عرض"
        '
        'TXT_MASROUFL_CODE
        '
        Me.TXT_MASROUFL_CODE.Location = New System.Drawing.Point(266, 120)
        Me.TXT_MASROUFL_CODE.Name = "TXT_MASROUFL_CODE"
        Me.TXT_MASROUFL_CODE.Size = New System.Drawing.Size(44, 29)
        Me.TXT_MASROUFL_CODE.TabIndex = 12
        Me.TXT_MASROUFL_CODE.Visible = False
        '
        'ERADAT_REP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 172)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXT_MASROUFL_CODE)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_VIWE)
        Me.Controls.Add(Me.TXT_MASROUFL_NAME)
        Me.Controls.Add(Me.CH_MASROUF)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_END_DATE)
        Me.Controls.Add(Me.TXT_START_DATE)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ERADAT_REP"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "         تقرير الأيرادات"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_END_DATE As DateTimePicker
    Friend WithEvents TXT_START_DATE As DateTimePicker
    Friend WithEvents TXT_MASROUFL_NAME As ComboBox
    Friend WithEvents CH_MASROUF As CheckBox
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_VIWE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_MASROUFL_CODE As TextBox
End Class
