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
    public partial class FormKelolaUserA : Form
    {
        private void TampilkanUserTerdaftar()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT COUNT(*) FROM tblogin";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalUser = (int)cmd.ExecuteScalar();
                userterdaftar.Text = totalUser.ToString();
            }
        }

        private void TampilkanData()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT username, role, id_user FROM tblogin";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
            }
        }

        public FormKelolaUserA()
        {
            InitializeComponent();
        }

        private void FormKelolaUserA_Load(object sender, EventArgs e)
        {
            TampilkanData();
            TampilkanUserTerdaftar();
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

        private void tambahuser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "" || cmbRole.Text == "")
            {
                MessageBox.Show("Semua kolom harus diisi");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "INSERT INTO tblogin (username, password, role) VALUES (@username, @password, @role)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", hash);
                    cmd.Parameters.AddWithValue("@role", cmbRole.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            txtPassword.Text = "";
            txtUsername.Text = "";
            MessageBox.Show("User berhasil ditambahkan");
            TampilkanData();

        }

        private void resetpassword_Click_1(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Pilih user dan isi password baru");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "UPDATE tblogin SET password = @password WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@password", hash);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                    int baris = cmd.ExecuteNonQuery();
                    if (baris > 0)
                        MessageBox.Show("Password berhasil direset");
                    else
                        MessageBox.Show("Username tidak ditemukan");
                }
            }
            txtPassword.Text = "";
            txtUsername.Text = "";
            MessageBox.Show("User berhasil diubah");
            TampilkanData();
        }

        private void pencarian_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    using (SqlConnection conn = Koneksi.Buka())
            //    {
            //        string query = "SELECT * FROM tblogin WHERE username LIKE @search";
            //        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            //        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
            //        DataTable tabel = new DataTable();
            //        adapter.Fill(tabel);
            //        datagridview.DataSource = tabel;
            //    }

            //    e.SuppressKeyPress = true;
            //}
            
            // matiin aja deh
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Pilih user dan isi password baru");
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text);

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "DELETE FROM tblogin WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                    int baris = cmd.ExecuteNonQuery();
                    if (baris > 0)
                        MessageBox.Show("User berhasil dihapus");
                    else
                        MessageBox.Show("Username tidak ditemukan");
                }
            }
            txtPassword.Text = "";
            txtUsername.Text = "";
            MessageBox.Show("User berhasil dihapus");
            TampilkanData();
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
                string query = "SELECT * FROM tblogin WHERE username LIKE @search";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + pencarian.Text + "%");
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
            }
        }
    }
    
}
