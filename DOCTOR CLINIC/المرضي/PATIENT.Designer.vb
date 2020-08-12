<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PATIENT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PATIENT))
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
        Me.PA_NAME = New System.Windows.Forms.ComboBox()
        Me.PATION_BINDING = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
        Me.PA_CHI_R1 = New System.Windows.Forms.CheckBox()
        Me.PA_OP_R1 = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PA_TYPE = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PA_CODE2 = New System.Windows.Forms.TextBox()
        Me.AUTOCHI = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PA_CHI = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PA_AGE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PA_TEL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PA_CODE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PA_OP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PA_NAME2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PA_TEL2 = New System.Windows.Forms.TextBox()
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
        Me.GRBTN.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.GRBTN.Location = New System.Drawing.Point(12, 262)
        Me.GRBTN.Name = "GRBTN"
        Me.GRBTN.Size = New System.Drawing.Size(842, 72)
        Me.GRBTN.TabIndex = 0
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
        Me.SEARCHBTN.Enabled = False
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
        Me.GroupBox1.Controls.Add(Me.PA_NAME)
        Me.GroupBox1.Controls.Add(Me.PA_CHI_R1)
        Me.GroupBox1.Controls.Add(Me.PA_OP_R1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.PA_TYPE)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.PA_AGE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.PA_TEL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PA_CODE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.PA_NAME2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.PA_TEL2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 254)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات المرضي"
        '
        'PA_NAME
        '
        Me.PA_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PA_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PA_NAME.DataSource = Me.PATION_BINDING
        Me.PA_NAME.DisplayMember = "PA_NAME"
        Me.PA_NAME.FormattingEnabled = True
        Me.PA_NAME.Location = New System.Drawing.Point(273, 24)
        Me.PA_NAME.Name = "PA_NAME"
        Me.PA_NAME.Size = New System.Drawing.Size(264, 29)
        Me.PA_NAME.TabIndex = 26
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
        'PA_CHI_R1
        '
        Me.PA_CHI_R1.AutoSize = True
        Me.PA_CHI_R1.Location = New System.Drawing.Point(641, 202)
        Me.PA_CHI_R1.Name = "PA_CHI_R1"
        Me.PA_CHI_R1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PA_CHI_R1.Size = New System.Drawing.Size(129, 25)
        Me.PA_CHI_R1.TabIndex = 25
        Me.PA_CHI_R1.Text = "هل يوجد اطفال"
        Me.PA_CHI_R1.UseVisualStyleBackColor = True
        '
        'PA_OP_R1
        '
        Me.PA_OP_R1.AutoSize = True
        Me.PA_OP_R1.Location = New System.Drawing.Point(641, 128)
        Me.PA_OP_R1.Name = "PA_OP_R1"
        Me.PA_OP_R1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PA_OP_R1.Size = New System.Drawing.Size(178, 25)
        Me.PA_OP_R1.TabIndex = 21
        Me.PA_OP_R1.Text = "هل يوجد عمليات سابقة"
        Me.PA_OP_R1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(116, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 21)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "الجنس :"
        '
        'PA_TYPE
        '
        Me.PA_TYPE.FormattingEnabled = True
        Me.PA_TYPE.Items.AddRange(New Object() {"ذكر", "أنثي"})
        Me.PA_TYPE.Location = New System.Drawing.Point(12, 67)
        Me.PA_TYPE.Name = "PA_TYPE"
        Me.PA_TYPE.Size = New System.Drawing.Size(98, 29)
        Me.PA_TYPE.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PA_CODE2)
        Me.GroupBox3.Controls.Add(Me.AUTOCHI)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.PA_CHI)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(596, 55)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'PA_CODE2
        '
        Me.PA_CODE2.Location = New System.Drawing.Point(27, 17)
        Me.PA_CODE2.Name = "PA_CODE2"
        Me.PA_CODE2.Size = New System.Drawing.Size(109, 29)
        Me.PA_CODE2.TabIndex = 26
        Me.PA_CODE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AUTOCHI
        '
        Me.AUTOCHI.AutoSize = True
        Me.AUTOCHI.Checked = True
        Me.AUTOCHI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AUTOCHI.Location = New System.Drawing.Point(6, 24)
        Me.AUTOCHI.Name = "AUTOCHI"
        Me.AUTOCHI.Size = New System.Drawing.Size(15, 14)
        Me.AUTOCHI.TabIndex = 3
        Me.AUTOCHI.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label11.Location = New System.Drawing.Point(131, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(187, 21)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "رقم ملف المريض بالعيادة : "
        '
        'PA_CHI
        '
        Me.PA_CHI.Location = New System.Drawing.Point(346, 17)
        Me.PA_CHI.Name = "PA_CHI"
        Me.PA_CHI.Size = New System.Drawing.Size(166, 29)
        Me.PA_CHI.TabIndex = 20
        Me.PA_CHI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(518, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "عددهم :"
        '
        'PA_AGE
        '
        Me.PA_AGE.Location = New System.Drawing.Point(670, 69)
        Me.PA_AGE.Name = "PA_AGE"
        Me.PA_AGE.Size = New System.Drawing.Size(65, 29)
        Me.PA_AGE.TabIndex = 3
        Me.PA_AGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(572, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "أحد الأقارب :"
        '
        'PA_TEL
        '
        Me.PA_TEL.Location = New System.Drawing.Point(12, 26)
        Me.PA_TEL.Name = "PA_TEL"
        Me.PA_TEL.Size = New System.Drawing.Size(139, 29)
        Me.PA_TEL.TabIndex = 2
        Me.PA_TEL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(543, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "أسم المريض :"
        '
        'PA_CODE
        '
        Me.PA_CODE.BackColor = System.Drawing.Color.White
        Me.PA_CODE.Enabled = False
        Me.PA_CODE.Location = New System.Drawing.Point(647, 26)
        Me.PA_CODE.Name = "PA_CODE"
        Me.PA_CODE.Size = New System.Drawing.Size(88, 29)
        Me.PA_CODE.TabIndex = 1
        Me.PA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(737, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "كود المريض :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(738, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 21)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "عمر المريض :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.PA_OP)
        Me.GroupBox2.Location = New System.Drawing.Point(54, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 89)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(485, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 21)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "أذكرها  :"
        Me.Label8.Visible = False
        '
        'PA_OP
        '
        Me.PA_OP.Location = New System.Drawing.Point(3, 16)
        Me.PA_OP.Multiline = True
        Me.PA_OP.Name = "PA_OP"
        Me.PA_OP.Size = New System.Drawing.Size(476, 68)
        Me.PA_OP.TabIndex = 20
        Me.PA_OP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PA_OP.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(155, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "تليفون المريض :"
        '
        'PA_NAME2
        '
        Me.PA_NAME2.Location = New System.Drawing.Point(381, 69)
        Me.PA_NAME2.Name = "PA_NAME2"
        Me.PA_NAME2.Size = New System.Drawing.Size(188, 29)
        Me.PA_NAME2.TabIndex = 4
        Me.PA_NAME2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 21)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "تليفونة :"
        '
        'PA_TEL2
        '
        Me.PA_TEL2.Location = New System.Drawing.Point(176, 69)
        Me.PA_TEL2.Name = "PA_TEL2"
        Me.PA_TEL2.Size = New System.Drawing.Size(139, 29)
        Me.PA_TEL2.TabIndex = 5
        Me.PA_TEL2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 349)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(866, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 2
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
        'PATIENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 371)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GRBTN)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "PATIENT"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسجيل المرضي"
        Me.GRBTN.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents PA_CODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PA_AGE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PA_NAME2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PA_TEL2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PA_TEL As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PA_CHI As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PA_OP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents USER_ADD As ToolStripStatusLabel
    Friend WithEvents DATE_ADD As ToolStripStatusLabel
    Friend WithEvents TIME_ADD As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents EDITNAMEBT As ToolStripStatusLabel
    Friend WithEvents USER_EDIT As ToolStripStatusLabel
    Friend WithEvents DATE_EDIT As ToolStripStatusLabel
    Friend WithEvents TIME_EDIT As ToolStripStatusLabel
    Friend WithEvents TIMERADD As Timer
    Friend WithEvents TIMEREDIT As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents PA_TYPE As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents AUTOCHI As CheckBox
    Friend WithEvents PA_OP_R1 As CheckBox
    Friend WithEvents PA_CHI_R1 As CheckBox
    Friend WithEvents PA_NAME As ComboBox
    Friend WithEvents PATION_BINDING As BindingSource
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
    Friend WithEvents PA_CODE2 As TextBox
End Class
