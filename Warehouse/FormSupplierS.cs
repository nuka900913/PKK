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
    public partial class FormSupplierS : Form
    {
        public FormSupplierS()
        {
            InitializeComponent();
        }

        private void TampilkanData()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT * FROM tbdatasupplier";
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
                Staff formstaff = Application.OpenForms.OfType<Staff>().FirstOrDefault();
                formstaff?.Close();
            }
        }

        private void FormSupplierS_Load(object sender, EventArgs e)
        {
            TampilkanData();
        }

        private void pencarian_TextChanged(object sender, EventArgs e)
        {
            {
                using (SqlConnection conn = Koneksi.Buka())
                {
                    string query = "SELECT * FROM tbdatasupplier WHERE nama_supplier LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
                    DataTable tabel = new DataTable();
                    adapter.Fill(tabel);
                    datagridview.DataSource = tabel;
                }
            }
        }

        private void pencarian_Click(object sender, EventArgs e)
        {
            pencarian.Text = "";
            TampilkanData();
        }
    }
}
