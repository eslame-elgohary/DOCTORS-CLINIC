<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TEST_FRM_INFERTILITY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TEST_FRM_INFERTILITY))
        Me.TXT_DATE_TEST = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TXT_CODE_TEST = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_PA_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_NAME_PALCE_TEST = New System.Windows.Forms.TextBox()
        Me.TXT_TESTNAME = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TXT_RESULT_TEST = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTN_DELET = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EDIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_DATE_TEST
        '
        Me.TXT_DATE_TEST.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DATE_TEST.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE_TEST.Location = New System.Drawing.Point(100, 41)
        Me.TXT_DATE_TEST.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_DATE_TEST.Name = "TXT_DATE_TEST"
        Me.TXT_DATE_TEST.Size = New System.Drawing.Size(152, 27)
        Me.TXT_DATE_TEST.TabIndex = 7
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label33.Location = New System.Drawing.Point(37, 44)
        Me.Label33.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(59, 19)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Date :"
        '
        'TXT_CODE_TEST
        '
        Me.TXT_CODE_TEST.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_TEST.Enabled = False
        Me.TXT_CODE_TEST.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CODE_TEST.Location = New System.Drawing.Point(72, 10)
        Me.TXT_CODE_TEST.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_CODE_TEST.Name = "TXT_CODE_TEST"
        Me.TXT_CODE_TEST.Size = New System.Drawing.Size(92, 27)
        Me.TXT_CODE_TEST.TabIndex = 72
        Me.TXT_CODE_TEST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label30.Location = New System.Drawing.Point(284, 43)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 19)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "PLACE :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Code :"
        '
        'TXT_PA_NAME
        '
        Me.TXT_PA_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_PA_NAME.Enabled = False
        Me.TXT_PA_NAME.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PA_NAME.Location = New System.Drawing.Point(245, 10)
        Me.TXT_PA_NAME.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_PA_NAME.Name = "TXT_PA_NAME"
        Me.TXT_PA_NAME.Size = New System.Drawing.Size(283, 27)
        Me.TXT_PA_NAME.TabIndex = 82
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_PA_CODE.Enabled = False
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(288, -5)
        Me.TXT_PA_CODE.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(27, 21)
        Me.TXT_PA_CODE.TabIndex = 81
        Me.TXT_PA_CODE.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label7.Location = New System.Drawing.Point(174, 13)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "NAME :"
        '
        'TXT_NAME_PALCE_TEST
        '
        Me.TXT_NAME_PALCE_TEST.BackColor = System.Drawing.Color.Aqua
        Me.TXT_NAME_PALCE_TEST.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME_PALCE_TEST.Location = New System.Drawing.Point(361, 41)
        Me.TXT_NAME_PALCE_TEST.Margin = New System.Windows.Forms.Padding(2)
        Me.TXT_NAME_PALCE_TEST.Name = "TXT_NAME_PALCE_TEST"
        Me.TXT_NAME_PALCE_TEST.Size = New System.Drawing.Size(167, 27)
        Me.TXT_NAME_PALCE_TEST.TabIndex = 83
        '
        'TXT_TESTNAME
        '
        Me.TXT_TESTNAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_TESTNAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_TESTNAME.BackColor = System.Drawing.Color.Aqua
        Me.TXT_TESTNAME.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TESTNAME.FormattingEnabled = True
        Me.TXT_TESTNAME.Location = New System.Drawing.Point(120, 73)
        Me.TXT_TESTNAME.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TXT_TESTNAME.Name = "TXT_TESTNAME"
        Me.TXT_TESTNAME.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_TESTNAME.Size = New System.Drawing.Size(213, 27)
        Me.TXT_TESTNAME.TabIndex = 110
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label22.Location = New System.Drawing.Point(10, 75)
        Me.Label22.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(108, 19)
        Me.Label22.TabIndex = 111
        Me.Label22.Text = "Name Test :"
        '
        'TXT_RESULT_TEST
        '
        Me.TXT_RESULT_TEST.BackColor = System.Drawing.Color.Aqua
        Me.TXT_RESULT_TEST.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_RESULT_TEST.Location = New System.Drawing.Point(412, 75)
        Me.TXT_RESULT_TEST.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.TXT_RESULT_TEST.Name = "TXT_RESULT_TEST"
        Me.TXT_RESULT_TEST.Size = New System.Drawing.Size(116, 27)
        Me.TXT_RESULT_TEST.TabIndex = 113
        Me.TXT_RESULT_TEST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label25.Location = New System.Drawing.Point(335, 77)
        Me.Label25.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(72, 19)
        Me.Label25.TabIndex = 112
        Me.Label25.Text = "Result :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 173)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(526, 257)
        Me.DataGridView1.TabIndex = 114
        '
        'BTN_DELET
        '
        Me.BTN_DELET.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELET.Appearance.Options.UseFont = True
        Me.BTN_DELET.ImageOptions.Image = CType(resources.GetObject("BTN_DELET.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_DELET.Location = New System.Drawing.Point(341, 118)
        Me.BTN_DELET.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_DELET.Name = "BTN_DELET"
        Me.BTN_DELET.Size = New System.Drawing.Size(91, 40)
        Me.BTN_DELET.TabIndex = 78
        Me.BTN_DELET.Text = "DELET"
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEW.Appearance.Options.UseFont = True
        Me.BTN_NEW.ImageOptions.Image = CType(resources.GetObject("BTN_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NEW.Location = New System.Drawing.Point(29, 118)
        Me.BTN_NEW.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(84, 40)
        Me.BTN_NEW.TabIndex = 75
        Me.BTN_NEW.Text = "NEW"
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.Appearance.Options.UseFont = True
        Me.BTN_SAVE.ImageOptions.Image = CType(resources.GetObject("BTN_SAVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_SAVE.Location = New System.Drawing.Point(128, 118)
        Me.BTN_SAVE.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(99, 40)
        Me.BTN_SAVE.TabIndex = 76
        Me.BTN_SAVE.Text = "SAVE"
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDIT.Appearance.Options.UseFont = True
        Me.BTN_EDIT.ImageOptions.Image = CType(resources.GetObject("BTN_EDIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EDIT.Location = New System.Drawing.Point(241, 118)
        Me.BTN_EDIT.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_EDIT.Name = "BTN_EDIT"
        Me.BTN_EDIT.Size = New System.Drawing.Size(88, 40)
        Me.BTN_EDIT.TabIndex = 77
        Me.BTN_EDIT.Text = "EDIT"
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(448, 118)
        Me.BTN_EXIT.Margin = New System.Windows.Forms.Padding(2)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(80, 40)
        Me.BTN_EXIT.TabIndex = 79
        Me.BTN_EXIT.Text = "EXIT"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_TEST_INFERT"
        Me.Column1.HeaderText = "code"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NAME_PALCE_TEST_INFERT"
        Me.Column2.FillWeight = 40.0!
        Me.Column2.HeaderText = "Place"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "DATE_TEST_INFERT"
        Me.Column3.FillWeight = 70.0!
        Me.Column3.HeaderText = "Date"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "NAME_TEST_INFERT"
        Me.Column4.HeaderText = "Name Test"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "RESULT_TEST_INFERT"
        Me.Column5.HeaderText = "Result"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'TEST_FRM_INFERTILITY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 435)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TXT_RESULT_TEST)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.TXT_TESTNAME)
        Me.Controls.Add(Me.TXT_NAME_PALCE_TEST)
        Me.Controls.Add(Me.TXT_PA_NAME)
        Me.Controls.Add(Me.TXT_PA_CODE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_EDIT)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.BTN_NEW)
        Me.Controls.Add(Me.BTN_DELET)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_CODE_TEST)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.TXT_DATE_TEST)
        Me.Controls.Add(Me.Label33)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TEST_FRM_INFERTILITY"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investigations"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_DATE_TEST As DateTimePicker
    Friend WithEvents Label33 As Label
    Friend WithEvents TXT_CODE_TEST As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_PA_NAME As TextBox
    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_NAME_PALCE_TEST As TextBox
    Friend WithEvents TXT_TESTNAME As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TXT_RESULT_TEST As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_DELET As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EDIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
