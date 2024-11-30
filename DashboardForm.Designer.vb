<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdashboard
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
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(132, 123)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 100)
        Button1.TabIndex = 0
        Button1.Text = "Guru"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(264, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 32)
        Label1.TabIndex = 1
        Label1.Text = "Dashboard Bimbel UN"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(272, 123)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 100)
        Button2.TabIndex = 2
        Button2.Text = "Siswa"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(406, 123)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 100)
        Button3.TabIndex = 3
        Button3.Text = "Kehadiran"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(542, 123)
        Button4.Name = "Button4"
        Button4.Size = New Size(106, 100)
        Button4.TabIndex = 4
        Button4.Text = "Nilai"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(343, 252)
        Button5.Name = "Button5"
        Button5.Size = New Size(106, 100)
        Button5.TabIndex = 5
        Button5.Text = "Ubah Password"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button6.Location = New Point(677, 21)
        Button6.Name = "Button6"
        Button6.Size = New Size(87, 48)
        Button6.TabIndex = 6
        Button6.Text = "Logout"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' frmdashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "frmdashboard"
        Text = "Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
