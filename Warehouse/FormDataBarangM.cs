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

namespace Warehouse
{
    public partial class FormDataBarangM : Form
    {
        public FormDataBarangM()
        {
            InitializeComponent();
        }

        private void HitungHampirHabis()
        {
            using (SqlConnection conn = Koneksi.Buka())
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbdatabarang WHERE stok <= @batas", conn))
            {
                cmd.Parameters.AddWithValue("@batas", Koneksi.BatasStok);
                stokhampirhabis.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0");
            }
        }

        private void TampilkanStokHabis()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbdatabarang WHERE stok = 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalBarang = (int)cmd.ExecuteScalar();
                stokhabis.Text = totalBarang.ToString();
            }
        }

        private void TampilkanStokAman()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbdatabarang WHERE stok > 0";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalBarang = (int)cmd.ExecuteScalar();
                stokaman.Text = totalBarang.ToString();
            }
        }

        private void TampilkanData()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT * FROM tbdatabarang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
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

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDataBarangM_Load(object sender, EventArgs e)
        {
            TampilkanStokAman();
            TampilkanStokHabis();
            TampilkanData();
            HitungHampirHabis();
        }

        private void pencarian_Click(object sender, EventArgs e)
        {
            pencarian.Text = "";
            TampilkanData();
        }

        private void pencarian_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT * FROM tbdatabarang WHERE nama_barang LIKE @search OR kode_barang LIKE @search OR id_kategori LIKE @search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
            }
        }
    }
    
}
