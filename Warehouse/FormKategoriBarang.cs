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
    public partial class FormKategoriBarang : Form
    {
        private void TampilkanKategoriTerdaftar()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbkategoribarang";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalKategori = (int)cmd.ExecuteScalar();
                kategori.Text = totalKategori .ToString();
            }
        }
        private void TampilkanData()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT * FROM tbkategoribarang";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
            }
        }

        public FormKategoriBarang()
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

        private void FormKategoriBarang_Load(object sender, EventArgs e)
        {
            TampilkanData();
            TampilkanKategoriTerdaftar();
        }

        private void pencarian_Click(object sender, EventArgs e)
        {
            pencarian.Text = "";
            TampilkanData();
        }

        private void pencarian_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    using (SqlConnection conn = Koneksi.Buka())
            //    {
            //        string query = "SELECT * FROM tbkategoribarang WHERE nama_kategori LIKE @search";
            //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            //        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
            //        DataTable tabel = new DataTable();
            //        adapter.Fill(tabel);
            //        datagridview.DataSource = tabel;
            //    }

            //    e.SuppressKeyPress = true;
            //}

            // dimatikan terlebih dahulu 
        }

        private void tambahkategori_Click(object sender, EventArgs e)
        {
            if ( txtnama_kategori.Text == "" || txtketerangan.Text == "")
            {
                MessageBox.Show("Semua kolom harus diisi");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "INSERT INTO tbkategoribarang (nama_kategori, keterangan) VALUES (@nama_kategori, @keterangan)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_kategori", txtnama_kategori.Text);
                    cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            txtnama_kategori.Text = "";
            txtketerangan.Text = "";
            MessageBox.Show("Kategori berhasil ditambahkan");
            TampilkanData();
        }

        private void ubahnama_Click(object sender, EventArgs e)
        {
            if (txtnama_kategori.Text == "" || txtketerangan.Text == "")
            {
                MessageBox.Show("Semua kolom harus diisi");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "UPDATE tbkategoribarang SET nama_kategori = @nama_kategori, keterangan = @keterangan WHERE nama_kategori = @nama_kategori_lama";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_kategori", txtnama_kategori.Text);
                    cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text);
                    cmd.Parameters.AddWithValue("@nama_kategori_lama", txtnama_kategori.Text);

                    int baris = cmd.ExecuteNonQuery();
                    if (baris > 0)
                        MessageBox.Show("Kategori berhasil diubah");
                    else
                        MessageBox.Show("Kategori tidak ditemukan");
                }
            }
            txtnama_kategori.Text = "";
            txtketerangan.Text = "";
            kategori.Text = "";
            MessageBox.Show("Kategori berhasil diubah");
            TampilkanData();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (txtnama_kategori.Text == "")
            {
                MessageBox.Show("Masukkan nama kategori yang ingin dihapus");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "DELETE FROM tbkategoribarang WHERE nama_kategori = @nama_kategori";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_kategori", txtnama_kategori.Text);

                    int baris = cmd.ExecuteNonQuery();
                    if (baris > 0)
                        MessageBox.Show("Kategori berhasil dihapus");
                    else
                        MessageBox.Show("Kategori tidak ditemukan");
                }
            }
            txtnama_kategori.Text = "";
            txtketerangan.Text = "";
            kategori.Text = "";
            MessageBox.Show("Kategori berhasil dihapus");
            TampilkanData();
        }

        private void pencarian_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT * FROM tbkategoribarang WHERE nama_kategori LIKE @search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
            }
        }
    }
}
