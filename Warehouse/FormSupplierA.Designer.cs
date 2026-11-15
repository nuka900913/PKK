namespace Warehouse
{
    partial class FormSupplierA
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
            this.label1 = new System.Windows.Forms.Label();
            this.supplierterdaftar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pencarian = new Guna.UI2.WinForms.Guna2TextBox();
            this.hapus = new Guna.UI2.WinForms.Guna2Button();
            this.ubahdata = new Guna.UI2.WinForms.Guna2Button();
            this.tambahsupplier = new Guna.UI2.WinForms.Guna2Button();
            this.txtnama_supplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtno_telp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtalamat = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtid_supplier = new Guna.UI2.WinForms.Guna2TextBox();
            this.cari = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kelola supplier";
            // 
            // supplierterdaftar
            // 
            this.supplierterdaftar.AutoSize = true;
            this.supplierterdaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierterdaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.supplierterdaftar.Location = new System.Drawing.Point(13, 38);
            this.supplierterdaftar.Name = "supplierterdaftar";
            this.supplierterdaftar.Size = new System.Drawing.Size(21, 22);
            this.supplierterdaftar.TabIndex = 10;
            this.supplierterdaftar.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.label3.Location = new System.Drawing.Point(40, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "supplier terdaftar";
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
            this.btnclose.TabIndex = 24;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
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
            this.datagridview.Location = new System.Drawing.Point(17, 342);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(869, 306);
            this.datagridview.TabIndex = 26;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.HeaderStyle.Height = 17;
            this.datagridview.ThemeStyle.ReadOnly = true;
            this.datagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.RowsStyle.Height = 24;
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
            this.pencarian.ForeColor = System.Drawing.Color.Black;
            this.pencarian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pencarian.Location = new System.Drawing.Point(17, 76);
            this.pencarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pencarian.Name = "pencarian";
            this.pencarian.PlaceholderText = "🔍 Cari nama supplier...";
            this.pencarian.SelectedText = "";
            this.pencarian.Size = new System.Drawing.Size(869, 41);
            this.pencarian.TabIndex = 27;
            this.pencarian.TextChanged += new System.EventHandler(this.pencarian_TextChanged);
            this.pencarian.Click += new System.EventHandler(this.pencarian_Click);
            this.pencarian.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pencarian_KeyDown);
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
            this.hapus.Location = new System.Drawing.Point(762, 299);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(125, 36);
            this.hapus.TabIndex = 40;
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
            this.ubahdata.Location = new System.Drawing.Point(591, 299);
            this.ubahdata.Name = "ubahdata";
            this.ubahdata.Size = new System.Drawing.Size(165, 36);
            this.ubahdata.TabIndex = 39;
            this.ubahdata.Text = "Ubah data";
            this.ubahdata.Click += new System.EventHandler(this.ubahdata_Click);
            // 
            // tambahsupplier
            // 
            this.tambahsupplier.BorderColor = System.Drawing.Color.White;
            this.tambahsupplier.BorderRadius = 10;
            this.tambahsupplier.BorderThickness = 1;
            this.tambahsupplier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tambahsupplier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tambahsupplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tambahsupplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tambahsupplier.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.tambahsupplier.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahsupplier.ForeColor = System.Drawing.Color.White;
            this.tambahsupplier.Location = new System.Drawing.Point(369, 298);
            this.tambahsupplier.Name = "tambahsupplier";
            this.tambahsupplier.Size = new System.Drawing.Size(216, 36);
            this.tambahsupplier.TabIndex = 38;
            this.tambahsupplier.Text = "Tambah supplier";
            this.tambahsupplier.Click += new System.EventHandler(this.tambahsupplier_Click);
            // 
            // txtnama_supplier
            // 
            this.txtnama_supplier.BorderRadius = 15;
            this.txtnama_supplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnama_supplier.DefaultText = "";
            this.txtnama_supplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnama_supplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnama_supplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama_supplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama_supplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnama_supplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnama_supplier.ForeColor = System.Drawing.Color.Black;
            this.txtnama_supplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnama_supplier.Location = new System.Drawing.Point(17, 146);
            this.txtnama_supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_supplier.Name = "txtnama_supplier";
            this.txtnama_supplier.PlaceholderText = "Masukkan nama supplier";
            this.txtnama_supplier.SelectedText = "";
            this.txtnama_supplier.Size = new System.Drawing.Size(265, 41);
            this.txtnama_supplier.TabIndex = 45;
            // 
            // txtno_telp
            // 
            this.txtno_telp.BorderRadius = 15;
            this.txtno_telp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtno_telp.DefaultText = "";
            this.txtno_telp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtno_telp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtno_telp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtno_telp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtno_telp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtno_telp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtno_telp.ForeColor = System.Drawing.Color.Black;
            this.txtno_telp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtno_telp.Location = new System.Drawing.Point(17, 195);
            this.txtno_telp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtno_telp.Name = "txtno_telp";
            this.txtno_telp.PlaceholderText = "Masukkan no telepon";
            this.txtno_telp.SelectedText = "";
            this.txtno_telp.Size = new System.Drawing.Size(265, 41);
            this.txtno_telp.TabIndex = 44;
            // 
            // txtemail
            // 
            this.txtemail.BorderRadius = 15;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(17, 244);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PlaceholderText = "Masukkan email";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(265, 41);
            this.txtemail.TabIndex = 43;
            // 
            // txtalamat
            // 
            this.txtalamat.BorderRadius = 15;
            this.txtalamat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtalamat.DefaultText = "";
            this.txtalamat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtalamat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtalamat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtalamat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtalamat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtalamat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtalamat.ForeColor = System.Drawing.Color.Black;
            this.txtalamat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtalamat.Location = new System.Drawing.Point(17, 293);
            this.txtalamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.PlaceholderText = "Masukkan alamat";
            this.txtalamat.SelectedText = "";
            this.txtalamat.Size = new System.Drawing.Size(265, 41);
            this.txtalamat.TabIndex = 42;
            // 
            // txtid_supplier
            // 
            this.txtid_supplier.BorderRadius = 15;
            this.txtid_supplier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid_supplier.DefaultText = "";
            this.txtid_supplier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtid_supplier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtid_supplier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid_supplier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtid_supplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid_supplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtid_supplier.ForeColor = System.Drawing.Color.Black;
            this.txtid_supplier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtid_supplier.Location = new System.Drawing.Point(289, 146);
            this.txtid_supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtid_supplier.Name = "txtid_supplier";
            this.txtid_supplier.PlaceholderText = "Masukkan id supplier u/ di ubah/hapus";
            this.txtid_supplier.SelectedText = "";
            this.txtid_supplier.Size = new System.Drawing.Size(296, 41);
            this.txtid_supplier.TabIndex = 46;
            this.txtid_supplier.TextChanged += new System.EventHandler(this.txtid_supplier_TextChanged);
            this.txtid_supplier.Click += new System.EventHandler(this.txtid_supplier_Click);
            this.txtid_supplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_supplier_KeyDown);
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
            this.cari.Location = new System.Drawing.Point(591, 151);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(92, 36);
            this.cari.TabIndex = 47;
            this.cari.Text = "Cari";
            this.cari.Click += new System.EventHandler(this.cari_Click);
            // 
            // FormSupplierA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.txtid_supplier);
            this.Controls.Add(this.txtnama_supplier);
            this.Controls.Add(this.txtno_telp);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtalamat);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.ubahdata);
            this.Controls.Add(this.tambahsupplier);
            this.Controls.Add(this.pencarian);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.supplierterdaftar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupplierA";
            this.Text = "FormSupplierA";
            this.Load += new System.EventHandler(this.FormSupplierA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label supplierterdaftar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private Guna.UI2.WinForms.Guna2TextBox pencarian;
        private Guna.UI2.WinForms.Guna2Button hapus;
        private Guna.UI2.WinForms.Guna2Button ubahdata;
        private Guna.UI2.WinForms.Guna2Button tambahsupplier;
        private Guna.UI2.WinForms.Guna2TextBox txtnama_supplier;
        private Guna.UI2.WinForms.Guna2TextBox txtno_telp;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2TextBox txtalamat;
        private Guna.UI2.WinForms.Guna2TextBox txtid_supplier;
        private Guna.UI2.WinForms.Guna2Button cari;
    }
}