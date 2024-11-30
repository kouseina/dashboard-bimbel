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
        TextBox3 = New TextBox()
        Label5 = New Label()
        Button2 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(345, 196)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(378, 29)
        TextBox3.TabIndex = 60
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(96, 204)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 21)
        Label5.TabIndex = 59
        Label5.Text = "PASSWORD BARU"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(563, 323)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 37)
        Button2.TabIndex = 57
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(345, 249)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(378, 29)
        TextBox2.TabIndex = 56
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(345, 121)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(378, 29)
        TextBox1.TabIndex = 55
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(96, 257)
        Label3.Name = "Label3"
        Label3.Size = New Size(233, 21)
        Label3.TabIndex = 53
        Label3.Text = "KONFIRMASI PASSWORD BARU"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(96, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 21)
        Label2.TabIndex = 52
        Label2.Text = "PASSWORD LAMA"
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
        ' frmubahpassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "frmubahpassword"
        Text = "UbahPassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
