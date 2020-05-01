<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NETFRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NETFRM))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.STNET = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_MASS = New System.Windows.Forms.TextBox()
        Me.BTNSEND = New DevExpress.XtraEditors.SimpleButton()
        Me.SEND_CLOSE = New DevExpress.XtraEditors.SimpleButton()
        Me.STAT_LAST = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ImageOptions.Image = CType(resources.GetObject("SimpleButton1.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(164, 42)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "أتصال بالموقع"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.ImageOptions.Image = CType(resources.GetObject("SimpleButton2.ImageOptions.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(590, 2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(40, 42)
        Me.SimpleButton2.TabIndex = 2
        Me.SimpleButton2.Text = "أغلاق"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'STNET
        '
        Me.STNET.AutoSize = True
        Me.STNET.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STNET.Location = New System.Drawing.Point(42, 57)
        Me.STNET.Name = "STNET"
        Me.STNET.Size = New System.Drawing.Size(52, 21)
        Me.STNET.TabIndex = 3
        Me.STNET.Text = "000000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "رقم المريض التالي :"
        '
        'TXT_MASS
        '
        Me.TXT_MASS.Location = New System.Drawing.Point(151, 84)
        Me.TXT_MASS.Multiline = True
        Me.TXT_MASS.Name = "TXT_MASS"
        Me.TXT_MASS.Size = New System.Drawing.Size(212, 27)
        Me.TXT_MASS.TabIndex = 5
        Me.TXT_MASS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNSEND
        '
        Me.BTNSEND.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSEND.Appearance.Options.UseFont = True
        Me.BTNSEND.ImageOptions.Image = CType(resources.GetObject("BTNSEND.ImageOptions.Image"), System.Drawing.Image)
        Me.BTNSEND.Location = New System.Drawing.Point(369, 75)
        Me.BTNSEND.Name = "BTNSEND"
        Me.BTNSEND.Size = New System.Drawing.Size(101, 42)
        Me.BTNSEND.TabIndex = 6
        Me.BTNSEND.Text = "أرسال"
        '
        'SEND_CLOSE
        '
        Me.SEND_CLOSE.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEND_CLOSE.Appearance.Options.UseFont = True
        Me.SEND_CLOSE.ImageOptions.Image = CType(resources.GetObject("SEND_CLOSE.ImageOptions.Image"), System.Drawing.Image)
        Me.SEND_CLOSE.Location = New System.Drawing.Point(486, 75)
        Me.SEND_CLOSE.Name = "SEND_CLOSE"
        Me.SEND_CLOSE.Size = New System.Drawing.Size(144, 42)
        Me.SEND_CLOSE.TabIndex = 7
        Me.SEND_CLOSE.Text = "أغلاق العيادة"
        '
        'STAT_LAST
        '
        Me.STAT_LAST.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STAT_LAST.Location = New System.Drawing.Point(195, 10)
        Me.STAT_LAST.Name = "STAT_LAST"
        Me.STAT_LAST.Size = New System.Drawing.Size(367, 47)
        Me.STAT_LAST.TabIndex = 8
        Me.STAT_LAST.Text = "000000"
        Me.STAT_LAST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NETFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 126)
        Me.Controls.Add(Me.STAT_LAST)
        Me.Controls.Add(Me.SEND_CLOSE)
        Me.Controls.Add(Me.BTNSEND)
        Me.Controls.Add(Me.TXT_MASS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.STNET)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "NETFRM"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الأنترنت"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents STNET As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_MASS As TextBox
    Friend WithEvents BTNSEND As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SEND_CLOSE As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents STAT_LAST As Label
End Class
