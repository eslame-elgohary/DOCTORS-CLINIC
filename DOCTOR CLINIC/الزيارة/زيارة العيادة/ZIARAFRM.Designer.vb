﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ZIARAFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ZIARAFRM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SEARCH_BTN = New DevExpress.XtraEditors.SimpleButton()
        Me.CALL_BTN = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_CALL_INFO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DATE_TODAY = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXT_TKHSOS_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_CODE = New System.Windows.Forms.Label()
        Me.TXT_DOC_CODE = New System.Windows.Forms.TextBox()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NOACTIVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_ACTIVE = New DevExpress.XtraEditors.SimpleButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_DOC = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_TKHSOS = New System.Windows.Forms.TextBox()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_PA_TEL2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_PA_TEL = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_PA = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SEARCH_BTN)
        Me.GroupBox1.Controls.Add(Me.CALL_BTN)
        Me.GroupBox1.Controls.Add(Me.TXT_CALL_INFO)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DATE_TODAY)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHSOS_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_DOC_CODE)
        Me.GroupBox1.Controls.Add(Me.BTN_EXIT)
        Me.GroupBox1.Controls.Add(Me.BTN_NEW)
        Me.GroupBox1.Controls.Add(Me.BTN_NOACTIVE)
        Me.GroupBox1.Controls.Add(Me.BTN_ACTIVE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_DOC)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_TKHSOS)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_TEL2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_TEL)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_PA)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1159, 200)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'SEARCH_BTN
        '
        Me.SEARCH_BTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCH_BTN.Appearance.Options.UseFont = True
        Me.SEARCH_BTN.ImageOptions.Image = CType(resources.GetObject("SEARCH_BTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SEARCH_BTN.Location = New System.Drawing.Point(114, 133)
        Me.SEARCH_BTN.Name = "SEARCH_BTN"
        Me.SEARCH_BTN.Size = New System.Drawing.Size(195, 49)
        Me.SEARCH_BTN.TabIndex = 23
        Me.SEARCH_BTN.Text = "عرض حالة المريض"
        '
        'CALL_BTN
        '
        Me.CALL_BTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CALL_BTN.Appearance.Options.UseFont = True
        Me.CALL_BTN.ImageOptions.Image = Global.DOCTOR_CLINIC.My.Resources.Resources.iconfinder_phone_call__text__sms_dial__2992207__1_
        Me.CALL_BTN.Location = New System.Drawing.Point(744, 133)
        Me.CALL_BTN.Name = "CALL_BTN"
        Me.CALL_BTN.Size = New System.Drawing.Size(141, 49)
        Me.CALL_BTN.TabIndex = 22
        Me.CALL_BTN.Text = "أتصال"
        '
        'TXT_CALL_INFO
        '
        Me.TXT_CALL_INFO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_CALL_INFO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_CALL_INFO.FormattingEnabled = True
        Me.TXT_CALL_INFO.Items.AddRange(New Object() {"التليفون غير متاح", "التليفون مغلق", "سيتم الحضور", "جرس ولم يرد"})
        Me.TXT_CALL_INFO.Location = New System.Drawing.Point(900, 144)
        Me.TXT_CALL_INFO.Name = "TXT_CALL_INFO"
        Me.TXT_CALL_INFO.Size = New System.Drawing.Size(238, 29)
        Me.TXT_CALL_INFO.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(19, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(485, 21)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "* ملحوظة : لن يتم ظهور أسم المريض أذا كان التاريخ مختلف عن تاريخ الحجز"
        '
        'DATE_TODAY
        '
        Me.DATE_TODAY.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATE_TODAY.Location = New System.Drawing.Point(523, 57)
        Me.DATE_TODAY.Name = "DATE_TODAY"
        Me.DATE_TODAY.Size = New System.Drawing.Size(167, 29)
        Me.DATE_TODAY.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(696, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 21)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "تاريخ اليوم :"
        '
        'TXT_TKHSOS_CODE
        '
        Me.TXT_TKHSOS_CODE.Location = New System.Drawing.Point(181, 13)
        Me.TXT_TKHSOS_CODE.Name = "TXT_TKHSOS_CODE"
        Me.TXT_TKHSOS_CODE.Size = New System.Drawing.Size(42, 29)
        Me.TXT_TKHSOS_CODE.TabIndex = 17
        Me.TXT_TKHSOS_CODE.Visible = False
        '
        'TXT_CODE
        '
        Me.TXT_CODE.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE.ForeColor = System.Drawing.Color.Green
        Me.TXT_CODE.Location = New System.Drawing.Point(866, 89)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(118, 47)
        Me.TXT_CODE.TabIndex = 16
        Me.TXT_CODE.Text = "100000"
        '
        'TXT_DOC_CODE
        '
        Me.TXT_DOC_CODE.Location = New System.Drawing.Point(1103, 54)
        Me.TXT_DOC_CODE.Name = "TXT_DOC_CODE"
        Me.TXT_DOC_CODE.Size = New System.Drawing.Size(42, 29)
        Me.TXT_DOC_CODE.TabIndex = 15
        Me.TXT_DOC_CODE.Visible = False
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(10, 133)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(96, 49)
        Me.BTN_EXIT.TabIndex = 14
        Me.BTN_EXIT.Text = "أغلاق"
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEW.Appearance.Options.UseFont = True
        Me.BTN_NEW.ImageOptions.Image = CType(resources.GetObject("BTN_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NEW.Location = New System.Drawing.Point(322, 133)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(96, 49)
        Me.BTN_NEW.TabIndex = 13
        Me.BTN_NEW.Text = "جديد"
        '
        'BTN_NOACTIVE
        '
        Me.BTN_NOACTIVE.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NOACTIVE.Appearance.Options.UseFont = True
        Me.BTN_NOACTIVE.ImageOptions.Image = CType(resources.GetObject("BTN_NOACTIVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NOACTIVE.Location = New System.Drawing.Point(428, 133)
        Me.BTN_NOACTIVE.Name = "BTN_NOACTIVE"
        Me.BTN_NOACTIVE.Size = New System.Drawing.Size(151, 49)
        Me.BTN_NOACTIVE.TabIndex = 12
        Me.BTN_NOACTIVE.Text = "الغاء الحجز"
        '
        'BTN_ACTIVE
        '
        Me.BTN_ACTIVE.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACTIVE.Appearance.Options.UseFont = True
        Me.BTN_ACTIVE.ImageOptions.Image = CType(resources.GetObject("BTN_ACTIVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_ACTIVE.Location = New System.Drawing.Point(592, 133)
        Me.BTN_ACTIVE.Name = "BTN_ACTIVE"
        Me.BTN_ACTIVE.Size = New System.Drawing.Size(141, 49)
        Me.BTN_ACTIVE.TabIndex = 11
        Me.BTN_ACTIVE.Text = "تأكيد الحجز"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1050, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "الطبيب :"
        '
        'TXT_DOC
        '
        Me.TXT_DOC.BackColor = System.Drawing.Color.White
        Me.TXT_DOC.Enabled = False
        Me.TXT_DOC.Location = New System.Drawing.Point(795, 54)
        Me.TXT_DOC.Name = "TXT_DOC"
        Me.TXT_DOC.Size = New System.Drawing.Size(250, 29)
        Me.TXT_DOC.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "العيادة :"
        '
        'TXT_TKHSOS
        '
        Me.TXT_TKHSOS.BackColor = System.Drawing.Color.White
        Me.TXT_TKHSOS.Enabled = False
        Me.TXT_TKHSOS.Location = New System.Drawing.Point(19, 21)
        Me.TXT_TKHSOS.Name = "TXT_TKHSOS"
        Me.TXT_TKHSOS.Size = New System.Drawing.Size(250, 29)
        Me.TXT_TKHSOS.TabIndex = 7
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(1103, 19)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(42, 29)
        Me.TXT_PA_CODE.TabIndex = 6
        Me.TXT_PA_CODE.Visible = False
        '
        'TXT_PA_TEL2
        '
        Me.TXT_PA_TEL2.BackColor = System.Drawing.Color.White
        Me.TXT_PA_TEL2.Enabled = False
        Me.TXT_PA_TEL2.Location = New System.Drawing.Point(348, 22)
        Me.TXT_PA_TEL2.Name = "TXT_PA_TEL2"
        Me.TXT_PA_TEL2.Size = New System.Drawing.Size(162, 29)
        Me.TXT_PA_TEL2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(692, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "رقم التليفون :"
        '
        'TXT_PA_TEL
        '
        Me.TXT_PA_TEL.BackColor = System.Drawing.Color.White
        Me.TXT_PA_TEL.Enabled = False
        Me.TXT_PA_TEL.Location = New System.Drawing.Point(525, 22)
        Me.TXT_PA_TEL.Name = "TXT_PA_TEL"
        Me.TXT_PA_TEL.Size = New System.Drawing.Size(162, 29)
        Me.TXT_PA_TEL.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1051, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "أسم المريض :"
        '
        'TXT_PA
        '
        Me.TXT_PA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_PA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_PA.FormattingEnabled = True
        Me.TXT_PA.Location = New System.Drawing.Point(791, 19)
        Me.TXT_PA.Name = "TXT_PA"
        Me.TXT_PA.Size = New System.Drawing.Size(254, 29)
        Me.TXT_PA.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(510, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "-"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 209)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1159, 306)
        Me.DataGridView1.TabIndex = 1
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CODE_H_A"
        Me.Column2.FillWeight = 40.0!
        Me.Column2.HeaderText = "رقم الحجز"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_PA_H_A"
        Me.Column1.HeaderText = "كود المريض"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "PA_NAME"
        Me.Column3.HeaderText = "أسم المريض"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "DO_NAME"
        Me.Column4.HeaderText = "الطبيب"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "TYPE_A"
        Me.Column5.HeaderText = "الأجراء"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "DATE_H_A"
        Me.Column6.FillWeight = 60.0!
        Me.Column6.HeaderText = "التاريخ"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "رقم الملف"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "ملاحظات"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'ZIARAFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 522)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "ZIARAFRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "زيارة المرضي للعيادات"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_DOC As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_TKHSOS As TextBox
    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents TXT_PA_TEL2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_PA_TEL As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_PA As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTN_NOACTIVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_ACTIVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_DOC_CODE As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXT_CODE As Label
    Friend WithEvents TXT_TKHSOS_CODE As TextBox
    Friend WithEvents DATE_TODAY As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CALL_BTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_CALL_INFO As ComboBox
    Friend WithEvents SEARCH_BTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
