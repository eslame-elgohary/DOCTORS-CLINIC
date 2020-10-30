<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T3AQOD_FRM2020
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(T3AQOD_FRM2020))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_MONY_ACTION = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_ACTION = New System.Windows.Forms.ComboBox()
        Me.TXT_DOCTOR_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_TKHASOS_CODE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_DOCTOR = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_DATE_END = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_DATE_START = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_TKHASOS = New System.Windows.Forms.ComboBox()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TIMERADD = New System.Windows.Forms.Timer(Me.components)
        Me.TIMEREDIT = New System.Windows.Forms.Timer(Me.components)
        Me.ACTIVE_DOCTOR = New DevExpress.XtraEditors.SimpleButton()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.PRINTBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.UNDOBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SEARCHBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.DELETBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.EDITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.NEWBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GRBTN.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ACTIVE_DOCTOR)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXT_MONY_ACTION)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_ACTION)
        Me.GroupBox1.Controls.Add(Me.TXT_DOCTOR_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHASOS_CODE)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_DOCTOR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE_END)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE_START)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHASOS)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(877, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(461, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 21)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "قيمة الأجراء :"
        '
        'TXT_MONY_ACTION
        '
        Me.TXT_MONY_ACTION.BackColor = System.Drawing.Color.Aqua
        Me.TXT_MONY_ACTION.Location = New System.Drawing.Point(351, 103)
        Me.TXT_MONY_ACTION.Name = "TXT_MONY_ACTION"
        Me.TXT_MONY_ACTION.Size = New System.Drawing.Size(100, 29)
        Me.TXT_MONY_ACTION.TabIndex = 16
        Me.TXT_MONY_ACTION.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(763, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 21)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "نوع الأجراء :"
        '
        'TXT_ACTION
        '
        Me.TXT_ACTION.FormattingEnabled = True
        Me.TXT_ACTION.Location = New System.Drawing.Point(556, 102)
        Me.TXT_ACTION.Name = "TXT_ACTION"
        Me.TXT_ACTION.Size = New System.Drawing.Size(201, 29)
        Me.TXT_ACTION.TabIndex = 14
        '
        'TXT_DOCTOR_CODE
        '
        Me.TXT_DOCTOR_CODE.Location = New System.Drawing.Point(77, 67)
        Me.TXT_DOCTOR_CODE.Name = "TXT_DOCTOR_CODE"
        Me.TXT_DOCTOR_CODE.Size = New System.Drawing.Size(49, 29)
        Me.TXT_DOCTOR_CODE.TabIndex = 13
        Me.TXT_DOCTOR_CODE.Visible = False
        '
        'TXT_TKHASOS_CODE
        '
        Me.TXT_TKHASOS_CODE.Location = New System.Drawing.Point(387, 67)
        Me.TXT_TKHASOS_CODE.Name = "TXT_TKHASOS_CODE"
        Me.TXT_TKHASOS_CODE.Size = New System.Drawing.Size(64, 29)
        Me.TXT_TKHASOS_CODE.TabIndex = 12
        Me.TXT_TKHASOS_CODE.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "الطبيب :"
        '
        'TXT_DOCTOR
        '
        Me.TXT_DOCTOR.FormattingEnabled = True
        Me.TXT_DOCTOR.Location = New System.Drawing.Point(11, 54)
        Me.TXT_DOCTOR.Name = "TXT_DOCTOR"
        Me.TXT_DOCTOR.Size = New System.Drawing.Size(201, 29)
        Me.TXT_DOCTOR.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(506, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "التخصص :"
        '
        'TXT_DATE_END
        '
        Me.TXT_DATE_END.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE_END.Location = New System.Drawing.Point(590, 54)
        Me.TXT_DATE_END.Name = "TXT_DATE_END"
        Me.TXT_DATE_END.Size = New System.Drawing.Size(167, 29)
        Me.TXT_DATE_END.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(763, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "نهاية التعاقد :"
        '
        'TXT_DATE_START
        '
        Me.TXT_DATE_START.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE_START.Location = New System.Drawing.Point(12, 17)
        Me.TXT_DATE_START.Name = "TXT_DATE_START"
        Me.TXT_DATE_START.Size = New System.Drawing.Size(200, 29)
        Me.TXT_DATE_START.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "بداية التعاقد :"
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BackColor = System.Drawing.Color.Aqua
        Me.TXT_NAME.Location = New System.Drawing.Point(324, 17)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(239, 29)
        Me.TXT_NAME.TabIndex = 4
        Me.TXT_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(569, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "أسم الجهة :"
        '
        'TXT_TKHASOS
        '
        Me.TXT_TKHASOS.FormattingEnabled = True
        Me.TXT_TKHASOS.Location = New System.Drawing.Point(299, 54)
        Me.TXT_TKHASOS.Name = "TXT_TKHASOS"
        Me.TXT_TKHASOS.Size = New System.Drawing.Size(201, 29)
        Me.TXT_TKHASOS.TabIndex = 2
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(657, 17)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(100, 29)
        Me.TXT_CODE.TabIndex = 1
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(763, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "كود التعاقد :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(0, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(877, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "كود التخصص"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "أسم التخصص"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "كود الطبيب"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'Column4
        '
        Me.Column4.HeaderText = "أسم الطبيب"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "الأجراء"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "القيمة"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 373)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(877, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 37
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
        Me.GRBTN.Location = New System.Drawing.Point(9, 294)
        Me.GRBTN.Name = "GRBTN"
        Me.GRBTN.Size = New System.Drawing.Size(864, 72)
        Me.GRBTN.TabIndex = 36
        Me.GRBTN.TabStop = False
        '
        'TIMERADD
        '
        '
        'TIMEREDIT
        '
        '
        'ACTIVE_DOCTOR
        '
        Me.ACTIVE_DOCTOR.ImageOptions.Image = CType(resources.GetObject("ACTIVE_DOCTOR.ImageOptions.Image"), System.Drawing.Image)
        Me.ACTIVE_DOCTOR.Location = New System.Drawing.Point(265, 94)
        Me.ACTIVE_DOCTOR.Name = "ACTIVE_DOCTOR"
        Me.ACTIVE_DOCTOR.Size = New System.Drawing.Size(44, 42)
        Me.ACTIVE_DOCTOR.TabIndex = 18
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
        Me.PRINTBTN.Location = New System.Drawing.Point(71, 20)
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
        Me.UNDOBTN.Enabled = False
        Me.UNDOBTN.ImageOptions.Image = CType(resources.GetObject("UNDOBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.UNDOBTN.Location = New System.Drawing.Point(185, 22)
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
        Me.SEARCHBTN.Location = New System.Drawing.Point(309, 20)
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
        Me.DELETBTN.Location = New System.Drawing.Point(423, 20)
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
        Me.EDITBTN.Location = New System.Drawing.Point(537, 20)
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
        Me.SAVEBTN.Location = New System.Drawing.Point(651, 20)
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
        Me.NEWBTN.Location = New System.Drawing.Point(765, 20)
        Me.NEWBTN.Name = "NEWBTN"
        Me.NEWBTN.Size = New System.Drawing.Size(96, 44)
        Me.NEWBTN.TabIndex = 1
        Me.NEWBTN.Text = "جديد"
        '
        'T3AQOD_FRM2020
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(877, 395)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GRBTN)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "T3AQOD_FRM2020"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "أضافة تعاقد"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GRBTN.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_TKHASOS As ComboBox
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_DATE_END As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DATE_START As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_DOCTOR As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_DOCTOR_CODE As TextBox
    Friend WithEvents TXT_TKHASOS_CODE As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_MONY_ACTION As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_ACTION As ComboBox
    Friend WithEvents ACTIVE_DOCTOR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
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
End Class
