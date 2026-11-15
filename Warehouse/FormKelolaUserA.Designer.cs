namespace Warehouse
{
    partial class FormKelolaUserA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKelolaUserA));
            this.userterdaftar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pencarian = new Guna.UI2.WinForms.Guna2TextBox();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tambahuser = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.resetpassword = new Guna.UI2.WinForms.Guna2Button();
            this.hapus = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // userterdaftar
            // 
            this.userterdaftar.AutoSize = true;
            this.userterdaftar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userterdaftar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.userterdaftar.Location = new System.Drawing.Point(13, 38);
            this.userterdaftar.Name = "userterdaftar";
            this.userterdaftar.Size = new System.Drawing.Size(21, 22);
            this.userterdaftar.TabIndex = 11;
            this.userterdaftar.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Kelola user";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(40, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "user terdaftar";
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
            this.pencarian.Location = new System.Drawing.Point(17, 77);
            this.pencarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pencarian.Name = "pencarian";
            this.pencarian.PlaceholderText = "🔍 Cari nama user...";
            this.pencarian.SelectedText = "";
            this.pencarian.Size = new System.Drawing.Size(870, 41);
            this.pencarian.TabIndex = 14;
            this.pencarian.TextChanged += new System.EventHandler(this.pencarian_TextChanged);
            this.pencarian.Click += new System.EventHandler(this.pencarian_Click);
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
            this.datagridview.Location = new System.Drawing.Point(17, 280);
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
            // tambahuser
            // 
            this.tambahuser.BorderColor = System.Drawing.Color.White;
            this.tambahuser.BorderRadius = 10;
            this.tambahuser.BorderThickness = 1;
            this.tambahuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tambahuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tambahuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tambahuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tambahuser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.tambahuser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahuser.ForeColor = System.Drawing.Color.White;
            this.tambahuser.Location = new System.Drawing.Point(288, 238);
            this.tambahuser.Name = "tambahuser";
            this.tambahuser.Size = new System.Drawing.Size(202, 36);
            this.tambahuser.TabIndex = 27;
            this.tambahuser.Text = "Tambah user";
            this.tambahuser.Click += new System.EventHandler(this.tambahuser_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(17, 232);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Masukkan password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(265, 41);
            this.txtPassword.TabIndex = 28;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(17, 183);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PlaceholderText = "Masukkan username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(265, 41);
            this.txtUsername.TabIndex = 29;
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.Transparent;
            this.cmbRole.BorderRadius = 15;
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.ForeColor = System.Drawing.Color.Black;
            this.cmbRole.ItemHeight = 30;
            this.cmbRole.Items.AddRange(new object[] {
            "manager",
            "admin",
            "staff"});
            this.cmbRole.Location = new System.Drawing.Point(288, 183);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(140, 36);
            this.cmbRole.TabIndex = 30;
            // 
            // resetpassword
            // 
            this.resetpassword.BorderColor = System.Drawing.Color.White;
            this.resetpassword.BorderRadius = 10;
            this.resetpassword.BorderThickness = 1;
            this.resetpassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resetpassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resetpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resetpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resetpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.resetpassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetpassword.ForeColor = System.Drawing.Color.White;
            this.resetpassword.Location = new System.Drawing.Point(496, 238);
            this.resetpassword.Name = "resetpassword";
            this.resetpassword.Size = new System.Drawing.Size(202, 36);
            this.resetpassword.TabIndex = 33;
            this.resetpassword.Text = "Ubah Password";
            this.resetpassword.Click += new System.EventHandler(this.resetpassword_Click_1);
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
            this.hapus.Location = new System.Drawing.Point(704, 237);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(125, 36);
            this.hapus.TabIndex = 34;
            this.hapus.Text = "Hapus";
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // FormKelolaUserA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.resetpassword);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.tambahuser);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.pencarian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.userterdaftar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormKelolaUserA";
            this.Text = "FormKelolaUserA";
            this.Load += new System.EventHandler(this.FormKelolaUserA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userterdaftar;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox pencarian;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private Guna.UI2.WinForms.Guna2Button tambahuser;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2ComboBox cmbRole;
        private Guna.UI2.WinForms.Guna2Button resetpassword;
        private Guna.UI2.WinForms.Guna2Button hapus;
    }
}