<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMP_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMP_FRM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXT_DQAQ_MONY = New System.Windows.Forms.TextBox()
        Me.TXT_DQAQ = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_RATEB = New System.Windows.Forms.TextBox()
        Me.TXT_ENSRAF = New System.Windows.Forms.MaskedTextBox()
        Me.TXT_HDOR = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.GRBTN = New System.Windows.Forms.GroupBox()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.DELETBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.EDITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.NEWBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TXT_SEARCH = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GRBTN.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TXT_DQAQ_MONY)
        Me.GroupBox1.Controls.Add(Me.TXT_DQAQ)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXT_RATEB)
        Me.GroupBox1.Controls.Add(Me.TXT_ENSRAF)
        Me.GroupBox1.Controls.Add(Me.TXT_HDOR)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.Location = New System.Drawing.Point(9, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 118)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TXT_DQAQ_MONY
        '
        Me.TXT_DQAQ_MONY.Location = New System.Drawing.Point(310, 132)
        Me.TXT_DQAQ_MONY.Name = "TXT_DQAQ_MONY"
        Me.TXT_DQAQ_MONY.Size = New System.Drawing.Size(191, 29)
        Me.TXT_DQAQ_MONY.TabIndex = 41
        '
        'TXT_DQAQ
        '
        Me.TXT_DQAQ.Location = New System.Drawing.Point(49, 132)
        Me.TXT_DQAQ.Name = "TXT_DQAQ"
        Me.TXT_DQAQ.Size = New System.Drawing.Size(232, 29)
        Me.TXT_DQAQ.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 21)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "أجمالي الراتب :"
        '
        'TXT_RATEB
        '
        Me.TXT_RATEB.BackColor = System.Drawing.Color.Aqua
        Me.TXT_RATEB.Location = New System.Drawing.Point(78, 72)
        Me.TXT_RATEB.Name = "TXT_RATEB"
        Me.TXT_RATEB.Size = New System.Drawing.Size(100, 29)
        Me.TXT_RATEB.TabIndex = 38
        Me.TXT_RATEB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TXT_ENSRAF
        '
        Me.TXT_ENSRAF.BackColor = System.Drawing.Color.Aqua
        Me.TXT_ENSRAF.Location = New System.Drawing.Point(310, 75)
        Me.TXT_ENSRAF.Mask = "00:00"
        Me.TXT_ENSRAF.Name = "TXT_ENSRAF"
        Me.TXT_ENSRAF.Size = New System.Drawing.Size(78, 29)
        Me.TXT_ENSRAF.TabIndex = 37
        Me.TXT_ENSRAF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_ENSRAF.ValidatingType = GetType(Date)
        '
        'TXT_HDOR
        '
        Me.TXT_HDOR.BackColor = System.Drawing.Color.Aqua
        Me.TXT_HDOR.Location = New System.Drawing.Point(478, 72)
        Me.TXT_HDOR.Mask = "00:00"
        Me.TXT_HDOR.Name = "TXT_HDOR"
        Me.TXT_HDOR.Size = New System.Drawing.Size(78, 29)
        Me.TXT_HDOR.TabIndex = 36
        Me.TXT_HDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_HDOR.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(392, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 21)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "أنصراف :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(561, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 21)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "حضور :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "كود الموظف :"
        '
        'TXT_NAME
        '
        Me.TXT_NAME.BackColor = System.Drawing.Color.Aqua
        Me.TXT_NAME.Location = New System.Drawing.Point(6, 26)
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(329, 29)
        Me.TXT_NAME.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(562, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "كود الموظف :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(456, 26)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(100, 29)
        Me.TXT_CODE.TabIndex = 0
        Me.TXT_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GRBTN
        '
        Me.GRBTN.Controls.Add(Me.EXITBTN)
        Me.GRBTN.Controls.Add(Me.DELETBTN)
        Me.GRBTN.Controls.Add(Me.EDITBTN)
        Me.GRBTN.Controls.Add(Me.SAVEBTN)
        Me.GRBTN.Controls.Add(Me.NEWBTN)
        Me.GRBTN.Location = New System.Drawing.Point(37, 388)
        Me.GRBTN.Name = "GRBTN"
        Me.GRBTN.Size = New System.Drawing.Size(636, 72)
        Me.GRBTN.TabIndex = 22
        Me.GRBTN.TabStop = False
        '
        'EXITBTN
        '
        Me.EXITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.Appearance.Options.UseFont = True
        Me.EXITBTN.ImageOptions.Image = CType(resources.GetObject("EXITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBTN.Location = New System.Drawing.Point(52, 22)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(41, 44)
        Me.EXITBTN.TabIndex = 7
        '
        'DELETBTN
        '
        Me.DELETBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETBTN.Appearance.ForeColor = System.Drawing.Color.Red
        Me.DELETBTN.Appearance.Options.UseFont = True
        Me.DELETBTN.Appearance.Options.UseForeColor = True
        Me.DELETBTN.ImageOptions.Image = CType(resources.GetObject("DELETBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.DELETBTN.Location = New System.Drawing.Point(133, 22)
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
        Me.EDITBTN.Location = New System.Drawing.Point(264, 22)
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
        Me.SAVEBTN.Location = New System.Drawing.Point(384, 22)
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
        Me.NEWBTN.Location = New System.Drawing.Point(506, 22)
        Me.NEWBTN.Name = "NEWBTN"
        Me.NEWBTN.Size = New System.Drawing.Size(96, 44)
        Me.NEWBTN.TabIndex = 1
        Me.NEWBTN.Text = "جديد"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 164)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(667, 218)
        Me.DataGridView1.TabIndex = 23
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "EMP_CODE"
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "EMP_NAME"
        Me.Column2.HeaderText = "أسم الموظف"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "EMP_HDOR"
        Me.Column3.FillWeight = 40.0!
        Me.Column3.HeaderText = "حضور"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "EMP_ENSRAF"
        Me.Column4.FillWeight = 40.0!
        Me.Column4.HeaderText = "أنصراف"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.FillWeight = 40.0!
        Me.Column5.HeaderText = "-"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'TXT_SEARCH
        '
        Me.TXT_SEARCH.BackColor = System.Drawing.SystemColors.Info
        Me.TXT_SEARCH.Location = New System.Drawing.Point(193, 123)
        Me.TXT_SEARCH.Name = "TXT_SEARCH"
        Me.TXT_SEARCH.Size = New System.Drawing.Size(329, 29)
        Me.TXT_SEARCH.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "البحث بأسم الموظف :"
        '
        'EMP_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXT_SEARCH)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GRBTN)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "EMP_FRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "                                                                                 " &
    "                          أضافة موظفين"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GRBTN.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_RATEB As TextBox
    Friend WithEvents TXT_ENSRAF As MaskedTextBox
    Friend WithEvents TXT_HDOR As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_DQAQ_MONY As TextBox
    Friend WithEvents TXT_DQAQ As TextBox
    Friend WithEvents GRBTN As GroupBox
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DELETBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EDITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SAVEBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents NEWBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TXT_SEARCH As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
End Class
