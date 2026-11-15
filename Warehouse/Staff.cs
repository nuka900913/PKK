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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormDashboardS formdashboard = new FormDashboardS();
            formdashboard.TopLevel = false;
            formdashboard.FormBorderStyle = FormBorderStyle.None;
            formdashboard.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formdashboard);
            formdashboard.Show();
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

        private void btntransaksibarang_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormIn_OutboundA formtransaksibarang = new FormIn_OutboundA();
            formtransaksibarang.TopLevel = false;
            formtransaksibarang.FormBorderStyle = FormBorderStyle.None;
            formtransaksibarang.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formtransaksibarang);
            formtransaksibarang.Show();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormStokS formstok = new FormStokS();
            formstok.TopLevel = false;
            formstok.FormBorderStyle = FormBorderStyle.None;
            formstok.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formstok);
            formstok.Show();
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormSupplierS formsupplier = new FormSupplierS();
            formsupplier.TopLevel = false;
            formsupplier.FormBorderStyle = FormBorderStyle.None;
            formsupplier.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formsupplier);
            formsupplier.Show();
        }

        private void barangkeluar_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormStockBarangA formsupplier = new FormStockBarangA();
            formsupplier.TopLevel = false;
            formsupplier.FormBorderStyle = FormBorderStyle.None;
            formsupplier.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formsupplier);
            formsupplier.Show();
        }

        private void panelkonten_Click(object sender, EventArgs e)
        {

        }
    }
}
