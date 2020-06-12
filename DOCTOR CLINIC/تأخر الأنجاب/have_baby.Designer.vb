<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class have_baby
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(have_baby))
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LMP_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_NAME_PA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_RH = New System.Windows.Forms.ComboBox()
        Me.TXT_ABO = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EDD_DATE = New System.Windows.Forms.DateTimePicker()
        Me.MARED_DEAT = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(56, 11)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(56, 27)
        Me.TXT_PA_CODE.TabIndex = 23
        Me.TXT_PA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EXITBTN
        '
        Me.EXITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.Appearance.Options.UseFont = True
        Me.EXITBTN.ImageOptions.Image = CType(resources.GetObject("EXITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBTN.Location = New System.Drawing.Point(427, 198)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(106, 44)
        Me.EXITBTN.TabIndex = 20
        Me.EXITBTN.Text = "Exit"
        '
        'SAVEBTN
        '
        Me.SAVEBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVEBTN.Appearance.ForeColor = System.Drawing.Color.OliveDrab
        Me.SAVEBTN.Appearance.Options.UseFont = True
        Me.SAVEBTN.Appearance.Options.UseForeColor = True
        Me.SAVEBTN.ImageOptions.Image = CType(resources.GetObject("SAVEBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SAVEBTN.Location = New System.Drawing.Point(29, 198)
        Me.SAVEBTN.Name = "SAVEBTN"
        Me.SAVEBTN.Size = New System.Drawing.Size(115, 44)
        Me.SAVEBTN.TabIndex = 19
        Me.SAVEBTN.Text = "Accept"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(14, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(557, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "* محلوظة هامة : أنه فى حالة الموافقة على التسجيل سيتم أغلاق كارت متابعة الأنجاب ن" &
    "هائيا "
        '
        'LMP_DATE
        '
        Me.LMP_DATE.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LMP_DATE.Location = New System.Drawing.Point(289, 44)
        Me.LMP_DATE.Name = "LMP_DATE"
        Me.LMP_DATE.Size = New System.Drawing.Size(167, 27)
        Me.LMP_DATE.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(466, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "L.M.P :"
        '
        'TXT_NAME_PA
        '
        Me.TXT_NAME_PA.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME_PA.ForeColor = System.Drawing.Color.SteelBlue
        Me.TXT_NAME_PA.Location = New System.Drawing.Point(118, 13)
        Me.TXT_NAME_PA.Name = "TXT_NAME_PA"
        Me.TXT_NAME_PA.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_NAME_PA.Size = New System.Drawing.Size(342, 20)
        Me.TXT_NAME_PA.TabIndex = 13
        Me.TXT_NAME_PA.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(466, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(466, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(55, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "ABO :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(175, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(44, 19)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "RH :"
        '
        'TXT_RH
        '
        Me.TXT_RH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_RH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_RH.BackColor = System.Drawing.Color.Aqua
        Me.TXT_RH.FormattingEnabled = True
        Me.TXT_RH.Items.AddRange(New Object() {"POSITIVE", "NEGATIVE"})
        Me.TXT_RH.Location = New System.Drawing.Point(19, 100)
        Me.TXT_RH.Name = "TXT_RH"
        Me.TXT_RH.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_RH.Size = New System.Drawing.Size(147, 27)
        Me.TXT_RH.TabIndex = 27
        '
        'TXT_ABO
        '
        Me.TXT_ABO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_ABO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_ABO.BackColor = System.Drawing.Color.Aqua
        Me.TXT_ABO.FormattingEnabled = True
        Me.TXT_ABO.Items.AddRange(New Object() {"A", "B", "AB", "O"})
        Me.TXT_ABO.Location = New System.Drawing.Point(289, 98)
        Me.TXT_ABO.Name = "TXT_ABO"
        Me.TXT_ABO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_ABO.Size = New System.Drawing.Size(167, 27)
        Me.TXT_ABO.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "E.D.D :"
        '
        'EDD_DATE
        '
        Me.EDD_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EDD_DATE.Location = New System.Drawing.Point(19, 45)
        Me.EDD_DATE.Name = "EDD_DATE"
        Me.EDD_DATE.Size = New System.Drawing.Size(147, 27)
        Me.EDD_DATE.TabIndex = 24
        '
        'MARED_DEAT
        '
        Me.MARED_DEAT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MARED_DEAT.Location = New System.Drawing.Point(210, 205)
        Me.MARED_DEAT.Name = "MARED_DEAT"
        Me.MARED_DEAT.Size = New System.Drawing.Size(147, 27)
        Me.MARED_DEAT.TabIndex = 30
        Me.MARED_DEAT.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(40, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(185, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "وسيتم فتح كارت متابعة الحمل"
        '
        'have_baby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 255)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MARED_DEAT)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXT_RH)
        Me.Controls.Add(Me.TXT_ABO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EDD_DATE)
        Me.Controls.Add(Me.EXITBTN)
        Me.Controls.Add(Me.SAVEBTN)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LMP_DATE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_NAME_PA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_PA_CODE)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "have_baby"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تحويل متابعة الأنجاب الى متابعة حمل"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SAVEBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As Label
    Friend WithEvents LMP_DATE As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_NAME_PA As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_RH As ComboBox
    Friend WithEvents TXT_ABO As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents EDD_DATE As DateTimePicker
    Friend WithEvents MARED_DEAT As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
