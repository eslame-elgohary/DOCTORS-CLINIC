<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PERSONAL_HISTORY_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PERSONAL_HISTORY_FRM))
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_DELET = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EDIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_RH = New System.Windows.Forms.ComboBox()
        Me.TXT_ABO = New System.Windows.Forms.ComboBox()
        Me.TXT_NAME = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EDP_DATE = New System.Windows.Forms.DateTimePicker()
        Me.LMP_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MARED_DEAT = New System.Windows.Forms.DateTimePicker()
        Me.TXT_NAME2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_AGE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_SEARCH = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(413, 192)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EXIT.TabIndex = 12
        Me.BTN_EXIT.Text = "EXIT"
        '
        'BTN_DELET
        '
        Me.BTN_DELET.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELET.Appearance.Options.UseFont = True
        Me.BTN_DELET.ImageOptions.Image = CType(resources.GetObject("BTN_DELET.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_DELET.Location = New System.Drawing.Point(317, 192)
        Me.BTN_DELET.Name = "BTN_DELET"
        Me.BTN_DELET.Size = New System.Drawing.Size(87, 33)
        Me.BTN_DELET.TabIndex = 11
        Me.BTN_DELET.Text = "DELET"
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDIT.Appearance.Options.UseFont = True
        Me.BTN_EDIT.ImageOptions.Image = CType(resources.GetObject("BTN_EDIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EDIT.Location = New System.Drawing.Point(216, 192)
        Me.BTN_EDIT.Name = "BTN_EDIT"
        Me.BTN_EDIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EDIT.TabIndex = 10
        Me.BTN_EDIT.Text = "EDIT"
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.Appearance.Options.UseFont = True
        Me.BTN_SAVE.ImageOptions.Image = CType(resources.GetObject("BTN_SAVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_SAVE.Location = New System.Drawing.Point(114, 192)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(87, 33)
        Me.BTN_SAVE.TabIndex = 9
        Me.BTN_SAVE.Text = "SAVE"
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEW.Appearance.Options.UseFont = True
        Me.BTN_NEW.ImageOptions.Image = CType(resources.GetObject("BTN_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NEW.Location = New System.Drawing.Point(12, 192)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(87, 33)
        Me.BTN_NEW.TabIndex = 8
        Me.BTN_NEW.Text = "NEW"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(488, 215)
        Me.DataGridView1.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_PA_CODE)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXT_RH)
        Me.GroupBox1.Controls.Add(Me.TXT_ABO)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.EDP_DATE)
        Me.GroupBox1.Controls.Add(Me.LMP_DATE)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.MARED_DEAT)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_AGE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(3, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(509, 183)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_PA_CODE.Enabled = False
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(227, 15)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(42, 27)
        Me.TXT_PA_CODE.TabIndex = 19
        Me.TXT_PA_CODE.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(55, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "ABO :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(299, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "RH :"
        '
        'TXT_RH
        '
        Me.TXT_RH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_RH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_RH.BackColor = System.Drawing.Color.Aqua
        Me.TXT_RH.FormattingEnabled = True
        Me.TXT_RH.Items.AddRange(New Object() {"POSITIVE", "NEGATIVE"})
        Me.TXT_RH.Location = New System.Drawing.Point(349, 150)
        Me.TXT_RH.Name = "TXT_RH"
        Me.TXT_RH.Size = New System.Drawing.Size(147, 27)
        Me.TXT_RH.TabIndex = 16
        '
        'TXT_ABO
        '
        Me.TXT_ABO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_ABO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_ABO.BackColor = System.Drawing.Color.Aqua
        Me.TXT_ABO.FormattingEnabled = True
        Me.TXT_ABO.Items.AddRange(New Object() {"A", "B", "AB", "O"})
        Me.TXT_ABO.Location = New System.Drawing.Point(114, 150)
        Me.TXT_ABO.Name = "TXT_ABO"
        Me.TXT_ABO.Size = New System.Drawing.Size(146, 27)
        Me.TXT_ABO.TabIndex = 15
        '
        'TXT_NAME
        '
        Me.TXT_NAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_NAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_NAME.BackColor = System.Drawing.Color.Aqua
        Me.TXT_NAME.FormattingEnabled = True
        Me.TXT_NAME.Location = New System.Drawing.Point(249, 18)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(247, 27)
        Me.TXT_NAME.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(175, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "NAME :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(280, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "E.D.D :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "L.M.P :"
        '
        'EDP_DATE
        '
        Me.EDP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EDP_DATE.Location = New System.Drawing.Point(349, 117)
        Me.EDP_DATE.Name = "EDP_DATE"
        Me.EDP_DATE.Size = New System.Drawing.Size(147, 27)
        Me.EDP_DATE.TabIndex = 10
        '
        'LMP_DATE
        '
        Me.LMP_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.LMP_DATE.Location = New System.Drawing.Point(113, 116)
        Me.LMP_DATE.Name = "LMP_DATE"
        Me.LMP_DATE.Size = New System.Drawing.Size(147, 27)
        Me.LMP_DATE.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Married Since :"
        '
        'MARED_DEAT
        '
        Me.MARED_DEAT.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MARED_DEAT.Location = New System.Drawing.Point(140, 82)
        Me.MARED_DEAT.Name = "MARED_DEAT"
        Me.MARED_DEAT.Size = New System.Drawing.Size(192, 27)
        Me.MARED_DEAT.TabIndex = 7
        '
        'TXT_NAME2
        '
        Me.TXT_NAME2.BackColor = System.Drawing.Color.White
        Me.TXT_NAME2.Enabled = False
        Me.TXT_NAME2.Location = New System.Drawing.Point(296, 50)
        Me.TXT_NAME2.Name = "TXT_NAME2"
        Me.TXT_NAME2.Size = New System.Drawing.Size(204, 27)
        Me.TXT_NAME2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(142, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "HUSBAND NAME :"
        '
        'TXT_AGE
        '
        Me.TXT_AGE.BackColor = System.Drawing.Color.White
        Me.TXT_AGE.Enabled = False
        Me.TXT_AGE.Location = New System.Drawing.Point(59, 50)
        Me.TXT_AGE.Name = "TXT_AGE"
        Me.TXT_AGE.Size = New System.Drawing.Size(73, 27)
        Me.TXT_AGE.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "age :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CODE :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(96, 18)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(73, 27)
        Me.TXT_CODE.TabIndex = 0
        '
        'TXT_SEARCH
        '
        Me.TXT_SEARCH.BackColor = System.Drawing.Color.LightYellow
        Me.TXT_SEARCH.Location = New System.Drawing.Point(29, 234)
        Me.TXT_SEARCH.Name = "TXT_SEARCH"
        Me.TXT_SEARCH.Size = New System.Drawing.Size(333, 27)
        Me.TXT_SEARCH.TabIndex = 15
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Location = New System.Drawing.Point(364, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(140, 19)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "SEARCH NAME :"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_PERS"
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PA_NAME"
        Me.Column2.HeaderText = "NAME"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "PA_NAME2"
        Me.Column4.HeaderText = "HUSBAND NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 30.0!
        Me.Column3.HeaderText = "-"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'PERSONAL_HISTORY_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 493)
        Me.Controls.Add(Me.TXT_SEARCH)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_DELET)
        Me.Controls.Add(Me.BTN_EDIT)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.BTN_NEW)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "PERSONAL_HISTORY_FRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERSONAL HISTORY"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_DELET As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EDIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXT_NAME2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_AGE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents TXT_NAME As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents EDP_DATE As DateTimePicker
    Friend WithEvents LMP_DATE As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents MARED_DEAT As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_RH As ComboBox
    Friend WithEvents TXT_ABO As ComboBox
    Friend WithEvents TXT_SEARCH As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
