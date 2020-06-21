<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ELAG_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ELAG_FRM))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EDITNAMEBT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GRBTN = New System.Windows.Forms.GroupBox()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.PRINTBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.UNDOBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SEARCHBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.DELETBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.EDITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.NEWBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.TIMERADD = New System.Windows.Forms.Timer(Me.components)
        Me.TIMEREDIT = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_INFO2 = New System.Windows.Forms.ComboBox()
        Me.TXT_CODE2 = New System.Windows.Forms.Label()
        Me.VIWERPATIN = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXT_3MLIAT = New System.Windows.Forms.TextBox()
        Me.TXT_TKHASOS = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXT_HRARA = New System.Windows.Forms.TextBox()
        Me.TXT_DOCTOR = New System.Windows.Forms.ComboBox()
        Me.TXT_NO3_PHARM = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_INFO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXT_KG = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_D = New System.Windows.Forms.TextBox()
        Me.TXT_CODE_DOCTOR = New System.Windows.Forms.TextBox()
        Me.TXT_CODE_GOR3A = New System.Windows.Forms.TextBox()
        Me.TXT_CODE_PHARM = New System.Windows.Forms.TextBox()
        Me.ACTIV_BTN = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_NAME_GOR3A = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_NAME_PHARM = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.HISTORY_PA = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_NAME_PA = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_AGE_PA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_TYPE_PA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CODE_PA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        Me.StatusStrip1.SuspendLayout()
        Me.GRBTN.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VIWERPATIN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 443)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(925, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel4.Text = "الأضافة : "
        '
        'USER_ADD
        '
        Me.USER_ADD.Name = "USER_ADD"
        Me.USER_ADD.Size = New System.Drawing.Size(121, 17)
        Me.USER_ADD.Text = "ToolStripStatusLabel1"
        '
        'DATE_ADD
        '
        Me.DATE_ADD.Name = "DATE_ADD"
        Me.DATE_ADD.Size = New System.Drawing.Size(121, 17)
        Me.DATE_ADD.Text = "ToolStripStatusLabel2"
        '
        'TIME_ADD
        '
        Me.TIME_ADD.Name = "TIME_ADD"
        Me.TIME_ADD.Size = New System.Drawing.Size(121, 17)
        Me.TIME_ADD.Text = "ToolStripStatusLabel3"
        '
        'EDITNAMEBT
        '
        Me.EDITNAMEBT.Name = "EDITNAMEBT"
        Me.EDITNAMEBT.Size = New System.Drawing.Size(47, 17)
        Me.EDITNAMEBT.Text = "التعديل : "
        Me.EDITNAMEBT.Visible = False
        '
        'USER_EDIT
        '
        Me.USER_EDIT.Name = "USER_EDIT"
        Me.USER_EDIT.Size = New System.Drawing.Size(121, 17)
        Me.USER_EDIT.Text = "ToolStripStatusLabel6"
        Me.USER_EDIT.Visible = False
        '
        'DATE_EDIT
        '
        Me.DATE_EDIT.Name = "DATE_EDIT"
        Me.DATE_EDIT.Size = New System.Drawing.Size(121, 17)
        Me.DATE_EDIT.Text = "ToolStripStatusLabel1"
        Me.DATE_EDIT.Visible = False
        '
        'TIME_EDIT
        '
        Me.TIME_EDIT.Name = "TIME_EDIT"
        Me.TIME_EDIT.Size = New System.Drawing.Size(121, 17)
        Me.TIME_EDIT.Text = "ToolStripStatusLabel2"
        Me.TIME_EDIT.Visible = False
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
        Me.GRBTN.Location = New System.Drawing.Point(32, 364)
        Me.GRBTN.Name = "GRBTN"
        Me.GRBTN.Size = New System.Drawing.Size(858, 72)
        Me.GRBTN.TabIndex = 3
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
        'TIMERADD
        '
        '
        'TIMEREDIT
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_INFO2)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE2)
        Me.GroupBox1.Controls.Add(Me.VIWERPATIN)
        Me.GroupBox1.Controls.Add(Me.TXT_3MLIAT)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHASOS)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TXT_HRARA)
        Me.GroupBox1.Controls.Add(Me.TXT_DOCTOR)
        Me.GroupBox1.Controls.Add(Me.TXT_NO3_PHARM)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TXT_INFO)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TXT_KG)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TXT_D)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE_DOCTOR)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE_GOR3A)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE_PHARM)
        Me.GroupBox1.Controls.Add(Me.ACTIV_BTN)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME_GOR3A)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME_PHARM)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.HISTORY_PA)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME_PA)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_AGE_PA)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_TYPE_PA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE_PA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(907, 178)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'TXT_INFO2
        '
        Me.TXT_INFO2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_INFO2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_INFO2.BackColor = System.Drawing.Color.White
        Me.TXT_INFO2.FormattingEnabled = True
        Me.TXT_INFO2.Location = New System.Drawing.Point(5, 95)
        Me.TXT_INFO2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TXT_INFO2.Name = "TXT_INFO2"
        Me.TXT_INFO2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_INFO2.Size = New System.Drawing.Size(366, 29)
        Me.TXT_INFO2.TabIndex = 65
        '
        'TXT_CODE2
        '
        Me.TXT_CODE2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE2.ForeColor = System.Drawing.Color.DeepPink
        Me.TXT_CODE2.Location = New System.Drawing.Point(5, 58)
        Me.TXT_CODE2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TXT_CODE2.Name = "TXT_CODE2"
        Me.TXT_CODE2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_CODE2.Size = New System.Drawing.Size(74, 33)
        Me.TXT_CODE2.TabIndex = 64
        Me.TXT_CODE2.Text = "000000"
        Me.TXT_CODE2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VIWERPATIN
        '
        Me.VIWERPATIN.AllowUserToAddRows = False
        Me.VIWERPATIN.AllowUserToDeleteRows = False
        Me.VIWERPATIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VIWERPATIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11})
        Me.VIWERPATIN.Location = New System.Drawing.Point(841, 92)
        Me.VIWERPATIN.Name = "VIWERPATIN"
        Me.VIWERPATIN.ReadOnly = True
        Me.VIWERPATIN.Size = New System.Drawing.Size(33, 33)
        Me.VIWERPATIN.TabIndex = 36
        Me.VIWERPATIN.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "R_CODE_PA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "كود المريض"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "R_INFO"
        Me.DataGridViewTextBoxColumn2.HeaderText = "شكوى المريض"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "R_DT_PHARM"
        Me.DataGridViewTextBoxColumn3.HeaderText = "الدواء"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "R_DT_NO3"
        Me.Column7.HeaderText = "نوع الدواء"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "R_DT_GOR3A"
        Me.Column8.HeaderText = "الجرعة"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "R_DATE"
        Me.Column9.HeaderText = "التاريخ"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "DO_NAME"
        Me.Column10.HeaderText = "اسم الطبيب"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "DO_TKHSOS"
        Me.Column11.HeaderText = "التخصص"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'TXT_3MLIAT
        '
        Me.TXT_3MLIAT.BackColor = System.Drawing.Color.White
        Me.TXT_3MLIAT.Enabled = False
        Me.TXT_3MLIAT.Location = New System.Drawing.Point(841, 56)
        Me.TXT_3MLIAT.Name = "TXT_3MLIAT"
        Me.TXT_3MLIAT.Size = New System.Drawing.Size(30, 29)
        Me.TXT_3MLIAT.TabIndex = 37
        Me.TXT_3MLIAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_3MLIAT.Visible = False
        '
        'TXT_TKHASOS
        '
        Me.TXT_TKHASOS.BackColor = System.Drawing.Color.White
        Me.TXT_TKHASOS.Location = New System.Drawing.Point(12, 28)
        Me.TXT_TKHASOS.Name = "TXT_TKHASOS"
        Me.TXT_TKHASOS.Size = New System.Drawing.Size(34, 29)
        Me.TXT_TKHASOS.TabIndex = 34
        Me.TXT_TKHASOS.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(796, 98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 21)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "درجة الحرارة :"
        '
        'TXT_HRARA
        '
        Me.TXT_HRARA.Location = New System.Drawing.Point(741, 95)
        Me.TXT_HRARA.Name = "TXT_HRARA"
        Me.TXT_HRARA.Size = New System.Drawing.Size(54, 29)
        Me.TXT_HRARA.TabIndex = 32
        Me.TXT_HRARA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_DOCTOR
        '
        Me.TXT_DOCTOR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_DOCTOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_DOCTOR.FormattingEnabled = True
        Me.TXT_DOCTOR.Location = New System.Drawing.Point(52, 18)
        Me.TXT_DOCTOR.Name = "TXT_DOCTOR"
        Me.TXT_DOCTOR.Size = New System.Drawing.Size(244, 29)
        Me.TXT_DOCTOR.TabIndex = 31
        '
        'TXT_NO3_PHARM
        '
        Me.TXT_NO3_PHARM.BackColor = System.Drawing.Color.White
        Me.TXT_NO3_PHARM.Enabled = False
        Me.TXT_NO3_PHARM.Location = New System.Drawing.Point(440, 135)
        Me.TXT_NO3_PHARM.Name = "TXT_NO3_PHARM"
        Me.TXT_NO3_PHARM.Size = New System.Drawing.Size(149, 29)
        Me.TXT_NO3_PHARM.TabIndex = 30
        Me.TXT_NO3_PHARM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(371, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 21)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "شكوي المريض :"
        '
        'TXT_INFO
        '
        Me.TXT_INFO.Location = New System.Drawing.Point(6, 95)
        Me.TXT_INFO.Name = "TXT_INFO"
        Me.TXT_INFO.Size = New System.Drawing.Size(359, 29)
        Me.TXT_INFO.TabIndex = 28
        Me.TXT_INFO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(549, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 21)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "الوزن :"
        '
        'TXT_KG
        '
        Me.TXT_KG.Location = New System.Drawing.Point(491, 95)
        Me.TXT_KG.Name = "TXT_KG"
        Me.TXT_KG.Size = New System.Drawing.Size(52, 29)
        Me.TXT_KG.TabIndex = 26
        Me.TXT_KG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(680, 98)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 21)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "الضغط :"
        '
        'TXT_D
        '
        Me.TXT_D.Location = New System.Drawing.Point(609, 95)
        Me.TXT_D.Name = "TXT_D"
        Me.TXT_D.Size = New System.Drawing.Size(65, 29)
        Me.TXT_D.TabIndex = 24
        Me.TXT_D.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_CODE_DOCTOR
        '
        Me.TXT_CODE_DOCTOR.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_DOCTOR.Location = New System.Drawing.Point(23, 18)
        Me.TXT_CODE_DOCTOR.Name = "TXT_CODE_DOCTOR"
        Me.TXT_CODE_DOCTOR.Size = New System.Drawing.Size(34, 29)
        Me.TXT_CODE_DOCTOR.TabIndex = 23
        Me.TXT_CODE_DOCTOR.Visible = False
        '
        'TXT_CODE_GOR3A
        '
        Me.TXT_CODE_GOR3A.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_GOR3A.Enabled = False
        Me.TXT_CODE_GOR3A.Location = New System.Drawing.Point(297, 128)
        Me.TXT_CODE_GOR3A.Name = "TXT_CODE_GOR3A"
        Me.TXT_CODE_GOR3A.Size = New System.Drawing.Size(34, 29)
        Me.TXT_CODE_GOR3A.TabIndex = 22
        Me.TXT_CODE_GOR3A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_CODE_GOR3A.Visible = False
        '
        'TXT_CODE_PHARM
        '
        Me.TXT_CODE_PHARM.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_PHARM.Enabled = False
        Me.TXT_CODE_PHARM.Location = New System.Drawing.Point(867, 135)
        Me.TXT_CODE_PHARM.Name = "TXT_CODE_PHARM"
        Me.TXT_CODE_PHARM.Size = New System.Drawing.Size(30, 29)
        Me.TXT_CODE_PHARM.TabIndex = 21
        Me.TXT_CODE_PHARM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_CODE_PHARM.Visible = False
        '
        'ACTIV_BTN
        '
        Me.ACTIV_BTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACTIV_BTN.Appearance.Options.UseFont = True
        Me.ACTIV_BTN.ImageOptions.Image = CType(resources.GetObject("ACTIV_BTN.ImageOptions.Image"), System.Drawing.Image)
        Me.ACTIV_BTN.Location = New System.Drawing.Point(145, 130)
        Me.ACTIV_BTN.Name = "ACTIV_BTN"
        Me.ACTIV_BTN.Size = New System.Drawing.Size(44, 35)
        Me.ACTIV_BTN.TabIndex = 20
        '
        'TXT_NAME_GOR3A
        '
        Me.TXT_NAME_GOR3A.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_NAME_GOR3A.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_NAME_GOR3A.FormattingEnabled = True
        Me.TXT_NAME_GOR3A.Location = New System.Drawing.Point(203, 134)
        Me.TXT_NAME_GOR3A.Name = "TXT_NAME_GOR3A"
        Me.TXT_NAME_GOR3A.Size = New System.Drawing.Size(162, 29)
        Me.TXT_NAME_GOR3A.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(371, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 21)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "الجرعة :"
        '
        'TXT_NAME_PHARM
        '
        Me.TXT_NAME_PHARM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_NAME_PHARM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_NAME_PHARM.FormattingEnabled = True
        Me.TXT_NAME_PHARM.Location = New System.Drawing.Point(594, 135)
        Me.TXT_NAME_PHARM.Name = "TXT_NAME_PHARM"
        Me.TXT_NAME_PHARM.Size = New System.Drawing.Size(203, 29)
        Me.TXT_NAME_PHARM.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(803, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "أسم الدواء :"
        '
        'HISTORY_PA
        '
        Me.HISTORY_PA.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HISTORY_PA.Appearance.Options.UseFont = True
        Me.HISTORY_PA.ImageOptions.Image = CType(resources.GetObject("HISTORY_PA.ImageOptions.Image"), System.Drawing.Image)
        Me.HISTORY_PA.Location = New System.Drawing.Point(6, 130)
        Me.HISTORY_PA.Name = "HISTORY_PA"
        Me.HISTORY_PA.Size = New System.Drawing.Size(130, 34)
        Me.HISTORY_PA.TabIndex = 15
        Me.HISTORY_PA.Text = "ملف المريض"
        '
        'TXT_NAME_PA
        '
        Me.TXT_NAME_PA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_NAME_PA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_NAME_PA.DataSource = Me.BindingSource1
        Me.TXT_NAME_PA.DisplayMember = "PA_NAME"
        Me.TXT_NAME_PA.FormattingEnabled = True
        Me.TXT_NAME_PA.Location = New System.Drawing.Point(386, 56)
        Me.TXT_NAME_PA.Name = "TXT_NAME_PA"
        Me.TXT_NAME_PA.Size = New System.Drawing.Size(203, 29)
        Me.TXT_NAME_PA.TabIndex = 14
        Me.TXT_NAME_PA.ValueMember = "PA_NAME"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 21)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "العمر :"
        '
        'TXT_AGE_PA
        '
        Me.TXT_AGE_PA.BackColor = System.Drawing.Color.White
        Me.TXT_AGE_PA.Enabled = False
        Me.TXT_AGE_PA.Location = New System.Drawing.Point(84, 61)
        Me.TXT_AGE_PA.Name = "TXT_AGE_PA"
        Me.TXT_AGE_PA.Size = New System.Drawing.Size(76, 29)
        Me.TXT_AGE_PA.TabIndex = 12
        Me.TXT_AGE_PA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(330, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "النوع :"
        '
        'TXT_TYPE_PA
        '
        Me.TXT_TYPE_PA.BackColor = System.Drawing.Color.White
        Me.TXT_TYPE_PA.Enabled = False
        Me.TXT_TYPE_PA.Location = New System.Drawing.Point(224, 59)
        Me.TXT_TYPE_PA.Name = "TXT_TYPE_PA"
        Me.TXT_TYPE_PA.Size = New System.Drawing.Size(100, 29)
        Me.TXT_TYPE_PA.TabIndex = 10
        Me.TXT_TYPE_PA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(595, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "أسم المريض :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(805, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "كود المريض :"
        '
        'TXT_CODE_PA
        '
        Me.TXT_CODE_PA.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_PA.Enabled = False
        Me.TXT_CODE_PA.Location = New System.Drawing.Point(699, 53)
        Me.TXT_CODE_PA.Name = "TXT_CODE_PA"
        Me.TXT_CODE_PA.Size = New System.Drawing.Size(100, 29)
        Me.TXT_CODE_PA.TabIndex = 6
        Me.TXT_CODE_PA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(302, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "أسم الطبيب المعالج :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(625, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "التاريخ :"
        '
        'TXT_DATE
        '
        Me.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE.Location = New System.Drawing.Point(446, 18)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_DATE.Size = New System.Drawing.Size(173, 29)
        Me.TXT_DATE.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(805, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "رقم الروشتة :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(699, 18)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(100, 29)
        Me.TXT_CODE.TabIndex = 0
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(901, 183)
        Me.DataGridView1.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "كود الدواء"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "أسم الدواء"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "نوع الدواء"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "كود الجرعة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "الجرعة"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 30.0!
        Me.Column5.HeaderText = "-"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'BindingSource1
        '
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
        'ELAG_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 465)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GRBTN)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ELAG_FRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "روشتة علاج طبيب"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GRBTN.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VIWERPATIN, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents USER_ADD As ToolStripStatusLabel
    Friend WithEvents DATE_ADD As ToolStripStatusLabel
    Friend WithEvents TIME_ADD As ToolStripStatusLabel
    Friend WithEvents EDITNAMEBT As ToolStripStatusLabel
    Friend WithEvents USER_EDIT As ToolStripStatusLabel
    Friend WithEvents DATE_EDIT As ToolStripStatusLabel
    Friend WithEvents TIME_EDIT As ToolStripStatusLabel
    Friend WithEvents GRBTN As GroupBox
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PRINTBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents UNDOBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SEARCHBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DELETBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EDITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SAVEBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NEWBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TIMERADD As Timer
    Friend WithEvents TIMEREDIT As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_DATE As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_AGE_PA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_TYPE_PA As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CODE_PA As TextBox
    Friend WithEvents TXT_NAME_PA As ComboBox
    Friend WithEvents HISTORY_PA As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_NAME_GOR3A As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_NAME_PHARM As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ACTIV_BTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXT_CODE_GOR3A As TextBox
    Friend WithEvents TXT_CODE_PHARM As TextBox
    Friend WithEvents TXT_CODE_DOCTOR As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXT_INFO As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXT_KG As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_D As TextBox
    Friend WithEvents TXT_NO3_PHARM As TextBox
    Friend WithEvents TXT_DOCTOR As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TXT_HRARA As TextBox
    Friend WithEvents TXT_TKHASOS As TextBox
    Friend WithEvents VIWERPATIN As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents TXT_3MLIAT As TextBox
    Friend WithEvents TXT_CODE2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents TXT_INFO2 As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
End Class
