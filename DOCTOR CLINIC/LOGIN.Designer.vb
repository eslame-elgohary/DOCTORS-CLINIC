<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGIN
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGIN))
        Me.TXT_TYPE = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CODE_USER = New System.Windows.Forms.TextBox()
        Me.REALY_NAME = New System.Windows.Forms.TextBox()
        Me.USER1 = New System.Windows.Forms.ComboBox()
        Me.PASS1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NAMEPROLAB = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ENTERBUTTON = New DevExpress.XtraEditors.SimpleButton()
        Me.EXITBUTTON = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox17 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_TYPE
        '
        Me.TXT_TYPE.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TYPE.Location = New System.Drawing.Point(422, 357)
        Me.TXT_TYPE.Margin = New System.Windows.Forms.Padding(5)
        Me.TXT_TYPE.Name = "TXT_TYPE"
        Me.TXT_TYPE.Size = New System.Drawing.Size(87, 33)
        Me.TXT_TYPE.TabIndex = 64
        Me.TXT_TYPE.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(180, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 21)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "01112577838 / "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(271, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "01003587857"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(219, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(349, 45)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "DOCTORS CLINIC"
        '
        'CODE_USER
        '
        Me.CODE_USER.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CODE_USER.Location = New System.Drawing.Point(20, 325)
        Me.CODE_USER.Margin = New System.Windows.Forms.Padding(5)
        Me.CODE_USER.Name = "CODE_USER"
        Me.CODE_USER.Size = New System.Drawing.Size(87, 33)
        Me.CODE_USER.TabIndex = 59
        Me.CODE_USER.Visible = False
        '
        'REALY_NAME
        '
        Me.REALY_NAME.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REALY_NAME.Location = New System.Drawing.Point(119, 363)
        Me.REALY_NAME.Margin = New System.Windows.Forms.Padding(5)
        Me.REALY_NAME.Name = "REALY_NAME"
        Me.REALY_NAME.Size = New System.Drawing.Size(87, 33)
        Me.REALY_NAME.TabIndex = 58
        Me.REALY_NAME.Visible = False
        '
        'USER1
        '
        Me.USER1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.USER1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.USER1.BackColor = System.Drawing.Color.White
        Me.USER1.FormattingEnabled = True
        Me.USER1.Location = New System.Drawing.Point(227, 155)
        Me.USER1.Name = "USER1"
        Me.USER1.Size = New System.Drawing.Size(258, 29)
        Me.USER1.TabIndex = 46
        '
        'PASS1
        '
        Me.PASS1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASS1.Location = New System.Drawing.Point(20, 363)
        Me.PASS1.Margin = New System.Windows.Forms.Padding(5)
        Me.PASS1.Name = "PASS1"
        Me.PASS1.Size = New System.Drawing.Size(87, 33)
        Me.PASS1.TabIndex = 55
        Me.PASS1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label5.Location = New System.Drawing.Point(315, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 21)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "أ / اسلام الجوهرى"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "تم تصميم هذا البرنامج بمعرفة"
        '
        'NAMEPROLAB
        '
        Me.NAMEPROLAB.AutoSize = True
        Me.NAMEPROLAB.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAMEPROLAB.ForeColor = System.Drawing.Color.Maroon
        Me.NAMEPROLAB.Location = New System.Drawing.Point(159, 65)
        Me.NAMEPROLAB.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.NAMEPROLAB.Name = "NAMEPROLAB"
        Me.NAMEPROLAB.Size = New System.Drawing.Size(427, 65)
        Me.NAMEPROLAB.TabIndex = 50
        Me.NAMEPROLAB.Text = "Mothercare Clinic"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "الرقم السري :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(115, 158)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 21)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "أسم المستخدم :"
        '
        'password
        '
        Me.password.BackColor = System.Drawing.Color.White
        Me.password.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(227, 203)
        Me.password.Margin = New System.Windows.Forms.Padding(5)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.Size = New System.Drawing.Size(259, 33)
        Me.password.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(41, 374)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(577, 45)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "AL-Karma Software Company "
        '
        'ENTERBUTTON
        '
        Me.ENTERBUTTON.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENTERBUTTON.Appearance.Options.UseFont = True
        Me.ENTERBUTTON.ImageOptions.Image = CType(resources.GetObject("ENTERBUTTON.ImageOptions.Image"), System.Drawing.Image)
        Me.ENTERBUTTON.Location = New System.Drawing.Point(67, 266)
        Me.ENTERBUTTON.Name = "ENTERBUTTON"
        Me.ENTERBUTTON.Size = New System.Drawing.Size(138, 45)
        Me.ENTERBUTTON.TabIndex = 65
        Me.ENTERBUTTON.Text = "الدخول"
        '
        'EXITBUTTON
        '
        Me.EXITBUTTON.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXITBUTTON.Appearance.Options.UseFont = True
        Me.EXITBUTTON.ImageOptions.Image = CType(resources.GetObject("EXITBUTTON.ImageOptions.Image"), System.Drawing.Image)
        Me.EXITBUTTON.Location = New System.Drawing.Point(347, 266)
        Me.EXITBUTTON.Name = "EXITBUTTON"
        Me.EXITBUTTON.Size = New System.Drawing.Size(138, 45)
        Me.EXITBUTTON.TabIndex = 66
        Me.EXITBUTTON.Text = "الخروج"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox1.Image = Global.DOCTOR_CLINIC.My.Resources.Resources._640x480
        Me.PictureBox1.Location = New System.Drawing.Point(515, 121)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 291)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(67, 199)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'PictureBox17
        '
        Me.PictureBox17.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.PictureBox17.BackColor = System.Drawing.Color.White
        Me.PictureBox17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox17.Image = CType(resources.GetObject("PictureBox17.Image"), System.Drawing.Image)
        Me.PictureBox17.Location = New System.Drawing.Point(67, 147)
        Me.PictureBox17.Name = "PictureBox17"
        Me.PictureBox17.Size = New System.Drawing.Size(40, 37)
        Me.PictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox17.TabIndex = 56
        Me.PictureBox17.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 150
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-6, 420)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.RightToLeftLayout = True
        Me.ProgressBar1.Size = New System.Drawing.Size(829, 36)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 87
        Me.ProgressBar1.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label8.Location = New System.Drawing.Point(166, 425)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 23)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "الدقة المثالية للشاشة "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label11.Location = New System.Drawing.Point(377, 425)
        Me.Label11.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(130, 23)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "768      1366"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label10.Location = New System.Drawing.Point(427, 425)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 23)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "x"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.White
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox3.Image = Global.DOCTOR_CLINIC.My.Resources.Resources.karma_logo_02
        Me.PictureBox3.Location = New System.Drawing.Point(576, -5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(232, 189)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 92
        Me.PictureBox3.TabStop = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 457)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NAMEPROLAB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ENTERBUTTON)
        Me.Controls.Add(Me.EXITBUTTON)
        Me.Controls.Add(Me.TXT_TYPE)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CODE_USER)
        Me.Controls.Add(Me.REALY_NAME)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox17)
        Me.Controls.Add(Me.USER1)
        Me.Controls.Add(Me.PASS1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.PictureBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "LOGIN"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "تسجيل الدخول"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_TYPE As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CODE_USER As TextBox
    Friend WithEvents REALY_NAME As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox17 As PictureBox
    Friend WithEvents USER1 As ComboBox
    Friend WithEvents PASS1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NAMEPROLAB As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents Label3 As Label
    Private WithEvents EXITBUTTON As DevExpress.XtraEditors.SimpleButton
    Private WithEvents ENTERBUTTON As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
