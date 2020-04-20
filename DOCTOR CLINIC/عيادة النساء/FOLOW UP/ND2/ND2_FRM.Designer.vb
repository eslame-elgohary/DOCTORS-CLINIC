<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ND2_FRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ND2_FRM))
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ND2_TOTAL = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ND2_urine = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ND2_HOUR = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ND2_pc = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ND2_TSH = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ND2_plt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ND2_LONIZED = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ND2_hb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXT_PA_NAME = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE = New System.Windows.Forms.TextBox()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EDIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.BTN_DELET = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_PA_CODE.Enabled = False
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(229, 15)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(42, 23)
        Me.TXT_PA_CODE.TabIndex = 19
        Me.TXT_PA_CODE.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ND2_TOTAL)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.ND2_urine)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.ND2_HOUR)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.ND2_pc)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.ND2_TSH)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.ND2_plt)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ND2_LONIZED)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ND2_hb)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_NAME)
        Me.GroupBox1.Controls.Add(Me.TXT_PA_CODE)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_CODE)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(509, 189)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'ND2_TOTAL
        '
        Me.ND2_TOTAL.BackColor = System.Drawing.Color.Aqua
        Me.ND2_TOTAL.ForeColor = System.Drawing.Color.Black
        Me.ND2_TOTAL.Location = New System.Drawing.Point(341, 57)
        Me.ND2_TOTAL.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ND2_TOTAL.Name = "ND2_TOTAL"
        Me.ND2_TOTAL.Size = New System.Drawing.Size(120, 23)
        Me.ND2_TOTAL.TabIndex = 94
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label20.Location = New System.Drawing.Point(247, 57)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(88, 20)
        Me.Label20.TabIndex = 95
        Me.Label20.Text = "TOTAL :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ND2_urine
        '
        Me.ND2_urine.BackColor = System.Drawing.Color.Aqua
        Me.ND2_urine.ForeColor = System.Drawing.Color.Black
        Me.ND2_urine.Location = New System.Drawing.Point(341, 145)
        Me.ND2_urine.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ND2_urine.Name = "ND2_urine"
        Me.ND2_urine.Size = New System.Drawing.Size(120, 23)
        Me.ND2_urine.TabIndex = 92
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label18.Location = New System.Drawing.Point(229, 146)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(106, 23)
        Me.Label18.TabIndex = 93
        Me.Label18.Text = "Urine :"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ND2_HOUR
        '
        Me.ND2_HOUR.BackColor = System.Drawing.Color.Aqua
        Me.ND2_HOUR.ForeColor = System.Drawing.Color.Black
        Me.ND2_HOUR.Location = New System.Drawing.Point(103, 146)
        Me.ND2_HOUR.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ND2_HOUR.Name = "ND2_HOUR"
        Me.ND2_HOUR.Size = New System.Drawing.Size(104, 23)
        Me.ND2_HOUR.TabIndex = 90
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label19.Location = New System.Drawing.Point(9, 146)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(90, 23)
        Me.Label19.TabIndex = 91
        Me.Label19.Text = "HOUR :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ND2_pc
        '
        Me.ND2_pc.BackColor = System.Drawing.Color.Aqua
        Me.ND2_pc.ForeColor = System.Drawing.Color.Black
        Me.ND2_pc.Location = New System.Drawing.Point(103, 114)
        Me.ND2_pc.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ND2_pc.Name = "ND2_pc"
        Me.ND2_pc.Size = New System.Drawing.Size(104, 23)
        Me.ND2_pc.TabIndex = 86
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Location = New System.Drawing.Point(9, 114)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(90, 23)
        Me.Label17.TabIndex = 87
        Me.Label17.Text = "PC :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ND2_TSH
        '
        Me.ND2_TSH.BackColor = System.Drawing.Color.Aqua
        Me.ND2_TSH.ForeColor = System.Drawing.Color.Black
        Me.ND2_TSH.Location = New System.Drawing.Point(341, 114)
        Me.ND2_TSH.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ND2_TSH.Name = "ND2_TSH"
        Me.ND2_TSH.Size = New System.Drawing.Size(120, 23)
        Me.ND2_TSH.TabIndex = 84
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Location = New System.Drawing.Point(229, 115)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(106, 23)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "TSH :"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ND2_plt
        '
        Me.ND2_plt.BackColor = System.Drawing.Color.Aqua
        Me.ND2_plt.ForeColor = System.Drawing.Color.Black
        Me.ND2_plt.Location = New System.Drawing.Point(103, 85)
        Me.ND2_plt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ND2_plt.Name = "ND2_plt"
        Me.ND2_plt.Size = New System.Drawing.Size(104, 23)
        Me.ND2_plt.TabIndex = 82
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label15.Location = New System.Drawing.Point(9, 85)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(90, 23)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "PLT :"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ND2_LONIZED
        '
        Me.ND2_LONIZED.BackColor = System.Drawing.Color.Aqua
        Me.ND2_LONIZED.ForeColor = System.Drawing.Color.Black
        Me.ND2_LONIZED.Location = New System.Drawing.Point(341, 87)
        Me.ND2_LONIZED.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ND2_LONIZED.Name = "ND2_LONIZED"
        Me.ND2_LONIZED.Size = New System.Drawing.Size(120, 23)
        Me.ND2_LONIZED.TabIndex = 80
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Location = New System.Drawing.Point(229, 88)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(106, 23)
        Me.Label13.TabIndex = 81
        Me.Label13.Text = "LONIZED :"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ND2_hb
        '
        Me.ND2_hb.BackColor = System.Drawing.Color.Aqua
        Me.ND2_hb.ForeColor = System.Drawing.Color.Black
        Me.ND2_hb.Location = New System.Drawing.Point(103, 58)
        Me.ND2_hb.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ND2_hb.Name = "ND2_hb"
        Me.ND2_hb.Size = New System.Drawing.Size(104, 23)
        Me.ND2_hb.TabIndex = 78
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label12.Location = New System.Drawing.Point(9, 58)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(88, 23)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Hb%:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TXT_PA_NAME
        '
        Me.TXT_PA_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_PA_NAME.Enabled = False
        Me.TXT_PA_NAME.Location = New System.Drawing.Point(251, 21)
        Me.TXT_PA_NAME.Name = "TXT_PA_NAME"
        Me.TXT_PA_NAME.Size = New System.Drawing.Size(246, 23)
        Me.TXT_PA_NAME.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label7.Location = New System.Drawing.Point(177, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "NAME :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label1.Location = New System.Drawing.Point(27, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CODE :"
        '
        'TXT_CODE
        '
        Me.TXT_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_CODE.Enabled = False
        Me.TXT_CODE.Location = New System.Drawing.Point(98, 18)
        Me.TXT_CODE.Name = "TXT_CODE"
        Me.TXT_CODE.Size = New System.Drawing.Size(73, 23)
        Me.TXT_CODE.TabIndex = 0
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(414, 201)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EXIT.TabIndex = 21
        Me.BTN_EXIT.Text = "EXIT"
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDIT.Appearance.Options.UseFont = True
        Me.BTN_EDIT.ImageOptions.Image = CType(resources.GetObject("BTN_EDIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EDIT.Location = New System.Drawing.Point(217, 201)
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
        Me.BTN_SAVE.Location = New System.Drawing.Point(115, 201)
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
        Me.BTN_NEW.Location = New System.Drawing.Point(13, 201)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(87, 33)
        Me.BTN_NEW.TabIndex = 17
        Me.BTN_NEW.Text = "NEW"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 244)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(488, 208)
        Me.DataGridView1.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_ND2"
        Me.Column1.HeaderText = "2nd trimester"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 30.0!
        Me.Column3.HeaderText = "-"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'BTN_DELET
        '
        Me.BTN_DELET.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELET.Appearance.Options.UseFont = True
        Me.BTN_DELET.ImageOptions.Image = CType(resources.GetObject("BTN_DELET.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_DELET.Location = New System.Drawing.Point(318, 201)
        Me.BTN_DELET.Name = "BTN_DELET"
        Me.BTN_DELET.Size = New System.Drawing.Size(87, 33)
        Me.BTN_DELET.TabIndex = 20
        Me.BTN_DELET.Text = "DELET"
        '
        'ND2_FRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 463)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_EDIT)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.BTN_NEW)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_DELET)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ND2_FRM"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "2nd trimester"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE As TextBox
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EDIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_DELET As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_PA_NAME As TextBox
    Friend WithEvents ND2_TOTAL As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents ND2_urine As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents ND2_HOUR As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ND2_pc As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents ND2_TSH As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents ND2_plt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents ND2_LONIZED As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ND2_hb As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
