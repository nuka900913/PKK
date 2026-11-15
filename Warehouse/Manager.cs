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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormDashboardM formdashboard = new FormDashboardM();
            formdashboard.TopLevel = false;
            formdashboard.FormBorderStyle = FormBorderStyle.None;
            formdashboard.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formdashboard);
            formdashboard.Show();
        }

        private void btnsemuadata_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormDataBarangM formdatabarang = new FormDataBarangM();
            formdatabarang.TopLevel = false;
            formdatabarang.FormBorderStyle = FormBorderStyle.None;
            formdatabarang.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formdatabarang);
            formdatabarang.Show();
        }


        private void btnlaporan_Click(object sender, EventArgs e)
        {
            panelkonten.Controls.Clear();

            FormLaporanM formlaporan = new FormLaporanM();
            formlaporan.TopLevel = false;
            formlaporan.FormBorderStyle = FormBorderStyle.None;
            formlaporan.Dock = DockStyle.Fill;

            panelkonten.Controls.Add(formlaporan);
            formlaporan.Show();
        }
    }
}
