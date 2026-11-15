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

    public partial class FormIn_OutboundA : Form
    {
        private void IsiCombo(ComboBox cmb, string query, string tampil, string nilai)
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

        private void TampilkanData()
        {
            using (SqlConnection conn = Koneksi.Buka())
            {
                string query = "SELECT * FROM tbbarangmasuk";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable tabel = new DataTable();
                adapter.Fill(tabel);
                datagridview.DataSource = tabel;
            }
        }

        public FormIn_OutboundA()
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

        private void FormIn_OutboundA_Load(object sender, EventArgs e)
        {
            IsiCombo(cmbBarang, "SELECT id_barang, nama_barang FROM tbdatabarang ORDER BY nama_barang", "nama_barang", "id_barang");
            IsiCombo(cmbSupplier, "SELECT id_supplier, nama_supplier FROM tbdatasupplier ORDER BY nama_supplier", "nama_supplier", "id_supplier");
            TampilkanData();
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            int jumlah;
            if (cmbBarang.SelectedValue == null || cmbSupplier.SelectedValue == null ||
                !int.TryParse(txtjumlah_barang. Text, out jumlah) || jumlah <= 0)
            {
                MessageBox.Show("Pilih barang, supplier, dan isi jumlah dengan angka lebih dari 0");
                return;
            }

            using (SqlConnection conn = Koneksi.Buka())
            using (SqlTransaction trx = conn.BeginTransaction())
            {
                try
                {
                    string insert = @"INSERT INTO tbbarangmasuk (id_barang, id_supplier, jumlah, keterangan, id_user)
                              VALUES (@id_barang, @id_supplier, @jumlah, @keterangan, @id_user)";
                    using (SqlCommand cmd = new SqlCommand(insert, conn, trx))
                    {
                        cmd.Parameters.AddWithValue("@id_barang", cmbBarang.SelectedValue);
                        cmd.Parameters.AddWithValue("@id_supplier", cmbSupplier.SelectedValue);
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@keterangan", txtketerangan.Text);
                        cmd.Parameters.AddWithValue("@id_user", Sesi.IdUser);
                        cmd.ExecuteNonQuery();
                    }

                    string update = "UPDATE tbdatabarang SET stok = stok + @jumlah WHERE id_barang = @barang";
                    using (SqlCommand cmd = new SqlCommand(update, conn, trx))
                    {
                        cmd.Parameters.AddWithValue("@jumlah", jumlah);
                        cmd.Parameters.AddWithValue("@barang", cmbBarang.SelectedValue);
                        cmd.ExecuteNonQuery();
                    }

                    trx.Commit();
                    MessageBox.Show("Barang masuk berhasil dicatat");
                    TampilkanData();
                }
                catch (Exception ex)
                {
                    trx.Rollback();
                    MessageBox.Show("Gagal menyimpan: " + ex.Message);
                }
            }
        }
    }
  
}
