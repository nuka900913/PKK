namespace Warehouse
{
    partial class FormDataBarangM
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
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pencarian = new Guna.UI2.WinForms.Guna2TextBox();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.stokhabis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stokaman = new System.Windows.Forms.Label();
            this.labelgatau = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gatau = new System.Windows.Forms.Label();
            this.stokhampirhabis = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
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
            this.btnclose.TabIndex = 33;
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
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Semua data barang";
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
            this.pencarian.Location = new System.Drawing.Point(12, 88);
            this.pencarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pencarian.Name = "pencarian";
            this.pencarian.PlaceholderText = "🔍 Cari nama barang atau kode barang/id kategori...";
            this.pencarian.SelectedText = "";
            this.pencarian.Size = new System.Drawing.Size(537, 41);
            this.pencarian.TabIndex = 35;
            this.pencarian.TextChanged += new System.EventHandler(this.pencarian_TextChanged);
            this.pencarian.Click += new System.EventHandler(this.pencarian_Click);
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
            this.datagridview.Location = new System.Drawing.Point(17, 245);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(869, 306);
            this.datagridview.TabIndex = 39;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.HeaderStyle.Height = 17;
            this.datagridview.ThemeStyle.ReadOnly = true;
            this.datagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.RowsStyle.Height = 24;
            this.datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_CellContentClick);
            // 
            // stokhabis
            // 
            this.stokhabis.AutoSize = true;
            this.stokhabis.BackColor = System.Drawing.Color.OrangeRed;
            this.stokhabis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokhabis.Location = new System.Drawing.Point(614, 196);
            this.stokhabis.Name = "stokhabis";
            this.stokhabis.Size = new System.Drawing.Size(33, 36);
            this.stokhabis.TabIndex = 51;
            this.stokhabis.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(616, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 50;
            this.label5.Text = "Stok Habis";
            // 
            // stokaman
            // 
            this.stokaman.AutoSize = true;
            this.stokaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.stokaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.stokaman.Location = new System.Drawing.Point(23, 196);
            this.stokaman.Name = "stokaman";
            this.stokaman.Size = new System.Drawing.Size(33, 36);
            this.stokaman.TabIndex = 49;
            this.stokaman.Text = "0";
            // 
            // labelgatau
            // 
            this.labelgatau.AutoSize = true;
            this.labelgatau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.labelgatau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgatau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.labelgatau.Location = new System.Drawing.Point(25, 147);
            this.labelgatau.Name = "labelgatau";
            this.labelgatau.Size = new System.Drawing.Size(106, 22);
            this.labelgatau.TabIndex = 48;
            this.labelgatau.Text = "Stok Aman";
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BorderRadius = 10;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(607, 136);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(279, 103);
            this.guna2PictureBox3.TabIndex = 47;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(17, 136);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(289, 103);
            this.guna2PictureBox1.TabIndex = 46;
            this.guna2PictureBox1.TabStop = false;
            // 
            // gatau
            // 
            this.gatau.AutoSize = true;
            this.gatau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gatau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.gatau.Location = new System.Drawing.Point(13, 38);
            this.gatau.Name = "gatau";
            this.gatau.Size = new System.Drawing.Size(362, 22);
            this.gatau.TabIndex = 52;
            this.gatau.Text = "Pantauan data barang dan stok gudang";
            // 
            // stokhampirhabis
            // 
            this.stokhampirhabis.AutoSize = true;
            this.stokhampirhabis.BackColor = System.Drawing.Color.Gold;
            this.stokhampirhabis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokhampirhabis.Location = new System.Drawing.Point(319, 196);
            this.stokhampirhabis.Name = "stokhampirhabis";
            this.stokhampirhabis.Size = new System.Drawing.Size(33, 36);
            this.stokhampirhabis.TabIndex = 55;
            this.stokhampirhabis.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(321, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 22);
            this.label3.TabIndex = 54;
            this.label3.Text = "Stok Hampir Habis";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 10;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.Gold;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(312, 136);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(289, 103);
            this.guna2PictureBox2.TabIndex = 53;
            this.guna2PictureBox2.TabStop = false;
            // 
            // FormDataBarangM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.stokhampirhabis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.gatau);
            this.Controls.Add(this.stokhabis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stokaman);
            this.Controls.Add(this.labelgatau);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.pencarian);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDataBarangM";
            this.Text = "FormDataBarangM";
            this.Load += new System.EventHandler(this.FormDataBarangM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox pencarian;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private System.Windows.Forms.Label stokhabis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label stokaman;
        private System.Windows.Forms.Label labelgatau;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label gatau;
        private System.Windows.Forms.Label stokhampirhabis;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}