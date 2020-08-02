<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HAGEZ_PATEINT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HAGEZ_PATEINT))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_ID = New System.Windows.Forms.TextBox()
        Me.TXT_CODE2 = New System.Windows.Forms.TextBox()
        Me.TXT_TEL = New System.Windows.Forms.TextBox()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_CLOSE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EDIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_DELET = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.CH_DATE = New System.Windows.Forms.CheckBox()
        Me.TXT_DOCTOR_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_TKHASOS_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_CODE_PA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_DATE = New System.Windows.Forms.DateTimePicker()
        Me.TXT_DOCTOR = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_TKHSOS = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PA_NAME = New System.Windows.Forms.ComboBox()
        Me.PATION_BINDING = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.Label()
        Me.ADD_PA = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
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
        Me.CODE_TIMER = New System.Windows.Forms.Timer(Me.components)
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        Me.TXT_ACTION = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_DATE)
        Me.GroupBox1.Controls.Add(Me.TXT_ACTION)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_ID)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE2)
        Me.GroupBox1.Controls.Add(Me.TXT_TEL)
        Me.GroupBox1.Controls.Add(Me.BTN_NEW)
        Me.GroupBox1.Controls.Add(Me.BTN_CLOSE)
        Me.GroupBox1.Controls.Add(Me.BTN_EDIT)
        Me.GroupBox1.Controls.Add(Me.BTN_DELET)
        Me.GroupBox1.Controls.Add(Me.BTN_SAVE)
        Me.GroupBox1.Controls.Add(Me.CH_DATE)
        Me.GroupBox1.Controls.Add(Me.TXT_DOCTOR_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHASOS_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE_PA)
        Me.GroupBox1.Controls.Add(Me.TXT_DOCTOR)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHSOS)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.PA_NAME)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Controls.Add(Me.ADD_PA)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1013, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TXT_ID
        '
        Me.TXT_ID.Location = New System.Drawing.Point(970, 55)
        Me.TXT_ID.Name = "TXT_ID"
        Me.TXT_ID.Size = New System.Drawing.Size(32, 29)
        Me.TXT_ID.TabIndex = 75
        Me.TXT_ID.Visible = False
        '
        'TXT_CODE2
        '
        Me.TXT_CODE2.Location = New System.Drawing.Point(740, 18)
        Me.TXT_CODE2.Name = "TXT_CODE2"
        Me.TXT_CODE2.Size = New System.Drawing.Size(32, 29)
        Me.TXT_CODE2.TabIndex = 74
        Me.TXT_CODE2.Visible = False
        '
        'TXT_TEL
        '
        Me.TXT_TEL.Location = New System.Drawing.Point(778, 12)
        Me.TXT_TEL.Name = "TXT_TEL"
        Me.TXT_TEL.Size = New System.Drawing.Size(32, 29)
        Me.TXT_TEL.TabIndex = 73
        Me.TXT_TEL.Visible = False
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEW.Appearance.Options.UseFont = True
        Me.BTN_NEW.ImageOptions.Image = CType(resources.GetObject("BTN_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NEW.Location = New System.Drawing.Point(381, 72)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(80, 42)
        Me.BTN_NEW.TabIndex = 72
        Me.BTN_NEW.Text = "جديد"
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.Appearance.Options.UseFont = True
        Me.BTN_CLOSE.ImageOptions.Image = CType(resources.GetObject("BTN_CLOSE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_CLOSE.Location = New System.Drawing.Point(8, 71)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(41, 42)
        Me.BTN_CLOSE.TabIndex = 71
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDIT.Appearance.Options.UseFont = True
        Me.BTN_EDIT.ImageOptions.Image = CType(resources.GetObject("BTN_EDIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EDIT.Location = New System.Drawing.Point(170, 71)
        Me.BTN_EDIT.Name = "BTN_EDIT"
        Me.BTN_EDIT.Size = New System.Drawing.Size(91, 42)
        Me.BTN_EDIT.TabIndex = 70
        Me.BTN_EDIT.Text = "تعديل"
        '
        'BTN_DELET
        '
        Me.BTN_DELET.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELET.Appearance.Options.UseFont = True
        Me.BTN_DELET.ImageOptions.Image = CType(resources.GetObject("BTN_DELET.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_DELET.Location = New System.Drawing.Point(58, 72)
        Me.BTN_DELET.Name = "BTN_DELET"
        Me.BTN_DELET.Size = New System.Drawing.Size(103, 42)
        Me.BTN_DELET.TabIndex = 69
        Me.BTN_DELET.Text = "طباعة"
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.Appearance.Options.UseFont = True
        Me.BTN_SAVE.ImageOptions.Image = CType(resources.GetObject("BTN_SAVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_SAVE.Location = New System.Drawing.Point(270, 71)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(101, 42)
        Me.BTN_SAVE.TabIndex = 68
        Me.BTN_SAVE.Text = "تأكيد"
        '
        'CH_DATE
        '
        Me.CH_DATE.AutoSize = True
        Me.CH_DATE.Checked = True
        Me.CH_DATE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CH_DATE.Location = New System.Drawing.Point(483, 85)
        Me.CH_DATE.Name = "CH_DATE"
        Me.CH_DATE.Size = New System.Drawing.Size(15, 14)
        Me.CH_DATE.TabIndex = 10
        Me.CH_DATE.UseVisualStyleBackColor = True
        '
        'TXT_DOCTOR_CODE
        '
        Me.TXT_DOCTOR_CODE.Location = New System.Drawing.Point(137, 23)
        Me.TXT_DOCTOR_CODE.Name = "TXT_DOCTOR_CODE"
        Me.TXT_DOCTOR_CODE.Size = New System.Drawing.Size(32, 29)
        Me.TXT_DOCTOR_CODE.TabIndex = 9
        Me.TXT_DOCTOR_CODE.Visible = False
        '
        'TXT_TKHASOS_CODE
        '
        Me.TXT_TKHASOS_CODE.Location = New System.Drawing.Point(401, 20)
        Me.TXT_TKHASOS_CODE.Name = "TXT_TKHASOS_CODE"
        Me.TXT_TKHASOS_CODE.Size = New System.Drawing.Size(32, 29)
        Me.TXT_TKHASOS_CODE.TabIndex = 8
        Me.TXT_TKHASOS_CODE.Visible = False
        '
        'TXT_CODE_PA
        '
        Me.TXT_CODE_PA.Location = New System.Drawing.Point(831, 12)
        Me.TXT_CODE_PA.Name = "TXT_CODE_PA"
        Me.TXT_CODE_PA.Size = New System.Drawing.Size(32, 29)
        Me.TXT_CODE_PA.TabIndex = 1
        Me.TXT_CODE_PA.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(704, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "التاريخ :"
        '
        'TXT_DATE
        '
        Me.TXT_DATE.CalendarMonthBackground = System.Drawing.Color.White
        Me.TXT_DATE.Enabled = False
        Me.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE.Location = New System.Drawing.Point(506, 77)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_DATE.Size = New System.Drawing.Size(200, 29)
        Me.TXT_DATE.TabIndex = 1
        '
        'TXT_DOCTOR
        '
        Me.TXT_DOCTOR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_DOCTOR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_DOCTOR.FormattingEnabled = True
        Me.TXT_DOCTOR.Location = New System.Drawing.Point(111, 28)
        Me.TXT_DOCTOR.Name = "TXT_DOCTOR"
        Me.TXT_DOCTOR.Size = New System.Drawing.Size(178, 29)
        Me.TXT_DOCTOR.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(295, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "أسم الطبيب :"
        '
        'TXT_TKHSOS
        '
        Me.TXT_TKHSOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_TKHSOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_TKHSOS.FormattingEnabled = True
        Me.TXT_TKHSOS.Location = New System.Drawing.Point(391, 28)
        Me.TXT_TKHSOS.Name = "TXT_TKHSOS"
        Me.TXT_TKHSOS.Size = New System.Drawing.Size(170, 29)
        Me.TXT_TKHSOS.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(567, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "العيادة :"
        '
        'PA_NAME
        '
        Me.PA_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.PA_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PA_NAME.DataSource = Me.PATION_BINDING
        Me.PA_NAME.DisplayMember = "PA_NAME"
        Me.PA_NAME.FormattingEnabled = True
        Me.PA_NAME.Location = New System.Drawing.Point(654, 28)
        Me.PA_NAME.Name = "PA_NAME"
        Me.PA_NAME.Size = New System.Drawing.Size(248, 29)
        Me.PA_NAME.TabIndex = 1
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(908, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "أسم المريض :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE.ForeColor = System.Drawing.Color.Green
        Me.TXT_CODE.Location = New System.Drawing.Point(6, 18)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(99, 47)
        Me.TXT_CODE.TabIndex = 1
        Me.TXT_CODE.Text = "100000"
        '
        'ADD_PA
        '
        Me.ADD_PA.AutoSize = True
        Me.ADD_PA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ADD_PA.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_PA.ForeColor = System.Drawing.Color.DodgerBlue
        Me.ADD_PA.Location = New System.Drawing.Point(620, 12)
        Me.ADD_PA.Name = "ADD_PA"
        Me.ADD_PA.Size = New System.Drawing.Size(48, 50)
        Me.ADD_PA.TabIndex = 67
        Me.ADD_PA.Text = "+"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column10, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 136)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1013, 328)
        Me.DataGridView1.TabIndex = 1
        '
        'TIMEREDIT
        '
        Me.TIMEREDIT.Enabled = True
        '
        'TIMERADD
        '
        Me.TIMERADD.Enabled = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 474)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1037, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 35
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
        'CODE_TIMER
        '
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'TXT_ACTION
        '
        Me.TXT_ACTION.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_ACTION.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_ACTION.FormattingEnabled = True
        Me.TXT_ACTION.Location = New System.Drawing.Point(765, 77)
        Me.TXT_ACTION.Name = "TXT_ACTION"
        Me.TXT_ACTION.Size = New System.Drawing.Size(178, 29)
        Me.TXT_ACTION.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(941, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 21)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "الأجراء :"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "ID"
        Me.Column9.HeaderText = "ID"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_H"
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "رقم الحجز"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PA_NAME"
        Me.Column2.HeaderText = "أسم المريض"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "DO_TKHSOS"
        Me.Column3.HeaderText = "العيادة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "DO_NAME"
        Me.Column4.HeaderText = "أسم الطبيب"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "DOT_NAME"
        Me.Column10.HeaderText = "الأجراء"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 50.0!
        Me.Column5.HeaderText = "-"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "PA_TEL"
        Me.Column6.HeaderText = "TEL_PA"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "PA_CODE2"
        Me.Column7.HeaderText = "CODE2_PA"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "DATE_H"
        Me.Column8.HeaderText = "DATE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'HAGEZ_PATEINT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 496)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "HAGEZ_PATEINT"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الحجز"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PA_NAME As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_DOCTOR As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_TKHSOS As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DATE As DateTimePicker
    Friend WithEvents TXT_DOCTOR_CODE As TextBox
    Friend WithEvents TXT_TKHASOS_CODE As TextBox
    Friend WithEvents TXT_CODE_PA As TextBox
    Friend WithEvents CH_DATE As CheckBox
    Friend WithEvents TXT_CODE As Label
    Friend WithEvents ADD_PA As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_CLOSE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EDIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_DELET As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
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
    Friend WithEvents CODE_TIMER As Timer
    Friend WithEvents TXT_CODE2 As TextBox
    Friend WithEvents TXT_TEL As TextBox
    Friend WithEvents PATION_BINDING As BindingSource
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
    Friend WithEvents TXT_ID As TextBox
    Friend WithEvents TXT_ACTION As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
