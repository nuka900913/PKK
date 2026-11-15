using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Warehouse
{
    public partial class FormDashboardS : Form
    {
        public FormDashboardS()
        {
            InitializeComponent();
        }

        private void MuatDashboard()
        {
            DateTime hari = DateTime.Today;
            DateTime besok = hari.AddDays(1);

            try
            {
                using (SqlConnection conn = Koneksi.Buka())
                {
                    // ini aku buat untuk tiga kartu sekaligus dalam satu query biar lebih gampang aja
                    string qKartu = @"SELECT
                (SELECT COUNT(*) FROM tbdatabarang),
                (SELECT ISNULL(SUM(jumlah), 0) FROM tbbarangmasuk  WHERE tanggal >= @hari AND tanggal < @besok),
                (SELECT ISNULL(SUM(jumlah), 0) FROM tbbarangkeluar WHERE tanggal >= @hari AND tanggal < @besok)";

                    using (SqlCommand cmd = new SqlCommand(qKartu, conn))
                    {
                        cmd.Parameters.AddWithValue("@hari", hari);
                        cmd.Parameters.AddWithValue("@besok", besok);
                        using (SqlDataReader r = cmd.ExecuteReader())
                        {
                            if (r.Read())
                            {
                                totalbarang.Text = Convert.ToInt32(r[0]).ToString("N0");
                                masukhariini.Text = Convert.ToInt32(r[1]).ToString("N0");
                                keluarhariini.Text = Convert.ToInt32(r[2]).ToString("N0");
                            }
                        }
                    }

                    // 5 aktivitas terbaru (masuk dan keluar digabung)
                    string qAktivitas = @"SELECT TOP 5 * FROM (
                    SELECT m.tanggal AS Tanggal, b.nama_barang AS Barang, 'Masuk' AS Jenis, m.jumlah AS Jumlah
                    FROM tbbarangmasuk m JOIN tbdatabarang b ON b.id_barang = m.id_barang
                    UNION ALL
                    SELECT k.tanggal, b.nama_barang, 'Keluar', k.jumlah
                    FROM tbbarangkeluar k JOIN tbdatabarang b ON b.id_barang = k.id_barang
                    ) x ORDER BY Tanggal DESC";

                    DataTable tabel = new DataTable();
                    new SqlDataAdapter(qAktivitas, conn).Fill(tabel);
                    datagridview.DataSource = tabel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat dashboard: " + ex.Message);
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            datagridview.ReadOnly = true;
            datagridview.AllowUserToAddRows = false;
            datagridview.RowHeadersVisible = false;
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            MuatDashboard();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult jawab = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawab == DialogResult.Yes)
            {
                Staff formstaff = Application.OpenForms.OfType<Staff>().FirstOrDefault();
                formstaff?.Close();
            }
        }

        private void FormDashboardS_Load(object sender, EventArgs e)
        {
            MuatDashboard();
        }
    }
}
