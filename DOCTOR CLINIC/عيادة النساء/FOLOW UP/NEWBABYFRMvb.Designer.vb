<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NEWBABYFRMvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NEWBABYFRMvb))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_NAME_PA = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXT_DATE = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_BABY_NO = New System.Windows.Forms.TextBox()
        Me.SAVEBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.EXITBTN = New DevExpress.XtraEditors.SimpleButton()
        Me.TXT_LAST_OP = New System.Windows.Forms.TextBox()
        Me.TXT_CHI = New System.Windows.Forms.TextBox()
        Me.TXT_PA_CODE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(192, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "تم أجراء عملية الولادة للسيدة /"
        '
        'TXT_NAME_PA
        '
        Me.TXT_NAME_PA.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NAME_PA.ForeColor = System.Drawing.Color.SteelBlue
        Me.TXT_NAME_PA.Location = New System.Drawing.Point(30, 23)
        Me.TXT_NAME_PA.Name = "TXT_NAME_PA"
        Me.TXT_NAME_PA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_NAME_PA.Size = New System.Drawing.Size(342, 20)
        Me.TXT_NAME_PA.TabIndex = 1
        Me.TXT_NAME_PA.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(466, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "تاريخ العملية :"
        '
        'TXT_DATE
        '
        Me.TXT_DATE.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_DATE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TXT_DATE.Location = New System.Drawing.Point(293, 55)
        Me.TXT_DATE.Name = "TXT_DATE"
        Me.TXT_DATE.Size = New System.Drawing.Size(167, 27)
        Me.TXT_DATE.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(90, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(473, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "* محلوظة هامة : أنه فى حالة الموافقة على التسجيل سيتم أغلاق كارت المتابعة"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "عدد المواليد :"
        '
        'TXT_BABY_NO
        '
        Me.TXT_BABY_NO.Location = New System.Drawing.Point(63, 56)
        Me.TXT_BABY_NO.Name = "TXT_BABY_NO"
        Me.TXT_BABY_NO.Size = New System.Drawing.Size(100, 27)
        Me.TXT_BABY_NO.TabIndex = 6
        Me.TXT_BABY_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SAVEBTN
        '
        Me.SAVEBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVEBTN.Appearance.ForeColor = System.Drawing.Color.DarkRed
        Me.SAVEBTN.Appearance.Options.UseFont = True
        Me.SAVEBTN.Appearance.Options.UseForeColor = True
        Me.SAVEBTN.ImageOptions.Image = CType(resources.GetObject("SAVEBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.SAVEBTN.Location = New System.Drawing.Point(429, 137)
        Me.SAVEBTN.Name = "SAVEBTN"
        Me.SAVEBTN.Size = New System.Drawing.Size(115, 44)
        Me.SAVEBTN.TabIndex = 7
        Me.SAVEBTN.Text = "Save"
        '
        'EXITBTN
        '
        Me.EXITBTN.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBTN.Appearance.Options.UseFont = True
        Me.EXITBTN.ImageOptions.Image = CType(resources.GetObject("EXITBTN.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBTN.Location = New System.Drawing.Point(12, 137)
        Me.EXITBTN.Name = "EXITBTN"
        Me.EXITBTN.Size = New System.Drawing.Size(106, 44)
        Me.EXITBTN.TabIndex = 8
        Me.EXITBTN.Text = "Exit"
        '
        'TXT_LAST_OP
        '
        Me.TXT_LAST_OP.Location = New System.Drawing.Point(312, 137)
        Me.TXT_LAST_OP.Multiline = True
        Me.TXT_LAST_OP.Name = "TXT_LAST_OP"
        Me.TXT_LAST_OP.Size = New System.Drawing.Size(100, 27)
        Me.TXT_LAST_OP.TabIndex = 9
        Me.TXT_LAST_OP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_LAST_OP.Visible = False
        '
        'TXT_CHI
        '
        Me.TXT_CHI.Location = New System.Drawing.Point(153, 137)
        Me.TXT_CHI.Name = "TXT_CHI"
        Me.TXT_CHI.Size = New System.Drawing.Size(100, 27)
        Me.TXT_CHI.TabIndex = 10
        Me.TXT_CHI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_CHI.Visible = False
        '
        'TXT_PA_CODE
        '
        Me.TXT_PA_CODE.Location = New System.Drawing.Point(429, 12)
        Me.TXT_PA_CODE.Name = "TXT_PA_CODE"
        Me.TXT_PA_CODE.Size = New System.Drawing.Size(100, 27)
        Me.TXT_PA_CODE.TabIndex = 11
        Me.TXT_PA_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TXT_PA_CODE.Visible = False
        '
        'NEWBABYFRMvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 193)
        Me.Controls.Add(Me.TXT_PA_CODE)
        Me.Controls.Add(Me.TXT_CHI)
        Me.Controls.Add(Me.TXT_LAST_OP)
        Me.Controls.Add(Me.EXITBTN)
        Me.Controls.Add(Me.SAVEBTN)
        Me.Controls.Add(Me.TXT_BABY_NO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXT_DATE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_NAME_PA)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NEWBABYFRMvb"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "END OF FOWLO UP CARD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_NAME_PA As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXT_DATE As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_BABY_NO As TextBox
    Friend WithEvents SAVEBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EXITBTN As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TXT_LAST_OP As TextBox
    Friend WithEvents TXT_CHI As TextBox
    Friend WithEvents TXT_PA_CODE As TextBox
End Class
