<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WEIGHT_GAIN_FEMAL_INFERTILITY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WEIGHT_GAIN_FEMAL_INFERTILITY))
        Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TXT_PA_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_NAME_WEIGHT_GAIN_FEMALE = New System.Windows.Forms.TextBox()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EDIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_DELET = New DevExpress.XtraEditors.SimpleButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY
        '
        Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY.Enabled = False
        Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY.Location = New System.Drawing.Point(147, 12)
        Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY.Name = "TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY"
        Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY.Size = New System.Drawing.Size(88, 27)
        Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY.TabIndex = 72
        Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(12, 60)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(161, 16)
        Me.Label30.TabIndex = 71
        Me.Label30.Text = "WEIGHT GAIN HISTORY :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(80, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Code :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 148)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(609, 256)
        Me.DataGridView1.TabIndex = 74
        '
        'TXT_PA_NAME
        '
        Me.TXT_PA_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_PA_NAME.Enabled = False
        Me.TXT_PA_NAME.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PA_NAME.Location = New System.Drawing.Point(316, 12)
        Me.TXT_PA_NAME.Name = "TXT_PA_NAME"
        Me.TXT_PA_NAME.Size = New System.Drawing.Size(246, 26)
        Me.TXT_PA_NAME.TabIndex = 82
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_PA_CODE.Enabled = False
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(329, -7)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(42, 27)
        Me.TXT_PA_CODE.TabIndex = 81
        Me.TXT_PA_CODE.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(242, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "NAME :"
        '
        'TXT_NAME_WEIGHT_GAIN_FEMALE
        '
        Me.TXT_NAME_WEIGHT_GAIN_FEMALE.BackColor = System.Drawing.Color.Aqua
        Me.TXT_NAME_WEIGHT_GAIN_FEMALE.Location = New System.Drawing.Point(183, 48)
        Me.TXT_NAME_WEIGHT_GAIN_FEMALE.Multiline = True
        Me.TXT_NAME_WEIGHT_GAIN_FEMALE.Name = "TXT_NAME_WEIGHT_GAIN_FEMALE"
        Me.TXT_NAME_WEIGHT_GAIN_FEMALE.Size = New System.Drawing.Size(419, 46)
        Me.TXT_NAME_WEIGHT_GAIN_FEMALE.TabIndex = 83
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(468, 106)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EXIT.TabIndex = 79
        Me.BTN_EXIT.Text = "EXIT"
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDIT.Appearance.Options.UseFont = True
        Me.BTN_EDIT.ImageOptions.Image = CType(resources.GetObject("BTN_EDIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EDIT.Location = New System.Drawing.Point(271, 106)
        Me.BTN_EDIT.Name = "BTN_EDIT"
        Me.BTN_EDIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EDIT.TabIndex = 77
        Me.BTN_EDIT.Text = "EDIT"
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.Appearance.Options.UseFont = True
        Me.BTN_SAVE.ImageOptions.Image = CType(resources.GetObject("BTN_SAVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_SAVE.Location = New System.Drawing.Point(169, 106)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(87, 33)
        Me.BTN_SAVE.TabIndex = 76
        Me.BTN_SAVE.Text = "SAVE"
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEW.Appearance.Options.UseFont = True
        Me.BTN_NEW.ImageOptions.Image = CType(resources.GetObject("BTN_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NEW.Location = New System.Drawing.Point(67, 106)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(87, 33)
        Me.BTN_NEW.TabIndex = 75
        Me.BTN_NEW.Text = "NEW"
        '
        'BTN_DELET
        '
        Me.BTN_DELET.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELET.Appearance.Options.UseFont = True
        Me.BTN_DELET.ImageOptions.Image = CType(resources.GetObject("BTN_DELET.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_DELET.Location = New System.Drawing.Point(372, 106)
        Me.BTN_DELET.Name = "BTN_DELET"
        Me.BTN_DELET.Size = New System.Drawing.Size(87, 33)
        Me.BTN_DELET.TabIndex = 78
        Me.BTN_DELET.Text = "DELET"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_WEIGHT_GAIN_FEMAL_INFERTILTY"
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NAME_WEIGHT_GAIN_FEMAL_INFERTILTY"
        Me.Column2.HeaderText = "WEIGHT GAIN"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 30.0!
        Me.Column3.HeaderText = "-"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Visible = False
        '
        'WEIGHT_GAIN_FEMAL_INFERTILITY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 413)
        Me.Controls.Add(Me.TXT_NAME_WEIGHT_GAIN_FEMALE)
        Me.Controls.Add(Me.TXT_PA_NAME)
        Me.Controls.Add(Me.TXT_PA_CODE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTN_EXIT)
        Me.Controls.Add(Me.BTN_EDIT)
        Me.Controls.Add(Me.BTN_SAVE)
        Me.Controls.Add(Me.BTN_NEW)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_DELET)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY)
        Me.Controls.Add(Me.Label30)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "WEIGHT_GAIN_FEMAL_INFERTILITY"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WEIGHT_GAIN history"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_CODE_WEIGHT_GAIN_FEMAL_INFERTILTY As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EDIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_DELET As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_PA_NAME As TextBox
    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_NAME_WEIGHT_GAIN_FEMALE As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
End Class
