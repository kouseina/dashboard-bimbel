<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsiswa
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
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(171, 343)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(552, 224)
        DataGridView1.TabIndex = 19
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(563, 276)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 37)
        Button2.TabIndex = 18
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"6 SD", "3 SMP", "3 SMA"})
        ComboBox1.Location = New Point(345, 225)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(378, 29)
        ComboBox1.TabIndex = 17
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(345, 170)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(378, 29)
        TextBox2.TabIndex = 16
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(345, 117)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(378, 29)
        TextBox1.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(171, 228)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 21)
        Label4.TabIndex = 14
        Label4.Text = "KELAS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(171, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 21)
        Label3.TabIndex = 13
        Label3.Text = "NISN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(171, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 12
        Label2.Text = "NAMA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(390, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 37)
        Label1.TabIndex = 11
        Label1.Text = "Data Siswa"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(77, 36)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 33)
        Button1.TabIndex = 10
        Button1.Text = "Kembali ke Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(171, 276)
        Button3.Name = "Button3"
        Button3.Size = New Size(160, 37)
        Button3.TabIndex = 20
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' frmsiswa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 599)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "frmsiswa"
        Text = "Siswa"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
