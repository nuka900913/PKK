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
    public partial class FormStockBarangA : Form
    {
        private void TampilkanData()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT * FROM tbbarangkeluar";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
            }
        }

        private void IsiCombo(ComboBox cmb, string query, string tampil, string nilai)
        {
            try
            {
                using (SqlConnection conn = Koneksi.Buka())
                {
                    DataTable tabel = new DataTable();
                    new SqlDataAdapter(query, conn).Fill(tabel);
                    cmb.DataSource = tabel;
                    cmb.DisplayMember = tampil;
                    cmb.ValueMember = nilai;
                    cmb.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public FormStockBarangA()
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

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void simpan_Click(object sender, EventArgs e)
        {
            int jumlah;
            if (cmbBarang.SelectedValue == null ||
                !int.TryParse(txtjumlah_barang.Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Pilih barang dan isi jumlah dengan angka lebih dari 0");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            using (SqlTransaction trx = conn.BeginTransaction())
            {
                try
                {
                    string update = "UPDATE tbdatabarang SET stok = stok - @jumlah WHERE id_barang = @id_barang AND stok >= @jumlah";
                    int terubah;
                    using (SqlCommand cmd = new SqlCommand(update, conn, trx))
                    {
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@id_barang", cmbBarang.SelectedValue);
                        terubah = cmd.ExecuteNonQuery();
                    }

                    if (terubah == 0)
                    {
                        trx.Rollback();
                        MessageBox.Show("Stok tidak cukup untuk jumlah tersebut");
                        return;
                    }

                    string insert = @"INSERT INTO tbbarangkeluar (id_barang, jumlah, keterangan, id_user)
                              VALUES (@id_barang, @jumlah, @keterangan, @id_user)";
                    using (SqlCommand cmd = new SqlCommand(insert, conn, trx))
                    {
                        cmd.Parameters.AddWithValue("@id_barang", cmbBarang.SelectedValue);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text);
                        cmd.Parameters.AddWithValue("@id_user", Sesi.IdUser);
                        cmd.ExecuteNonQuery();
                    }

                    trx.Commit();
                    MessageBox.Show("Barang keluar berhasil dicatat");
                    TampilkanData();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show("Gagal menyimpan: " + ex.Message);
                }
            }
        }

        private void FormStockBarangA_Load(object sender, EventArgs e)
        {
            IsiCombo(cmbBarang, "SELECT id_barang, nama_barang FROM tbdatabarang ORDER BY nama_barang", "nama_barang", "id_barang");
            TampilkanData();
        }
    }
}
