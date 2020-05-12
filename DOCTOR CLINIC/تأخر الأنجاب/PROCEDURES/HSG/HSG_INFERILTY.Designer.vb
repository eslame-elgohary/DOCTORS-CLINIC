<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HSG_INFERILTY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HSG_INFERILTY))
        Me.TXT_PLACE_HSG_INFERILTY = New System.Windows.Forms.TextBox()
        Me.TXT_PA_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_CODE_HSG_INFERILTY = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.BTN_EXIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_EDIT = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_SAVE = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_NEW = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_DELET = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_DATE_HSG_INFERILTY = New System.Windows.Forms.DateTimePicker()
        Me.TXT_UTERUS_HSG_INFERILTY = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXT_TUBES_HSG_INFERILTY = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_PLACE_HSG_INFERILTY
        '
        Me.TXT_PLACE_HSG_INFERILTY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_PLACE_HSG_INFERILTY.Location = New System.Drawing.Point(409, 44)
        Me.TXT_PLACE_HSG_INFERILTY.Name = "TXT_PLACE_HSG_INFERILTY"
        Me.TXT_PLACE_HSG_INFERILTY.Size = New System.Drawing.Size(212, 27)
        Me.TXT_PLACE_HSG_INFERILTY.TabIndex = 98
        '
        'TXT_PA_NAME
        '
        Me.TXT_PA_NAME.BackColor = System.Drawing.Color.White
        Me.TXT_PA_NAME.Enabled = False
        Me.TXT_PA_NAME.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_PA_NAME.Location = New System.Drawing.Point(259, 9)
        Me.TXT_PA_NAME.Name = "TXT_PA_NAME"
        Me.TXT_PA_NAME.Size = New System.Drawing.Size(246, 26)
        Me.TXT_PA_NAME.TabIndex = 97
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.BackColor = System.Drawing.Color.White
        Me.TXT_PA_CODE.Enabled = False
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(493, 1)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(42, 27)
        Me.TXT_PA_CODE.TabIndex = 96
        Me.TXT_PA_CODE.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(185, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "NAME :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(9, 226)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(609, 195)
        Me.DataGridView1.TabIndex = 89
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Code :"
        '
        'TXT_CODE_HSG_INFERILTY
        '
        Me.TXT_CODE_HSG_INFERILTY.BackColor = System.Drawing.Color.White
        Me.TXT_CODE_HSG_INFERILTY.Enabled = False
        Me.TXT_CODE_HSG_INFERILTY.Location = New System.Drawing.Point(82, 8)
        Me.TXT_CODE_HSG_INFERILTY.Name = "TXT_CODE_HSG_INFERILTY"
        Me.TXT_CODE_HSG_INFERILTY.Size = New System.Drawing.Size(88, 27)
        Me.TXT_CODE_HSG_INFERILTY.TabIndex = 87
        Me.TXT_CODE_HSG_INFERILTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(325, 47)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(73, 19)
        Me.Label30.TabIndex = 86
        Me.Label30.Text = "PLACE :"
        '
        'BTN_EXIT
        '
        Me.BTN_EXIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EXIT.Appearance.Options.UseFont = True
        Me.BTN_EXIT.ImageOptions.Image = CType(resources.GetObject("BTN_EXIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EXIT.Location = New System.Drawing.Point(480, 181)
        Me.BTN_EXIT.Name = "BTN_EXIT"
        Me.BTN_EXIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EXIT.TabIndex = 94
        Me.BTN_EXIT.Text = "EXIT"
        '
        'BTN_EDIT
        '
        Me.BTN_EDIT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_EDIT.Appearance.Options.UseFont = True
        Me.BTN_EDIT.ImageOptions.Image = CType(resources.GetObject("BTN_EDIT.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_EDIT.Location = New System.Drawing.Point(283, 181)
        Me.BTN_EDIT.Name = "BTN_EDIT"
        Me.BTN_EDIT.Size = New System.Drawing.Size(87, 33)
        Me.BTN_EDIT.TabIndex = 92
        Me.BTN_EDIT.Text = "EDIT"
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.Appearance.Options.UseFont = True
        Me.BTN_SAVE.ImageOptions.Image = CType(resources.GetObject("BTN_SAVE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_SAVE.Location = New System.Drawing.Point(181, 181)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(87, 33)
        Me.BTN_SAVE.TabIndex = 91
        Me.BTN_SAVE.Text = "SAVE"
        '
        'BTN_NEW
        '
        Me.BTN_NEW.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_NEW.Appearance.Options.UseFont = True
        Me.BTN_NEW.ImageOptions.Image = CType(resources.GetObject("BTN_NEW.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_NEW.Location = New System.Drawing.Point(79, 181)
        Me.BTN_NEW.Name = "BTN_NEW"
        Me.BTN_NEW.Size = New System.Drawing.Size(87, 33)
        Me.BTN_NEW.TabIndex = 90
        Me.BTN_NEW.Text = "NEW"
        '
        'BTN_DELET
        '
        Me.BTN_DELET.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_DELET.Appearance.Options.UseFont = True
        Me.BTN_DELET.ImageOptions.Image = CType(resources.GetObject("BTN_DELET.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_DELET.Location = New System.Drawing.Point(384, 181)
        Me.BTN_DELET.Name = "BTN_DELET"
        Me.BTN_DELET.Size = New System.Drawing.Size(87, 33)
        Me.BTN_DELET.TabIndex = 93
        Me.BTN_DELET.Text = "DELET"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "DATE :"
        '
        'TXT_DATE_HSG_INFERILTY
        '
        Me.TXT_DATE_HSG_INFERILTY.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE_HSG_INFERILTY.Location = New System.Drawing.Point(81, 43)
        Me.TXT_DATE_HSG_INFERILTY.Name = "TXT_DATE_HSG_INFERILTY"
        Me.TXT_DATE_HSG_INFERILTY.Size = New System.Drawing.Size(183, 27)
        Me.TXT_DATE_HSG_INFERILTY.TabIndex = 100
        '
        'TXT_UTERUS_HSG_INFERILTY
        '
        Me.TXT_UTERUS_HSG_INFERILTY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_UTERUS_HSG_INFERILTY.Location = New System.Drawing.Point(84, 77)
        Me.TXT_UTERUS_HSG_INFERILTY.Multiline = True
        Me.TXT_UTERUS_HSG_INFERILTY.Name = "TXT_UTERUS_HSG_INFERILTY"
        Me.TXT_UTERUS_HSG_INFERILTY.Size = New System.Drawing.Size(537, 42)
        Me.TXT_UTERUS_HSG_INFERILTY.TabIndex = 102
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Uterus :"
        '
        'TXT_TUBES_HSG_INFERILTY
        '
        Me.TXT_TUBES_HSG_INFERILTY.BackColor = System.Drawing.Color.Aqua
        Me.TXT_TUBES_HSG_INFERILTY.Location = New System.Drawing.Point(84, 125)
        Me.TXT_TUBES_HSG_INFERILTY.Multiline = True
        Me.TXT_TUBES_HSG_INFERILTY.Name = "TXT_TUBES_HSG_INFERILTY"
        Me.TXT_TUBES_HSG_INFERILTY.Size = New System.Drawing.Size(537, 42)
        Me.TXT_TUBES_HSG_INFERILTY.TabIndex = 104
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 19)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Tubes :"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_HSG_INFERILTY"
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PLACE_HSG_INFERILTY"
        Me.Column2.HeaderText = "PLACE"
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
        'Column4
        '
        Me.Column4.DataPropertyName = "DATE_HSG_INFERILTY"
        Me.Column4.HeaderText = "DATE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'HSG_INFERILTY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 433)
        Me.Controls.Add(Me.TXT_TUBES_HSG_INFERILTY)
        Me.Controls.Add(Me.TXT_UTERUS_HSG_INFERILTY)
        Me.Controls.Add(Me.TXT_DATE_HSG_INFERILTY)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_PLACE_HSG_INFERILTY)
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
        Me.Controls.Add(Me.TXT_CODE_HSG_INFERILTY)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "HSG_INFERILTY"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HSG INFERILTY"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_PLACE_HSG_INFERILTY As TextBox
    Friend WithEvents TXT_PA_NAME As TextBox
    Friend WithEvents TXT_PA_CODE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BTN_EXIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_EDIT As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_SAVE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_NEW As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_DELET As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_CODE_HSG_INFERILTY As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_DATE_HSG_INFERILTY As DateTimePicker
    Friend WithEvents TXT_UTERUS_HSG_INFERILTY As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXT_TUBES_HSG_INFERILTY As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewButtonColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
