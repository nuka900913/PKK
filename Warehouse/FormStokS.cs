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
    public partial class FormStokS : Form
    {
        public FormStokS()
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

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void FormStokS_Load(object sender, EventArgs e)
        {
            TampilkanData();
            TampilkanStokAman();
            TampilkanStokHabis();
            HitungHampirHabis();
        }
    }
}
