<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HISTORY_ENGAB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HISTORY_ENGAB))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_INFO2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_AGE2 = New System.Windows.Forms.TextBox()
        Me.TXT_NAME2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_COMPIN = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TXT_DATE_MARRIED = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_AGE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NAME_PA = New System.Windows.Forms.ComboBox()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.TXT_SEARCH = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_DELET = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EDIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_PA_CODE)
        Me.GroupBox1.Controls.Add(Me.TXT_INFO2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_AGE2)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME2)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TXT_COMPIN)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.TXT_DATE_MARRIED)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_AGE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME_PA)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Location = New System.Drawing.Point(6, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(708, 138)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.Enabled = False
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(275, 15)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(36, 27)
        Me.TXT_PA_CODE.TabIndex = 120
        Me.TXT_PA_CODE.Visible = False
        '
        'TXT_INFO2
        '
        Me.TXT_INFO2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_INFO2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_INFO2.BackColor = System.Drawing.Color.Aqua
        Me.TXT_INFO2.FormattingEnabled = True
        Me.TXT_INFO2.Items.AddRange(New Object() {"مدخن", "غير مدخن"})
        Me.TXT_INFO2.Location = New System.Drawing.Point(546, 92)
        Me.TXT_INFO2.Name = "TXT_INFO2"
        Me.TXT_INFO2.Size = New System.Drawing.Size(142, 27)
        Me.TXT_INFO2.TabIndex = 119
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(479, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(64, 19)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Habits :"
        '
        'TXT_AGE2
        '
        Me.TXT_AGE2.BackColor = System.Drawing.Color.Aqua
        Me.TXT_AGE2.Location = New System.Drawing.Point(418, 92)
        Me.TXT_AGE2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TXT_AGE2.Name = "TXT_AGE2"
        Me.TXT_AGE2.Size = New System.Drawing.Size(57, 27)
        Me.TXT_AGE2.TabIndex = 115
        Me.TXT_AGE2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_NAME2
        '
        Me.TXT_NAME2.BackColor = System.Drawing.Color.White
        Me.TXT_NAME2.Enabled = False
        Me.TXT_NAME2.Location = New System.Drawing.Point(138, 94)
        Me.TXT_NAME2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TXT_NAME2.Name = "TXT_NAME2"
        Me.TXT_NAME2.Size = New System.Drawing.Size(209, 27)
        Me.TXT_NAME2.TabIndex = 114
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 97)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(128, 19)
        Me.Label9.TabIndex = 117
        Me.Label9.Text = "Husband Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(366, 97)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(48, 19)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Age :"
        '
        'TXT_COMPIN
        '
        Me.TXT_COMPIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TXT_COMPIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_COMPIN.BackColor = System.Drawing.Color.Aqua
        Me.TXT_COMPIN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.TXT_COMPIN.FormattingEnabled = True
        Me.TXT_COMPIN.Location = New System.Drawing.Point(393, 59)
        Me.TXT_COMPIN.Name = "TXT_COMPIN"
        Me.TXT_COMPIN.Size = New System.Drawing.Size(295, 27)
        Me.TXT_COMPIN.TabIndex = 113
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(299, 61)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label27.Size = New System.Drawing.Size(92, 19)
        Me.Label27.TabIndex = 112
        Me.Label27.Text = "Complaint :"
        '
        'TXT_DATE_MARRIED
        '
        Me.TXT_DATE_MARRIED.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE_MARRIED.Location = New System.Drawing.Point(124, 58)
        Me.TXT_DATE_MARRIED.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TXT_DATE_MARRIED.Name = "TXT_DATE_MARRIED"
        Me.TXT_DATE_MARRIED.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TXT_DATE_MARRIED.Size = New System.Drawing.Size(171, 27)
        Me.TXT_DATE_MARRIED.TabIndex = 103
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 61)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(115, 19)
        Me.Label6.TabIndex = 104
        Me.Label6.Text = "Married Since :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(550, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Age :"
        '
        'TXT_AGE
        '
        Me.TXT_AGE.BackColor = System.Drawing.Color.White
        Me.TXT_AGE.Enabled = False
        Me.TXT_AGE.Location = New System.Drawing.Point(602, 26)
        Me.TXT_AGE.Name = "TXT_AGE"
        Me.TXT_AGE.Size = New System.Drawing.Size(86, 27)
        Me.TXT_AGE.TabIndex = 4
        Me.TXT_AGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Code :"
        '
        'TXT_NAME_PA
        '
        Me.TXT_NAME_PA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TXT_NAME_PA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TXT_NAME_PA.BackColor = System.Drawing.Color.Aqua
        Me.TXT_NAME_PA.FormattingEnabled = True
        Me.TXT_NAME_PA.Location = New System.Drawing.Point(233, 23)
        Me.TXT_NAME_PA.Name = "TXT_NAME_PA"
        Me.TXT_NAME_PA.Size = New System.Drawing.Size(301, 27)
        Me.TXT_NAME_PA.TabIndex = 1
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(74, 20)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(86, 27)
        Me.TXT_CODE.TabIndex = 0
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_SEARCH
        '
        Me.TXT_SEARCH.BackColor = System.Drawing.Color.LightYellow
        Me.TXT_SEARCH.Location = New System.Drawing.Point(281, 192)
        Me.TXT_SEARCH.Name = "TXT_SEARCH"
        Me.TXT_SEARCH.Size = New System.Drawing.Size(333, 27)
        Me.TXT_SEARCH.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Location = New System.Drawing.Point(140, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(128, 19)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "SEARCH NAME :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(6, 228)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(708, 236)
        Me.DataGridView1.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_INFERT_HIS"
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
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(95, 140)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EXIT.TabIndex = 21
        Me.BTN_EXIT.Text = "EXIT"
        '
        'BTN_DELET
        '
        Me.BTN_DELET.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELET.Appearance.Options.UseFont = True
        Me.BTN_DELET.ImageOptions.Image = CType(resources.GetObject("BTN_DELET.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_DELET.Location = New System.Drawing.Point(198, 140)
        Me.BTN_DELET.Name = "BTN_DELET"
        Me.BTN_DELET.Size = New System.Drawing.Size(87, 33)
        Me.BTN_DELET.TabIndex = 20
        Me.BTN_DELET.Text = "DELET"
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDIT.Appearance.Options.UseFont = True
        Me.BTN_EDIT.ImageOptions.Image = CType(resources.GetObject("BTN_EDIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EDIT.Location = New System.Drawing.Point(299, 140)
        Me.BTN_EDIT.Name = "BTN_EDIT"
        Me.BTN_EDIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EDIT.TabIndex = 19
        Me.BTN_EDIT.Text = "EDIT"
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.Appearance.Options.UseFont = True
        Me.BTN_SAVE.ImageOptions.Image = CType(resources.GetObject("BTN_SAVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_SAVE.Location = New System.Drawing.Point(398, 140)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(87, 33)
        Me.BTN_SAVE.TabIndex = 18
        Me.BTN_SAVE.Text = "SAVE"
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEW.Appearance.Options.UseFont = True
        Me.BTN_NEW.ImageOptions.Image = CType(resources.GetObject("BTN_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NEW.Location = New System.Drawing.Point(498, 140)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(87, 33)
        Me.BTN_NEW.TabIndex = 17
        Me.BTN_NEW.Text = "NEW"
        '
        'HISTORY_ENGAB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 467)
        Me.Controls.Add(Me.TXT_SEARCH)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_DELET)
        Me.Controls.Add(Me.BTN_EDIT)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.BTN_NEW)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HISTORY_ENGAB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INFERTILITY HISTORY"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_AGE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_NAME_PA As ComboBox
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents TXT_DATE_MARRIED As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TXT_COMPIN As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TXT_AGE2 As TextBox
    Friend WithEvents TXT_NAME2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_INFO2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents TXT_SEARCH As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_DELET As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EDIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
