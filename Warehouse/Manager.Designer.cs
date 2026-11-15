namespace Warehouse
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.btndashboard = new Guna.UI2.WinForms.Guna2Button();
            this.btnsemuadata = new Guna.UI2.WinForms.Guna2Button();
            this.btnlaporan = new Guna.UI2.WinForms.Guna2Button();
            this.panelkonten = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelsidebar = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelkonten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelsidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btndashboard.BorderColor = System.Drawing.Color.White;
            this.btndashboard.BorderRadius = 10;
            this.btndashboard.BorderThickness = 1;
            this.btndashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.btndashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Location = new System.Drawing.Point(7, 55);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(192, 35);
            this.btndashboard.TabIndex = 21;
            this.btndashboard.Text = "Dashboard";
            this.btndashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnsemuadata
            // 
            this.btnsemuadata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnsemuadata.BorderColor = System.Drawing.Color.White;
            this.btnsemuadata.BorderRadius = 10;
            this.btnsemuadata.BorderThickness = 1;
            this.btnsemuadata.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsemuadata.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsemuadata.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsemuadata.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsemuadata.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.btnsemuadata.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsemuadata.ForeColor = System.Drawing.Color.White;
            this.btnsemuadata.Location = new System.Drawing.Point(7, 96);
            this.btnsemuadata.Name = "btnsemuadata";
            this.btnsemuadata.Size = new System.Drawing.Size(192, 35);
            this.btnsemuadata.TabIndex = 22;
            this.btnsemuadata.Text = "Semua data";
            this.btnsemuadata.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsemuadata.Click += new System.EventHandler(this.btnsemuadata_Click);
            // 
            // btnlaporan
            // 
            this.btnlaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.btnlaporan.BorderColor = System.Drawing.Color.White;
            this.btnlaporan.BorderRadius = 10;
            this.btnlaporan.BorderThickness = 1;
            this.btnlaporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlaporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlaporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlaporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlaporan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(44)))), ((int)(((byte)(193)))));
            this.btnlaporan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlaporan.ForeColor = System.Drawing.Color.White;
            this.btnlaporan.Location = new System.Drawing.Point(7, 137);
            this.btnlaporan.Name = "btnlaporan";
            this.btnlaporan.Size = new System.Drawing.Size(192, 35);
            this.btnlaporan.TabIndex = 24;
            this.btnlaporan.Text = "Laporan";
            this.btnlaporan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlaporan.Click += new System.EventHandler(this.btnlaporan_Click);
            // 
            // panelkonten
            // 
            this.panelkonten.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelkonten.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.panelkonten.ImageRotate = 0F;
            this.panelkonten.Location = new System.Drawing.Point(210, 0);
            this.panelkonten.Name = "panelkonten";
            this.panelkonten.Size = new System.Drawing.Size(904, 676);
            this.panelkonten.TabIndex = 25;
            this.panelkonten.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = global::Warehouse.Properties.Resources.GudangGue_transparan;
            this.pictureBox1.Location = new System.Drawing.Point(7, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panelsidebar
            // 
            this.panelsidebar.BorderRadius = 15;
            this.panelsidebar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(255)))));
            this.panelsidebar.ImageRotate = 0F;
            this.panelsidebar.Location = new System.Drawing.Point(-25, 0);
            this.panelsidebar.Name = "panelsidebar";
            this.panelsidebar.Size = new System.Drawing.Size(233, 676);
            this.panelsidebar.TabIndex = 2;
            this.panelsidebar.TabStop = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1114, 676);
            this.Controls.Add(this.panelkonten);
            this.Controls.Add(this.btnlaporan);
            this.Controls.Add(this.btnsemuadata);
            this.Controls.Add(this.btndashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelsidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r";
            ((System.ComponentModel.ISupportInitialize)(this.panelkonten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelsidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox panelsidebar;
        private Guna.UI2.WinForms.Guna2Button btndashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnsemuadata;
        private Guna.UI2.WinForms.Guna2Button btnlaporan;
        private Guna.UI2.WinForms.Guna2PictureBox panelkonten;
    }
}