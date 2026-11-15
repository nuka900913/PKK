namespace Warehouse
{
    partial class FormDashboardA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelgatau = new System.Windows.Forms.Label();
            this.totalbarang = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.totaluser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalsupplier = new System.Windows.Forms.Label();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.stokhabis = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.stokaman = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.stokhampirhabis = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
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
            this.btnclose.TabIndex = 7;
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
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dasboard admin";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ringkasan sistem hari ini ";
            // 
            // labelgatau
            // 
            this.labelgatau.AutoSize = true;
            this.labelgatau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.labelgatau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgatau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.labelgatau.Location = new System.Drawing.Point(23, 78);
            this.labelgatau.Name = "labelgatau";
            this.labelgatau.Size = new System.Drawing.Size(124, 22);
            this.labelgatau.TabIndex = 11;
            this.labelgatau.Text = "Total barang";
            this.labelgatau.Click += new System.EventHandler(this.labelgatau_Click);
            // 
            // totalbarang
            // 
            this.totalbarang.AutoSize = true;
            this.totalbarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.totalbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalbarang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.totalbarang.Location = new System.Drawing.Point(21, 127);
            this.totalbarang.Name = "totalbarang";
            this.totalbarang.Size = new System.Drawing.Size(33, 36);
            this.totalbarang.TabIndex = 12;
            this.totalbarang.Text = "0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label.Location = new System.Drawing.Point(320, 78);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 22);
            this.label.TabIndex = 14;
            this.label.Text = "Total user";
            // 
            // totaluser
            // 
            this.totaluser.AutoSize = true;
            this.totaluser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.totaluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.totaluser.Location = new System.Drawing.Point(318, 127);
            this.totaluser.Name = "totaluser";
            this.totaluser.Size = new System.Drawing.Size(33, 36);
            this.totaluser.TabIndex = 15;
            this.totaluser.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label3.Location = new System.Drawing.Point(615, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Total supplier";
            // 
            // totalsupplier
            // 
            this.totalsupplier.AutoSize = true;
            this.totalsupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.totalsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.totalsupplier.Location = new System.Drawing.Point(613, 127);
            this.totalsupplier.Name = "totalsupplier";
            this.totalsupplier.Size = new System.Drawing.Size(33, 36);
            this.totalsupplier.TabIndex = 18;
            this.totalsupplier.Text = "0";
            // 
            // datagridview
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.datagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridview.ColumnHeadersHeight = 17;
            this.datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview.Location = new System.Drawing.Point(17, 302);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(869, 306);
            this.datagridview.TabIndex = 25;
            this.datagridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.datagridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.HeaderStyle.Height = 17;
            this.datagridview.ThemeStyle.ReadOnly = true;
            this.datagridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview.ThemeStyle.RowsStyle.Height = 24;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BorderRadius = 10;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(606, 69);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(279, 103);
            this.guna2PictureBox3.TabIndex = 16;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 10;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(311, 69);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(289, 103);
            this.guna2PictureBox2.TabIndex = 13;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(16, 69);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(289, 103);
            this.guna2PictureBox1.TabIndex = 10;
            this.guna2PictureBox1.TabStop = false;
            // 
            // stokhabis
            // 
            this.stokhabis.AutoSize = true;
            this.stokhabis.BackColor = System.Drawing.Color.OrangeRed;
            this.stokhabis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokhabis.Location = new System.Drawing.Point(613, 241);
            this.stokhabis.Name = "stokhabis";
            this.stokhabis.Size = new System.Drawing.Size(33, 36);
            this.stokhabis.TabIndex = 28;
            this.stokhabis.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.OrangeRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(615, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Stok Habis";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.BorderRadius = 10;
            this.guna2PictureBox5.FillColor = System.Drawing.Color.OrangeRed;
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(606, 181);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(279, 103);
            this.guna2PictureBox5.TabIndex = 26;
            this.guna2PictureBox5.TabStop = false;
            // 
            // stokaman
            // 
            this.stokaman.AutoSize = true;
            this.stokaman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.stokaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokaman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.stokaman.Location = new System.Drawing.Point(22, 241);
            this.stokaman.Name = "stokaman";
            this.stokaman.Size = new System.Drawing.Size(33, 36);
            this.stokaman.TabIndex = 31;
            this.stokaman.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label6.Location = new System.Drawing.Point(24, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "Stok Aman";
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.BorderRadius = 10;
            this.guna2PictureBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(16, 181);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(289, 103);
            this.guna2PictureBox6.TabIndex = 29;
            this.guna2PictureBox6.TabStop = false;
            // 
            // stokhampirhabis
            // 
            this.stokhampirhabis.AutoSize = true;
            this.stokhampirhabis.BackColor = System.Drawing.Color.Gold;
            this.stokhampirhabis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stokhampirhabis.ForeColor = System.Drawing.Color.Black;
            this.stokhampirhabis.Location = new System.Drawing.Point(317, 241);
            this.stokhampirhabis.Name = "stokhampirhabis";
            this.stokhampirhabis.Size = new System.Drawing.Size(33, 36);
            this.stokhampirhabis.TabIndex = 34;
            this.stokhampirhabis.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(319, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 22);
            this.label7.TabIndex = 33;
            this.label7.Text = "Stok Hampir Habis";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BorderRadius = 10;
            this.guna2PictureBox4.FillColor = System.Drawing.Color.Gold;
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(311, 181);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(289, 103);
            this.guna2PictureBox4.TabIndex = 32;
            this.guna2PictureBox4.TabStop = false;
            // 
            // FormDashboardA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.stokhampirhabis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.guna2PictureBox4);
            this.Controls.Add(this.stokaman);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2PictureBox6);
            this.Controls.Add(this.stokhabis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2PictureBox5);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.totalsupplier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2PictureBox3);
            this.Controls.Add(this.totaluser);
            this.Controls.Add(this.label);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.totalbarang);
            this.Controls.Add(this.labelgatau);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnclose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDashboardA";
            this.Text = "FormDashboardA";
            this.Load += new System.EventHandler(this.FormDashboardA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelgatau;
        private System.Windows.Forms.Label totalbarang;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label totaluser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalsupplier;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label stokhabis;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.Label stokaman;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private System.Windows.Forms.Label stokhampirhabis;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
    }
}