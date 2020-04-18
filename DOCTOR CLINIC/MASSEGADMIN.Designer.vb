<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MASSEGADMIN
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MASSEGADMIN))
        Me.SENDBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.MASEG_TXT = New System.Windows.Forms.TextBox()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NAME_U = New System.Windows.Forms.ComboBox()
        Me.CODE_U = New System.Windows.Forms.TextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'SENDBTN
        '
        Me.SENDBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SENDBTN.Appearance.Options.UseFont = True
        Me.SENDBTN.ImageOptions.Image = CType(resources.GetObject("SENDBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SENDBTN.Location = New System.Drawing.Point(25, 285)
        Me.SENDBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.SENDBTN.Name = "SENDBTN"
        Me.SENDBTN.Size = New System.Drawing.Size(119, 37)
        Me.SENDBTN.TabIndex = 21
        Me.SENDBTN.Text = "أرسال"
        '
        'MASEG_TXT
        '
        Me.MASEG_TXT.Location = New System.Drawing.Point(14, 107)
        Me.MASEG_TXT.Margin = New System.Windows.Forms.Padding(5)
        Me.MASEG_TXT.Multiline = True
        Me.MASEG_TXT.Name = "MASEG_TXT"
        Me.MASEG_TXT.Size = New System.Drawing.Size(554, 169)
        Me.MASEG_TXT.TabIndex = 20
        '
        'EXITBTN
        '
        Me.EXITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.Appearance.Options.UseFont = True
        Me.EXITBTN.ImageOptions.Image = CType(resources.GetObject("EXITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBTN.Location = New System.Drawing.Point(449, 285)
        Me.EXITBTN.Margin = New System.Windows.Forms.Padding(5)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(119, 37)
        Me.EXITBTN.TabIndex = 22
        Me.EXITBTN.Text = "أغلاق"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "أسم الراسل :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "أسم المرسل اليه :"
        '
        'NAME_U
        '
        Me.NAME_U.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NAME_U.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NAME_U.FormattingEnabled = True
        Me.NAME_U.Location = New System.Drawing.Point(166, 44)
        Me.NAME_U.Name = "NAME_U"
        Me.NAME_U.Size = New System.Drawing.Size(265, 33)
        Me.NAME_U.TabIndex = 28
        '
        'CODE_U
        '
        Me.CODE_U.Location = New System.Drawing.Point(340, 8)
        Me.CODE_U.Name = "CODE_U"
        Me.CODE_U.Size = New System.Drawing.Size(49, 33)
        Me.CODE_U.TabIndex = 29
        Me.CODE_U.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(439, 44)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(5)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(129, 37)
        Me.SimpleButton1.TabIndex = 30
        Me.SimpleButton1.Text = "حذف الرسالة"
        '
        'MASSEGADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 343)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.CODE_U)
        Me.Controls.Add(Me.NAME_U)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EXITBTN)
        Me.Controls.Add(Me.SENDBTN)
        Me.Controls.Add(Me.MASEG_TXT)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "MASSEGADMIN"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "رسالة الأدارة"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SENDBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents MASEG_TXT As TextBox
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NAME_U As ComboBox
    Friend WithEvents CODE_U As TextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
