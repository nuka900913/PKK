namespace Warehouse
{
    partial class FormLaporanM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.barangterdaftar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.JenisLaporan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Periode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nilaitransaksi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalkeluar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalmasuk = new System.Windows.Forms.Label();
            this.labelgata = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cetak = new Guna.UI2.WinForms.Guna2Button();
            this.export = new Guna.UI2.WinForms.Guna2Button();
            this.chartTren = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cari = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTren)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnclose.Location = new System.Drawing.Point(855, -1);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(51, 43);
            this.btnclose.TabIndex = 31;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Laporan";
            // 
            // barangterdaftar
            // 
            this.barangterdaftar.AutoSize = true;
            this.barangterdaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barangterdaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.barangterdaftar.Location = new System.Drawing.Point(13, 38);
            this.barangterdaftar.Name = "barangterdaftar";
            this.barangterdaftar.Size = new System.Drawing.Size(273, 22);
            this.barangterdaftar.TabIndex = 33;
            this.barangterdaftar.Text = "Ringkasan transaksi dan stok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(203, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 64;
            this.label2.Text = "Jenis laporan";
            // 
            // JenisLaporan
            // 
            this.JenisLaporan.BackColor = System.Drawing.Color.Transparent;
            this.JenisLaporan.BorderRadius = 10;
            this.JenisLaporan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.JenisLaporan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JenisLaporan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.JenisLaporan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JenisLaporan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.JenisLaporan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.JenisLaporan.ForeColor = System.Drawing.Color.White;
            this.JenisLaporan.ItemHeight = 30;
            this.JenisLaporan.Items.AddRange(new object[] {
            "Barang masuk",
            "Barang keluar",
            "Masuk & keluar"});
            this.JenisLaporan.Location = new System.Drawing.Point(207, 126);
            this.JenisLaporan.Name = "JenisLaporan";
            this.JenisLaporan.Size = new System.Drawing.Size(183, 36);
            this.JenisLaporan.TabIndex = 63;
            this.JenisLaporan.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.label4.Location = new System.Drawing.Point(14, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 62;
            this.label4.Text = "Periode";
            // 
            // Periode
            // 
            this.Periode.BackColor = System.Drawing.Color.Transparent;
            this.Periode.BorderRadius = 10;
            this.Periode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Periode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Periode.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.Periode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Periode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Periode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Periode.ForeColor = System.Drawing.Color.White;
            this.Periode.ItemHeight = 30;
            this.Periode.Items.AddRange(new object[] {
            "Tahun ini",
            "Bulan ini",
            "Minggu ini",
            "Hari ini"});
            this.Periode.Location = new System.Drawing.Point(18, 126);
            this.Periode.Name = "Periode";
            this.Periode.Size = new System.Drawing.Size(183, 36);
            this.Periode.TabIndex = 61;
            this.Periode.Tag = "";
            // 
            // datagridview
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.datagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.datagridview.ColumnHeadersHeight = 17;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview.DefaultCellStyle = dataGridViewCellStyle12;
            this.datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.Location = new System.Drawing.Point(17, 470);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(871, 194);
            this.datagridview.TabIndex = 60;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.HeaderStyle.Height = 17;
            this.datagridview.ThemeStyle.ReadOnly = true;
            this.datagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.RowsStyle.Height = 24;
            // 
            // nilaitransaksi
            // 
            this.nilaitransaksi.AutoSize = true;
            this.nilaitransaksi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.nilaitransaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nilaitransaksi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.nilaitransaksi.Location = new System.Drawing.Point(615, 232);
            this.nilaitransaksi.Name = "nilaitransaksi";
            this.nilaitransaksi.Size = new System.Drawing.Size(33, 36);
            this.nilaitransaksi.TabIndex = 59;
            this.nilaitransaksi.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label5.Location = new System.Drawing.Point(617, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 22);
            this.label5.TabIndex = 58;
            this.label5.Text = "Nilai transaksi";
            // 
            // totalkeluar
            // 
            this.totalkeluar.AutoSize = true;
            this.totalkeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.totalkeluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalkeluar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.totalkeluar.Location = new System.Drawing.Point(320, 232);
            this.totalkeluar.Name = "totalkeluar";
            this.totalkeluar.Size = new System.Drawing.Size(33, 36);
            this.totalkeluar.TabIndex = 57;
            this.totalkeluar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(322, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 22);
            this.label3.TabIndex = 56;
            this.label3.Text = "Total keluar";
            // 
            // totalmasuk
            // 
            this.totalmasuk.AutoSize = true;
            this.totalmasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.totalmasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalmasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.totalmasuk.Location = new System.Drawing.Point(24, 232);
            this.totalmasuk.Name = "totalmasuk";
            this.totalmasuk.Size = new System.Drawing.Size(33, 36);
            this.totalmasuk.TabIndex = 55;
            this.totalmasuk.Text = "0";
            // 
            // labelgata
            // 
            this.labelgata.AutoSize = true;
            this.labelgata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.labelgata.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgata.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.labelgata.Location = new System.Drawing.Point(26, 183);
            this.labelgata.Name = "labelgata";
            this.labelgata.Size = new System.Drawing.Size(119, 22);
            this.labelgata.TabIndex = 54;
            this.labelgata.Text = "Total masuk";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BorderRadius = 10;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(607, 174);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(281, 103);
            this.guna2PictureBox3.TabIndex = 53;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 10;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(312, 174);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(289, 103);
            this.guna2PictureBox2.TabIndex = 52;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 174);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(289, 103);
            this.guna2PictureBox1.TabIndex = 51;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cetak
            // 
            this.cetak.BorderColor = System.Drawing.Color.White;
            this.cetak.BorderRadius = 10;
            this.cetak.BorderThickness = 1;
            this.cetak.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cetak.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cetak.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cetak.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cetak.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.cetak.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cetak.ForeColor = System.Drawing.Color.White;
            this.cetak.Location = new System.Drawing.Point(625, 126);
            this.cetak.Name = "cetak";
            this.cetak.Size = new System.Drawing.Size(116, 36);
            this.cetak.TabIndex = 50;
            this.cetak.Text = "Cetak";
            this.cetak.Click += new System.EventHandler(this.cetak_Click);
            // 
            // export
            // 
            this.export.BorderColor = System.Drawing.Color.White;
            this.export.BorderRadius = 10;
            this.export.BorderThickness = 1;
            this.export.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.export.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.export.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.export.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.export.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.export.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.export.ForeColor = System.Drawing.Color.White;
            this.export.Location = new System.Drawing.Point(747, 126);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(139, 36);
            this.export.TabIndex = 49;
            this.export.Text = "Export";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // chartTren
            // 
            this.chartTren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            chartArea4.Name = "ChartArea1";
            this.chartTren.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartTren.Legends.Add(legend4);
            this.chartTren.Location = new System.Drawing.Point(17, 283);
            this.chartTren.Name = "chartTren";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartTren.Series.Add(series4);
            this.chartTren.Size = new System.Drawing.Size(871, 181);
            this.chartTren.TabIndex = 67;
            this.chartTren.Text = "chart1";
            // 
            // cari
            // 
            this.cari.BorderColor = System.Drawing.Color.White;
            this.cari.BorderRadius = 10;
            this.cari.BorderThickness = 1;
            this.cari.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cari.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cari.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cari.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cari.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.cari.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari.ForeColor = System.Drawing.Color.White;
            this.cari.Location = new System.Drawing.Point(396, 126);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(134, 36);
            this.cari.TabIndex = 68;
            this.cari.Text = "Tampil";
            this.cari.Click += new System.EventHandler(this.cari_Click);
            // 
            // FormLaporanM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.chartTren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JenisLaporan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Periode);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.nilaitransaksi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalkeluar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.totalmasuk);
            this.Controls.Add(this.labelgata);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.cetak);
            this.Controls.Add(this.export);
            this.Controls.Add(this.barangterdaftar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLaporanM";
            this.Text = "FormLaporanM";
            this.Load += new System.EventHandler(this.FormLaporanM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label barangterdaftar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox JenisLaporan;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox Periode;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private System.Windows.Forms.Label nilaitransaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalkeluar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalmasuk;
        private System.Windows.Forms.Label labelgata;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button cetak;
        private Guna.UI2.WinForms.Guna2Button export;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTren;
        private Guna.UI2.WinForms.Guna2Button cari;
    }
}