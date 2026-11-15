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
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Username dan password harus diisi");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT id_user, password, role FROM tblogin WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", txtusername.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read() &&
                            BCrypt.Net.BCrypt.Verify(txtpassword.Text, reader["password"].ToString().Trim()))
                        {
                            Sesi.IdUser = Convert.ToInt32(reader["id_user"]);
                            Sesi.Username = txtusername.Text;
                            Sesi.Role = reader["role"].ToString().Trim();

                            string role = Sesi.Role.ToLower();

                            Form formTujuan = null;
                            if (role == "admin")
                                formTujuan = new Admin();
                            else if (role == "staff")
                                formTujuan = new Staff();
                            else if (role == "manager")
                                formTujuan = new Manager();

                            if (formTujuan != null)
                            {
                                this.Hide();
                                formTujuan.Show();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah");
                        }
                    }
                }
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnlogin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
