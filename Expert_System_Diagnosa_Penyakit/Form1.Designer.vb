<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.grpGejala = New System.Windows.Forms.GroupBox()
        Me.chkHilangBau2 = New System.Windows.Forms.CheckBox()
        Me.chkBatukBerdarah = New System.Windows.Forms.CheckBox()
        Me.chkBatukTidakBerdahak = New System.Windows.Forms.CheckBox()
        Me.chkHilangBau = New System.Windows.Forms.CheckBox()
        Me.chkHilangRasa = New System.Windows.Forms.CheckBox()
        Me.chkDiare = New System.Windows.Forms.CheckBox()
        Me.chkMual = New System.Windows.Forms.CheckBox()
        Me.chkTenggorokan = New System.Windows.Forms.CheckBox()
        Me.chkIngus = New System.Windows.Forms.CheckBox()
        Me.chkNyeriOtot = New System.Windows.Forms.CheckBox()
        Me.chkMenggigil = New System.Windows.Forms.CheckBox()
        Me.chkSakitKepala = New System.Windows.Forms.CheckBox()
        Me.chkSakitTubuh = New System.Windows.Forms.CheckBox()
        Me.chkRedaEnak = New System.Windows.Forms.CheckBox()
        Me.chkSesak = New System.Windows.Forms.CheckBox()
        Me.chkKelelahan = New System.Windows.Forms.CheckBox()
        Me.chkBatuk = New System.Windows.Forms.CheckBox()
        Me.chkDemam = New System.Windows.Forms.CheckBox()
        Me.btnDiagnosa = New System.Windows.Forms.Button()
        Me.btnBaru = New System.Windows.Forms.Button()
        Me.txtHasil = New System.Windows.Forms.TextBox()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.grpGejala.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblJudul.Location = New System.Drawing.Point(119, 18)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(455, 38)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Expert System Diagnosa Penyakit Berat"
        '
        'grpGejala
        '
        Me.grpGejala.Controls.Add(Me.chkHilangBau2)
        Me.grpGejala.Controls.Add(Me.chkBatukBerdarah)
        Me.grpGejala.Controls.Add(Me.chkBatukTidakBerdahak)
        Me.grpGejala.Controls.Add(Me.chkHilangBau)
        Me.grpGejala.Controls.Add(Me.chkHilangRasa)
        Me.grpGejala.Controls.Add(Me.chkDiare)
        Me.grpGejala.Controls.Add(Me.chkMual)
        Me.grpGejala.Controls.Add(Me.chkTenggorokan)
        Me.grpGejala.Controls.Add(Me.chkIngus)
        Me.grpGejala.Controls.Add(Me.chkNyeriOtot)
        Me.grpGejala.Controls.Add(Me.chkMenggigil)
        Me.grpGejala.Controls.Add(Me.chkSakitKepala)
        Me.grpGejala.Controls.Add(Me.chkSakitTubuh)
        Me.grpGejala.Controls.Add(Me.chkRedaEnak)
        Me.grpGejala.Controls.Add(Me.chkSesak)
        Me.grpGejala.Controls.Add(Me.chkKelelahan)
        Me.grpGejala.Controls.Add(Me.chkBatuk)
        Me.grpGejala.Controls.Add(Me.chkDemam)
        Me.grpGejala.Location = New System.Drawing.Point(35, 70)
        Me.grpGejala.Name = "grpGejala"
        Me.grpGejala.Size = New System.Drawing.Size(380, 610)
        Me.grpGejala.TabIndex = 1
        Me.grpGejala.TabStop = False
        Me.grpGejala.Text = "Pilih Gejala"
        '
        'chkHilangBau2
        '
        Me.chkHilangBau2.Location = New System.Drawing.Point(15, 543)
        Me.chkHilangBau2.Name = "chkHilangBau2"
        Me.chkHilangBau2.Size = New System.Drawing.Size(150, 24)
        Me.chkHilangBau2.TabIndex = 17
        Me.chkHilangBau2.Text = "Hilang bau"
        '
        'chkBatukBerdarah
        '
        Me.chkBatukBerdarah.Location = New System.Drawing.Point(15, 513)
        Me.chkBatukBerdarah.Name = "chkBatukBerdarah"
        Me.chkBatukBerdarah.Size = New System.Drawing.Size(150, 24)
        Me.chkBatukBerdarah.TabIndex = 16
        Me.chkBatukBerdarah.Text = "Batuk berdarah"
        '
        'chkBatukTidakBerdahak
        '
        Me.chkBatukTidakBerdahak.Location = New System.Drawing.Point(15, 483)
        Me.chkBatukTidakBerdahak.Name = "chkBatukTidakBerdahak"
        Me.chkBatukTidakBerdahak.Size = New System.Drawing.Size(170, 24)
        Me.chkBatukTidakBerdahak.TabIndex = 15
        Me.chkBatukTidakBerdahak.Text = "Batuk tidak berdahak"
        '
        'chkHilangBau
        '
        Me.chkHilangBau.Location = New System.Drawing.Point(15, 453)
        Me.chkHilangBau.Name = "chkHilangBau"
        Me.chkHilangBau.Size = New System.Drawing.Size(150, 24)
        Me.chkHilangBau.TabIndex = 14
        Me.chkHilangBau.Text = "Hilang bau"
        '
        'chkHilangRasa
        '
        Me.chkHilangRasa.Location = New System.Drawing.Point(15, 423)
        Me.chkHilangRasa.Name = "chkHilangRasa"
        Me.chkHilangRasa.Size = New System.Drawing.Size(150, 24)
        Me.chkHilangRasa.TabIndex = 13
        Me.chkHilangRasa.Text = "Hilang rasa"
        '
        'chkDiare
        '
        Me.chkDiare.Location = New System.Drawing.Point(15, 393)
        Me.chkDiare.Name = "chkDiare"
        Me.chkDiare.Size = New System.Drawing.Size(150, 24)
        Me.chkDiare.TabIndex = 12
        Me.chkDiare.Text = "Diare"
        '
        'chkMual
        '
        Me.chkMual.Location = New System.Drawing.Point(15, 363)
        Me.chkMual.Name = "chkMual"
        Me.chkMual.Size = New System.Drawing.Size(150, 24)
        Me.chkMual.TabIndex = 11
        Me.chkMual.Text = "Mual"
        '
        'chkTenggorokan
        '
        Me.chkTenggorokan.Location = New System.Drawing.Point(15, 333)
        Me.chkTenggorokan.Name = "chkTenggorokan"
        Me.chkTenggorokan.Size = New System.Drawing.Size(170, 24)
        Me.chkTenggorokan.TabIndex = 10
        Me.chkTenggorokan.Text = "Sakit tenggorokan"
        '
        'chkIngus
        '
        Me.chkIngus.Location = New System.Drawing.Point(15, 303)
        Me.chkIngus.Name = "chkIngus"
        Me.chkIngus.Size = New System.Drawing.Size(170, 24)
        Me.chkIngus.TabIndex = 9
        Me.chkIngus.Text = "Ingus atau hidung tersumbat"
        '
        'chkNyeriOtot
        '
        Me.chkNyeriOtot.Location = New System.Drawing.Point(15, 273)
        Me.chkNyeriOtot.Name = "chkNyeriOtot"
        Me.chkNyeriOtot.Size = New System.Drawing.Size(150, 24)
        Me.chkNyeriOtot.TabIndex = 8
        Me.chkNyeriOtot.Text = "Nyeri otot"
        '
        'chkMenggigil
        '
        Me.chkMenggigil.Location = New System.Drawing.Point(15, 243)
        Me.chkMenggigil.Name = "chkMenggigil"
        Me.chkMenggigil.Size = New System.Drawing.Size(150, 24)
        Me.chkMenggigil.TabIndex = 7
        Me.chkMenggigil.Text = "Menggigil"
        '
        'chkSakitKepala
        '
        Me.chkSakitKepala.Location = New System.Drawing.Point(15, 213)
        Me.chkSakitKepala.Name = "chkSakitKepala"
        Me.chkSakitKepala.Size = New System.Drawing.Size(150, 24)
        Me.chkSakitKepala.TabIndex = 6
        Me.chkSakitKepala.Text = "Sakit kepala"
        '
        'chkSakitTubuh
        '
        Me.chkSakitTubuh.Location = New System.Drawing.Point(15, 183)
        Me.chkSakitTubuh.Name = "chkSakitTubuh"
        Me.chkSakitTubuh.Size = New System.Drawing.Size(170, 24)
        Me.chkSakitTubuh.TabIndex = 5
        Me.chkSakitTubuh.Text = "Sakit dan nyeri tubuh"
        '
        'chkRedaEnak
        '
        Me.chkRedaEnak.Location = New System.Drawing.Point(15, 153)
        Me.chkRedaEnak.Name = "chkRedaEnak"
        Me.chkRedaEnak.Size = New System.Drawing.Size(150, 24)
        Me.chkRedaEnak.TabIndex = 4
        Me.chkRedaEnak.Text = "Rasa tidak enak"
        '
        'chkSesak
        '
        Me.chkSesak.Location = New System.Drawing.Point(15, 123)
        Me.chkSesak.Name = "chkSesak"
        Me.chkSesak.Size = New System.Drawing.Size(150, 24)
        Me.chkSesak.TabIndex = 3
        Me.chkSesak.Text = "Sesak napas"
        '
        'chkKelelahan
        '
        Me.chkKelelahan.Location = New System.Drawing.Point(15, 93)
        Me.chkKelelahan.Name = "chkKelelahan"
        Me.chkKelelahan.Size = New System.Drawing.Size(150, 24)
        Me.chkKelelahan.TabIndex = 2
        Me.chkKelelahan.Text = "Kelelahan"
        '
        'chkBatuk
        '
        Me.chkBatuk.Location = New System.Drawing.Point(15, 63)
        Me.chkBatuk.Name = "chkBatuk"
        Me.chkBatuk.Size = New System.Drawing.Size(150, 24)
        Me.chkBatuk.TabIndex = 1
        Me.chkBatuk.Text = "Batuk"
        '
        'chkDemam
        '
        Me.chkDemam.Location = New System.Drawing.Point(15, 30)
        Me.chkDemam.Name = "chkDemam"
        Me.chkDemam.Size = New System.Drawing.Size(150, 24)
        Me.chkDemam.TabIndex = 0
        Me.chkDemam.Text = "Demam"
        '
        'btnDiagnosa
        '
        Me.btnDiagnosa.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDiagnosa.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDiagnosa.Location = New System.Drawing.Point(480, 100)
        Me.btnDiagnosa.Name = "btnDiagnosa"
        Me.btnDiagnosa.Size = New System.Drawing.Size(300, 80)
        Me.btnDiagnosa.TabIndex = 2
        Me.btnDiagnosa.Text = "Diagnosa"
        Me.btnDiagnosa.UseVisualStyleBackColor = False
        '
        'btnBaru
        '
        Me.btnBaru.BackColor = System.Drawing.Color.LightGray
        Me.btnBaru.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnBaru.Location = New System.Drawing.Point(480, 220)
        Me.btnBaru.Name = "btnBaru"
        Me.btnBaru.Size = New System.Drawing.Size(300, 80)
        Me.btnBaru.TabIndex = 3
        Me.btnBaru.Text = "Baru"
        Me.btnBaru.UseVisualStyleBackColor = False
        '
        'txtHasil
        '
        Me.txtHasil.Location = New System.Drawing.Point(480, 380)
        Me.txtHasil.Multiline = True
        Me.txtHasil.Name = "txtHasil"
        Me.txtHasil.Size = New System.Drawing.Size(300, 80)
        Me.txtHasil.TabIndex = 4
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblHasil.Location = New System.Drawing.Point(480, 340)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(148, 28)
        Me.lblHasil.TabIndex = 5
        Me.lblHasil.Text = "Hasil Konsultasi"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(906, 783)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.grpGejala)
        Me.Controls.Add(Me.btnDiagnosa)
        Me.Controls.Add(Me.btnBaru)
        Me.Controls.Add(Me.txtHasil)
        Me.Controls.Add(Me.lblHasil)
        Me.Name = "Form1"
        Me.Text = "Expert System Diagnosa Penyakit"
        Me.grpGejala.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As Label
    Friend WithEvents grpGejala As GroupBox
    Friend WithEvents chkDemam As CheckBox
    Friend WithEvents chkBatuk As CheckBox
    Friend WithEvents chkKelelahan As CheckBox
    Friend WithEvents chkSesak As CheckBox
    Friend WithEvents chkRedaEnak As CheckBox
    Friend WithEvents chkSakitTubuh As CheckBox
    Friend WithEvents chkSakitKepala As CheckBox
    Friend WithEvents chkMenggigil As CheckBox
    Friend WithEvents chkNyeriOtot As CheckBox
    Friend WithEvents chkIngus As CheckBox
    Friend WithEvents chkTenggorokan As CheckBox
    Friend WithEvents chkMual As CheckBox
    Friend WithEvents chkDiare As CheckBox
    Friend WithEvents chkHilangRasa As CheckBox
    Friend WithEvents chkHilangBau As CheckBox
    Friend WithEvents chkBatukTidakBerdahak As CheckBox
    Friend WithEvents chkBatukBerdarah As CheckBox
    Friend WithEvents chkHilangBau2 As CheckBox
    Friend WithEvents btnDiagnosa As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents lblHasil As Label

    Private Sub chkRedaEnak_CheckedChanged(sender As Object, e As EventArgs) Handles chkRedaEnak.CheckedChanged

    End Sub
End Class