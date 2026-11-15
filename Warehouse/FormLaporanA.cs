using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;//
using System.Data;// untuk export ke excel ae
using System.IO;//

using System.Drawing;// kedua ini untuk cetak laporan ke printer atau semacamnya lah
using System.Drawing.Printing;//

using System.Globalization;

namespace Warehouse
{
    public partial class FormLaporanA : Form
    {
        private void HitungNilaiTransaksi(DateTime dari, DateTime sampai)
        {
            decimal nilai = 0;

            using (SqlConnection conn = Koneksi.Buka())
            {
                if (JenisLaporan.Text == "Barang masuk" || JenisLaporan.Text == "Masuk & keluar")
                {
                    string qMasuk = @"SELECT ISNULL(SUM(m.jumlah * b.harga_satuan), 0)
                              FROM tbbarangmasuk m
                              JOIN tbdatabarang b ON b.id_barang = m.id_barang
                              WHERE m.tanggal >= @dari AND m.tanggal < @sampai";
                    using (SqlCommand cmd = new SqlCommand(qMasuk, conn))
                    {
                        cmd.Parameters.AddWithValue("@dari", dari);
                        cmd.Parameters.AddWithValue("@sampai", sampai);
                        nilai += Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }

                if (JenisLaporan.Text == "Barang keluar" || JenisLaporan.Text == "Masuk & keluar")
                {
                    string qKeluar = @"SELECT ISNULL(SUM(k.jumlah * b.harga_satuan), 0)
                               FROM tbbarangkeluar k
                               JOIN tbdatabarang b ON b.id_barang = k.id_barang
                               WHERE k.tanggal >= @dari AND k.tanggal < @sampai";
                    using (SqlCommand cmd = new SqlCommand(qKeluar, conn))
                    {
                        cmd.Parameters.AddWithValue("@dari", dari);
                        cmd.Parameters.AddWithValue("@sampai", sampai);
                        nilai += Convert.ToDecimal(cmd.ExecuteScalar());
                    }
                }
            }

            nilaitransaksi.Text = "Rp " + nilai.ToString("N0");
        }

        private void TampilkanNilaiTransaksi()
        {
            DateTime dari, sampai;
            DateTime hariIni = DateTime.Today;
            switch (Periode.Text)
            {
                case "Hari ini":
                    dari = hariIni; sampai = hariIni.AddDays(1); break;
                case "Minggu ini":
                    int selisih = ((int)hariIni.DayOfWeek + 6) % 7;   // awal minggu = Senin
                    dari = hariIni.AddDays(-selisih); sampai = dari.AddDays(7); break;
                case "Bulan ini":
                    dari = new DateTime(hariIni.Year, hariIni.Month, 1); sampai = dari.AddMonths(1); break;
                case "Tahun ini":
                    dari = new DateTime(hariIni.Year, 1, 1); sampai = dari.AddYears(1); break;
                default:
                    MessageBox.Show("Pilih periode dulu"); return;
            }
            HitungNilaiTransaksi(dari, sampai);
        }
        
        private void TampilkanTotalKeluar()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbbarangkeluar";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalUser = (int)cmd.ExecuteScalar();
                totalkeluar.Text = totalUser.ToString();
            }
        }

        private void TampilkanTotalMasuk()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbbarangmasuk";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalUser = (int)cmd.ExecuteScalar();
                totalmasuk.Text = totalUser.ToString();
            }
        }

        public FormLaporanA()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult jawab = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                Admin formadmin = Application.OpenForms.OfType<Admin>().FirstOrDefault();
                formadmin?.Close();
            }
        }

        private void FormLaporanA_Load(object sender, EventArgs e)
        {
            TampilkanTotalMasuk();
            TampilkanTotalKeluar();

            Periode.Text = "Hari ini";
            JenisLaporan.Text = "Masuk & keluar";
            TampilkanNilaiTransaksi();
            cari_Click(sender, e);
        }

        private void cari_Click(object sender, EventArgs e)
        {
            DateTime dari, sampai;
            DateTime hariIni = DateTime.Today;

            switch (Periode.Text)
            {
                case "Hari ini":
                    dari = hariIni; sampai = hariIni.AddDays(1); break;
                case "Minggu ini":
                    int selisih = ((int)hariIni.DayOfWeek + 6) % 7;   // awal minggu = Senin
                    dari = hariIni.AddDays(-selisih); sampai = dari.AddDays(7); break;
                case "Bulan ini":
                    dari = new DateTime(hariIni.Year, hariIni.Month, 1); sampai = dari.AddMonths(1); break;
                case "Tahun ini":
                    dari = new DateTime(hariIni.Year, 1, 1); sampai = dari.AddYears(1); break;
                default:
                    MessageBox.Show("Pilih periode dulu"); return;
            }

            string queryMasuk = @"SELECT m.tanggal AS Tanggal, b.nama_barang AS Barang, 'Masuk' AS Jenis, m.jumlah AS Jumlah
                      FROM tbbarangmasuk m JOIN tbdatabarang b ON b.id_barang = m.id_barang
                      WHERE m.tanggal >= @dari AND m.tanggal < @sampai";
            string queryKeluar = @"SELECT k.tanggal, b.nama_barang, 'Keluar', k.jumlah
                       FROM tbbarangkeluar k JOIN tbdatabarang b ON b.id_barang = k.id_barang
                       WHERE k.tanggal >= @dari AND k.tanggal < @sampai";

            string query;
            if (JenisLaporan.Text == "Barang masuk")
                query = queryMasuk + " ORDER BY Tanggal DESC";
            else if (JenisLaporan.Text == "Barang keluar")
                query = queryKeluar.Replace("k.tanggal, b.nama_barang, 'Keluar', k.jumlah",
                                            "k.tanggal AS Tanggal, b.nama_barang AS Barang, 'Keluar' AS Jenis, k.jumlah AS Jumlah")
                        + " ORDER BY Tanggal DESC";
            else if (JenisLaporan.Text == "Masuk & keluar")
                query = queryMasuk + " UNION ALL " + queryKeluar + " ORDER BY Tanggal DESC";
            else
            {
                MessageBox.Show("Pilih jenis laporan dulu"); return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@dari", dari);
                adapter.SelectCommand.Parameters.AddWithValue("@sampai", sampai);
                DataTable tabel = new DataTable();
                datagridview.DataSource = tabel;
                adapter.Fill(tabel);
                
            }

            TampilkanNilaiTransaksi();
        }

        private void pencarian_TextChanged(object sender, EventArgs e)
        {
            DataTable tabel = datagridview.DataSource as DataTable;
            if (tabel == null) return;   

            string kata = pencarian.Text.Trim().Replace("'", "''");

            try
            {
                tabel.DefaultView.RowFilter = kata == "" ? "" : "Barang LIKE '%" + kata + "%'";
            }
            catch (Exception)
            {
                
            }
        }

        private void pencarian_Click(object sender, EventArgs e)
        {
            pencarian.Text = "";
        }

        private void nilaitransaksi_Click(object sender, EventArgs e)
        {
            TampilkanNilaiTransaksi();
        }

        private void btnbarangmasuk_Click(object sender, EventArgs e)
        {
            DataTable sumber = datagridview.DataSource as DataTable;
            if (sumber == null || sumber.DefaultView.Count == 0)
            {
                MessageBox.Show("Tampilkan laporan dulu sebelum export");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "Laporan_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    DataTable hasil = sumber.DefaultView.ToTable();   // sudah memakai filter pencarian

                    using (XLWorkbook wb = new XLWorkbook())
                    {
                        IXLWorksheet ws = wb.Worksheets.Add("Laporan");
                        ws.Cell(1, 1).Value = "Laporan Warehouse";
                        ws.Cell(1, 1).Style.Font.Bold = true;
                        ws.Cell(2, 1).Value = Periode.Text + " - " + JenisLaporan.Text;
                        ws.Cell(3, 1).Value = "Nilai transaksi: " + nilaitransaksi.Text;

                        ws.Cell(5, 1).InsertTable(hasil);
                        ws.Columns().AdjustToContents();

                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Export berhasil");
                }
                catch (IOException)
                {
                    MessageBox.Show("File tidak bisa ditulis. Tutup dulu file Excel yang sama kalau sedang terbuka.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Export gagal: " + ex.Message);
                }
            }
        }

        private int barisCetak = 0;
        private int halamanCetak = 1;

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            using (Font fKop = new Font("Segoe UI", 16, FontStyle.Bold))
            using (Font fJudul = new Font("Segoe UI", 14, FontStyle.Bold))
            using (Font fIsi = new Font("Segoe UI", 10))
            using (Font fHead = new Font("Segoe UI", 10, FontStyle.Bold))
            using (StringFormat potong = new StringFormat { Trimming = StringTrimming.EllipsisCharacter, FormatFlags = StringFormatFlags.NoWrap })
            {
                float x = e.MarginBounds.Left;
                float y = e.MarginBounds.Top;

                // ini buat judul di halaman pertama
                if (halamanCetak == 1)
                {
                    // ===== KOP SURAT =====
                    float tinggiLogo = 60;
                    Image logo = Properties.Resources.GudangGue_transparan;   // jangan di-Dispose, gambar ini dipakai bersama
                    g.DrawImage(logo, x, y, tinggiLogo, tinggiLogo);

                    float xTeks = x + tinggiLogo + 12;
                    g.DrawString("GUDANGGUE", fKop, Brushes.Black, xTeks, y);
                    g.DrawString("Sistem Manajemen Gudang", fIsi, Brushes.Black, xTeks, y + fKop.GetHeight(g));
                    g.DrawString("Alamat Gudang | Telp: 0800-0000-0000", fIsi, Brushes.Black, xTeks, y + fKop.GetHeight(g) + fIsi.GetHeight(g));

                    y += tinggiLogo + 8;
                    using (Pen tebal = new Pen(Color.Black, 3))
                        g.DrawLine(tebal, x, y, x + e.MarginBounds.Width, y);
                    g.DrawLine(Pens.Black, x, y + 4, x + e.MarginBounds.Width, y + 4);
                    y += 18;

                    // ===== JUDUL LAPORAN =====
                    g.DrawString("Laporan " + JenisLaporan.Text, fJudul, Brushes.Black, x, y);
                    y += fJudul.GetHeight(g) + 4;
                    g.DrawString("Periode: " + Periode.Text, fIsi, Brushes.Black, x, y);
                    y += fIsi.GetHeight(g);
                    g.DrawString("Nilai transaksi: " + nilaitransaksi.Text, fIsi, Brushes.Black, x, y);
                    y += fIsi.GetHeight(g) + 12;

                    // (kode chart yang tadi tetap di sini, kalau ada)
                }

                // ini buat lebar kolom proporsional dengan lebar kolom di grid
                var kolom = new System.Collections.Generic.List<DataGridViewColumn>();
                float totalLebar = 0;
                foreach (DataGridViewColumn c in datagridview.Columns)
                {
                    if (c.Visible) { kolom.Add(c); totalLebar += c.Width; }
                }

                float tinggiBaris = fIsi.GetHeight(g) + 8;

                // ini buat header kolom
                float xKolom = x;
                foreach (DataGridViewColumn c in kolom)
                {
                    float lebar = e.MarginBounds.Width * c.Width / totalLebar;
                    g.DrawString(c.HeaderText, fHead, Brushes.Black, new RectangleF(xKolom, y, lebar, tinggiBaris), potong);
                    xKolom += lebar;
                }
                y += tinggiBaris;
                g.DrawLine(Pens.Black, x, y, x + e.MarginBounds.Width, y);
                y += 4;

                // isi baris, berhenti kalau halaman penuh
                while (barisCetak < datagridview.Rows.Count && y + tinggiBaris < e.MarginBounds.Bottom - 20)
                {
                    DataGridViewRow row = datagridview.Rows[barisCetak];
                    barisCetak++;
                    if (row.IsNewRow) continue;

                    xKolom = x;
                    foreach (DataGridViewColumn c in kolom)
                    {
                        float lebar = e.MarginBounds.Width * c.Width / totalLebar;
                        string teks = Convert.ToString(row.Cells[c.Index].FormattedValue);
                        g.DrawString(teks, fIsi, Brushes.Black, new RectangleF(xKolom, y, lebar, tinggiBaris), potong);
                        xKolom += lebar;
                    }
                    y += tinggiBaris;
                }

                bool semuaBaris = barisCetak >= datagridview.Rows.Count;
                float tinggiTtd = 170;
                bool muatTtd = y + tinggiTtd <= e.MarginBounds.Bottom - 20;

                if (semuaBaris && muatTtd)
                {
                    float xTtd = e.MarginBounds.Right - 220;
                    float yTtd = y + 24;

                    g.DrawString("Tanggal cetak: " + DateTime.Now.ToString("d MMMM yyyy", new CultureInfo("id-ID")),
                                 fIsi, Brushes.Black, xTtd, yTtd);
                    yTtd += fIsi.GetHeight(g) + 4;
                    g.DrawString("Penanggung jawab,", fIsi, Brushes.Black, xTtd, yTtd);
                    yTtd += 70;   // ruang untuk tanda tangan

                    string nama = Sesi.Username;
                    string jabatan = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Sesi.Role);

                    g.DrawString(nama, fHead, Brushes.Black, xTtd, yTtd);
                    float garisY = yTtd + fHead.GetHeight(g);
                    float lebarGaris = Math.Max(g.MeasureString(nama, fHead).Width, 150);
                    g.DrawLine(Pens.Black, xTtd, garisY, xTtd + lebarGaris, garisY);
                    g.DrawString(jabatan, fIsi, Brushes.Black, xTtd, garisY + 2);
                }

                // nomor halaman
                g.DrawString("Halaman " + halamanCetak, fIsi, Brushes.Gray, x, e.MarginBounds.Bottom);

                e.HasMorePages = !(semuaBaris && muatTtd);
                if (e.HasMorePages) halamanCetak++;
            }
        }


        private void catattransaksi_Click(object sender, EventArgs e)
        {
            if (datagridview.Rows.Count == 0)
            {
                MessageBox.Show("Tampilkan laporan dulu sebelum mencetak");
                return;
            }

            barisCetak = 0;
            halamanCetak = 1;

            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;

            using (PrintPreviewDialog preview = new PrintPreviewDialog())
            {
                preview.Document = doc;
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog();
            }
        }

        private void Periode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
