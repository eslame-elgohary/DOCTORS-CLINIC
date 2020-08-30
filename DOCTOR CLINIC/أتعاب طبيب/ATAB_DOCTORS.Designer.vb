<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ATAB_DOCTORS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ATAB_DOCTORS))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_DOCTOR_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_DOCTOR = New System.Windows.Forms.ComboBox()
        Me.TXT_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TXT_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SAFY_AR = New System.Windows.Forms.TextBox()
        Me.KHAZINA_CODE = New System.Windows.Forms.TextBox()
        Me.KHAZINA_NAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TIMERADD = New System.Windows.Forms.Timer(Me.components)
        Me.TIMEREDIT = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_ADD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.EDITNAMEBT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.USER_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DATE_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TIME_EDIT = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PRINTBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SEARCHBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.EDITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.ACTIVE_DOCTOR = New DevExpress.XtraEditors.SimpleButton()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.NEWBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_TYPEMONY = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_DATE2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 21)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "أسم الطبيب :"
        '
        'TXT_DOCTOR_CODE
        '
        Me.TXT_DOCTOR_CODE.Location = New System.Drawing.Point(117, 37)
        Me.TXT_DOCTOR_CODE.Name = "TXT_DOCTOR_CODE"
        Me.TXT_DOCTOR_CODE.Size = New System.Drawing.Size(26, 29)
        Me.TXT_DOCTOR_CODE.TabIndex = 13
        Me.TXT_DOCTOR_CODE.Visible = False
        '
        'TXT_DOCTOR
        '
        Me.TXT_DOCTOR.FormattingEnabled = True
        Me.TXT_DOCTOR.Location = New System.Drawing.Point(128, 46)
        Me.TXT_DOCTOR.Name = "TXT_DOCTOR"
        Me.TXT_DOCTOR.Size = New System.Drawing.Size(261, 29)
        Me.TXT_DOCTOR.TabIndex = 12
        '
        'TXT_DATE
        '
        Me.TXT_DATE.Checked = False
        Me.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE.Location = New System.Drawing.Point(292, 8)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_DATE.Size = New System.Drawing.Size(173, 29)
        Me.TXT_DATE.TabIndex = 15
        Me.TXT_DATE.Value = New Date(2020, 4, 1, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(213, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "من تاريخ :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column10, Me.Column1, Me.Column2})
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridView1.Location = New System.Drawing.Point(12, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(856, 260)
        Me.DataGridView1.TabIndex = 17
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "NAME_ACTION"
        Me.Column9.HeaderText = "الأجراء"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "count_action"
        Me.Column10.FillWeight = 50.0!
        Me.Column10.HeaderText = "عدد المرضي"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "DOT_DOCTORS"
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "قيمة الاجراء"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "egmaly"
        Me.Column2.FillWeight = 50.0!
        Me.Column2.HeaderText = "الأجمالي"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'TXT_TOTAL
        '
        Me.TXT_TOTAL.BackColor = System.Drawing.Color.White
        Me.TXT_TOTAL.Enabled = False
        Me.TXT_TOTAL.Location = New System.Drawing.Point(104, 349)
        Me.TXT_TOTAL.Name = "TXT_TOTAL"
        Me.TXT_TOTAL.Size = New System.Drawing.Size(156, 29)
        Me.TXT_TOTAL.TabIndex = 130
        Me.TXT_TOTAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 352)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "الأجمالي :"
        '
        'SAFY_AR
        '
        Me.SAFY_AR.BackColor = System.Drawing.Color.White
        Me.SAFY_AR.Enabled = False
        Me.SAFY_AR.Location = New System.Drawing.Point(266, 350)
        Me.SAFY_AR.Name = "SAFY_AR"
        Me.SAFY_AR.Size = New System.Drawing.Size(602, 29)
        Me.SAFY_AR.TabIndex = 137
        Me.SAFY_AR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'KHAZINA_CODE
        '
        Me.KHAZINA_CODE.BackColor = System.Drawing.Color.White
        Me.KHAZINA_CODE.Enabled = False
        Me.KHAZINA_CODE.Location = New System.Drawing.Point(679, 38)
        Me.KHAZINA_CODE.Name = "KHAZINA_CODE"
        Me.KHAZINA_CODE.Size = New System.Drawing.Size(23, 29)
        Me.KHAZINA_CODE.TabIndex = 142
        Me.KHAZINA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.KHAZINA_CODE.Visible = False
        '
        'KHAZINA_NAME
        '
        Me.KHAZINA_NAME.BackColor = System.Drawing.Color.White
        Me.KHAZINA_NAME.Enabled = False
        Me.KHAZINA_NAME.Location = New System.Drawing.Point(683, 43)
        Me.KHAZINA_NAME.Name = "KHAZINA_NAME"
        Me.KHAZINA_NAME.Size = New System.Drawing.Size(185, 29)
        Me.KHAZINA_NAME.TabIndex = 141
        Me.KHAZINA_NAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(585, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 21)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "أسم الخزينة :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(103, 8)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(88, 29)
        Me.TXT_CODE.TabIndex = 139
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 21)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "رقم الايصال :"
        '
        'TIMERADD
        '
        '
        'TIMEREDIT
        '
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel4, Me.USER_ADD, Me.DATE_ADD, Me.TIME_ADD, Me.EDITNAMEBT, Me.USER_EDIT, Me.DATE_EDIT, Me.TIME_EDIT})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 432)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(880, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 143
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
        'PRINTBTN
        '
        Me.PRINTBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PRINTBTN.Appearance.Options.UseFont = True
        Me.PRINTBTN.ImageOptions.Image = CType(resources.GetObject("PRINTBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.PRINTBTN.Location = New System.Drawing.Point(494, 386)
        Me.PRINTBTN.Name = "PRINTBTN"
        Me.PRINTBTN.Size = New System.Drawing.Size(96, 35)
        Me.PRINTBTN.TabIndex = 146
        Me.PRINTBTN.Text = "طباعة"
        '
        'SEARCHBTN
        '
        Me.SEARCHBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCHBTN.Appearance.Options.UseFont = True
        Me.SEARCHBTN.ImageOptions.Image = CType(resources.GetObject("SEARCHBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SEARCHBTN.Location = New System.Drawing.Point(381, 386)
        Me.SEARCHBTN.Name = "SEARCHBTN"
        Me.SEARCHBTN.Size = New System.Drawing.Size(96, 36)
        Me.SEARCHBTN.TabIndex = 145
        Me.SEARCHBTN.Text = "بحث"
        '
        'EDITBTN
        '
        Me.EDITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EDITBTN.Appearance.ForeColor = System.Drawing.Color.SteelBlue
        Me.EDITBTN.Appearance.Options.UseFont = True
        Me.EDITBTN.Appearance.Options.UseForeColor = True
        Me.EDITBTN.ImageOptions.Image = CType(resources.GetObject("EDITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EDITBTN.Location = New System.Drawing.Point(266, 385)
        Me.EDITBTN.Name = "EDITBTN"
        Me.EDITBTN.Size = New System.Drawing.Size(96, 36)
        Me.EDITBTN.TabIndex = 144
        Me.EDITBTN.Text = "تعديل"
        '
        'ACTIVE_DOCTOR
        '
        Me.ACTIVE_DOCTOR.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ACTIVE_DOCTOR.Appearance.Options.UseFont = True
        Me.ACTIVE_DOCTOR.ImageOptions.Image = CType(resources.GetObject("ACTIVE_DOCTOR.ImageOptions.Image"), System.Drawing.Image)
        Me.ACTIVE_DOCTOR.Location = New System.Drawing.Point(685, 41)
        Me.ACTIVE_DOCTOR.Name = "ACTIVE_DOCTOR"
        Me.ACTIVE_DOCTOR.Size = New System.Drawing.Size(42, 35)
        Me.ACTIVE_DOCTOR.TabIndex = 136
        Me.ACTIVE_DOCTOR.Visible = False
        '
        'EXITBTN
        '
        Me.EXITBTN.ImageOptions.Image = CType(resources.GetObject("EXITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBTN.Location = New System.Drawing.Point(693, 386)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(39, 36)
        Me.EXITBTN.TabIndex = 135
        '
        'NEWBTN
        '
        Me.NEWBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NEWBTN.Appearance.Options.UseFont = True
        Me.NEWBTN.ImageOptions.Image = CType(resources.GetObject("NEWBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.NEWBTN.Location = New System.Drawing.Point(36, 385)
        Me.NEWBTN.Name = "NEWBTN"
        Me.NEWBTN.Size = New System.Drawing.Size(93, 36)
        Me.NEWBTN.TabIndex = 133
        Me.NEWBTN.Text = "جديد"
        '
        'SAVEBTN
        '
        Me.SAVEBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVEBTN.Appearance.Options.UseFont = True
        Me.SAVEBTN.ImageOptions.Image = CType(resources.GetObject("SAVEBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SAVEBTN.Location = New System.Drawing.Point(150, 386)
        Me.SAVEBTN.Name = "SAVEBTN"
        Me.SAVEBTN.Size = New System.Drawing.Size(93, 36)
        Me.SAVEBTN.TabIndex = 132
        Me.SAVEBTN.Text = "حفظ"
        '
        'TXT_TYPEMONY
        '
        Me.TXT_TYPEMONY.BackColor = System.Drawing.Color.White
        Me.TXT_TYPEMONY.Enabled = False
        Me.TXT_TYPEMONY.Location = New System.Drawing.Point(492, 43)
        Me.TXT_TYPEMONY.Name = "TXT_TYPEMONY"
        Me.TXT_TYPEMONY.Size = New System.Drawing.Size(87, 29)
        Me.TXT_TYPEMONY.TabIndex = 148
        Me.TXT_TYPEMONY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "نوع التعامل :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(491, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 150
        Me.Label7.Text = "حتى تاريخ :"
        '
        'TXT_DATE2
        '
        Me.TXT_DATE2.Checked = False
        Me.TXT_DATE2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE2.Location = New System.Drawing.Point(577, 5)
        Me.TXT_DATE2.Name = "TXT_DATE2"
        Me.TXT_DATE2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_DATE2.Size = New System.Drawing.Size(173, 29)
        Me.TXT_DATE2.TabIndex = 149
        Me.TXT_DATE2.Value = New Date(2020, 4, 1, 0, 0, 0, 0)
        Me.TXT_DATE2.Visible = False
        '
        'ATAB_DOCTORS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXT_DATE2)
        Me.Controls.Add(Me.TXT_TYPEMONY)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PRINTBTN)
        Me.Controls.Add(Me.SEARCHBTN)
        Me.Controls.Add(Me.EDITBTN)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.KHAZINA_CODE)
        Me.Controls.Add(Me.KHAZINA_NAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXT_CODE)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SAFY_AR)
        Me.Controls.Add(Me.ACTIVE_DOCTOR)
        Me.Controls.Add(Me.EXITBTN)
        Me.Controls.Add(Me.NEWBTN)
        Me.Controls.Add(Me.SAVEBTN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_TOTAL)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_DATE)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_DOCTOR_CODE)
        Me.Controls.Add(Me.TXT_DOCTOR)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ATAB_DOCTORS"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                            أيصال أتعاب الطبيب"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_DOCTOR_CODE As TextBox
    Friend WithEvents TXT_DOCTOR As ComboBox
    Friend WithEvents TXT_DATE As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXT_TOTAL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NEWBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SAVEBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ACTIVE_DOCTOR As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents SAFY_AR As TextBox
    Friend WithEvents KHAZINA_CODE As TextBox
    Friend WithEvents KHAZINA_NAME As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TIMERADD As Timer
    Friend WithEvents TIMEREDIT As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents USER_ADD As ToolStripStatusLabel
    Friend WithEvents DATE_ADD As ToolStripStatusLabel
    Friend WithEvents TIME_ADD As ToolStripStatusLabel
    Friend WithEvents EDITNAMEBT As ToolStripStatusLabel
    Friend WithEvents USER_EDIT As ToolStripStatusLabel
    Friend WithEvents DATE_EDIT As ToolStripStatusLabel
    Friend WithEvents TIME_EDIT As ToolStripStatusLabel
    Friend WithEvents EDITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SEARCHBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PRINTBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_TYPEMONY As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_DATE2 As DateTimePicker
End Class
