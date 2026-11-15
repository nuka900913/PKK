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
    public partial class FormDashboardA : Form
    {
        private void HitungHampirHabis()
        {
            using (SqlConnection conn = Koneksi.Buka())
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM tbdatabarang WHERE stok <= @batas", conn))
            {
                cmd.Parameters.AddWithValue("@batas", Koneksi.BatasStok);
                stokhampirhabis.Text = Convert.ToInt32(cmd.ExecuteScalar()).ToString("N0");
            }
        }

        private void TampilkanTotalSupplier()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbdatasupplier";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalSupplier = (int)cmd.ExecuteScalar();
                totalsupplier.Text = totalSupplier.ToString();
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
        private void TampilkanTotalUser()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tblogin";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalUser = (int)cmd.ExecuteScalar();
                totaluser.Text = totalUser.ToString();
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

        private void datagridview_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in datagridview.Rows)
            {
                if (row.IsNewRow) continue;

                object nilai = row.Cells["stok"].Value;
                if (nilai == null || nilai == DBNull.Value) continue;

                row.DefaultCellStyle.ForeColor =
                    Convert.ToInt32(nilai) <= Koneksi.BatasStok ? Color.Red : SystemColors.ControlText;
            }
        }

        public FormDashboardA()
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelgatau_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboardA_Load(object sender, EventArgs e)
        {
            TampilkanData();
            TampilkanTotalUser();
            TampilkanTotalBarang();
            TampilkanStokAman();
            TampilkanStokHabis();
            TampilkanTotalSupplier();
            HitungHampirHabis();
        }
    }
}
