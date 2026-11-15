using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormDashboardA formdashboard = new FormDashboardA();
            formdashboard.TopLevel = false;
            formdashboard.FormBorderStyle = FormBorderStyle.None;
            formdashboard.Dock = DockStyle.Fill;

            // 3. Masukkan dan tampilkan form ke dalam panel
            panelkonten.Controls.Add(formdashboard);
            formdashboard.Show();
        }

        private void panelkonten_Click(object sender, EventArgs e)
        {

        }

        private void btnkelolauser_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormKelolaUserA formkelolauser = new FormKelolaUserA();
            formkelolauser.TopLevel = false;
            formkelolauser.FormBorderStyle = FormBorderStyle.None;
            formkelolauser.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formkelolauser);
            formkelolauser.Show();
        }

        private void btndatabarang_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormDataBarangA formdatabarang = new FormDataBarangA();
            formdatabarang.TopLevel = false;
            formdatabarang.FormBorderStyle = FormBorderStyle.None;
            formdatabarang.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formdatabarang);
            formdatabarang.Show();
        }

        private void btnkategoribarang_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormKategoriBarang formkategoribarang = new FormKategoriBarang();
            formkategoribarang.TopLevel = false;
            formkategoribarang.FormBorderStyle = FormBorderStyle.None;
            formkategoribarang.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formkategoribarang);
            formkategoribarang.Show();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormSupplierA formsupplier = new FormSupplierA();
            formsupplier.TopLevel = false;
            formsupplier.FormBorderStyle = FormBorderStyle.None;
            formsupplier.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formsupplier);
            formsupplier.Show();
        }

        private void btnin_outbound_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormIn_OutboundA formin_outbound = new FormIn_OutboundA();
            formin_outbound.TopLevel = false;
            formin_outbound.FormBorderStyle = FormBorderStyle.None;
            formin_outbound.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formin_outbound);
            formin_outbound.Show();
        }

        private void btnstokbarang_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormStockBarangA formstokbarang = new FormStockBarangA();
            formstokbarang.TopLevel = false;
            formstokbarang.FormBorderStyle = FormBorderStyle.None;
            formstokbarang.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formstokbarang);
            formstokbarang.Show();
        }

        private void btnlaporan_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormLaporanA formlaporan = new FormLaporanA();
            formlaporan.TopLevel = false;
            formlaporan.FormBorderStyle = FormBorderStyle.None;
            formlaporan.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formlaporan);
            formlaporan.Show();
        }
    }
}
