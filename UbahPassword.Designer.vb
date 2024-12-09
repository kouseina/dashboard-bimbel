<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmubahpassword
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
        txtOld = New TextBox()
        Label5 = New Label()
        Button2 = New Button()
        txtNewPassword = New TextBox()
        txtEmail = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        txtNewConfirmPassword = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtOld
        ' 
        txtOld.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtOld.Location = New Point(345, 196)
        txtOld.Name = "txtOld"
        txtOld.Size = New Size(378, 29)
        txtOld.TabIndex = 60
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(96, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 21)
        Label5.TabIndex = 59
        Label5.Text = "PASSWORD LAMA"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(563, 365)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 37)
        Button2.TabIndex = 57
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewPassword.Location = New Point(345, 249)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(378, 29)
        txtNewPassword.TabIndex = 56
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(345, 121)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(378, 29)
        txtEmail.TabIndex = 55
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(96, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(138, 21)
        Label3.TabIndex = 53
        Label3.Text = "PASSWORD BARU"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(96, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 21)
        Label2.TabIndex = 52
        Label2.Text = "EMAIL"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(306, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(199, 37)
        Label1.TabIndex = 51
        Label1.Text = "Ubah Password"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(77, 40)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 33)
        Button1.TabIndex = 50
        Button1.Text = "Kembali ke Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtNewConfirmPassword
        ' 
        txtNewConfirmPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNewConfirmPassword.Location = New Point(345, 297)
        txtNewConfirmPassword.Name = "txtNewConfirmPassword"
        txtNewConfirmPassword.Size = New Size(378, 29)
        txtNewConfirmPassword.TabIndex = 62
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(96, 305)
        Label4.Name = "Label4"
        Label4.Size = New Size(233, 21)
        Label4.TabIndex = 61
        Label4.Text = "KONFIRMASI PASSWORD BARU"
        ' 
        ' frmubahpassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNewConfirmPassword)
        Controls.Add(Label4)
        Controls.Add(txtOld)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(txtNewPassword)
        Controls.Add(txtEmail)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "frmubahpassword"
        Text = "UbahPassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtOld As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNewConfirmPassword As TextBox
    Friend WithEvents Label4 As Label
End Class
