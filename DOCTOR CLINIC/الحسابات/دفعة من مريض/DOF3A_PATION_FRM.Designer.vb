<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DOF3A_PATION_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DOF3A_PATION_FRM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SAFY_AR = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXT_MONY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_RASED = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PA_NAME = New System.Windows.Forms.ComboBox()
        Me.PA_CODE = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.KHAZINA_CODE = New System.Windows.Forms.TextBox()
        Me.KHAZINA_NAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GRBTN = New System.Windows.Forms.GroupBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EDITNAMEBT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIMERADD = New System.Windows.Forms.Timer(Me.components)
        Me.TIMEREDIT = New System.Windows.Forms.Timer(Me.components)
        Me.TXT_ALL = New System.Windows.Forms.TextBox()
        Me.TXT_ADD = New System.Windows.Forms.TextBox()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.PRINTBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SEARCHBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.DELETBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.EDITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.NEWBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        Me.GRBTN.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_ADD)
        Me.GroupBox1.Controls.Add(Me.TXT_ALL)
        Me.GroupBox1.Controls.Add(Me.SAFY_AR)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TXT_MONY)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_RASED)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.PA_NAME)
        Me.GroupBox1.Controls.Add(Me.PA_CODE)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.KHAZINA_CODE)
        Me.GroupBox1.Controls.Add(Me.KHAZINA_NAME)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 160)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'SAFY_AR
        '
        Me.SAFY_AR.BackColor = System.Drawing.Color.White
        Me.SAFY_AR.Enabled = False
        Me.SAFY_AR.Location = New System.Drawing.Point(6, 109)
        Me.SAFY_AR.Name = "SAFY_AR"
        Me.SAFY_AR.Size = New System.Drawing.Size(584, 29)
        Me.SAFY_AR.TabIndex = 61
        Me.SAFY_AR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(727, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(55, 21)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "المبلغ :"
        '
        'TXT_MONY
        '
        Me.TXT_MONY.BackColor = System.Drawing.Color.White
        Me.TXT_MONY.Location = New System.Drawing.Point(596, 109)
        Me.TXT_MONY.Name = "TXT_MONY"
        Me.TXT_MONY.Size = New System.Drawing.Size(126, 29)
        Me.TXT_MONY.TabIndex = 59
        Me.TXT_MONY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "الرصيد :"
        '
        'TXT_RASED
        '
        Me.TXT_RASED.BackColor = System.Drawing.Color.White
        Me.TXT_RASED.Enabled = False
        Me.TXT_RASED.Location = New System.Drawing.Point(32, 63)
        Me.TXT_RASED.Name = "TXT_RASED"
        Me.TXT_RASED.Size = New System.Drawing.Size(125, 29)
        Me.TXT_RASED.TabIndex = 56
        Me.TXT_RASED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(526, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 21)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "أسم المريض :"
        '
        'PA_NAME
        '
        Me.PA_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PA_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PA_NAME.FormattingEnabled = True
        Me.PA_NAME.Location = New System.Drawing.Point(235, 63)
        Me.PA_NAME.Name = "PA_NAME"
        Me.PA_NAME.Size = New System.Drawing.Size(283, 29)
        Me.PA_NAME.TabIndex = 54
        '
        'PA_CODE
        '
        Me.PA_CODE.BackColor = System.Drawing.Color.White
        Me.PA_CODE.Enabled = False
        Me.PA_CODE.Location = New System.Drawing.Point(627, 63)
        Me.PA_CODE.Name = "PA_CODE"
        Me.PA_CODE.Size = New System.Drawing.Size(78, 29)
        Me.PA_CODE.TabIndex = 53
        Me.PA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(711, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 21)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "كود المريض :"
        '
        'KHAZINA_CODE
        '
        Me.KHAZINA_CODE.BackColor = System.Drawing.Color.White
        Me.KHAZINA_CODE.Enabled = False
        Me.KHAZINA_CODE.Location = New System.Drawing.Point(6, 31)
        Me.KHAZINA_CODE.Name = "KHAZINA_CODE"
        Me.KHAZINA_CODE.Size = New System.Drawing.Size(23, 29)
        Me.KHAZINA_CODE.TabIndex = 19
        Me.KHAZINA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.KHAZINA_CODE.Visible = False
        '
        'KHAZINA_NAME
        '
        Me.KHAZINA_NAME.BackColor = System.Drawing.Color.White
        Me.KHAZINA_NAME.Enabled = False
        Me.KHAZINA_NAME.Location = New System.Drawing.Point(32, 29)
        Me.KHAZINA_NAME.Name = "KHAZINA_NAME"
        Me.KHAZINA_NAME.Size = New System.Drawing.Size(197, 29)
        Me.KHAZINA_NAME.TabIndex = 18
        Me.KHAZINA_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "أسم الخزينة :"
        '
        'TXT_DATE
        '
        Me.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE.Location = New System.Drawing.Point(332, 29)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.Size = New System.Drawing.Size(167, 29)
        Me.TXT_DATE.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(505, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "تاريخ الأيصال :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(618, 28)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(88, 29)
        Me.TXT_CODE.TabIndex = 9
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(712, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "رقم الايصال :"
        '
        'GRBTN
        '
        Me.GRBTN.Controls.Add(Me.EXITBTN)
        Me.GRBTN.Controls.Add(Me.PRINTBTN)
        Me.GRBTN.Controls.Add(Me.SEARCHBTN)
        Me.GRBTN.Controls.Add(Me.DELETBTN)
        Me.GRBTN.Controls.Add(Me.EDITBTN)
        Me.GRBTN.Controls.Add(Me.SAVEBTN)
        Me.GRBTN.Controls.Add(Me.NEWBTN)
        Me.GRBTN.Location = New System.Drawing.Point(57, 157)
        Me.GRBTN.Name = "GRBTN"
        Me.GRBTN.Size = New System.Drawing.Size(713, 72)
        Me.GRBTN.TabIndex = 32
        Me.GRBTN.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 239)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(844, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 35
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel4.Text = "الأضافة : "
        '
        'USER_ADD
        '
        Me.USER_ADD.Name = "USER_ADD"
        Me.USER_ADD.Size = New System.Drawing.Size(119, 17)
        Me.USER_ADD.Text = "ToolStripStatusLabel1"
        '
        'DATE_ADD
        '
        Me.DATE_ADD.Name = "DATE_ADD"
        Me.DATE_ADD.Size = New System.Drawing.Size(119, 17)
        Me.DATE_ADD.Text = "ToolStripStatusLabel2"
        '
        'TIME_ADD
        '
        Me.TIME_ADD.Name = "TIME_ADD"
        Me.TIME_ADD.Size = New System.Drawing.Size(119, 17)
        Me.TIME_ADD.Text = "ToolStripStatusLabel3"
        '
        'EDITNAMEBT
        '
        Me.EDITNAMEBT.Name = "EDITNAMEBT"
        Me.EDITNAMEBT.Size = New System.Drawing.Size(52, 17)
        Me.EDITNAMEBT.Text = "التعديل : "
        Me.EDITNAMEBT.Visible = False
        '
        'USER_EDIT
        '
        Me.USER_EDIT.Name = "USER_EDIT"
        Me.USER_EDIT.Size = New System.Drawing.Size(119, 17)
        Me.USER_EDIT.Text = "ToolStripStatusLabel6"
        Me.USER_EDIT.Visible = False
        '
        'DATE_EDIT
        '
        Me.DATE_EDIT.Name = "DATE_EDIT"
        Me.DATE_EDIT.Size = New System.Drawing.Size(119, 17)
        Me.DATE_EDIT.Text = "ToolStripStatusLabel1"
        Me.DATE_EDIT.Visible = False
        '
        'TIME_EDIT
        '
        Me.TIME_EDIT.Name = "TIME_EDIT"
        Me.TIME_EDIT.Size = New System.Drawing.Size(119, 17)
        Me.TIME_EDIT.Text = "ToolStripStatusLabel2"
        Me.TIME_EDIT.Visible = False
        '
        'TIMERADD
        '
        '
        'TIMEREDIT
        '
        '
        'TXT_ALL
        '
        Me.TXT_ALL.BackColor = System.Drawing.Color.White
        Me.TXT_ALL.Enabled = False
        Me.TXT_ALL.Location = New System.Drawing.Point(760, 74)
        Me.TXT_ALL.Name = "TXT_ALL"
        Me.TXT_ALL.Size = New System.Drawing.Size(42, 29)
        Me.TXT_ALL.TabIndex = 62
        Me.TXT_ALL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ALL.Visible = False
        '
        'TXT_ADD
        '
        Me.TXT_ADD.BackColor = System.Drawing.Color.White
        Me.TXT_ADD.Enabled = False
        Me.TXT_ADD.Location = New System.Drawing.Point(763, 39)
        Me.TXT_ADD.Name = "TXT_ADD"
        Me.TXT_ADD.Size = New System.Drawing.Size(42, 29)
        Me.TXT_ADD.TabIndex = 63
        Me.TXT_ADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ADD.Visible = False
        '
        'EXITBTN
        '
        Me.EXITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.Appearance.Options.UseFont = True
        Me.EXITBTN.ImageOptions.Image = CType(resources.GetObject("EXITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBTN.Location = New System.Drawing.Point(6, 22)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(41, 44)
        Me.EXITBTN.TabIndex = 7
        '
        'PRINTBTN
        '
        Me.PRINTBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRINTBTN.Appearance.Options.UseFont = True
        Me.PRINTBTN.ImageOptions.Image = CType(resources.GetObject("PRINTBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.PRINTBTN.Location = New System.Drawing.Point(58, 22)
        Me.PRINTBTN.Name = "PRINTBTN"
        Me.PRINTBTN.Size = New System.Drawing.Size(96, 44)
        Me.PRINTBTN.TabIndex = 6
        Me.PRINTBTN.Text = "طباعة"
        '
        'SEARCHBTN
        '
        Me.SEARCHBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCHBTN.Appearance.Options.UseFont = True
        Me.SEARCHBTN.ImageOptions.Image = CType(resources.GetObject("SEARCHBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SEARCHBTN.Location = New System.Drawing.Point(169, 22)
        Me.SEARCHBTN.Name = "SEARCHBTN"
        Me.SEARCHBTN.Size = New System.Drawing.Size(96, 44)
        Me.SEARCHBTN.TabIndex = 4
        Me.SEARCHBTN.Text = "بحث"
        '
        'DELETBTN
        '
        Me.DELETBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETBTN.Appearance.ForeColor = System.Drawing.Color.Red
        Me.DELETBTN.Appearance.Options.UseFont = True
        Me.DELETBTN.Appearance.Options.UseForeColor = True
        Me.DELETBTN.ImageOptions.Image = CType(resources.GetObject("DELETBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.DELETBTN.Location = New System.Drawing.Point(277, 22)
        Me.DELETBTN.Name = "DELETBTN"
        Me.DELETBTN.Size = New System.Drawing.Size(96, 44)
        Me.DELETBTN.TabIndex = 3
        Me.DELETBTN.Text = "حذف"
        '
        'EDITBTN
        '
        Me.EDITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDITBTN.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.EDITBTN.Appearance.Options.UseFont = True
        Me.EDITBTN.Appearance.Options.UseForeColor = True
        Me.EDITBTN.ImageOptions.Image = CType(resources.GetObject("EDITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EDITBTN.Location = New System.Drawing.Point(385, 22)
        Me.EDITBTN.Name = "EDITBTN"
        Me.EDITBTN.Size = New System.Drawing.Size(96, 44)
        Me.EDITBTN.TabIndex = 2
        Me.EDITBTN.Text = "تعديل"
        '
        'SAVEBTN
        '
        Me.SAVEBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVEBTN.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.SAVEBTN.Appearance.Options.UseFont = True
        Me.SAVEBTN.Appearance.Options.UseForeColor = True
        Me.SAVEBTN.ImageOptions.Image = CType(resources.GetObject("SAVEBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SAVEBTN.Location = New System.Drawing.Point(497, 22)
        Me.SAVEBTN.Name = "SAVEBTN"
        Me.SAVEBTN.Size = New System.Drawing.Size(96, 44)
        Me.SAVEBTN.TabIndex = 0
        Me.SAVEBTN.Text = "حفظ"
        '
        'NEWBTN
        '
        Me.NEWBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NEWBTN.Appearance.ForeColor = System.Drawing.Color.LimeGreen
        Me.NEWBTN.Appearance.Options.UseFont = True
        Me.NEWBTN.Appearance.Options.UseForeColor = True
        Me.NEWBTN.ImageOptions.Image = CType(resources.GetObject("NEWBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.NEWBTN.Location = New System.Drawing.Point(604, 22)
        Me.NEWBTN.Name = "NEWBTN"
        Me.NEWBTN.Size = New System.Drawing.Size(96, 44)
        Me.NEWBTN.TabIndex = 1
        Me.NEWBTN.Text = "جديد"
        '
        'DOF3A_PATION_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 261)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GRBTN)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "DOF3A_PATION_FRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "دفعة من مريض معمل"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GRBTN.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_RASED As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PA_NAME As ComboBox
    Friend WithEvents PA_CODE As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents KHAZINA_CODE As TextBox
    Friend WithEvents KHAZINA_NAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DATE As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TXT_MONY As TextBox
    Friend WithEvents SAFY_AR As TextBox
    Friend WithEvents GRBTN As GroupBox
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PRINTBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SEARCHBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DELETBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EDITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SAVEBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NEWBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents USER_ADD As ToolStripStatusLabel
    Friend WithEvents DATE_ADD As ToolStripStatusLabel
    Friend WithEvents TIME_ADD As ToolStripStatusLabel
    Friend WithEvents EDITNAMEBT As ToolStripStatusLabel
    Friend WithEvents USER_EDIT As ToolStripStatusLabel
    Friend WithEvents DATE_EDIT As ToolStripStatusLabel
    Friend WithEvents TIME_EDIT As ToolStripStatusLabel
    Friend WithEvents TIMERADD As Timer
    Friend WithEvents TIMEREDIT As Timer
    Friend WithEvents TXT_ADD As TextBox
    Friend WithEvents TXT_ALL As TextBox
End Class
