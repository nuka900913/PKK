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

using System.Collections.Generic;//untuk menggunakan data charting
using System.Windows.Forms.DataVisualization.Charting;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace Warehouse
{
    public partial class FormDashboardM : Form
    {
        public FormDashboardM()
        {
            InitializeComponent();
        }

        private void HitungTransaksiBulanIni()
        {
            DateTime awal = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
            DateTime akhir = awal.AddMonths(1);

            string query = @"SELECT
        (SELECT COUNT(*) FROM tbbarangmasuk  WHERE tanggal >= @awal AND tanggal < @akhir) +
        (SELECT COUNT(*) FROM tbbarangkeluar WHERE tanggal >= @awal AND tanggal < @akhir)";

            using (SqlConnection conn = Koneksi.Buka())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@awal", awal);
                cmd.Parameters.AddWithValue("@akhir", akhir);
                transaksibulanini.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0");
            }
        }

        private void HitungNilaiStok()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT ISNULL(SUM(CAST(stok AS DECIMAL(18,2)) * harga_satuan), 0) FROM tbdatabarang";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    decimal nilai = Convert.ToDecimal(cmd.ExecuteScalar());
                    nilaistok.Text = "Rp " + nilai.ToString("N0");
                }
            }
        }

        private void TampilkanTotalBarang()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbdatabarang";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalBarang = (int)cmd.ExecuteScalar();
                totalbarang.Text = totalBarang.ToString();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult jawab = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                Manager formmanager = Application.OpenForms.OfType<Manager>().FirstOrDefault();
                formmanager?.Close();
            }
        }

        private void FormDashboardM_Load(object sender, EventArgs e)
        {
            HitungTransaksiBulanIni();
            HitungNilaiStok();
            TampilkanTotalBarang();
            IsiChart();
        }

        private Dictionary<string, int> AmbilPerBulan(string tabel, DateTime awal)
        {
            var hasil = new Dictionary<string, int>();

            string query = "SELECT YEAR(tanggal), MONTH(tanggal), SUM(jumlah) FROM " + tabel +
                           " WHERE tanggal >= @awal GROUP BY YEAR(tanggal), MONTH(tanggal)";

            using (SqlConnection conn = Koneksi.Buka())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@awal", awal);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        string kunci = r.GetInt32(0) + "-" + r.GetInt32(1).ToString("00");
                        hasil[kunci] = Convert.ToInt32(r[2]);
                    }
                }
            }
            return hasil;
        }

        private void IsiChart()
        {
            DateTime awal = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-5);

            var masuk = AmbilPerBulan("tbbarangmasuk", awal);
            var keluar = AmbilPerBulan("tbbarangkeluar", awal);

            chartTren.Series.Clear();
            Series sMasuk = new Series("Masuk") { ChartType = SeriesChartType.Column };
            Series sKeluar = new Series("Keluar") { ChartType = SeriesChartType.Column };

            for (int i = 0; i < 6; i++)
            {
                DateTime bulan = awal.AddMonths(i);
                string kunci = bulan.Year + "-" + bulan.Month.ToString("00");
                string label = bulan.ToString("MMM yy");

                sMasuk.Points.AddXY(label, masuk.ContainsKey(kunci) ? masuk[kunci] : 0);
                sKeluar.Points.AddXY(label, keluar.ContainsKey(kunci) ? keluar[kunci] : 0);
            }

            chartTren.Series.Add(sMasuk);
            chartTren.Series.Add(sKeluar);
            chartTren.Titles.Clear();
            chartTren.Titles.Add("Tren barang masuk dan keluar");
        }

        private void btncetaklaporan_Click(object sender, EventArgs e)
        {

        }
        private void FormLaporan_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
