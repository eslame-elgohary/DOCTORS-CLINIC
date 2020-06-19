<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEARCH_PATIENT
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SEARCH_PATIENT))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SELECTORDER = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.PATION_BINDING = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA = New DOCTOR_CLINIC.PATIENTDATA()
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        Me.PACODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PANAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAAGEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PANAME2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PATEL2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PACODE2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PACODEDataGridViewTextBoxColumn, Me.PANAMEDataGridViewTextBoxColumn, Me.PATELDataGridViewTextBoxColumn, Me.PAAGEDataGridViewTextBoxColumn, Me.PANAME2DataGridViewTextBoxColumn, Me.PATEL2DataGridViewTextBoxColumn, Me.PACODE2DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PATION_BINDING
        Me.DataGridView1.Location = New System.Drawing.Point(12, 50)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(796, 365)
        Me.DataGridView1.TabIndex = 0
        '
        'SELECTORDER
        '
        Me.SELECTORDER.FormattingEnabled = True
        Me.SELECTORDER.Items.AddRange(New Object() {"أسم المريض", "تليفون المريض", "أحد الاقارب", "تليفون أحد الاقارب", "رقم الملف بالعيادة"})
        Me.SELECTORDER.Location = New System.Drawing.Point(15, 11)
        Me.SELECTORDER.Name = "SELECTORDER"
        Me.SELECTORDER.Size = New System.Drawing.Size(233, 29)
        Me.SELECTORDER.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(266, 11)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(303, 29)
        Me.TextBox1.TabIndex = 2
        '
        'EXITBTN
        '
        Me.EXITBTN.ImageOptions.Image = CType(resources.GetObject("EXITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBTN.Location = New System.Drawing.Point(767, 12)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(41, 30)
        Me.EXITBTN.TabIndex = 3
        '
        'PATION_BINDING
        '
        Me.PATION_BINDING.DataMember = "PATIENT"
        Me.PATION_BINDING.DataSource = Me.PATIENTDATA
        Me.PATION_BINDING.Filter = "STAT = TRUE"
        '
        'PATIENTDATA
        '
        Me.PATIENTDATA.DataSetName = "PATIENTDATA"
        Me.PATIENTDATA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'PACODEDataGridViewTextBoxColumn
        '
        Me.PACODEDataGridViewTextBoxColumn.DataPropertyName = "PA_CODE"
        Me.PACODEDataGridViewTextBoxColumn.HeaderText = "كود المريض"
        Me.PACODEDataGridViewTextBoxColumn.Name = "PACODEDataGridViewTextBoxColumn"
        Me.PACODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PANAMEDataGridViewTextBoxColumn
        '
        Me.PANAMEDataGridViewTextBoxColumn.DataPropertyName = "PA_NAME"
        Me.PANAMEDataGridViewTextBoxColumn.HeaderText = "أسم المريض"
        Me.PANAMEDataGridViewTextBoxColumn.Name = "PANAMEDataGridViewTextBoxColumn"
        Me.PANAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PATELDataGridViewTextBoxColumn
        '
        Me.PATELDataGridViewTextBoxColumn.DataPropertyName = "PA_TEL"
        Me.PATELDataGridViewTextBoxColumn.HeaderText = "تليفون المريض"
        Me.PATELDataGridViewTextBoxColumn.Name = "PATELDataGridViewTextBoxColumn"
        Me.PATELDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PAAGEDataGridViewTextBoxColumn
        '
        Me.PAAGEDataGridViewTextBoxColumn.DataPropertyName = "PA_AGE"
        Me.PAAGEDataGridViewTextBoxColumn.HeaderText = "عمر المريض"
        Me.PAAGEDataGridViewTextBoxColumn.Name = "PAAGEDataGridViewTextBoxColumn"
        Me.PAAGEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PANAME2DataGridViewTextBoxColumn
        '
        Me.PANAME2DataGridViewTextBoxColumn.DataPropertyName = "PA_NAME2"
        Me.PANAME2DataGridViewTextBoxColumn.HeaderText = "أسم الزوج"
        Me.PANAME2DataGridViewTextBoxColumn.Name = "PANAME2DataGridViewTextBoxColumn"
        Me.PANAME2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PATEL2DataGridViewTextBoxColumn
        '
        Me.PATEL2DataGridViewTextBoxColumn.DataPropertyName = "PA_TEL2"
        Me.PATEL2DataGridViewTextBoxColumn.HeaderText = "تليفونه"
        Me.PATEL2DataGridViewTextBoxColumn.Name = "PATEL2DataGridViewTextBoxColumn"
        Me.PATEL2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'PACODE2DataGridViewTextBoxColumn
        '
        Me.PACODE2DataGridViewTextBoxColumn.DataPropertyName = "PA_CODE2"
        Me.PACODE2DataGridViewTextBoxColumn.HeaderText = "رقم الملف"
        Me.PACODE2DataGridViewTextBoxColumn.Name = "PACODE2DataGridViewTextBoxColumn"
        Me.PACODE2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'SEARCH_PATIENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 423)
        Me.Controls.Add(Me.EXITBTN)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SELECTORDER)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "SEARCH_PATIENT"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "بحث عن مريض"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATION_BINDING, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents SELECTORDER As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PATION_BINDING As BindingSource
    Friend WithEvents PATIENTDATA As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
    Friend WithEvents PACODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PANAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PATELDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PAAGEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PANAME2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PATEL2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PACODE2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
