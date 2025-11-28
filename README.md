# 🩺 Expert System Diagnosa Penyakit Pernapasan dan Umum
*Sistem Pakar untuk melakukan diagnosa awal beberapa penyakit berdasarkan gejala yang dipilih oleh pengguna.*

---

## 📋 Deskripsi Proyek

[cite_start]Proyek ini adalah implementasi **Sistem Pakar (Expert System)** sederhana yang dibangun menggunakan **Visual Basic (VB.NET)** dan **Windows Forms**[cite: 1, 43]. Sistem ini dirancang untuk memberikan diagnosa awal mengenai beberapa penyakit pernapasan dan umum berdasarkan gejala yang dipilih oleh pengguna.

[cite_start]Logika diagnosa menggunakan metode **Forward Chaining** [cite: 22, 23] dengan basis pengetahuan (aturan) yang telah ditentukan sebelumnya. [cite_start]Hasil diagnosa menampilkan kemungkinan penyakit utama, tingkat kecocokan (persentase), deskripsi penyakit, serta saran penanganan awal[cite: 33, 34].

## ✨ Fitur Utama

* [cite_start]**Basis Pengetahuan Penyakit:** Mencakup daftar penyakit dan gejala yang terkait, seperti COVID-19, Influenza, Pilek, Bronkitis, Pneumonia, TBC, Asma, Gastroenteritis, dan Sinusitis, termasuk Migrain[cite: 4, 6, 8, 9, 11, 12, 14, 15, 17, 18].
* [cite_start]**Aturan Minimum Gejala:** Setiap penyakit memiliki batas minimum gejala yang harus cocok untuk dianggap terdiagnosa[cite: 5, 13, 24].
* [cite_start]**Metode Forward Chaining:** Digunakan untuk memproses input gejala dan mencari penyakit yang paling cocok dengan gejala yang dipilih[cite: 22, 23].
* [cite_start]**Perhitungan Persentase Kecocokan:** Menghitung tingkat kecocokan antara gejala input dan aturan penyakit untuk memprioritaskan hasil[cite: 32, 33].
* [cite_start]**Tampilan Hasil Rinci:** Menampilkan penyakit utama, persentase kecocokan, deskripsi penyakit, dan saran penanganan[cite: 33, 34].
* [cite_start]**Saran Konsultasi:** Selalu menyertakan peringatan untuk segera berkonsultasi dengan dokter profesional untuk diagnosa yang akurat[cite: 38].
* [cite_start]**Tombol Reset/Baru:** Fungsi untuk membersihkan semua input gejala dan hasil diagnosa sebelumnya[cite: 39, 41, 42].

## 💻 Teknologi yang Digunakan

* [cite_start]**Bahasa Pemrograman:** Visual Basic (VB.NET) [cite: 1]
* [cite_start]**Platform:** Windows Forms (.NET Framework) [cite: 43]
* **Paradigma:** Sistem Pakar (Expert System) dengan metode Forward Chaining.

## ⚙️ Basis Aturan Pengetahuan

[cite_start]Basis pengetahuan didefinisikan dalam kelas `RulePenyakit` dan diinisialisasi dalam `listPenyakit`[cite: 1, 3]. Berikut adalah beberapa contoh aturan:

| Penyakit | Gejala Utama | Minimal Gejala |
| :--- | :--- | :--- |
| **COVID-19** | [cite_start]Demam, Batuk, Kelelahan, Sesak napas, Hilang rasa/bau, Sakit kepala, Diare, dll. [cite: 4] | [cite_start]4 [cite: 5] |
| **Influenza (Flu)** | [cite_start]Demam, Batuk, Sakit kepala, Nyeri tubuh, Menggigil, Sakit tenggorokan, Nyeri otot [cite: 6] | [cite_start]4 [cite: 6] |
| **Pneumonia** | [cite_start]Demam, Batuk, Sesak napas, Menggigil, Nyeri tubuh, Kelelahan, Mual [cite: 11] | [cite_start]4 [cite: 11] |
| **TBC** | [cite_start]Batuk, Batuk berdarah, Kelelahan, Demam, Menggigil, Nyeri tubuh [cite: 12, 13] | [cite_start]4 [cite: 13] |
| **Pilek (Common Cold)** | [cite_start]Ingus/Hidung tersumbat, Sakit tenggorokan, Batuk, Rasa tidak enak, Sakit kepala [cite: 8] | [cite_start]3 [cite: 8] |

## 🛠️ Instalasi dan Penggunaan

Proyek ini adalah aplikasi desktop berbasis Windows Forms.

1.  **Clone Repositori:**
    ```bash
    git clone [https://github.com/Justizz10/Expert_System_Diagnosa_Penyakit_Berat/tree/main/Expert_System_Diagnosa_Penyakit]
    ```
2.  **Buka di IDE:** Buka folder proyek di Visual Studio.
3.  [cite_start]**Jalankan:** Jalankan proyek (biasanya dengan menekan F5 atau tombol "Start")[cite: 43].
4.  **Diagnosa:**
    * [cite_start]Pilih gejala yang Anda rasakan dari daftar *checkbox*[cite: 51].
    * [cite_start]Klik tombol **"Diagnosa"**[cite: 66].
    * [cite_start]Hasil diagnosa akan ditampilkan di kotak teks dan melalui *message box*[cite: 68, 30].
    * [cite_start]Gunakan tombol **"Baru"** untuk mereset input[cite: 67].
