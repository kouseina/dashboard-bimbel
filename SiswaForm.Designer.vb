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
        DataGridView = New DataGridView()
        btsimpan = New Button()
        cbkelas = New ComboBox()
        txtnisn = New TextBox()
        txtnama = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        bthapus = New Button()
        CType(DataGridView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView
        ' 
        DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView.Location = New Point(171, 343)
        DataGridView.Name = "DataGridView"
        DataGridView.Size = New Size(552, 224)
        DataGridView.TabIndex = 19
        ' 
        ' btsimpan
        ' 
        btsimpan.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btsimpan.Location = New Point(563, 276)
        btsimpan.Name = "btsimpan"
        btsimpan.Size = New Size(160, 37)
        btsimpan.TabIndex = 18
        btsimpan.Text = "Simpan"
        btsimpan.UseVisualStyleBackColor = True
        ' 
        ' cbkelas
        ' 
        cbkelas.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbkelas.FormattingEnabled = True
        cbkelas.Location = New Point(345, 225)
        cbkelas.Name = "cbkelas"
        cbkelas.Size = New Size(378, 29)
        cbkelas.TabIndex = 17
        ' 
        ' txtnisn
        ' 
        txtnisn.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtnisn.Location = New Point(345, 170)
        txtnisn.Name = "txtnisn"
        txtnisn.Size = New Size(378, 29)
        txtnisn.TabIndex = 16
        ' 
        ' txtnama
        ' 
        txtnama.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtnama.Location = New Point(345, 117)
        txtnama.Name = "txtnama"
        txtnama.Size = New Size(378, 29)
        txtnama.TabIndex = 15
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
        ' bthapus
        ' 
        bthapus.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        bthapus.Location = New Point(171, 276)
        bthapus.Name = "bthapus"
        bthapus.Size = New Size(160, 37)
        bthapus.TabIndex = 20
        bthapus.Text = "Hapus"
        bthapus.UseVisualStyleBackColor = True
        ' 
        ' frmsiswa
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 599)
        Controls.Add(bthapus)
        Controls.Add(DataGridView)
        Controls.Add(btsimpan)
        Controls.Add(cbkelas)
        Controls.Add(txtnisn)
        Controls.Add(txtnama)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "frmsiswa"
        Text = "Siswa"
        CType(DataGridView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents btsimpan As Button
    Friend WithEvents cbkelas As ComboBox
    Friend WithEvents txtnisn As TextBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents bthapus As Button
End Class
