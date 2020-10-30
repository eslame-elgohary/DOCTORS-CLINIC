<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADD_MONY_T3AQOD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_MONY_T3AQOD))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KHAZINA_CODE = New System.Windows.Forms.TextBox()
        Me.KHAZINA_NAME = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_T3AQOD_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_PA_CODE2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_PA_TEL = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_NUMPER_CARD_PA = New System.Windows.Forms.TextBox()
        Me.TXT_PA_NAME = New System.Windows.Forms.ComboBox()
        Me.PATIENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
        Me.TXT_T3AQOD_NAME = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_DOCTOR = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_TKHASOS = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_DOCTOR_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_TKHASOS_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_ACTION = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_COVER = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_ADD_ACTION = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_MONY_PA = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXT_MONY_GHA = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXT_MONY_ACTION = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRBTN = New System.Windows.Forms.GroupBox()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.PRINTBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.UNDOBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SEARCHBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.DELETBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.EDITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.NEWBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXT_RASED_NEW = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_BAKY = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TXT_MONY = New System.Windows.Forms.TextBox()
        Me.TXT_RASED = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.SAFY_AR = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXT_TYPEMONY = New System.Windows.Forms.ComboBox()
        Me.TXT_TOTAL_PA = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TXT_TOTAL_GHA = New System.Windows.Forms.TextBox()
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
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        Me.TXT_ADD = New System.Windows.Forms.TextBox()
        Me.TXT_ALL = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRBTN.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Controls.Add(Me.KHAZINA_CODE)
        Me.GroupBox1.Controls.Add(Me.KHAZINA_NAME)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_T3AQOD_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_CODE2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_TEL)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_NUMPER_CARD_PA)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_NAME)
        Me.GroupBox1.Controls.Add(Me.TXT_T3AQOD_NAME)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_DOCTOR)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHASOS)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_DOCTOR_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHASOS_CODE)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1073, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'KHAZINA_CODE
        '
        Me.KHAZINA_CODE.BackColor = System.Drawing.Color.White
        Me.KHAZINA_CODE.Enabled = False
        Me.KHAZINA_CODE.Location = New System.Drawing.Point(110, 22)
        Me.KHAZINA_CODE.Name = "KHAZINA_CODE"
        Me.KHAZINA_CODE.Size = New System.Drawing.Size(23, 29)
        Me.KHAZINA_CODE.TabIndex = 41
        Me.KHAZINA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.KHAZINA_CODE.Visible = False
        '
        'KHAZINA_NAME
        '
        Me.KHAZINA_NAME.BackColor = System.Drawing.Color.White
        Me.KHAZINA_NAME.Enabled = False
        Me.KHAZINA_NAME.Location = New System.Drawing.Point(11, 17)
        Me.KHAZINA_NAME.Name = "KHAZINA_NAME"
        Me.KHAZINA_NAME.Size = New System.Drawing.Size(197, 29)
        Me.KHAZINA_NAME.TabIndex = 40
        Me.KHAZINA_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(214, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(92, 21)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "أسم الخزينة :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(306, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "رقم الكارنية :"
        '
        'TXT_T3AQOD_CODE
        '
        Me.TXT_T3AQOD_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_T3AQOD_CODE.Enabled = False
        Me.TXT_T3AQOD_CODE.Location = New System.Drawing.Point(441, 28)
        Me.TXT_T3AQOD_CODE.Name = "TXT_T3AQOD_CODE"
        Me.TXT_T3AQOD_CODE.Size = New System.Drawing.Size(69, 29)
        Me.TXT_T3AQOD_CODE.TabIndex = 36
        Me.TXT_T3AQOD_CODE.Visible = False
        '
        'TXT_PA_CODE2
        '
        Me.TXT_PA_CODE2.BackColor = System.Drawing.Color.White
        Me.TXT_PA_CODE2.Enabled = False
        Me.TXT_PA_CODE2.Location = New System.Drawing.Point(8, 60)
        Me.TXT_PA_CODE2.Name = "TXT_PA_CODE2"
        Me.TXT_PA_CODE2.Size = New System.Drawing.Size(98, 29)
        Me.TXT_PA_CODE2.TabIndex = 25
        Me.TXT_PA_CODE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(110, 64)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 21)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "رقم الملف :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(398, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 21)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "تليفون المريض :"
        '
        'TXT_PA_TEL
        '
        Me.TXT_PA_TEL.BackColor = System.Drawing.Color.White
        Me.TXT_PA_TEL.Enabled = False
        Me.TXT_PA_TEL.Location = New System.Drawing.Point(200, 61)
        Me.TXT_PA_TEL.Name = "TXT_PA_TEL"
        Me.TXT_PA_TEL.Size = New System.Drawing.Size(192, 29)
        Me.TXT_PA_TEL.TabIndex = 22
        Me.TXT_PA_TEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(621, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "كود المريض :"
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_PA_CODE.Enabled = False
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(517, 60)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(100, 29)
        Me.TXT_PA_CODE.TabIndex = 20
        Me.TXT_PA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NUMPER_CARD_PA
        '
        Me.TXT_NUMPER_CARD_PA.BackColor = System.Drawing.Color.Aqua
        Me.TXT_NUMPER_CARD_PA.Location = New System.Drawing.Point(8, 99)
        Me.TXT_NUMPER_CARD_PA.Name = "TXT_NUMPER_CARD_PA"
        Me.TXT_NUMPER_CARD_PA.Size = New System.Drawing.Size(292, 29)
        Me.TXT_NUMPER_CARD_PA.TabIndex = 14
        Me.TXT_NUMPER_CARD_PA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_PA_NAME
        '
        Me.TXT_PA_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_PA_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_PA_NAME.BackColor = System.Drawing.Color.Aqua
        Me.TXT_PA_NAME.DataSource = Me.PATIENTBindingSource
        Me.TXT_PA_NAME.DisplayMember = "PA_NAME"
        Me.TXT_PA_NAME.FormattingEnabled = True
        Me.TXT_PA_NAME.Location = New System.Drawing.Point(725, 61)
        Me.TXT_PA_NAME.Name = "TXT_PA_NAME"
        Me.TXT_PA_NAME.Size = New System.Drawing.Size(235, 29)
        Me.TXT_PA_NAME.TabIndex = 13
        Me.TXT_PA_NAME.ValueMember = "PA_NAME"
        '
        'PATIENTBindingSource
        '
        Me.PATIENTBindingSource.DataMember = "PATIENT"
        Me.PATIENTBindingSource.DataSource = Me.PATIENTDATA
        Me.PATIENTBindingSource.Filter = "STAT=TRUE"
        '
        'PATIENTDATA
        '
        Me.PATIENTDATA.DataSetName = "PATIENTDATA"
        Me.PATIENTDATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXT_T3AQOD_NAME
        '
        Me.TXT_T3AQOD_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_T3AQOD_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_T3AQOD_NAME.BackColor = System.Drawing.Color.Aqua
        Me.TXT_T3AQOD_NAME.FormattingEnabled = True
        Me.TXT_T3AQOD_NAME.Location = New System.Drawing.Point(312, 17)
        Me.TXT_T3AQOD_NAME.Name = "TXT_T3AQOD_NAME"
        Me.TXT_T3AQOD_NAME.Size = New System.Drawing.Size(235, 29)
        Me.TXT_T3AQOD_NAME.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(553, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "جهة التعاقد :"
        '
        'TXT_DOCTOR
        '
        Me.TXT_DOCTOR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_DOCTOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_DOCTOR.BackColor = System.Drawing.Color.Aqua
        Me.TXT_DOCTOR.FormattingEnabled = True
        Me.TXT_DOCTOR.Location = New System.Drawing.Point(410, 100)
        Me.TXT_DOCTOR.Name = "TXT_DOCTOR"
        Me.TXT_DOCTOR.Size = New System.Drawing.Size(227, 29)
        Me.TXT_DOCTOR.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(643, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "الطبيب :"
        '
        'TXT_TKHASOS
        '
        Me.TXT_TKHASOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_TKHASOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_TKHASOS.BackColor = System.Drawing.Color.Aqua
        Me.TXT_TKHASOS.FormattingEnabled = True
        Me.TXT_TKHASOS.Location = New System.Drawing.Point(726, 100)
        Me.TXT_TKHASOS.Name = "TXT_TKHASOS"
        Me.TXT_TKHASOS.Size = New System.Drawing.Size(235, 29)
        Me.TXT_TKHASOS.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(967, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "التخصص :"
        '
        'TXT_DATE
        '
        Me.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE.Location = New System.Drawing.Point(650, 18)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.Size = New System.Drawing.Size(152, 29)
        Me.TXT_DATE.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(974, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "رقم الأيصال :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(869, 18)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(104, 29)
        Me.TXT_CODE.TabIndex = 0
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(808, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "التاريخ :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(965, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "أسم المريض :"
        '
        'TXT_DOCTOR_CODE
        '
        Me.TXT_DOCTOR_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_DOCTOR_CODE.Enabled = False
        Me.TXT_DOCTOR_CODE.Location = New System.Drawing.Point(540, 91)
        Me.TXT_DOCTOR_CODE.Name = "TXT_DOCTOR_CODE"
        Me.TXT_DOCTOR_CODE.Size = New System.Drawing.Size(69, 29)
        Me.TXT_DOCTOR_CODE.TabIndex = 38
        Me.TXT_DOCTOR_CODE.Visible = False
        '
        'TXT_TKHASOS_CODE
        '
        Me.TXT_TKHASOS_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_TKHASOS_CODE.Enabled = False
        Me.TXT_TKHASOS_CODE.Location = New System.Drawing.Point(842, 91)
        Me.TXT_TKHASOS_CODE.Name = "TXT_TKHASOS_CODE"
        Me.TXT_TKHASOS_CODE.Size = New System.Drawing.Size(69, 29)
        Me.TXT_TKHASOS_CODE.TabIndex = 37
        Me.TXT_TKHASOS_CODE.Visible = False
        '
        'TXT_ACTION
        '
        Me.TXT_ACTION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_ACTION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_ACTION.BackColor = System.Drawing.Color.Aqua
        Me.TXT_ACTION.FormattingEnabled = True
        Me.TXT_ACTION.Location = New System.Drawing.Point(738, 24)
        Me.TXT_ACTION.Name = "TXT_ACTION"
        Me.TXT_ACTION.Size = New System.Drawing.Size(213, 29)
        Me.TXT_ACTION.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(948, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "الأجراء المطلوب :"
        '
        'TXT_COVER
        '
        Me.TXT_COVER.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_COVER.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_COVER.BackColor = System.Drawing.Color.Aqua
        Me.TXT_COVER.FormattingEnabled = True
        Me.TXT_COVER.Location = New System.Drawing.Point(540, 24)
        Me.TXT_COVER.Name = "TXT_COVER"
        Me.TXT_COVER.Size = New System.Drawing.Size(129, 29)
        Me.TXT_COVER.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(667, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "التغطية :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.CadetBlue
        Me.GroupBox2.Controls.Add(Me.BTN_ADD_ACTION)
        Me.GroupBox2.Controls.Add(Me.TXT_MONY_PA)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TXT_MONY_GHA)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TXT_MONY_ACTION)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TXT_ACTION)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TXT_COVER)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1073, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BTN_ADD_ACTION
        '
        Me.BTN_ADD_ACTION.ImageOptions.Image = CType(resources.GetObject("BTN_ADD_ACTION.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_ADD_ACTION.Location = New System.Drawing.Point(11, 19)
        Me.BTN_ADD_ACTION.Name = "BTN_ADD_ACTION"
        Me.BTN_ADD_ACTION.Size = New System.Drawing.Size(42, 40)
        Me.BTN_ADD_ACTION.TabIndex = 2
        '
        'TXT_MONY_PA
        '
        Me.TXT_MONY_PA.BackColor = System.Drawing.Color.White
        Me.TXT_MONY_PA.Enabled = False
        Me.TXT_MONY_PA.Location = New System.Drawing.Point(84, 24)
        Me.TXT_MONY_PA.Name = "TXT_MONY_PA"
        Me.TXT_MONY_PA.Size = New System.Drawing.Size(81, 29)
        Me.TXT_MONY_PA.TabIndex = 25
        Me.TXT_MONY_PA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(165, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(70, 21)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "المريض :"
        '
        'TXT_MONY_GHA
        '
        Me.TXT_MONY_GHA.BackColor = System.Drawing.Color.White
        Me.TXT_MONY_GHA.Enabled = False
        Me.TXT_MONY_GHA.Location = New System.Drawing.Point(239, 24)
        Me.TXT_MONY_GHA.Name = "TXT_MONY_GHA"
        Me.TXT_MONY_GHA.Size = New System.Drawing.Size(74, 29)
        Me.TXT_MONY_GHA.TabIndex = 23
        Me.TXT_MONY_GHA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(313, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 21)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "الجهة :"
        '
        'TXT_MONY_ACTION
        '
        Me.TXT_MONY_ACTION.BackColor = System.Drawing.Color.White
        Me.TXT_MONY_ACTION.Enabled = False
        Me.TXT_MONY_ACTION.Location = New System.Drawing.Point(369, 24)
        Me.TXT_MONY_ACTION.Name = "TXT_MONY_ACTION"
        Me.TXT_MONY_ACTION.Size = New System.Drawing.Size(80, 29)
        Me.TXT_MONY_ACTION.TabIndex = 21
        Me.TXT_MONY_ACTION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(446, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 21)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "قيمة الأجراء :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 199)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1073, 167)
        Me.DataGridView1.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "أسم الخدمة"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 40.0!
        Me.Column2.HeaderText = "قيمة الخدمة"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column3
        '
        Me.Column3.FillWeight = 40.0!
        Me.Column3.HeaderText = "نسبة الجهة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.FillWeight = 40.0!
        Me.Column4.HeaderText = "نسبة المريض"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
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
        Me.GRBTN.Location = New System.Drawing.Point(1, 494)
        Me.GRBTN.Name = "GRBTN"
        Me.GRBTN.Size = New System.Drawing.Size(1073, 72)
        Me.GRBTN.TabIndex = 8
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
        Me.PRINTBTN.Location = New System.Drawing.Point(99, 20)
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
        Me.UNDOBTN.Location = New System.Drawing.Point(241, 20)
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
        Me.SEARCHBTN.Location = New System.Drawing.Point(393, 20)
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
        Me.DELETBTN.Location = New System.Drawing.Point(535, 20)
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
        Me.EDITBTN.Location = New System.Drawing.Point(677, 20)
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
        Me.SAVEBTN.Location = New System.Drawing.Point(819, 20)
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
        Me.NEWBTN.Location = New System.Drawing.Point(961, 20)
        Me.NEWBTN.Name = "NEWBTN"
        Me.NEWBTN.Size = New System.Drawing.Size(96, 44)
        Me.NEWBTN.TabIndex = 1
        Me.NEWBTN.Text = "جديد"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.TXT_RASED_NEW)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.TXT_BAKY)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.TXT_MONY)
        Me.GroupBox3.Controls.Add(Me.TXT_RASED)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.SAFY_AR)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.TXT_TYPEMONY)
        Me.GroupBox3.Controls.Add(Me.TXT_TOTAL_PA)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TXT_TOTAL)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.TXT_TOTAL_GHA)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(0, 366)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1073, 131)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(740, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(100, 21)
        Me.Label24.TabIndex = 79
        Me.Label24.Text = "أجمالي الجهة :"
        '
        'TXT_RASED_NEW
        '
        Me.TXT_RASED_NEW.BackColor = System.Drawing.Color.White
        Me.TXT_RASED_NEW.Enabled = False
        Me.TXT_RASED_NEW.Location = New System.Drawing.Point(27, 52)
        Me.TXT_RASED_NEW.Name = "TXT_RASED_NEW"
        Me.TXT_RASED_NEW.Size = New System.Drawing.Size(163, 29)
        Me.TXT_RASED_NEW.TabIndex = 77
        Me.TXT_RASED_NEW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(196, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 21)
        Me.Label20.TabIndex = 78
        Me.Label20.Text = "الرصيد الحالي :"
        '
        'TXT_BAKY
        '
        Me.TXT_BAKY.BackColor = System.Drawing.Color.White
        Me.TXT_BAKY.Enabled = False
        Me.TXT_BAKY.Location = New System.Drawing.Point(334, 54)
        Me.TXT_BAKY.Name = "TXT_BAKY"
        Me.TXT_BAKY.Size = New System.Drawing.Size(153, 29)
        Me.TXT_BAKY.TabIndex = 75
        Me.TXT_BAKY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(493, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 21)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "المتبقي :"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(740, 57)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 21)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "المدفوع :"
        '
        'TXT_MONY
        '
        Me.TXT_MONY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_MONY.Location = New System.Drawing.Point(593, 54)
        Me.TXT_MONY.Name = "TXT_MONY"
        Me.TXT_MONY.Size = New System.Drawing.Size(137, 29)
        Me.TXT_MONY.TabIndex = 73
        Me.TXT_MONY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_RASED
        '
        Me.TXT_RASED.BackColor = System.Drawing.Color.White
        Me.TXT_RASED.Enabled = False
        Me.TXT_RASED.Location = New System.Drawing.Point(825, 51)
        Me.TXT_RASED.Name = "TXT_RASED"
        Me.TXT_RASED.Size = New System.Drawing.Size(132, 29)
        Me.TXT_RASED.TabIndex = 71
        Me.TXT_RASED.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(965, 55)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 21)
        Me.Label22.TabIndex = 72
        Me.Label22.Text = "رصيد سابق :"
        '
        'SAFY_AR
        '
        Me.SAFY_AR.BackColor = System.Drawing.Color.White
        Me.SAFY_AR.Enabled = False
        Me.SAFY_AR.Location = New System.Drawing.Point(27, 91)
        Me.SAFY_AR.Name = "SAFY_AR"
        Me.SAFY_AR.Size = New System.Drawing.Size(1029, 29)
        Me.SAFY_AR.TabIndex = 70
        Me.SAFY_AR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(200, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(78, 21)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "نوع الدفع :"
        '
        'TXT_TYPEMONY
        '
        Me.TXT_TYPEMONY.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_TYPEMONY.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_TYPEMONY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_TYPEMONY.FormattingEnabled = True
        Me.TXT_TYPEMONY.Items.AddRange(New Object() {"نقدي", "فيزا", "بريميوم كارد"})
        Me.TXT_TYPEMONY.Location = New System.Drawing.Point(27, 17)
        Me.TXT_TYPEMONY.Name = "TXT_TYPEMONY"
        Me.TXT_TYPEMONY.Size = New System.Drawing.Size(163, 29)
        Me.TXT_TYPEMONY.TabIndex = 61
        '
        'TXT_TOTAL_PA
        '
        Me.TXT_TOTAL_PA.BackColor = System.Drawing.Color.White
        Me.TXT_TOTAL_PA.Enabled = False
        Me.TXT_TOTAL_PA.Location = New System.Drawing.Point(288, 17)
        Me.TXT_TOTAL_PA.Name = "TXT_TOTAL_PA"
        Me.TXT_TOTAL_PA.Size = New System.Drawing.Size(128, 29)
        Me.TXT_TOTAL_PA.TabIndex = 27
        Me.TXT_TOTAL_PA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(426, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(157, 21)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "المطلوب من المريض :"
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.BackColor = System.Drawing.Color.White
        Me.TXT_TOTAL.Enabled = False
        Me.TXT_TOTAL.Location = New System.Drawing.Point(850, 17)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.Size = New System.Drawing.Size(128, 29)
        Me.TXT_TOTAL.TabIndex = 23
        Me.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(988, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 21)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "الأجمالى :"
        '
        'TXT_TOTAL_GHA
        '
        Me.TXT_TOTAL_GHA.BackColor = System.Drawing.Color.White
        Me.TXT_TOTAL_GHA.Enabled = False
        Me.TXT_TOTAL_GHA.Location = New System.Drawing.Point(593, 17)
        Me.TXT_TOTAL_GHA.Name = "TXT_TOTAL_GHA"
        Me.TXT_TOTAL_GHA.Size = New System.Drawing.Size(137, 29)
        Me.TXT_TOTAL_GHA.TabIndex = 25
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 582)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1073, 22)
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
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'TXT_ADD
        '
        Me.TXT_ADD.BackColor = System.Drawing.Color.White
        Me.TXT_ADD.Enabled = False
        Me.TXT_ADD.Location = New System.Drawing.Point(64, 248)
        Me.TXT_ADD.Name = "TXT_ADD"
        Me.TXT_ADD.Size = New System.Drawing.Size(42, 29)
        Me.TXT_ADD.TabIndex = 73
        Me.TXT_ADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ADD.Visible = False
        '
        'TXT_ALL
        '
        Me.TXT_ALL.BackColor = System.Drawing.Color.White
        Me.TXT_ALL.Enabled = False
        Me.TXT_ALL.Location = New System.Drawing.Point(61, 283)
        Me.TXT_ALL.Name = "TXT_ALL"
        Me.TXT_ALL.Size = New System.Drawing.Size(42, 29)
        Me.TXT_ALL.TabIndex = 72
        Me.TXT_ALL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ALL.Visible = False
        '
        'ADD_MONY_T3AQOD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1073, 604)
        Me.ControlBox = False
        Me.Controls.Add(Me.TXT_ADD)
        Me.Controls.Add(Me.TXT_ALL)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GRBTN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ADD_MONY_T3AQOD"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = resources.GetString("$this.Text")
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PATIENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRBTN.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_DATE As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents TXT_DOCTOR As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_TKHASOS As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_NUMPER_CARD_PA As TextBox
    Friend WithEvents TXT_PA_NAME As ComboBox
    Friend WithEvents TXT_T3AQOD_NAME As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_ACTION As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_PA_TEL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents TXT_COVER As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXT_PA_CODE2 As TextBox
    Friend WithEvents TXT_MONY_PA As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXT_MONY_GHA As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXT_MONY_ACTION As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents BTN_ADD_ACTION As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GRBTN As GroupBox
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PRINTBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UNDOBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SEARCHBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DELETBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EDITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SAVEBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NEWBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXT_TOTAL_PA As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TXT_TOTAL_GHA As TextBox
    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents Label16 As Label
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
    Friend WithEvents TXT_DOCTOR_CODE As TextBox
    Friend WithEvents TXT_TKHASOS_CODE As TextBox
    Friend WithEvents TXT_T3AQOD_CODE As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents TXT_TYPEMONY As ComboBox
    Friend WithEvents TXT_RASED_NEW As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TXT_BAKY As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TXT_MONY As TextBox
    Friend WithEvents TXT_RASED As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents SAFY_AR As TextBox
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTBindingSource As BindingSource
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
    Friend WithEvents KHAZINA_CODE As TextBox
    Friend WithEvents KHAZINA_NAME As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TXT_ADD As TextBox
    Friend WithEvents TXT_ALL As TextBox
    Friend WithEvents Label24 As Label
End Class
