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
    public partial class FormDataBarangA : Form
    {
        private void TampilkanBarangTerdaftar()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbdatabarang";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalBarang = (int)cmd.ExecuteScalar();
                label2.Text = totalBarang.ToString();
            }
        }

        private void TampilKategori()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT id_kategori, nama_kategori FROM tbkategoribarang";

                using (SqlDataAdapter da = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    kategori.DataSource = dt;
                    kategori.DisplayMember = "nama_kategori";
                    kategori.ValueMember = "id_kategori";
                    kategori.SelectedIndex = -1;
                }
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

        public FormDataBarangA()
        {
            InitializeComponent();
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

        private void FormDataBarangA_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Role: [" + Sesi.Role + "]");
            bool admin = string.Equals(Sesi.Role, "admin", StringComparison.OrdinalIgnoreCase);

            hapus.Visible = admin;

            TampilkanData();

            TampilkanData();
            TampilKategori();
            TampilkanBarangTerdaftar();
        }

        private void tambahbarang_Click(object sender, EventArgs e)
        {
            if (txtkode_barang.Text == "" || txtnama_barang.Text == "" || txtstok.Text == "" || txtharga_satuan.Text == "" || kategori.Text == "")
            {
                MessageBox.Show("Semua kolom harus diisi");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "INSERT INTO tbdatabarang (kode_barang, nama_barang, stok, harga_satuan, id_kategori) VALUES (@kode_barang, @nama_barang, @stok, @harga_satuan, @id_kategori)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kode_barang", txtkode_barang.Text);
                    cmd.Parameters.AddWithValue("@nama_barang", txtnama_barang.Text);
                    cmd.Parameters.AddWithValue("@stok", txtstok.Text);
                    cmd.Parameters.AddWithValue("@harga_satuan", txtharga_satuan.Text);
                    cmd.Parameters.AddWithValue("@id_kategori",Convert.ToInt32(kategori.SelectedValue));
                    cmd.ExecuteNonQuery();
                }
            }
            txtkode_barang.Text = "";
            txtnama_barang.Text = "";
            txtstok.Text = "";
            txtharga_satuan.Text = "";
            MessageBox.Show("Barang berhasil ditambahkan");
            TampilkanData();
        }

        private void ubahdata_Click(object sender, EventArgs e)
        {
            if (txtkode_barang.Text == "" || txtnama_barang.Text == "" || txtstok.Text == "" || txtharga_satuan.Text == "" )
            {
                MessageBox.Show("Semua kolom harus diisi");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "UPDATE tbdatabarang SET nama_barang = @nama_barang, stok = @stok, harga_satuan = @harga_satuan WHERE kode_barang = @kode_barang";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_barang", txtnama_barang.Text);
                    cmd.Parameters.AddWithValue("@stok", txtstok.Text);
                    cmd.Parameters.AddWithValue("@harga_satuan", txtharga_satuan.Text);
                    cmd.Parameters.AddWithValue("@kode_barang", txtkode_barang.Text);

                    int baris = cmd.ExecuteNonQuery();
                    if (baris > 0)
                        MessageBox.Show("Barang berhasil diubah");
                    else
                        MessageBox.Show("Kode barang tidak ditemukan");
                }
            }
            txtkode_barang.Text = "";
            txtnama_barang.Text = "";
            txtstok.Text = "";
            txtharga_satuan.Text = "";
            TampilkanData();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (Sesi.Role != "admin")
            {
                MessageBox.Show("Hanya Admin yang dapat menghapus barang");
                return;
            }

            if (txtkode_barang.Text == "")
            {
                MessageBox.Show("Masukkan kode barang yang ingin dihapus");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "DELETE FROM tbdatabarang WHERE kode_barang = @kode_barang";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@kode_barang", txtkode_barang.Text);

                    int baris = cmd.ExecuteNonQuery();
                    if (baris > 0)
                        MessageBox.Show("Barang berhasil dihapus");
                    else
                        MessageBox.Show("Kode barang tidak ditemukan");
                }
            }
            txtkode_barang.Text = "";
            txtnama_barang.Text = "";
            txtstok.Text = "";
            txtharga_satuan.Text = "";
            MessageBox.Show("Barang berhasil dihapus");
            TampilkanData();
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
            //        string query = "SELECT * FROM tbdatabarang WHERE nama_barang LIKE @search";
            //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            //        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
            //        DataTable tabel = new DataTable();
            //        adapter.Fill(tabel);
            //        datagridview.DataSource = tabel;
            //    }

            //    e.SuppressKeyPress = true;
            //}

            //dimatikan dulu ajadeh
        }

        private void cari_Click(object sender, EventArgs e)
        {
            if (txtid_barang.Text.Trim() == "")
            {
                MessageBox.Show("Masukkan ID Barang yang ingin dicari", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid_barang.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.Buka())
                {
                    string query = "SELECT kode_barang, nama_barang, stok, harga_satuan FROM tbdatabarang WHERE id_barang = @id_barang";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_barang", txtid_barang.Text.Trim());

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                txtkode_barang.Text = rd["kode_barang"].ToString();
                                txtnama_barang.Text = rd["nama_barang"].ToString();
                                txtstok.Text = rd["stok"].ToString();
                                txtharga_satuan.Text = rd["harga_satuan"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Data barang tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtkode_barang.Clear();
                                txtnama_barang.Clear();
                                txtstok.Clear();
                                txtharga_satuan.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Pencarian gagal!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtkode_barang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnama_barang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstok_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtharga_satuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void kategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pencarian_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT * FROM tbdatabarang WHERE nama_barang LIKE @search OR kode_barang LIKE @search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
            }
        }
    }
}
