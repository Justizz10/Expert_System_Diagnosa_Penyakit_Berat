Public Class Form1

    ' Class untuk menyimpan aturan penyakit
    Public Class RulePenyakit
        Public Property NamaPenyakit As String
        Public Property Gejala As List(Of String)
        Public Property MinimumGejala As Integer
        Public Property Deskripsi As String
        Public Property Saran As String

        Public Sub New(nama As String, gejala As List(Of String), minGejala As Integer, desk As String, saran As String)
            Me.NamaPenyakit = nama
            Me.Gejala = gejala
            Me.MinimumGejala = minGejala
            Me.Deskripsi = desk
            Me.Saran = saran
        End Sub
    End Class

    ' List untuk menyimpan semua aturan penyakit
    Private listPenyakit As New List(Of RulePenyakit)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi basis pengetahuan penyakit
        InisialisasiPenyakit()
    End Sub

    Private Sub InisialisasiPenyakit()
        ' Basis pengetahuan penyakit dengan gejala-gejalanya

        ' COVID-19
        listPenyakit.Add(New RulePenyakit(
            "COVID-19",
            New List(Of String) From {"Demam", "Batuk", "Kelelahan", "Sesak napas",
                                      "Hilang rasa", "Hilang bau", "Sakit kepala",
                                      "Sakit dan nyeri tubuh", "Diare"},
            4,
            "COVID-19 adalah penyakit yang disebabkan oleh virus SARS-CoV-2.",
            "Segera lakukan tes PCR/Antigen, isolasi mandiri, dan konsultasi dengan dokter."
        ))

        ' Influenza (Flu)
        listPenyakit.Add(New RulePenyakit(
            "Influenza (Flu)",
            New List(Of String) From {"Demam", "Batuk", "Sakit kepala", "Sakit dan nyeri tubuh",
                                      "Kelelahan", "Menggigil", "Sakit tenggorokan", "Nyeri otot"},
            4,
            "Influenza adalah infeksi virus yang menyerang sistem pernapasan.",
            "Istirahat cukup, minum banyak air, dan konsumsi obat penurun demam. Konsultasi dokter jika gejala memburuk."
        ))

        ' Pilek (Common Cold)
        listPenyakit.Add(New RulePenyakit(
            "Pilek (Common Cold)",
            New List(Of String) From {"Ingus atau hidung tersumbat", "Sakit tenggorokan",
                                      "Batuk", "Rasa tidak enak", "Sakit kepala"},
            3,
            "Pilek adalah infeksi virus ringan pada hidung dan tenggorokan.",
            "Istirahat yang cukup, minum air hangat, dan konsumsi vitamin C."
        ))

        ' Bronkitis
        listPenyakit.Add(New RulePenyakit(
            "Bronkitis",
            New List(Of String) From {"Batuk", "Sesak napas", "Kelelahan",
                                      "Rasa tidak enak", "Sakit kepala"},
            3,
            "Bronkitis adalah peradangan pada saluran bronkial di paru-paru.",
            "Istirahat, minum banyak cairan, dan hindari asap rokok. Segera ke dokter jika batuk berlangsung lebih dari 3 minggu."
        ))

        ' Pneumonia
        listPenyakit.Add(New RulePenyakit(
            "Pneumonia",
            New List(Of String) From {"Demam", "Batuk", "Sesak napas", "Menggigil",
                                      "Sakit dan nyeri tubuh", "Kelelahan", "Mual"},
            4,
            "Pneumonia adalah infeksi yang menyebabkan peradangan pada kantong udara di paru-paru.",
            "SEGERA konsultasi dengan dokter untuk mendapatkan antibiotik dan perawatan yang tepat."
        ))

        ' Tuberkulosis (TBC)
        listPenyakit.Add(New RulePenyakit(
            "Tuberkulosis (TBC)",
            New List(Of String) From {"Batuk", "Batuk berdarah", "Kelelahan", "Demam",
                                      "Menggigil", "Sakit dan nyeri tubuh"},
            4,
            "TBC adalah penyakit infeksi bakteri yang menyerang paru-paru.",
            "SEGERA ke dokter atau puskesmas untuk tes dahak dan mendapatkan pengobatan OAT (Obat Anti Tuberkulosis)."
        ))

        ' Asma
        listPenyakit.Add(New RulePenyakit(
            "Asma",
            New List(Of String) From {"Sesak napas", "Batuk", "Rasa tidak enak", "Kelelahan"},
            3,
            "Asma adalah kondisi di mana saluran pernapasan menyempit dan membengkak.",
            "Gunakan inhaler sesuai resep dokter, hindari pemicu asma, dan konsultasi rutin dengan dokter."
        ))

        ' Gastroenteritis (Flu Perut)
        listPenyakit.Add(New RulePenyakit(
            "Gastroenteritis (Flu Perut)",
            New List(Of String) From {"Mual", "Diare", "Sakit kepala", "Kelelahan",
                                      "Sakit dan nyeri tubuh"},
            3,
            "Gastroenteritis adalah peradangan pada saluran pencernaan.",
            "Minum banyak cairan untuk mencegah dehidrasi, konsumsi makanan yang mudah dicerna, dan istirahat cukup."
        ))

        ' Sinusitis
        listPenyakit.Add(New RulePenyakit(
            "Sinusitis",
            New List(Of String) From {"Sakit kepala", "Ingus atau hidung tersumbat",
                                      "Hilang bau", "Rasa tidak enak", "Kelelahan"},
            3,
            "Sinusitis adalah peradangan atau pembengkakan pada jaringan sinus.",
            "Gunakan dekongestan, kompres hangat pada wajah, dan konsultasi dokter jika berlangsung lebih dari 10 hari."
        ))

        ' Migrain
        listPenyakit.Add(New RulePenyakit(
            "Migrain",
            New List(Of String) From {"Sakit kepala", "Mual", "Rasa tidak enak", "Kelelahan"},
            2,
            "Migrain adalah sakit kepala yang intens dan berdenyut.",
            "Istirahat di ruangan gelap dan tenang, kompres dingin, hindari pemicu migrain, dan konsumsi obat sesuai resep dokter."
        ))
    End Sub

    Private Sub btnDiagnosa_Click(sender As Object, e As EventArgs) Handles btnDiagnosa.Click
        ' Mengumpulkan gejala yang dipilih
        Dim gejalaYangDipilih As New List(Of String)

        If chkDemam.Checked Then gejalaYangDipilih.Add("Demam")
        If chkBatuk.Checked Then gejalaYangDipilih.Add("Batuk")
        If chkKelelahan.Checked Then gejalaYangDipilih.Add("Kelelahan")
        If chkSesak.Checked Then gejalaYangDipilih.Add("Sesak napas")
        If chkRedaEnak.Checked Then gejalaYangDipilih.Add("Rasa tidak enak")
        If chkSakitTubuh.Checked Then gejalaYangDipilih.Add("Sakit dan nyeri tubuh")
        If chkSakitKepala.Checked Then gejalaYangDipilih.Add("Sakit kepala")
        If chkMenggigil.Checked Then gejalaYangDipilih.Add("Menggigil")
        If chkNyeriOtot.Checked Then gejalaYangDipilih.Add("Nyeri otot")
        If chkIngus.Checked Then gejalaYangDipilih.Add("Ingus atau hidung tersumbat")
        If chkTenggorokan.Checked Then gejalaYangDipilih.Add("Sakit tenggorokan")
        If chkMual.Checked Then gejalaYangDipilih.Add("Mual")
        If chkDiare.Checked Then gejalaYangDipilih.Add("Diare")
        If chkHilangRasa.Checked Then gejalaYangDipilih.Add("Hilang rasa")
        If chkHilangBau.Checked Then gejalaYangDipilih.Add("Hilang bau")
        If chkHilangBau2.Checked Then gejalaYangDipilih.Add("Hilang bau")
        If chkBatukTidakBerdahak.Checked Then gejalaYangDipilih.Add("Batuk tidak berdahak")
        If chkBatukBerdarah.Checked Then gejalaYangDipilih.Add("Batuk berdarah")

        ' Validasi input
        If gejalaYangDipilih.Count = 0 Then
            MessageBox.Show("Silakan pilih minimal 1 gejala!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Proses diagnosa menggunakan forward chaining
        Dim hasilDiagnosa As List(Of RulePenyakit) = ProsesDiagnosa(gejalaYangDipilih)

        ' Tampilkan hasil
        TampilkanHasil(hasilDiagnosa, gejalaYangDipilih)
    End Sub

    Private Function ProsesDiagnosa(gejalaInput As List(Of String)) As List(Of RulePenyakit)
        Dim hasilDiagnosa As New List(Of RulePenyakit)

        ' Cek setiap penyakit dalam basis pengetahuan
        For Each penyakit In listPenyakit
            ' Hitung jumlah gejala yang cocok
            Dim jumlahCocok As Integer = 0
            For Each gejala In gejalaInput
                If penyakit.Gejala.Contains(gejala) Then
                    jumlahCocok += 1
                End If
            Next

            ' Jika jumlah gejala cocok memenuhi minimum, tambahkan ke hasil
            If jumlahCocok >= penyakit.MinimumGejala Then
                hasilDiagnosa.Add(penyakit)
            End If
        Next

        ' Urutkan berdasarkan jumlah gejala yang cocok (tertinggi ke terendah)
        hasilDiagnosa = hasilDiagnosa.OrderByDescending(Function(p)
                                                            Dim cocok = 0
                                                            For Each g In gejalaInput
                                                                If p.Gejala.Contains(g) Then cocok += 1
                                                            Next
                                                            Return cocok
                                                        End Function).ToList()

        Return hasilDiagnosa
    End Function

    Private Sub TampilkanHasil(hasilDiagnosa As List(Of RulePenyakit), gejalaInput As List(Of String))
        If hasilDiagnosa.Count = 0 Then
            txtHasil.Text = "Tidak ditemukan penyakit yang cocok dengan gejala yang dipilih."
            MessageBox.Show("Gejala yang Anda alami tidak cocok dengan basis pengetahuan sistem." & vbCrLf & vbCrLf &
                          "Saran: Segera konsultasi dengan dokter untuk mendapatkan diagnosa yang tepat.",
                          "Hasil Konsultasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            ' Ambil penyakit dengan kemungkinan tertinggi
            Dim penyakitUtama As RulePenyakit = hasilDiagnosa(0)

            ' Hitung persentase kecocokan
            Dim jumlahCocok As Integer = 0
            For Each gejala In gejalaInput
                If penyakitUtama.Gejala.Contains(gejala) Then
                    jumlahCocok += 1
                End If
            Next
            Dim persentase As Double = (jumlahCocok / penyakitUtama.Gejala.Count) * 100

            ' Tampilkan di TextBox
            txtHasil.Text = penyakitUtama.NamaPenyakit

            ' Buat detail hasil
            Dim detailHasil As String = "=== HASIL DIAGNOSA SISTEM PAKAR ===" & vbCrLf & vbCrLf
            detailHasil &= "Kemungkinan Penyakit: " & penyakitUtama.NamaPenyakit & vbCrLf
            detailHasil &= "Tingkat Kecocokan: " & Math.Round(persentase, 1) & "%" & vbCrLf & vbCrLf
            detailHasil &= "Deskripsi:" & vbCrLf
            detailHasil &= penyakitUtama.Deskripsi & vbCrLf & vbCrLf
            detailHasil &= "Saran:" & vbCrLf
            detailHasil &= penyakitUtama.Saran & vbCrLf & vbCrLf

            ' Jika ada kemungkinan penyakit lain
            If hasilDiagnosa.Count > 1 Then
                detailHasil &= "--- Kemungkinan Penyakit Lain ---" & vbCrLf
                For i = 1 To Math.Min(2, hasilDiagnosa.Count - 1)
                    Dim jumlahCocokLain As Integer = 0
                    For Each gejala In gejalaInput
                        If hasilDiagnosa(i).Gejala.Contains(gejala) Then
                            jumlahCocokLain += 1
                        End If
                    Next
                    Dim persenLain As Double = (jumlahCocokLain / hasilDiagnosa(i).Gejala.Count) * 100
                    detailHasil &= "- " & hasilDiagnosa(i).NamaPenyakit & " (" & Math.Round(persenLain, 1) & "%)" & vbCrLf
                Next
                detailHasil &= vbCrLf
            End If

            detailHasil &= "==================================" & vbCrLf
            detailHasil &= "CATATAN PENTING:" & vbCrLf
            detailHasil &= "Hasil diagnosa ini hanya sebagai referensi awal." & vbCrLf
            detailHasil &= "Untuk diagnosa yang akurat, konsultasikan dengan dokter profesional."

            ' Tampilkan dalam MessageBox
            MessageBox.Show(detailHasil, "Hasil Konsultasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBaru_Click(sender As Object, e As EventArgs) Handles btnBaru.Click
        ' Reset semua checkbox
        chkDemam.Checked = False
        chkBatuk.Checked = False
        chkKelelahan.Checked = False
        chkSesak.Checked = False
        chkRedaEnak.Checked = False
        chkSakitTubuh.Checked = False
        chkSakitKepala.Checked = False
        chkMenggigil.Checked = False
        chkNyeriOtot.Checked = False
        chkIngus.Checked = False
        chkTenggorokan.Checked = False
        chkMual.Checked = False
        chkDiare.Checked = False
        chkHilangRasa.Checked = False
        chkHilangBau.Checked = False
        chkHilangBau2.Checked = False
        chkBatukTidakBerdahak.Checked = False
        chkBatukBerdarah.Checked = False

        ' Reset hasil
        txtHasil.Text = ""

        MessageBox.Show("Form telah direset. Silakan mulai konsultasi baru.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lblJudul_Click(sender As Object, e As EventArgs) Handles lblJudul.Click

    End Sub
End Class