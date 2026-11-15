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
    public partial class FormSupplierA : Form
    {
        private void TampilkanSupplierTerdaftar()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tbdatasupplier";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalSupplier = (int)cmd.ExecuteScalar();
                supplierterdaftar.Text = totalSupplier.ToString();
            }
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
        public FormSupplierA()
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

        private void FormSupplierA_Load(object sender, EventArgs e)
        {
            TampilkanData();
            TampilkanSupplierTerdaftar();
        }

        private void tambahsupplier_Click(object sender, EventArgs e)
        {
            if (txtnama_supplier.Text == "" || txtemail.Text == "" || txtalamat.Text == "" || txtno_telp.Text == "" )
            {
                MessageBox.Show("Semua kolom harus diisi");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "INSERT INTO tbdatasupplier (nama_supplier, email, alamat, no_telp) VALUES (@nama_supplier, @email, @alamat, @no_telp)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_supplier", txtnama_supplier.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);
                    cmd.Parameters.AddWithValue("@no_telp", txtno_telp.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            txtnama_supplier.Text = "";
            txtemail.Text = "";
            txtalamat.Text = "";
            txtno_telp.Text = "";
            MessageBox.Show("Supplier berhasil ditambahkan");
            TampilkanData();
        }

        private void pencarian_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    using (SqlConnection conn = Koneksi.Buka())
            //    {
            //        string query = "SELECT * FROM tbdatasupplier WHERE nama_supplier LIKE @search";
            //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            //        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
            //        DataTable tabel = new DataTable();
            //        adapter.Fill(tabel);
            //        datagridview.DataSource = tabel;
            //    }

            //    e.SuppressKeyPress = true;
            //}

            // di matikan terlebih dahulu
        }

        private void pencarian_Click(object sender, EventArgs e)
        {
            pencarian.Text = "";
            TampilkanData();
        }

        private void ubahdata_Click(object sender, EventArgs e)
        {
            if ( txtid_supplier.Text == "" || txtnama_supplier.Text == "" || txtemail.Text == "" || txtalamat.Text == "" || txtno_telp.Text == "")
            {
                MessageBox.Show("Semua kolom harus diisi");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "UPDATE tbdatasupplier SET nama_supplier = @nama_supplier, email = @email, alamat = @alamat, no_telp = @no_telp WHERE id_supplier = @id_supplier";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nama_supplier", txtnama_supplier.Text);
                    cmd.Parameters.AddWithValue("@email", txtemail.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtalamat.Text);
                    cmd.Parameters.AddWithValue("@no_telp", txtno_telp.Text);
                    cmd.Parameters.AddWithValue("@id_supplier", txtid_supplier.Text);

                    int baris = cmd.ExecuteNonQuery();
                    if (baris > 0)
                        MessageBox.Show("Data Supplier berhasil diubah");
                    else
                        MessageBox.Show("ID supplier tidak ditemukan");
                }
            }
            txtnama_supplier.Text = "";
            txtemail.Text = "";
            txtalamat.Text = "";
            txtno_telp.Text = "";
            txtid_supplier.Text = "";
            TampilkanData();
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (txtid_supplier.Text == "")
            {
                MessageBox.Show("Masukkan kode supplier yang ingin dihapus");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "DELETE FROM tbdatasupplier WHERE id_supplier = @id_supplier";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id_supplier", txtid_supplier.Text);
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus supplier ini?", "Konfirmasi", buttons);
                    if (result == DialogResult.Yes)
                    {
                        int baris = cmd.ExecuteNonQuery();
                        if (baris > 0)
                            MessageBox.Show("Supplier berhasil dihapus");
                        else
                            MessageBox.Show("Id supplier tidak ditemukan");
                    }
                }
            }

            txtnama_supplier.Text = "";
            txtemail.Text = "";
            txtalamat.Text = "";
            txtno_telp.Text = "";
            txtid_supplier.Text = "";
            MessageBox.Show("Supplier berhasil dihapus");
            TampilkanData();
        }

        private void txtid_supplier_Click(object sender, EventArgs e)
        {
            pencarian.Text = "";
            TampilkanData();
        }

        private void txtid_supplier_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cari_Click(object sender, EventArgs e)
        {
            if (txtid_supplier.Text.Trim() == "")
            {
                MessageBox.Show("Masukkan ID Supplier yang ingin dicari", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtid_supplier.Focus();
                return;
            }

            try
            {
                using (SqlConnection conn = Koneksi.Buka())
                {
                    string query = "SELECT nama_supplier, email, alamat, no_telp FROM tbdatasupplier WHERE id_supplier = @id_supplier";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_supplier", txtid_supplier.Text.Trim());

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                txtnama_supplier.Text = rd["nama_supplier"].ToString();
                                txtemail.Text = rd["email"].ToString();
                                txtalamat.Text = rd["alamat"].ToString();
                                txtno_telp.Text = rd["no_telp"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("Data supplier tidak ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtnama_supplier.Clear();
                                txtemail.Clear();
                                txtalamat.Clear();
                                txtno_telp.Clear();
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

        private void txtid_supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void pencarian_TextChanged(object sender, EventArgs e)
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
}
