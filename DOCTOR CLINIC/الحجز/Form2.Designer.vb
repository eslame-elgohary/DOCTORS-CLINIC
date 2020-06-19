<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PATIENTDATA2020 = New DOCTOR_CLINIC.PATIENTDATA()
        Me.PATIENTTableAdapter = New DOCTOR_CLINIC.PATIENTDATATableAdapters.PATIENTTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PACODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PANAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PATIENTDATA2020, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.BindingSource1
        Me.ComboBox1.DisplayMember = "PA_NAME"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(503, 38)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "PA_CODE"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "PATIENT"
        Me.BindingSource1.DataSource = Me.PATIENTDATA2020
        Me.BindingSource1.Filter = "stat=true"
        '
        'PATIENTDATA2020
        '
        Me.PATIENTDATA2020.DataSetName = "PATIENTDATA"
        Me.PATIENTDATA2020.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PATIENTTableAdapter
        '
        Me.PATIENTTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(555, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PACODEDataGridViewTextBoxColumn, Me.PANAMEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(32, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(377, 150)
        Me.DataGridView1.TabIndex = 2
        '
        'PACODEDataGridViewTextBoxColumn
        '
        Me.PACODEDataGridViewTextBoxColumn.DataPropertyName = "PA_CODE"
        Me.PACODEDataGridViewTextBoxColumn.HeaderText = "PA_CODE"
        Me.PACODEDataGridViewTextBoxColumn.Name = "PACODEDataGridViewTextBoxColumn"
        Me.PACODEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PANAMEDataGridViewTextBoxColumn
        '
        Me.PANAMEDataGridViewTextBoxColumn.DataPropertyName = "PA_NAME"
        Me.PANAMEDataGridViewTextBoxColumn.HeaderText = "PA_NAME"
        Me.PANAMEDataGridViewTextBoxColumn.Name = "PANAMEDataGridViewTextBoxColumn"
        Me.PANAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(90, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(202, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 214)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PATIENTDATA2020, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents PATIENTDATA2020 As PATIENTDATA
    Friend WithEvents PATIENTTableAdapter As PATIENTDATATableAdapters.PATIENTTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PACODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PANAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
End Class
