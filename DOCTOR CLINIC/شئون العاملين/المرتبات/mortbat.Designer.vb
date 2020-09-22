<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mortbat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mortbat))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.T3 = New System.Windows.Forms.TextBox()
        Me.Q_EDAFY = New System.Windows.Forms.TextBox()
        Me.T4 = New System.Windows.Forms.TextBox()
        Me.TXT_RATEB = New System.Windows.Forms.TextBox()
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.TXT_ENSRAF_M = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_HDOR_M = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_ENSRAF = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_HDOR = New System.Windows.Forms.MaskedTextBox()
        Me.BTN_ADD_MOA3ED = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NAME_EMP = New System.Windows.Forms.ComboBox()
        Me.TXT_CODE_EMP = New System.Windows.Forms.TextBox()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GRBTN.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.T3)
        Me.GroupBox1.Controls.Add(Me.Q_EDAFY)
        Me.GroupBox1.Controls.Add(Me.T4)
        Me.GroupBox1.Controls.Add(Me.TXT_RATEB)
        Me.GroupBox1.Controls.Add(Me.T1)
        Me.GroupBox1.Controls.Add(Me.T2)
        Me.GroupBox1.Controls.Add(Me.TXT_ENSRAF_M)
        Me.GroupBox1.Controls.Add(Me.TXT_HDOR_M)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXT_ENSRAF)
        Me.GroupBox1.Controls.Add(Me.TXT_HDOR)
        Me.GroupBox1.Controls.Add(Me.BTN_ADD_MOA3ED)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME_EMP)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE_EMP)
        Me.GroupBox1.Location = New System.Drawing.Point(10, -6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(838, 157)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'T3
        '
        Me.T3.Location = New System.Drawing.Point(297, 28)
        Me.T3.Name = "T3"
        Me.T3.Size = New System.Drawing.Size(72, 29)
        Me.T3.TabIndex = 47
        '
        'Q_EDAFY
        '
        Me.Q_EDAFY.Location = New System.Drawing.Point(9, 111)
        Me.Q_EDAFY.Name = "Q_EDAFY"
        Me.Q_EDAFY.Size = New System.Drawing.Size(76, 29)
        Me.Q_EDAFY.TabIndex = 46
        '
        'T4
        '
        Me.T4.Location = New System.Drawing.Point(91, 110)
        Me.T4.Name = "T4"
        Me.T4.Size = New System.Drawing.Size(72, 29)
        Me.T4.TabIndex = 45
        '
        'TXT_RATEB
        '
        Me.TXT_RATEB.Location = New System.Drawing.Point(43, 67)
        Me.TXT_RATEB.Name = "TXT_RATEB"
        Me.TXT_RATEB.Size = New System.Drawing.Size(100, 29)
        Me.TXT_RATEB.TabIndex = 44
        '
        'T1
        '
        Me.T1.Location = New System.Drawing.Point(199, 64)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(84, 29)
        Me.T1.TabIndex = 43
        '
        'T2
        '
        Me.T2.Location = New System.Drawing.Point(301, 65)
        Me.T2.Name = "T2"
        Me.T2.Size = New System.Drawing.Size(76, 29)
        Me.T2.TabIndex = 42
        '
        'TXT_ENSRAF_M
        '
        Me.TXT_ENSRAF_M.BackColor = System.Drawing.Color.White
        Me.TXT_ENSRAF_M.Location = New System.Drawing.Point(423, 62)
        Me.TXT_ENSRAF_M.Mask = "00:00"
        Me.TXT_ENSRAF_M.Name = "TXT_ENSRAF_M"
        Me.TXT_ENSRAF_M.Size = New System.Drawing.Size(78, 29)
        Me.TXT_ENSRAF_M.TabIndex = 37
        Me.TXT_ENSRAF_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ENSRAF_M.ValidatingType = GetType(Date)
        '
        'TXT_HDOR_M
        '
        Me.TXT_HDOR_M.BackColor = System.Drawing.Color.White
        Me.TXT_HDOR_M.Location = New System.Drawing.Point(558, 62)
        Me.TXT_HDOR_M.Mask = "00:00"
        Me.TXT_HDOR_M.Name = "TXT_HDOR_M"
        Me.TXT_HDOR_M.Size = New System.Drawing.Size(78, 29)
        Me.TXT_HDOR_M.TabIndex = 36
        Me.TXT_HDOR_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_HDOR_M.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(505, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 21)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "حتي :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(642, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 21)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "مواعيد العمل الرسمية من :"
        '
        'TXT_ENSRAF
        '
        Me.TXT_ENSRAF.Location = New System.Drawing.Point(278, 114)
        Me.TXT_ENSRAF.Mask = "00:00"
        Me.TXT_ENSRAF.Name = "TXT_ENSRAF"
        Me.TXT_ENSRAF.Size = New System.Drawing.Size(78, 29)
        Me.TXT_ENSRAF.TabIndex = 33
        Me.TXT_ENSRAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ENSRAF.ValidatingType = GetType(Date)
        '
        'TXT_HDOR
        '
        Me.TXT_HDOR.Location = New System.Drawing.Point(446, 111)
        Me.TXT_HDOR.Mask = "00:00"
        Me.TXT_HDOR.Name = "TXT_HDOR"
        Me.TXT_HDOR.Size = New System.Drawing.Size(78, 29)
        Me.TXT_HDOR.TabIndex = 32
        Me.TXT_HDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_HDOR.ValidatingType = GetType(Date)
        '
        'BTN_ADD_MOA3ED
        '
        Me.BTN_ADD_MOA3ED.ImageOptions.Image = CType(resources.GetObject("BTN_ADD_MOA3ED.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_ADD_MOA3ED.Location = New System.Drawing.Point(177, 108)
        Me.BTN_ADD_MOA3ED.Name = "BTN_ADD_MOA3ED"
        Me.BTN_ADD_MOA3ED.Size = New System.Drawing.Size(45, 35)
        Me.BTN_ADD_MOA3ED.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "كود الموظف :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(736, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 21)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "أذن رقم :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(615, 27)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(115, 29)
        Me.TXT_CODE.TabIndex = 11
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "أنصراف :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(529, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "حضور :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(774, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "اليوم :"
        '
        'TXT_DATE
        '
        Me.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE.Location = New System.Drawing.Point(593, 115)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_DATE.Size = New System.Drawing.Size(175, 29)
        Me.TXT_DATE.TabIndex = 4
        Me.TXT_DATE.Value = New Date(2020, 9, 16, 17, 18, 53, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(278, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "أسم الموظف :"
        '
        'TXT_NAME_EMP
        '
        Me.TXT_NAME_EMP.FormattingEnabled = True
        Me.TXT_NAME_EMP.Location = New System.Drawing.Point(43, 27)
        Me.TXT_NAME_EMP.Name = "TXT_NAME_EMP"
        Me.TXT_NAME_EMP.Size = New System.Drawing.Size(229, 29)
        Me.TXT_NAME_EMP.TabIndex = 0
        '
        'TXT_CODE_EMP
        '
        Me.TXT_CODE_EMP.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_EMP.Enabled = False
        Me.TXT_CODE_EMP.Location = New System.Drawing.Point(387, 27)
        Me.TXT_CODE_EMP.Name = "TXT_CODE_EMP"
        Me.TXT_CODE_EMP.Size = New System.Drawing.Size(115, 29)
        Me.TXT_CODE_EMP.TabIndex = 13
        Me.TXT_CODE_EMP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.Dgv.Location = New System.Drawing.Point(10, 157)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.Size = New System.Drawing.Size(838, 240)
        Me.Dgv.TabIndex = 20
        '
        'Column1
        '
        Me.Column1.HeaderText = "التاريخ"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "حضور"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "أنصراف"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "أضافي"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "قيمته"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 484)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(859, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 22
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
        Me.GRBTN.Location = New System.Drawing.Point(9, 392)
        Me.GRBTN.Name = "GRBTN"
        Me.GRBTN.Size = New System.Drawing.Size(842, 72)
        Me.GRBTN.TabIndex = 21
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
        'TIMERADD
        '
        '
        'TIMEREDIT
        '
        '
        'mortbat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 506)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GRBTN)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "mortbat"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                                         مرتبات العاملين"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GRBTN.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_NAME_EMP As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_DATE As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents TXT_CODE_EMP As TextBox
    Friend WithEvents BTN_ADD_MOA3ED As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Dgv As DataGridView
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
    Friend WithEvents TXT_ENSRAF As MaskedTextBox
    Friend WithEvents TXT_HDOR As MaskedTextBox
    Friend WithEvents TXT_ENSRAF_M As MaskedTextBox
    Friend WithEvents TXT_HDOR_M As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents T1 As TextBox
    Friend WithEvents T2 As TextBox
    Friend WithEvents TXT_RATEB As TextBox
    Friend WithEvents T4 As TextBox
    Friend WithEvents Q_EDAFY As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents T3 As TextBox
End Class
