namespace Warehouse
{
    partial class FormDataBarangA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataBarangA));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.kategori = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pencarian = new Guna.UI2.WinForms.Guna2TextBox();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.hapus = new Guna.UI2.WinForms.Guna2Button();
            this.ubahdata = new Guna.UI2.WinForms.Guna2Button();
            this.tambahbarang = new Guna.UI2.WinForms.Guna2Button();
            this.txtharga_satuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtstok = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnama_barang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtkode_barang = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.cari = new Guna.UI2.WinForms.Guna2Button();
            this.txtid_barang = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kelola data barang";
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
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "barang terdaftar";
            // 
            // kategori
            // 
            this.kategori.BackColor = System.Drawing.Color.Transparent;
            this.kategori.BorderRadius = 15;
            this.kategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.kategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategori.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.kategori.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.kategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.kategori.ItemHeight = 30;
            this.kategori.Location = new System.Drawing.Point(288, 253);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(199, 36);
            this.kategori.TabIndex = 20;
            this.kategori.SelectedIndexChanged += new System.EventHandler(this.kategori_SelectedIndexChanged);
            // 
            // pencarian
            // 
            this.pencarian.BorderRadius = 15;
            this.pencarian.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pencarian.DefaultText = "";
            this.pencarian.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.pencarian.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.pencarian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pencarian.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.pencarian.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pencarian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pencarian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pencarian.Location = new System.Drawing.Point(17, 77);
            this.pencarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pencarian.Name = "pencarian";
            this.pencarian.PlaceholderText = "🔍 Cari kode/nama barang...";
            this.pencarian.SelectedText = "";
            this.pencarian.Size = new System.Drawing.Size(869, 41);
            this.pencarian.TabIndex = 16;
            this.pencarian.TextChanged += new System.EventHandler(this.pencarian_TextChanged);
            this.pencarian.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pencarian_KeyDown);
            // 
            // datagridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridview.ColumnHeadersHeight = 17;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.Location = new System.Drawing.Point(17, 345);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(869, 306);
            this.datagridview.TabIndex = 29;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.HeaderStyle.Height = 17;
            this.datagridview.ThemeStyle.ReadOnly = true;
            this.datagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.RowsStyle.Height = 24;
            // 
            // hapus
            // 
            this.hapus.BorderColor = System.Drawing.Color.White;
            this.hapus.BorderRadius = 10;
            this.hapus.BorderThickness = 1;
            this.hapus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hapus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hapus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hapus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hapus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.hapus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.ForeColor = System.Drawing.Color.White;
            this.hapus.Location = new System.Drawing.Point(747, 303);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(125, 36);
            this.hapus.TabIndex = 37;
            this.hapus.Text = "Hapus";
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // ubahdata
            // 
            this.ubahdata.BorderColor = System.Drawing.Color.White;
            this.ubahdata.BorderRadius = 10;
            this.ubahdata.BorderThickness = 1;
            this.ubahdata.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ubahdata.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ubahdata.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ubahdata.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ubahdata.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.ubahdata.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubahdata.ForeColor = System.Drawing.Color.White;
            this.ubahdata.Location = new System.Drawing.Point(576, 303);
            this.ubahdata.Name = "ubahdata";
            this.ubahdata.Size = new System.Drawing.Size(165, 36);
            this.ubahdata.TabIndex = 36;
            this.ubahdata.Text = "Ubah data";
            this.ubahdata.Click += new System.EventHandler(this.ubahdata_Click);
            // 
            // tambahbarang
            // 
            this.tambahbarang.BorderColor = System.Drawing.Color.White;
            this.tambahbarang.BorderRadius = 10;
            this.tambahbarang.BorderThickness = 1;
            this.tambahbarang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tambahbarang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tambahbarang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tambahbarang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tambahbarang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.tambahbarang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahbarang.ForeColor = System.Drawing.Color.White;
            this.tambahbarang.Location = new System.Drawing.Point(354, 302);
            this.tambahbarang.Name = "tambahbarang";
            this.tambahbarang.Size = new System.Drawing.Size(216, 36);
            this.tambahbarang.TabIndex = 35;
            this.tambahbarang.Text = "Tambah barang";
            this.tambahbarang.Click += new System.EventHandler(this.tambahbarang_Click);
            // 
            // txtharga_satuan
            // 
            this.txtharga_satuan.BorderRadius = 15;
            this.txtharga_satuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtharga_satuan.DefaultText = "";
            this.txtharga_satuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtharga_satuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtharga_satuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtharga_satuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtharga_satuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtharga_satuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtharga_satuan.ForeColor = System.Drawing.Color.Black;
            this.txtharga_satuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtharga_satuan.Location = new System.Drawing.Point(17, 297);
            this.txtharga_satuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtharga_satuan.Name = "txtharga_satuan";
            this.txtharga_satuan.PlaceholderText = "Masukkan harga satuan";
            this.txtharga_satuan.SelectedText = "";
            this.txtharga_satuan.Size = new System.Drawing.Size(265, 41);
            this.txtharga_satuan.TabIndex = 38;
            this.txtharga_satuan.TextChanged += new System.EventHandler(this.txtharga_satuan_TextChanged);
            // 
            // txtstok
            // 
            this.txtstok.BorderRadius = 15;
            this.txtstok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtstok.DefaultText = "";
            this.txtstok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtstok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtstok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtstok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtstok.ForeColor = System.Drawing.Color.Black;
            this.txtstok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtstok.Location = new System.Drawing.Point(17, 248);
            this.txtstok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstok.Name = "txtstok";
            this.txtstok.PlaceholderText = "Masukkan stok";
            this.txtstok.SelectedText = "";
            this.txtstok.Size = new System.Drawing.Size(265, 41);
            this.txtstok.TabIndex = 39;
            this.txtstok.TextChanged += new System.EventHandler(this.txtstok_TextChanged);
            // 
            // txtnama_barang
            // 
            this.txtnama_barang.BorderRadius = 15;
            this.txtnama_barang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnama_barang.DefaultText = "";
            this.txtnama_barang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnama_barang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnama_barang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama_barang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama_barang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnama_barang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnama_barang.ForeColor = System.Drawing.Color.Black;
            this.txtnama_barang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnama_barang.Location = new System.Drawing.Point(17, 199);
            this.txtnama_barang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_barang.Name = "txtnama_barang";
            this.txtnama_barang.PlaceholderText = "Masukkan nama barang";
            this.txtnama_barang.SelectedText = "";
            this.txtnama_barang.Size = new System.Drawing.Size(265, 41);
            this.txtnama_barang.TabIndex = 40;
            this.txtnama_barang.TextChanged += new System.EventHandler(this.txtnama_barang_TextChanged);
            // 
            // txtkode_barang
            // 
            this.txtkode_barang.BorderRadius = 15;
            this.txtkode_barang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtkode_barang.DefaultText = "";
            this.txtkode_barang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtkode_barang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtkode_barang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtkode_barang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtkode_barang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtkode_barang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtkode_barang.ForeColor = System.Drawing.Color.Black;
            this.txtkode_barang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtkode_barang.Location = new System.Drawing.Point(17, 150);
            this.txtkode_barang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtkode_barang.Name = "txtkode_barang";
            this.txtkode_barang.PlaceholderText = "Masukkan kode barang";
            this.txtkode_barang.SelectedText = "";
            this.txtkode_barang.Size = new System.Drawing.Size(265, 41);
            this.txtkode_barang.TabIndex = 41;
            this.txtkode_barang.TextChanged += new System.EventHandler(this.txtkode_barang_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(576, 303);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(165, 36);
            this.guna2Button1.TabIndex = 36;
            this.guna2Button1.Text = "Ubah data";
            this.guna2Button1.Click += new System.EventHandler(this.ubahdata_Click);
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
            this.cari.Location = new System.Drawing.Point(590, 155);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(92, 36);
            this.cari.TabIndex = 49;
            this.cari.Text = "Cari";
            this.cari.Click += new System.EventHandler(this.cari_Click);
            // 
            // txtid_barang
            // 
            this.txtid_barang.BorderRadius = 15;
            this.txtid_barang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid_barang.DefaultText = "";
            this.txtid_barang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid_barang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid_barang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid_barang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid_barang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid_barang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtid_barang.ForeColor = System.Drawing.Color.Black;
            this.txtid_barang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid_barang.Location = new System.Drawing.Point(288, 150);
            this.txtid_barang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid_barang.Name = "txtid_barang";
            this.txtid_barang.PlaceholderText = "Masukkan id barang u/ di ubah/hapus";
            this.txtid_barang.SelectedText = "";
            this.txtid_barang.Size = new System.Drawing.Size(296, 41);
            this.txtid_barang.TabIndex = 48;
            // 
            // FormDataBarangA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.txtid_barang);
            this.Controls.Add(this.txtkode_barang);
            this.Controls.Add(this.txtnama_barang);
            this.Controls.Add(this.txtstok);
            this.Controls.Add(this.txtharga_satuan);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.ubahdata);
            this.Controls.Add(this.tambahbarang);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.pencarian);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(855, -1);
            this.Name = "FormDataBarangA";
            this.Text = "FormDataBarangA";
            this.Load += new System.EventHandler(this.FormDataBarangA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox kategori;
        private Guna.UI2.WinForms.Guna2TextBox pencarian;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private Guna.UI2.WinForms.Guna2Button hapus;
        private Guna.UI2.WinForms.Guna2Button ubahdata;
        private Guna.UI2.WinForms.Guna2Button tambahbarang;
        private Guna.UI2.WinForms.Guna2TextBox txtharga_satuan;
        private Guna.UI2.WinForms.Guna2TextBox txtstok;
        private Guna.UI2.WinForms.Guna2TextBox txtnama_barang;
        private Guna.UI2.WinForms.Guna2TextBox txtkode_barang;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button cari;
        private Guna.UI2.WinForms.Guna2TextBox txtid_barang;
    }
}