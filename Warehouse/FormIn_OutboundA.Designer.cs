namespace Warehouse
{
    partial class FormIn_OutboundA
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
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.cmbBarang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSupplier = new Guna.UI2.WinForms.Guna2ComboBox();
            this.simpan = new Guna.UI2.WinForms.Guna2Button();
            this.txtjumlah_barang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtketerangan = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Barang Masuk";
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
            this.datagridview.Location = new System.Drawing.Point(17, 262);
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
            this.btnclose.TabIndex = 28;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // cmbBarang
            // 
            this.cmbBarang.BackColor = System.Drawing.Color.Transparent;
            this.cmbBarang.BorderRadius = 15;
            this.cmbBarang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBarang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbBarang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbBarang.ItemHeight = 30;
            this.cmbBarang.Location = new System.Drawing.Point(17, 116);
            this.cmbBarang.Name = "cmbBarang";
            this.cmbBarang.Size = new System.Drawing.Size(265, 36);
            this.cmbBarang.TabIndex = 29;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.Color.Transparent;
            this.cmbSupplier.BorderRadius = 15;
            this.cmbSupplier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSupplier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSupplier.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSupplier.ItemHeight = 30;
            this.cmbSupplier.Location = new System.Drawing.Point(17, 68);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(265, 36);
            this.cmbSupplier.TabIndex = 30;
            // 
            // simpan
            // 
            this.simpan.BorderColor = System.Drawing.Color.White;
            this.simpan.BorderRadius = 10;
            this.simpan.BorderThickness = 1;
            this.simpan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.simpan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.simpan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.simpan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.simpan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.simpan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.ForeColor = System.Drawing.Color.White;
            this.simpan.Location = new System.Drawing.Point(308, 220);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(117, 36);
            this.simpan.TabIndex = 36;
            this.simpan.Text = "Simpan";
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // txtjumlah_barang
            // 
            this.txtjumlah_barang.BorderRadius = 15;
            this.txtjumlah_barang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtjumlah_barang.DefaultText = "";
            this.txtjumlah_barang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtjumlah_barang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtjumlah_barang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtjumlah_barang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtjumlah_barang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtjumlah_barang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtjumlah_barang.ForeColor = System.Drawing.Color.Black;
            this.txtjumlah_barang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtjumlah_barang.Location = new System.Drawing.Point(17, 165);
            this.txtjumlah_barang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtjumlah_barang.Name = "txtjumlah_barang";
            this.txtjumlah_barang.PlaceholderText = "Masukkan jumlah barang";
            this.txtjumlah_barang.SelectedText = "";
            this.txtjumlah_barang.Size = new System.Drawing.Size(265, 41);
            this.txtjumlah_barang.TabIndex = 43;
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
            this.txtketerangan.Location = new System.Drawing.Point(17, 214);
            this.txtketerangan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.PlaceholderText = "Masukkan keterangan";
            this.txtketerangan.SelectedText = "";
            this.txtketerangan.Size = new System.Drawing.Size(265, 41);
            this.txtketerangan.TabIndex = 42;
            // 
            // FormIn_OutboundA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.txtjumlah_barang);
            this.Controls.Add(this.txtketerangan);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.cmbSupplier);
            this.Controls.Add(this.cmbBarang);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIn_OutboundA";
            this.Text = "FormBarangMasuk";
            this.Load += new System.EventHandler(this.FormIn_OutboundA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2ComboBox cmbBarang;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSupplier;
        private Guna.UI2.WinForms.Guna2Button simpan;
        private Guna.UI2.WinForms.Guna2TextBox txtjumlah_barang;
        private Guna.UI2.WinForms.Guna2TextBox txtketerangan;
    }
}