<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ins_util
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
        Me.Btn_criar = New System.Windows.Forms.Button()
        Me.Lbl_pass = New System.Windows.Forms.Label()
        Me.Lbl_e_mail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_nick = New System.Windows.Forms.TextBox()
        Me.Btn_listar = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'Btn_criar
        '
        Me.Btn_criar.Location = New System.Drawing.Point(102, 104)
        Me.Btn_criar.Name = "Btn_criar"
        Me.Btn_criar.Size = New System.Drawing.Size(163, 23)
        Me.Btn_criar.TabIndex = 13
        Me.Btn_criar.Text = "Criar Utilizador"
        Me.Btn_criar.UseVisualStyleBackColor = True
        '
        'Lbl_pass
        '
        Me.Lbl_pass.AutoSize = True
        Me.Lbl_pass.Location = New System.Drawing.Point(38, 81)
        Me.Lbl_pass.Name = "Lbl_pass"
        Me.Lbl_pass.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_pass.TabIndex = 12
        Me.Lbl_pass.Text = "Password:"
        '
        'Lbl_e_mail
        '
        Me.Lbl_e_mail.AutoSize = True
        Me.Lbl_e_mail.Location = New System.Drawing.Point(38, 55)
        Me.Lbl_e_mail.Name = "Lbl_e_mail"
        Me.Lbl_e_mail.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_e_mail.TabIndex = 11
        Me.Lbl_e_mail.Text = "E_mail:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Nickname:"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(102, 52)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(163, 20)
        Me.txt_email.TabIndex = 9
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(102, 78)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(163, 20)
        Me.txt_pass.TabIndex = 8
        '
        'txt_nick
        '
        Me.txt_nick.Location = New System.Drawing.Point(102, 26)
        Me.txt_nick.Name = "txt_nick"
        Me.txt_nick.Size = New System.Drawing.Size(163, 20)
        Me.txt_nick.TabIndex = 7
        '
        'Btn_listar
        '
        Me.Btn_listar.Location = New System.Drawing.Point(102, 133)
        Me.Btn_listar.Name = "Btn_listar"
        Me.Btn_listar.Size = New System.Drawing.Size(163, 23)
        Me.Btn_listar.TabIndex = 14
        Me.Btn_listar.Text = "Listar"
        Me.Btn_listar.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(283, 26)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(453, 291)
        Me.WebBrowser1.TabIndex = 15
        '
        'Ins_util
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 354)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Btn_listar)
        Me.Controls.Add(Me.Btn_criar)
        Me.Controls.Add(Me.Lbl_pass)
        Me.Controls.Add(Me.Lbl_e_mail)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_nick)
        Me.Name = "Ins_util"
        Me.Text = "Inserir Utilizador:"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Btn_criar As System.Windows.Forms.Button
    Friend WithEvents Lbl_pass As System.Windows.Forms.Label
    Friend WithEvents Lbl_e_mail As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_nick As System.Windows.Forms.TextBox
    Friend WithEvents Btn_listar As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser

End Class
