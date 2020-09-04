<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADD_MONY_DOCTOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_MONY_DOCTOR))
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
        Me.LAST_COME = New DevExpress.XtraEditors.SimpleButton()
        Me.CODE_DOCTOR = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXT_DOCTOR = New System.Windows.Forms.ComboBox()
        Me.TA_CODE_TKHASOS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TA_TKHASOS = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_AGE = New System.Windows.Forms.TextBox()
        Me.TXT_PA_TYPE = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PA_NAME = New System.Windows.Forms.ComboBox()
        Me.PATION_BINDING = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_TYPEMONY = New System.Windows.Forms.ComboBox()
        Me.TXT_M = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ACTIVE_DOCTOR = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_PRICE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_ACTION = New System.Windows.Forms.ComboBox()
        Me.TXT_ACTION_CODE = New System.Windows.Forms.TextBox()
        Me.SAFY_AR = New System.Windows.Forms.TextBox()
        Me.SAFY = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DISCOUNT = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TOTAL = New System.Windows.Forms.TextBox()
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
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        Me.GRBTN.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UNDOBTN.Visible = False
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
        Me.DELETBTN.Visible = False
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
        Me.EDITBTN.Visible = False
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
        Me.GroupBox1.Controls.Add(Me.LAST_COME)
        Me.GroupBox1.Controls.Add(Me.CODE_DOCTOR)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.TXT_DOCTOR)
        Me.GroupBox1.Controls.Add(Me.TA_CODE_TKHASOS)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TA_TKHASOS)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 142)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'LAST_COME
        '
        Me.LAST_COME.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAST_COME.Appearance.Options.UseFont = True
        Me.LAST_COME.ImageOptions.Image = CType(resources.GetObject("LAST_COME.ImageOptions.Image"), System.Drawing.Image)
        Me.LAST_COME.Location = New System.Drawing.Point(9, 100)
        Me.LAST_COME.Name = "LAST_COME"
        Me.LAST_COME.Size = New System.Drawing.Size(162, 35)
        Me.LAST_COME.TabIndex = 59
        Me.LAST_COME.Text = "أخر زيارة للمريض"
        '
        'CODE_DOCTOR
        '
        Me.CODE_DOCTOR.BackColor = System.Drawing.Color.White
        Me.CODE_DOCTOR.Enabled = False
        Me.CODE_DOCTOR.Location = New System.Drawing.Point(365, 92)
        Me.CODE_DOCTOR.Name = "CODE_DOCTOR"
        Me.CODE_DOCTOR.Size = New System.Drawing.Size(21, 29)
        Me.CODE_DOCTOR.TabIndex = 65
        Me.CODE_DOCTOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.CODE_DOCTOR.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(391, 101)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 21)
        Me.Label16.TabIndex = 64
        Me.Label16.Text = "أسم الطبيب :"
        '
        'TXT_DOCTOR
        '
        Me.TXT_DOCTOR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_DOCTOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_DOCTOR.BackColor = System.Drawing.Color.Aqua
        Me.TXT_DOCTOR.FormattingEnabled = True
        Me.TXT_DOCTOR.Location = New System.Drawing.Point(186, 99)
        Me.TXT_DOCTOR.Name = "TXT_DOCTOR"
        Me.TXT_DOCTOR.Size = New System.Drawing.Size(200, 29)
        Me.TXT_DOCTOR.TabIndex = 63
        '
        'TA_CODE_TKHASOS
        '
        Me.TA_CODE_TKHASOS.BackColor = System.Drawing.Color.White
        Me.TA_CODE_TKHASOS.Enabled = False
        Me.TA_CODE_TKHASOS.Location = New System.Drawing.Point(786, 97)
        Me.TA_CODE_TKHASOS.Name = "TA_CODE_TKHASOS"
        Me.TA_CODE_TKHASOS.Size = New System.Drawing.Size(21, 29)
        Me.TA_CODE_TKHASOS.TabIndex = 62
        Me.TA_CODE_TKHASOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TA_CODE_TKHASOS.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(711, 100)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 21)
        Me.Label12.TabIndex = 61
        Me.Label12.Text = "التخصص :"
        '
        'TA_TKHASOS
        '
        Me.TA_TKHASOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TA_TKHASOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TA_TKHASOS.BackColor = System.Drawing.Color.Aqua
        Me.TA_TKHASOS.FormattingEnabled = True
        Me.TA_TKHASOS.Location = New System.Drawing.Point(506, 98)
        Me.TA_TKHASOS.Name = "TA_TKHASOS"
        Me.TA_TKHASOS.Size = New System.Drawing.Size(200, 29)
        Me.TA_TKHASOS.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 21)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "العمر :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(212, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 21)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "النوع :"
        '
        'TXT_AGE
        '
        Me.TXT_AGE.BackColor = System.Drawing.Color.White
        Me.TXT_AGE.Enabled = False
        Me.TXT_AGE.Location = New System.Drawing.Point(9, 66)
        Me.TXT_AGE.Name = "TXT_AGE"
        Me.TXT_AGE.Size = New System.Drawing.Size(55, 29)
        Me.TXT_AGE.TabIndex = 57
        Me.TXT_AGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_PA_TYPE
        '
        Me.TXT_PA_TYPE.BackColor = System.Drawing.Color.White
        Me.TXT_PA_TYPE.Enabled = False
        Me.TXT_PA_TYPE.Location = New System.Drawing.Point(128, 64)
        Me.TXT_PA_TYPE.Name = "TXT_PA_TYPE"
        Me.TXT_PA_TYPE.Size = New System.Drawing.Size(78, 29)
        Me.TXT_PA_TYPE.TabIndex = 56
        Me.TXT_PA_TYPE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.PA_NAME.BackColor = System.Drawing.Color.Aqua
        Me.PA_NAME.DataSource = Me.PATION_BINDING
        Me.PA_NAME.DisplayMember = "PA_NAME"
        Me.PA_NAME.FormattingEnabled = True
        Me.PA_NAME.Location = New System.Drawing.Point(294, 63)
        Me.PA_NAME.Name = "PA_NAME"
        Me.PA_NAME.Size = New System.Drawing.Size(224, 29)
        Me.PA_NAME.TabIndex = 54
        Me.PA_NAME.ValueMember = "PA_NAME"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(259, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 50)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "+"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TXT_TYPEMONY)
        Me.GroupBox2.Controls.Add(Me.TXT_M)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Controls.Add(Me.ACTIVE_DOCTOR)
        Me.GroupBox2.Controls.Add(Me.TXT_PRICE)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TXT_ACTION)
        Me.GroupBox2.Controls.Add(Me.TXT_ACTION_CODE)
        Me.GroupBox2.Controls.Add(Me.SAFY_AR)
        Me.GroupBox2.Controls.Add(Me.SAFY)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.DISCOUNT)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TOTAL)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 148)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(832, 276)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(173, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 21)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "نوع الدفع :"
        '
        'TXT_TYPEMONY
        '
        Me.TXT_TYPEMONY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_TYPEMONY.FormattingEnabled = True
        Me.TXT_TYPEMONY.Items.AddRange(New Object() {"نقدي", "فيزا", "بريميوم كارد"})
        Me.TXT_TYPEMONY.Location = New System.Drawing.Point(8, 205)
        Me.TXT_TYPEMONY.Name = "TXT_TYPEMONY"
        Me.TXT_TYPEMONY.Size = New System.Drawing.Size(163, 29)
        Me.TXT_TYPEMONY.TabIndex = 59
        '
        'TXT_M
        '
        Me.TXT_M.BackColor = System.Drawing.Color.White
        Me.TXT_M.Enabled = False
        Me.TXT_M.Location = New System.Drawing.Point(461, 21)
        Me.TXT_M.Name = "TXT_M"
        Me.TXT_M.Size = New System.Drawing.Size(21, 29)
        Me.TXT_M.TabIndex = 58
        Me.TXT_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_M.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column5, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 60)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(815, 135)
        Me.DataGridView1.TabIndex = 57
        '
        'Column1
        '
        Me.Column1.HeaderText = "كود الخدمة"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column5
        '
        Me.Column5.FillWeight = 15.0!
        Me.Column5.HeaderText = "م"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "أسم الخدمة"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 50.0!
        Me.Column3.HeaderText = "قيمة الخدمة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 25.0!
        Me.Column4.HeaderText = "-"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Visible = False
        '
        'ACTIVE_DOCTOR
        '
        Me.ACTIVE_DOCTOR.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACTIVE_DOCTOR.Appearance.Options.UseFont = True
        Me.ACTIVE_DOCTOR.ImageOptions.Image = CType(resources.GetObject("ACTIVE_DOCTOR.ImageOptions.Image"), System.Drawing.Image)
        Me.ACTIVE_DOCTOR.Location = New System.Drawing.Point(301, 20)
        Me.ACTIVE_DOCTOR.Name = "ACTIVE_DOCTOR"
        Me.ACTIVE_DOCTOR.Size = New System.Drawing.Size(42, 35)
        Me.ACTIVE_DOCTOR.TabIndex = 56
        '
        'TXT_PRICE
        '
        Me.TXT_PRICE.BackColor = System.Drawing.Color.White
        Me.TXT_PRICE.Enabled = False
        Me.TXT_PRICE.Location = New System.Drawing.Point(357, 26)
        Me.TXT_PRICE.Name = "TXT_PRICE"
        Me.TXT_PRICE.Size = New System.Drawing.Size(90, 29)
        Me.TXT_PRICE.TabIndex = 55
        Me.TXT_PRICE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(453, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 21)
        Me.Label11.TabIndex = 54
        Me.Label11.Text = "قيمة الخدمة :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(734, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 21)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "نوع الخدمة :"
        '
        'TXT_ACTION
        '
        Me.TXT_ACTION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_ACTION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_ACTION.BackColor = System.Drawing.Color.Aqua
        Me.TXT_ACTION.FormattingEnabled = True
        Me.TXT_ACTION.Location = New System.Drawing.Point(555, 25)
        Me.TXT_ACTION.Name = "TXT_ACTION"
        Me.TXT_ACTION.Size = New System.Drawing.Size(173, 29)
        Me.TXT_ACTION.TabIndex = 52
        '
        'TXT_ACTION_CODE
        '
        Me.TXT_ACTION_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_ACTION_CODE.Enabled = False
        Me.TXT_ACTION_CODE.Location = New System.Drawing.Point(525, 25)
        Me.TXT_ACTION_CODE.Name = "TXT_ACTION_CODE"
        Me.TXT_ACTION_CODE.Size = New System.Drawing.Size(21, 29)
        Me.TXT_ACTION_CODE.TabIndex = 51
        Me.TXT_ACTION_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ACTION_CODE.Visible = False
        '
        'SAFY_AR
        '
        Me.SAFY_AR.BackColor = System.Drawing.Color.White
        Me.SAFY_AR.Enabled = False
        Me.SAFY_AR.Location = New System.Drawing.Point(9, 241)
        Me.SAFY_AR.Name = "SAFY_AR"
        Me.SAFY_AR.Size = New System.Drawing.Size(794, 29)
        Me.SAFY_AR.TabIndex = 49
        Me.SAFY_AR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SAFY
        '
        Me.SAFY.BackColor = System.Drawing.Color.White
        Me.SAFY.Enabled = False
        Me.SAFY.Location = New System.Drawing.Point(262, 205)
        Me.SAFY.Name = "SAFY"
        Me.SAFY.Size = New System.Drawing.Size(117, 29)
        Me.SAFY.TabIndex = 46
        Me.SAFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(385, 209)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 21)
        Me.Label19.TabIndex = 48
        Me.Label19.Text = "الصافي :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(562, 209)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 21)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "الخصم :"
        '
        'DISCOUNT
        '
        Me.DISCOUNT.BackColor = System.Drawing.Color.Aqua
        Me.DISCOUNT.Location = New System.Drawing.Point(455, 206)
        Me.DISCOUNT.Name = "DISCOUNT"
        Me.DISCOUNT.Size = New System.Drawing.Size(105, 29)
        Me.DISCOUNT.TabIndex = 45
        Me.DISCOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(740, 209)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 21)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "الأجمالي :"
        '
        'TOTAL
        '
        Me.TOTAL.BackColor = System.Drawing.Color.White
        Me.TOTAL.Enabled = False
        Me.TOTAL.Location = New System.Drawing.Point(627, 206)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(107, 29)
        Me.TOTAL.TabIndex = 44
        Me.TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 492)
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
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'ADD_MONY_DOCTOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 514)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GRBTN)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ADD_MONY_DOCTOR"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "أستلام نقدية عيادات"
        Me.GRBTN.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SAFY_AR As TextBox
    Friend WithEvents SAFY As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents DISCOUNT As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TOTAL As TextBox
    Friend WithEvents TA_CODE_TKHASOS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TA_TKHASOS As ComboBox
    Friend WithEvents CODE_DOCTOR As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TXT_DOCTOR As ComboBox
    Friend WithEvents ACTIVE_DOCTOR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_PRICE As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_ACTION As ComboBox
    Friend WithEvents TXT_ACTION_CODE As TextBox
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXT_M As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LAST_COME As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
    Friend WithEvents TXT_TYPEMONY As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PATION_BINDING As BindingSource
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
End Class
