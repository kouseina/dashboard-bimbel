<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmkehadiran
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
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        Button2 = New Button()
        Cbketerangan = New ComboBox()
        Txttanggal = New TextBox()
        Txtnama = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        Txtnip = New TextBox()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(171, 326)
        Button3.Name = "Button3"
        Button3.Size = New Size(160, 37)
        Button3.TabIndex = 31
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(171, 393)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(552, 224)
        DataGridView1.TabIndex = 30
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(563, 326)
        Button2.Name = "Button2"
        Button2.Size = New Size(160, 37)
        Button2.TabIndex = 29
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Cbketerangan
        ' 
        Cbketerangan.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Cbketerangan.FormattingEnabled = True
        Cbketerangan.Items.AddRange(New Object() {"Hadir", "Sakit", "Ijin", "Alpha"})
        Cbketerangan.Location = New Point(345, 275)
        Cbketerangan.Name = "Cbketerangan"
        Cbketerangan.Size = New Size(378, 29)
        Cbketerangan.TabIndex = 28
        ' 
        ' Txttanggal
        ' 
        Txttanggal.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txttanggal.Location = New Point(345, 220)
        Txttanggal.Name = "Txttanggal"
        Txttanggal.Size = New Size(378, 29)
        Txttanggal.TabIndex = 27
        ' 
        ' Txtnama
        ' 
        Txtnama.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txtnama.Location = New Point(345, 119)
        Txtnama.Name = "Txtnama"
        Txtnama.Size = New Size(378, 29)
        Txtnama.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(171, 278)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 21)
        Label4.TabIndex = 25
        Label4.Text = "KETERANGAN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(171, 223)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 21)
        Label3.TabIndex = 24
        Label3.Text = "TANGGAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(171, 122)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 23
        Label2.Text = "NAMA"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(306, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 37)
        Label1.TabIndex = 22
        Label1.Text = "Data Kehadiran Guru"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(77, 38)
        Button1.Name = "Button1"
        Button1.Size = New Size(125, 33)
        Button1.TabIndex = 21
        Button1.Text = "Kembali ke Home"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Txtnip
        ' 
        Txtnip.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txtnip.Location = New Point(345, 167)
        Txtnip.Name = "Txtnip"
        Txtnip.Size = New Size(378, 29)
        Txtnip.TabIndex = 33
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(171, 170)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 21)
        Label5.TabIndex = 32
        Label5.Text = "NIP"
        ' 
        ' frmkehadiran
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 748)
        Controls.Add(Txtnip)
        Controls.Add(Label5)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(Button2)
        Controls.Add(Cbketerangan)
        Controls.Add(Txttanggal)
        Controls.Add(Txtnama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "frmkehadiran"
        Text = "KehadiranForm"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Cbketerangan As ComboBox
    Friend WithEvents Txttanggal As TextBox
    Friend WithEvents Txtnama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Txtnip As TextBox
    Friend WithEvents Label5 As Label
End Class
