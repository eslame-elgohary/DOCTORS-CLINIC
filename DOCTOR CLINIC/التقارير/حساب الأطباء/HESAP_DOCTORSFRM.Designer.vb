<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HESAP_DOCTORSFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HESAP_DOCTORSFRM))
        Me.TXT_START_DATE = New System.Windows.Forms.DateTimePicker()
        Me.TXT_END_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_DOC_NAME = New System.Windows.Forms.ComboBox()
        Me.TXT_DOC_CODE = New System.Windows.Forms.TextBox()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_VIWE = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_START_DATE
        '
        Me.TXT_START_DATE.Checked = False
        Me.TXT_START_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_START_DATE.Location = New System.Drawing.Point(122, 23)
        Me.TXT_START_DATE.Name = "TXT_START_DATE"
        Me.TXT_START_DATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_START_DATE.Size = New System.Drawing.Size(134, 29)
        Me.TXT_START_DATE.TabIndex = 0
        Me.TXT_START_DATE.Value = New Date(2020, 4, 1, 0, 0, 0, 0)
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
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "بداية الفترة :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(284, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "نهاية الفترة :"
        '
        'TXT_DOC_NAME
        '
        Me.TXT_DOC_NAME.FormattingEnabled = True
        Me.TXT_DOC_NAME.Location = New System.Drawing.Point(140, 89)
        Me.TXT_DOC_NAME.Name = "TXT_DOC_NAME"
        Me.TXT_DOC_NAME.Size = New System.Drawing.Size(351, 29)
        Me.TXT_DOC_NAME.TabIndex = 6
        '
        'TXT_DOC_CODE
        '
        Me.TXT_DOC_CODE.Location = New System.Drawing.Point(497, 89)
        Me.TXT_DOC_CODE.Name = "TXT_DOC_CODE"
        Me.TXT_DOC_CODE.Size = New System.Drawing.Size(26, 29)
        Me.TXT_DOC_CODE.TabIndex = 10
        Me.TXT_DOC_CODE.Visible = False
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(376, 151)
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
        Me.BTN_VIWE.Location = New System.Drawing.Point(23, 151)
        Me.BTN_VIWE.Name = "BTN_VIWE"
        Me.BTN_VIWE.Size = New System.Drawing.Size(126, 40)
        Me.BTN_VIWE.TabIndex = 8
        Me.BTN_VIWE.Text = "عرض"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "أسم الطبيب :"
        '
        'HESAP_DOCTORSFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 213)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_DOC_CODE)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_VIWE)
        Me.Controls.Add(Me.TXT_DOC_NAME)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_END_DATE)
        Me.Controls.Add(Me.TXT_START_DATE)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "HESAP_DOCTORSFRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "حساب الأطباء"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_START_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXT_END_DATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TXT_DOC_NAME As System.Windows.Forms.ComboBox
    Friend WithEvents BTN_VIWE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_DOC_CODE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As Label
End Class
