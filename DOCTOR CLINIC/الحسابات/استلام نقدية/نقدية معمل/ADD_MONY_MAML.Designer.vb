﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_MONY_MAML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_MONY_MAML))
        Me.GRBTN = New System.Windows.Forms.GroupBox()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.PRINTBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.UNDOBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SEARCHBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.DELETBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.EDITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.NEWBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_TYPEMONY = New System.Windows.Forms.ComboBox()
        Me.TXT_CODE2 = New System.Windows.Forms.TextBox()
        Me.MAML_CODE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MAML_NAME = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_AGE = New System.Windows.Forms.TextBox()
        Me.TXT_PA_TYPE = New System.Windows.Forms.TextBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXT_BAKY = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_MONY = New System.Windows.Forms.TextBox()
        Me.TXT_M = New System.Windows.Forms.TextBox()
        Me.SAFY_AR = New System.Windows.Forms.TextBox()
        Me.SAFY = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DISCOUNT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TOTAL = New System.Windows.Forms.TextBox()
        Me.ACTIVE_MAML = New DevExpress.XtraEditors.SimpleButton()
        Me.TH_PRICE = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TH_NAME = New System.Windows.Forms.ComboBox()
        Me.TH_CODE = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column0 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIMEREDIT = New System.Windows.Forms.Timer(Me.components)
        Me.TIMERADD = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EDITNAMEBT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GRBTN.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRBTN
        '
        Me.GRBTN.Controls.Add(Me.EXITBTN)
        Me.GRBTN.Controls.Add(Me.PRINTBTN)
        Me.GRBTN.Controls.Add(Me.UNDOBTN)
        Me.GRBTN.Controls.Add(Me.SEARCHBTN)
        Me.GRBTN.Controls.Add(Me.DELETBTN)
        Me.GRBTN.Controls.Add(Me.EDITBTN)
        Me.GRBTN.Controls.Add(Me.SAVEBTN)
        Me.GRBTN.Controls.Add(Me.NEWBTN)
        Me.GRBTN.Location = New System.Drawing.Point(11, 420)
        Me.GRBTN.Name = "GRBTN"
        Me.GRBTN.Size = New System.Drawing.Size(842, 72)
        Me.GRBTN.TabIndex = 31
        Me.GRBTN.TabStop = False
        '
        'EXITBTN
        '
        Me.EXITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.Appearance.Options.UseFont = True
        Me.EXITBTN.ImageOptions.Image = CType(resources.GetObject("EXITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBTN.Location = New System.Drawing.Point(12, 20)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(41, 44)
        Me.EXITBTN.TabIndex = 7
        '
        'PRINTBTN
        '
        Me.PRINTBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRINTBTN.Appearance.Options.UseFont = True
        Me.PRINTBTN.ImageOptions.Image = CType(resources.GetObject("PRINTBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.PRINTBTN.Location = New System.Drawing.Point(70, 20)
        Me.PRINTBTN.Name = "PRINTBTN"
        Me.PRINTBTN.Size = New System.Drawing.Size(96, 44)
        Me.PRINTBTN.TabIndex = 6
        Me.PRINTBTN.Text = "طباعة"
        '
        'UNDOBTN
        '
        Me.UNDOBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UNDOBTN.Appearance.ForeColor = System.Drawing.Color.Purple
        Me.UNDOBTN.Appearance.Options.UseFont = True
        Me.UNDOBTN.Appearance.Options.UseForeColor = True
        Me.UNDOBTN.ImageOptions.Image = CType(resources.GetObject("UNDOBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.UNDOBTN.Location = New System.Drawing.Point(180, 20)
        Me.UNDOBTN.Name = "UNDOBTN"
        Me.UNDOBTN.Size = New System.Drawing.Size(106, 44)
        Me.UNDOBTN.TabIndex = 5
        Me.UNDOBTN.Text = "الأرشيف"
        '
        'SEARCHBTN
        '
        Me.SEARCHBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCHBTN.Appearance.Options.UseFont = True
        Me.SEARCHBTN.ImageOptions.Image = CType(resources.GetObject("SEARCHBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SEARCHBTN.Location = New System.Drawing.Point(300, 20)
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
        Me.DELETBTN.Location = New System.Drawing.Point(408, 20)
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
        Me.EDITBTN.Location = New System.Drawing.Point(516, 20)
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
        Me.SAVEBTN.Location = New System.Drawing.Point(628, 20)
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
        Me.NEWBTN.Location = New System.Drawing.Point(735, 20)
        Me.NEWBTN.Name = "NEWBTN"
        Me.NEWBTN.Size = New System.Drawing.Size(96, 44)
        Me.NEWBTN.TabIndex = 1
        Me.NEWBTN.Text = "جديد"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TXT_TYPEMONY)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE2)
        Me.GroupBox1.Controls.Add(Me.MAML_CODE)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.MAML_NAME)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_AGE)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_TYPE)
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
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 142)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(197, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 21)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "نوع الدفع :"
        '
        'TXT_TYPEMONY
        '
        Me.TXT_TYPEMONY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_TYPEMONY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_TYPEMONY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_TYPEMONY.FormattingEnabled = True
        Me.TXT_TYPEMONY.Items.AddRange(New Object() {"نقدي", "فيزا", "بريميوم كارد"})
        Me.TXT_TYPEMONY.Location = New System.Drawing.Point(32, 107)
        Me.TXT_TYPEMONY.Name = "TXT_TYPEMONY"
        Me.TXT_TYPEMONY.Size = New System.Drawing.Size(163, 29)
        Me.TXT_TYPEMONY.TabIndex = 69
        '
        'TXT_CODE2
        '
        Me.TXT_CODE2.BackColor = System.Drawing.Color.White
        Me.TXT_CODE2.Enabled = False
        Me.TXT_CODE2.Location = New System.Drawing.Point(773, 24)
        Me.TXT_CODE2.Name = "TXT_CODE2"
        Me.TXT_CODE2.Size = New System.Drawing.Size(47, 29)
        Me.TXT_CODE2.TabIndex = 68
        Me.TXT_CODE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_CODE2.Visible = False
        '
        'MAML_CODE
        '
        Me.MAML_CODE.BackColor = System.Drawing.Color.White
        Me.MAML_CODE.Enabled = False
        Me.MAML_CODE.Location = New System.Drawing.Point(478, 98)
        Me.MAML_CODE.Name = "MAML_CODE"
        Me.MAML_CODE.Size = New System.Drawing.Size(21, 29)
        Me.MAML_CODE.TabIndex = 62
        Me.MAML_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MAML_CODE.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(711, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 21)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "أسم المعمل :"
        '
        'MAML_NAME
        '
        Me.MAML_NAME.BackColor = System.Drawing.Color.Aqua
        Me.MAML_NAME.Enabled = False
        Me.MAML_NAME.FormattingEnabled = True
        Me.MAML_NAME.Items.AddRange(New Object() {"معمل", "عيادة"})
        Me.MAML_NAME.Location = New System.Drawing.Point(506, 98)
        Me.MAML_NAME.Name = "MAML_NAME"
        Me.MAML_NAME.Size = New System.Drawing.Size(200, 29)
        Me.MAML_NAME.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 21)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "العمر :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 21)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "النوع :"
        '
        'TXT_AGE
        '
        Me.TXT_AGE.BackColor = System.Drawing.Color.White
        Me.TXT_AGE.Enabled = False
        Me.TXT_AGE.Location = New System.Drawing.Point(32, 66)
        Me.TXT_AGE.Name = "TXT_AGE"
        Me.TXT_AGE.Size = New System.Drawing.Size(55, 29)
        Me.TXT_AGE.TabIndex = 57
        Me.TXT_AGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_PA_TYPE
        '
        Me.TXT_PA_TYPE.BackColor = System.Drawing.Color.White
        Me.TXT_PA_TYPE.Enabled = False
        Me.TXT_PA_TYPE.Location = New System.Drawing.Point(151, 64)
        Me.TXT_PA_TYPE.Name = "TXT_PA_TYPE"
        Me.TXT_PA_TYPE.Size = New System.Drawing.Size(61, 29)
        Me.TXT_PA_TYPE.TabIndex = 56
        Me.TXT_PA_TYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(527, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 21)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "أسم المريض :"
        '
        'PA_NAME
        '
        Me.PA_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PA_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PA_NAME.BackColor = System.Drawing.Color.Aqua
        Me.PA_NAME.FormattingEnabled = True
        Me.PA_NAME.Items.AddRange(New Object() {"معمل", "عيادة"})
        Me.PA_NAME.Location = New System.Drawing.Point(299, 63)
        Me.PA_NAME.Name = "PA_NAME"
        Me.PA_NAME.Size = New System.Drawing.Size(220, 29)
        Me.PA_NAME.TabIndex = 54
        '
        'PA_CODE
        '
        Me.PA_CODE.BackColor = System.Drawing.Color.White
        Me.PA_CODE.Enabled = False
        Me.PA_CODE.Location = New System.Drawing.Point(628, 63)
        Me.PA_CODE.Name = "PA_CODE"
        Me.PA_CODE.Size = New System.Drawing.Size(78, 29)
        Me.PA_CODE.TabIndex = 53
        Me.PA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(712, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 21)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "كود المريض :"
        '
        'KHAZINA_CODE
        '
        Me.KHAZINA_CODE.BackColor = System.Drawing.Color.White
        Me.KHAZINA_CODE.Enabled = False
        Me.KHAZINA_CODE.Location = New System.Drawing.Point(299, 28)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(264, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 50)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "+"
        Me.Label6.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_BAKY)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TXT_MONY)
        Me.GroupBox2.Controls.Add(Me.TXT_M)
        Me.GroupBox2.Controls.Add(Me.SAFY_AR)
        Me.GroupBox2.Controls.Add(Me.SAFY)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.DISCOUNT)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TOTAL)
        Me.GroupBox2.Controls.Add(Me.ACTIVE_MAML)
        Me.GroupBox2.Controls.Add(Me.TH_PRICE)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TH_NAME)
        Me.GroupBox2.Controls.Add(Me.TH_CODE)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(832, 276)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'TXT_BAKY
        '
        Me.TXT_BAKY.BackColor = System.Drawing.Color.White
        Me.TXT_BAKY.Enabled = False
        Me.TXT_BAKY.Location = New System.Drawing.Point(6, 206)
        Me.TXT_BAKY.Name = "TXT_BAKY"
        Me.TXT_BAKY.Size = New System.Drawing.Size(90, 29)
        Me.TXT_BAKY.TabIndex = 62
        Me.TXT_BAKY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(100, 209)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 21)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "المتبقي :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(260, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "المدفوع :"
        '
        'TXT_MONY
        '
        Me.TXT_MONY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_MONY.Location = New System.Drawing.Point(170, 206)
        Me.TXT_MONY.Name = "TXT_MONY"
        Me.TXT_MONY.Size = New System.Drawing.Size(85, 29)
        Me.TXT_MONY.TabIndex = 60
        Me.TXT_MONY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_M
        '
        Me.TXT_M.BackColor = System.Drawing.Color.White
        Me.TXT_M.Enabled = False
        Me.TXT_M.Location = New System.Drawing.Point(93, 23)
        Me.TXT_M.Name = "TXT_M"
        Me.TXT_M.Size = New System.Drawing.Size(21, 29)
        Me.TXT_M.TabIndex = 59
        Me.TXT_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_M.Visible = False
        '
        'SAFY_AR
        '
        Me.SAFY_AR.BackColor = System.Drawing.Color.White
        Me.SAFY_AR.Enabled = False
        Me.SAFY_AR.Location = New System.Drawing.Point(18, 241)
        Me.SAFY_AR.Name = "SAFY_AR"
        Me.SAFY_AR.Size = New System.Drawing.Size(785, 29)
        Me.SAFY_AR.TabIndex = 49
        Me.SAFY_AR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SAFY
        '
        Me.SAFY.BackColor = System.Drawing.Color.White
        Me.SAFY.Enabled = False
        Me.SAFY.Location = New System.Drawing.Point(334, 206)
        Me.SAFY.Name = "SAFY"
        Me.SAFY.Size = New System.Drawing.Size(99, 29)
        Me.SAFY.TabIndex = 46
        Me.SAFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(438, 209)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 21)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "الصافي :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(591, 209)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 21)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "الخصم :"
        '
        'DISCOUNT
        '
        Me.DISCOUNT.BackColor = System.Drawing.Color.Aqua
        Me.DISCOUNT.Location = New System.Drawing.Point(512, 206)
        Me.DISCOUNT.Name = "DISCOUNT"
        Me.DISCOUNT.Size = New System.Drawing.Size(74, 29)
        Me.DISCOUNT.TabIndex = 45
        Me.DISCOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(756, 209)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 21)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "الأجمالي :"
        '
        'TOTAL
        '
        Me.TOTAL.BackColor = System.Drawing.Color.White
        Me.TOTAL.Enabled = False
        Me.TOTAL.Location = New System.Drawing.Point(656, 206)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(94, 29)
        Me.TOTAL.TabIndex = 44
        Me.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ACTIVE_MAML
        '
        Me.ACTIVE_MAML.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACTIVE_MAML.Appearance.Options.UseFont = True
        Me.ACTIVE_MAML.ImageOptions.Image = CType(resources.GetObject("ACTIVE_MAML.ImageOptions.Image"), System.Drawing.Image)
        Me.ACTIVE_MAML.Location = New System.Drawing.Point(170, 16)
        Me.ACTIVE_MAML.Name = "ACTIVE_MAML"
        Me.ACTIVE_MAML.Size = New System.Drawing.Size(42, 44)
        Me.ACTIVE_MAML.TabIndex = 39
        Me.ACTIVE_MAML.Visible = False
        '
        'TH_PRICE
        '
        Me.TH_PRICE.BackColor = System.Drawing.Color.White
        Me.TH_PRICE.Enabled = False
        Me.TH_PRICE.Location = New System.Drawing.Point(218, 23)
        Me.TH_PRICE.Name = "TH_PRICE"
        Me.TH_PRICE.Size = New System.Drawing.Size(127, 29)
        Me.TH_PRICE.TabIndex = 38
        Me.TH_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TH_PRICE.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(351, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 21)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "قيمة التحليل :"
        Me.Label10.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(720, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 21)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "أسم التحليل :"
        Me.Label9.Visible = False
        '
        'TH_NAME
        '
        Me.TH_NAME.FormattingEnabled = True
        Me.TH_NAME.Items.AddRange(New Object() {"معمل", "عيادة"})
        Me.TH_NAME.Location = New System.Drawing.Point(489, 25)
        Me.TH_NAME.Name = "TH_NAME"
        Me.TH_NAME.Size = New System.Drawing.Size(224, 29)
        Me.TH_NAME.TabIndex = 35
        Me.TH_NAME.Visible = False
        '
        'TH_CODE
        '
        Me.TH_CODE.BackColor = System.Drawing.Color.White
        Me.TH_CODE.Enabled = False
        Me.TH_CODE.Location = New System.Drawing.Point(462, 28)
        Me.TH_CODE.Name = "TH_CODE"
        Me.TH_CODE.Size = New System.Drawing.Size(21, 29)
        Me.TH_CODE.TabIndex = 34
        Me.TH_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TH_CODE.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column0, Me.Column6, Me.Column1, Me.Column3, Me.Column4, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(821, 184)
        Me.DataGridView1.TabIndex = 33
        '
        'Column7
        '
        Me.Column7.HeaderText = "كود الأيصال"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column0
        '
        Me.Column0.FillWeight = 20.0!
        Me.Column0.HeaderText = "م"
        Me.Column0.Name = "Column0"
        Me.Column0.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "كود المعمل"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "كود التحليل"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "أسم التحليل"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 50.0!
        Me.Column4.HeaderText = "السعر"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 60.0!
        Me.Column2.HeaderText = "أسم المعمل"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'TIMEREDIT
        '
        '
        'TIMERADD
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 493)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(855, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 34
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
        'ADD_MONY_MAML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 515)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GRBTN)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ADD_MONY_MAML"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "أستلام نقدية معمل"
        Me.GRBTN.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GRBTN As GroupBox
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PRINTBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UNDOBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SEARCHBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DELETBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EDITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SAVEBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NEWBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents KHAZINA_CODE As TextBox
    Friend WithEvents KHAZINA_NAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DATE As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_AGE As TextBox
    Friend WithEvents TXT_PA_TYPE As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PA_NAME As ComboBox
    Friend WithEvents PA_CODE As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents MAML_NAME As ComboBox
    Friend WithEvents MAML_CODE As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ACTIVE_MAML As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TH_PRICE As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TH_NAME As ComboBox
    Friend WithEvents TH_CODE As TextBox
    Friend WithEvents SAFY_AR As TextBox
    Friend WithEvents SAFY As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DISCOUNT As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TOTAL As TextBox
    Friend WithEvents TIMEREDIT As Timer
    Friend WithEvents TIMERADD As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents USER_ADD As ToolStripStatusLabel
    Friend WithEvents DATE_ADD As ToolStripStatusLabel
    Friend WithEvents TIME_ADD As ToolStripStatusLabel
    Friend WithEvents EDITNAMEBT As ToolStripStatusLabel
    Friend WithEvents USER_EDIT As ToolStripStatusLabel
    Friend WithEvents DATE_EDIT As ToolStripStatusLabel
    Friend WithEvents TIME_EDIT As ToolStripStatusLabel
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_M As TextBox
    Friend WithEvents TXT_CODE2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents TXT_BAKY As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_MONY As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_TYPEMONY As ComboBox
End Class
