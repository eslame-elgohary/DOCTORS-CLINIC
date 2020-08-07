<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORT_KHAZINAFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REPORT_KHAZINAFRM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GRU_CODE = New System.Windows.Forms.TextBox()
        Me.CH_GRU = New System.Windows.Forms.CheckBox()
        Me.GRU = New System.Windows.Forms.ComboBox()
        Me.KHAZINA_CODE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DATE_END = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DATE_START = New System.Windows.Forms.DateTimePicker()
        Me.SELECT_KHAZINA = New System.Windows.Forms.CheckBox()
        Me.KHAZINA_NAME = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PREVIWBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.BTN_CLOSE = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GRU_CODE)
        Me.GroupBox1.Controls.Add(Me.CH_GRU)
        Me.GroupBox1.Controls.Add(Me.GRU)
        Me.GroupBox1.Controls.Add(Me.KHAZINA_CODE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DATE_END)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DATE_START)
        Me.GroupBox1.Controls.Add(Me.SELECT_KHAZINA)
        Me.GroupBox1.Controls.Add(Me.KHAZINA_NAME)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(558, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GRU_CODE
        '
        Me.GRU_CODE.Location = New System.Drawing.Point(6, 102)
        Me.GRU_CODE.Name = "GRU_CODE"
        Me.GRU_CODE.Size = New System.Drawing.Size(43, 29)
        Me.GRU_CODE.TabIndex = 9
        Me.GRU_CODE.Visible = False
        '
        'CH_GRU
        '
        Me.CH_GRU.AutoSize = True
        Me.CH_GRU.Location = New System.Drawing.Point(450, 102)
        Me.CH_GRU.Name = "CH_GRU"
        Me.CH_GRU.Size = New System.Drawing.Size(97, 25)
        Me.CH_GRU.TabIndex = 8
        Me.CH_GRU.Text = "قسم معين"
        Me.CH_GRU.UseVisualStyleBackColor = True
        '
        'GRU
        '
        Me.GRU.Enabled = False
        Me.GRU.FormattingEnabled = True
        Me.GRU.Items.AddRange(New Object() {"أستلام نقدية عيادة", "أستلام نقدية معمل", "مصروفات نقدية", "تحويلات نقدية", "تسويات نقدية"})
        Me.GRU.Location = New System.Drawing.Point(55, 100)
        Me.GRU.Name = "GRU"
        Me.GRU.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GRU.Size = New System.Drawing.Size(389, 29)
        Me.GRU.TabIndex = 7
        '
        'KHAZINA_CODE
        '
        Me.KHAZINA_CODE.Location = New System.Drawing.Point(6, 63)
        Me.KHAZINA_CODE.Name = "KHAZINA_CODE"
        Me.KHAZINA_CODE.Size = New System.Drawing.Size(43, 29)
        Me.KHAZINA_CODE.TabIndex = 6
        Me.KHAZINA_CODE.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "حتى تاريخ :"
        '
        'DATE_END
        '
        Me.DATE_END.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATE_END.Location = New System.Drawing.Point(37, 25)
        Me.DATE_END.Name = "DATE_END"
        Me.DATE_END.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DATE_END.Size = New System.Drawing.Size(143, 29)
        Me.DATE_END.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(463, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "من تاريخ :"
        '
        'DATE_START
        '
        Me.DATE_START.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DATE_START.Location = New System.Drawing.Point(314, 26)
        Me.DATE_START.Name = "DATE_START"
        Me.DATE_START.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DATE_START.Size = New System.Drawing.Size(143, 29)
        Me.DATE_START.TabIndex = 2
        '
        'SELECT_KHAZINA
        '
        Me.SELECT_KHAZINA.AutoSize = True
        Me.SELECT_KHAZINA.Location = New System.Drawing.Point(450, 63)
        Me.SELECT_KHAZINA.Name = "SELECT_KHAZINA"
        Me.SELECT_KHAZINA.Size = New System.Drawing.Size(104, 25)
        Me.SELECT_KHAZINA.TabIndex = 1
        Me.SELECT_KHAZINA.Text = "خزينة معينة"
        Me.SELECT_KHAZINA.UseVisualStyleBackColor = True
        '
        'KHAZINA_NAME
        '
        Me.KHAZINA_NAME.Enabled = False
        Me.KHAZINA_NAME.FormattingEnabled = True
        Me.KHAZINA_NAME.Location = New System.Drawing.Point(55, 61)
        Me.KHAZINA_NAME.Name = "KHAZINA_NAME"
        Me.KHAZINA_NAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.KHAZINA_NAME.Size = New System.Drawing.Size(389, 29)
        Me.KHAZINA_NAME.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column1, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(-7, 252)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(695, 201)
        Me.DataGridView1.TabIndex = 1
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "KHAZINA_DATE"
        Me.Column2.HeaderText = "حتى تاريخ"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "KHAZINA_NAME"
        Me.Column3.HeaderText = "أسم الخزينة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "KHAZINA_CODE"
        Me.Column4.HeaderText = "كود الخزينة"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "KHAZINA_NAME_ACTION"
        Me.Column5.HeaderText = "أسم الحركة"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "KHAZINA_IN"
        Me.Column6.HeaderText = "IN"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "KHAZINA_OUT"
        Me.Column7.HeaderText = "OUT"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CODE_DT2"
        Me.Column1.HeaderText = "ؤخي"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "MONY_TYPE"
        Me.Column8.HeaderText = "typ"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'PREVIWBTN
        '
        Me.PREVIWBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PREVIWBTN.Appearance.Options.UseFont = True
        Me.PREVIWBTN.ImageOptions.Image = CType(resources.GetObject("PREVIWBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.PREVIWBTN.Location = New System.Drawing.Point(24, 174)
        Me.PREVIWBTN.Name = "PREVIWBTN"
        Me.PREVIWBTN.Size = New System.Drawing.Size(134, 46)
        Me.PREVIWBTN.TabIndex = 2
        Me.PREVIWBTN.Text = "عرض"
        '
        'BTN_CLOSE
        '
        Me.BTN_CLOSE.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CLOSE.Appearance.Options.UseFont = True
        Me.BTN_CLOSE.ImageOptions.Image = CType(resources.GetObject("BTN_CLOSE.ImageOptions.Image"), System.Drawing.Image)
        Me.BTN_CLOSE.Location = New System.Drawing.Point(465, 174)
        Me.BTN_CLOSE.Name = "BTN_CLOSE"
        Me.BTN_CLOSE.Size = New System.Drawing.Size(105, 46)
        Me.BTN_CLOSE.TabIndex = 3
        Me.BTN_CLOSE.Text = "أغلاق"
        '
        'REPORT_KHAZINAFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_CLOSE)
        Me.Controls.Add(Me.PREVIWBTN)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "REPORT_KHAZINAFRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تقرير خزينة"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DATE_END As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DATE_START As DateTimePicker
    Friend WithEvents SELECT_KHAZINA As CheckBox
    Friend WithEvents KHAZINA_NAME As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KHAZINA_CODE As TextBox
    Friend WithEvents PREVIWBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BTN_CLOSE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CH_GRU As CheckBox
    Friend WithEvents GRU As ComboBox
    Friend WithEvents GRU_CODE As TextBox
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class
