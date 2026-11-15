namespace Warehouse
{
    partial class FormKategoriBarang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKategoriBarang));
            this.label1 = new System.Windows.Forms.Label();
            this.kategori = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.pencarian = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnama_kategori = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtketerangan = new Guna.UI2.WinForms.Guna2TextBox();
            this.hapus = new Guna.UI2.WinForms.Guna2Button();
            this.ubahnama = new Guna.UI2.WinForms.Guna2Button();
            this.tambahkategori = new Guna.UI2.WinForms.Guna2Button();
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
            this.label1.Size = new System.Drawing.Size(278, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kelola kategori barang";
            // 
            // kategori
            // 
            this.kategori.AutoSize = true;
            this.kategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.kategori.Location = new System.Drawing.Point(13, 38);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(21, 22);
            this.kategori.TabIndex = 12;
            this.kategori.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(40, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "kategori";
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
            this.datagridview.Location = new System.Drawing.Point(17, 322);
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
            this.btnclose.TabIndex = 30;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
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
            this.pencarian.Location = new System.Drawing.Point(17, 72);
            this.pencarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pencarian.Name = "pencarian";
            this.pencarian.PlaceholderText = "🔍 Cari nama kategori...";
            this.pencarian.SelectedText = "";
            this.pencarian.Size = new System.Drawing.Size(869, 41);
            this.pencarian.TabIndex = 31;
            this.pencarian.TextChanged += new System.EventHandler(this.pencarian_TextChanged);
            this.pencarian.Click += new System.EventHandler(this.pencarian_Click);
            this.pencarian.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pencarian_KeyDown);
            // 
            // txtnama_kategori
            // 
            this.txtnama_kategori.BorderRadius = 15;
            this.txtnama_kategori.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnama_kategori.DefaultText = "";
            this.txtnama_kategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnama_kategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnama_kategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama_kategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnama_kategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnama_kategori.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnama_kategori.ForeColor = System.Drawing.Color.Black;
            this.txtnama_kategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnama_kategori.Location = new System.Drawing.Point(17, 222);
            this.txtnama_kategori.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_kategori.Name = "txtnama_kategori";
            this.txtnama_kategori.PlaceholderText = "Masukkan nama kategori";
            this.txtnama_kategori.SelectedText = "";
            this.txtnama_kategori.Size = new System.Drawing.Size(265, 41);
            this.txtnama_kategori.TabIndex = 43;
            // 
            // txtketerangan
            // 
            this.txtketerangan.BorderRadius = 15;
            this.txtketerangan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtketerangan.DefaultText = "";
            this.txtketerangan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtketerangan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtketerangan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtketerangan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtketerangan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtketerangan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtketerangan.ForeColor = System.Drawing.Color.Black;
            this.txtketerangan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtketerangan.Location = new System.Drawing.Point(17, 271);
            this.txtketerangan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.PlaceholderText = "Masukkan keterangan";
            this.txtketerangan.SelectedText = "";
            this.txtketerangan.Size = new System.Drawing.Size(265, 41);
            this.txtketerangan.TabIndex = 42;
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
            this.hapus.Location = new System.Drawing.Point(761, 280);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(125, 36);
            this.hapus.TabIndex = 46;
            this.hapus.Text = "Hapus";
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // ubahnama
            // 
            this.ubahnama.BorderColor = System.Drawing.Color.White;
            this.ubahnama.BorderRadius = 10;
            this.ubahnama.BorderThickness = 1;
            this.ubahnama.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ubahnama.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ubahnama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ubahnama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ubahnama.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.ubahnama.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubahnama.ForeColor = System.Drawing.Color.White;
            this.ubahnama.Location = new System.Drawing.Point(590, 280);
            this.ubahnama.Name = "ubahnama";
            this.ubahnama.Size = new System.Drawing.Size(165, 36);
            this.ubahnama.TabIndex = 45;
            this.ubahnama.Text = "Ubah nama";
            this.ubahnama.Click += new System.EventHandler(this.ubahnama_Click);
            // 
            // tambahkategori
            // 
            this.tambahkategori.BorderColor = System.Drawing.Color.White;
            this.tambahkategori.BorderRadius = 10;
            this.tambahkategori.BorderThickness = 1;
            this.tambahkategori.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tambahkategori.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tambahkategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tambahkategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tambahkategori.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.tambahkategori.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahkategori.ForeColor = System.Drawing.Color.White;
            this.tambahkategori.Location = new System.Drawing.Point(368, 279);
            this.tambahkategori.Name = "tambahkategori";
            this.tambahkategori.Size = new System.Drawing.Size(216, 36);
            this.tambahkategori.TabIndex = 44;
            this.tambahkategori.Text = "Tambah kategori";
            this.tambahkategori.Click += new System.EventHandler(this.tambahkategori_Click);
            // 
            // FormKategoriBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.ubahnama);
            this.Controls.Add(this.tambahkategori);
            this.Controls.Add(this.txtnama_kategori);
            this.Controls.Add(this.txtketerangan);
            this.Controls.Add(this.pencarian);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKategoriBarang";
            this.Text = "FormKategoriBarang";
            this.Load += new System.EventHandler(this.FormKategoriBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label kategori;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2TextBox pencarian;
        private Guna.UI2.WinForms.Guna2TextBox txtnama_kategori;
        private Guna.UI2.WinForms.Guna2TextBox txtketerangan;
        private Guna.UI2.WinForms.Guna2Button hapus;
        private Guna.UI2.WinForms.Guna2Button ubahnama;
        private Guna.UI2.WinForms.Guna2Button tambahkategori;
    }
}