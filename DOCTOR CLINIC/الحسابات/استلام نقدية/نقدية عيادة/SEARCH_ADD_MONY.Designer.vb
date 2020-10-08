<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEARCH_ADD_MONY
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SEARCH_ADD_MONY))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.K1 = New System.Windows.Forms.ComboBox()
        Me.DATE_END = New System.Windows.Forms.DateTimePicker()
        Me.DATE_START = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADD_DATE_VAL = New DevExpress.XtraEditors.SimpleButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(238, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(347, 29)
        Me.TextBox1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column2, Me.Column5, Me.Column6, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(793, 362)
        Me.DataGridView1.TabIndex = 2
        '
        'K1
        '
        Me.K1.FormattingEnabled = True
        Me.K1.Items.AddRange(New Object() {"رقم الأيصال", "أسم المريض"})
        Me.K1.Location = New System.Drawing.Point(38, 53)
        Me.K1.Name = "K1"
        Me.K1.Size = New System.Drawing.Size(181, 29)
        Me.K1.TabIndex = 3
        '
        'DATE_END
        '
        Me.DATE_END.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATE_END.Location = New System.Drawing.Point(385, 9)
        Me.DATE_END.Name = "DATE_END"
        Me.DATE_END.Size = New System.Drawing.Size(200, 29)
        Me.DATE_END.TabIndex = 10
        '
        'DATE_START
        '
        Me.DATE_START.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATE_START.Location = New System.Drawing.Point(104, 12)
        Me.DATE_START.Name = "DATE_START"
        Me.DATE_START.Size = New System.Drawing.Size(200, 29)
        Me.DATE_START.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 21)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "حتي :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "الفترة من :"
        '
        'ADD_DATE_VAL
        '
        Me.ADD_DATE_VAL.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADD_DATE_VAL.Appearance.Options.UseFont = True
        Me.ADD_DATE_VAL.ImageOptions.Image = CType(resources.GetObject("ADD_DATE_VAL.ImageOptions.Image"), System.Drawing.Image)
        Me.ADD_DATE_VAL.Location = New System.Drawing.Point(622, 16)
        Me.ADD_DATE_VAL.Name = "ADD_DATE_VAL"
        Me.ADD_DATE_VAL.Size = New System.Drawing.Size(133, 62)
        Me.ADD_DATE_VAL.TabIndex = 11
        Me.ADD_DATE_VAL.Text = "تأكيد الفترة"
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ADD_CODE"
        Me.Column1.FillWeight = 60.0!
        Me.Column1.HeaderText = "رقم الأيصال"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ADD_DATE"
        Me.Column3.FillWeight = 60.0!
        Me.Column3.HeaderText = "تاريخ الأيصال"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "PA_NAME"
        Me.Column2.HeaderText = "أسم المريض"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ADD_SAFY"
        Me.Column5.FillWeight = 60.0!
        Me.Column5.HeaderText = "صافي المبلغ"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "KHAZINA_IN"
        Me.Column6.FillWeight = 60.0!
        Me.Column6.HeaderText = "المدفوع"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.FillWeight = 40.0!
        Me.Column4.HeaderText = "-"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'SEARCH_ADD_MONY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 462)
        Me.Controls.Add(Me.ADD_DATE_VAL)
        Me.Controls.Add(Me.DATE_END)
        Me.Controls.Add(Me.DATE_START)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.K1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "SEARCH_ADD_MONY"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "البحث عن ايصال أستلام نقدية عيادة"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents K1 As ComboBox
    Friend WithEvents DATE_END As DateTimePicker
    Friend WithEvents DATE_START As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ADD_DATE_VAL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewButtonColumn
End Class
