namespace Warehouse
{
    partial class FormSupplierS
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
            this.label1 = new System.Windows.Forms.Label();
            this.datagridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pencarian = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
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
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Supplier";
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
            this.datagridview.Location = new System.Drawing.Point(17, 112);
            this.datagridview.Name = "datagridview";
            this.datagridview.ReadOnly = true;
            this.datagridview.RowHeadersVisible = false;
            this.datagridview.RowHeadersWidth = 51;
            this.datagridview.RowTemplate.Height = 24;
            this.datagridview.Size = new System.Drawing.Size(869, 306);
            this.datagridview.TabIndex = 38;
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
            this.pencarian.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pencarian.Location = new System.Drawing.Point(17, 55);
            this.pencarian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pencarian.Name = "pencarian";
            this.pencarian.PlaceholderText = "🔍 Cari nama user...";
            this.pencarian.SelectedText = "";
            this.pencarian.Size = new System.Drawing.Size(869, 41);
            this.pencarian.TabIndex = 39;
            this.pencarian.TextChanged += new System.EventHandler(this.pencarian_TextChanged);
            this.pencarian.Click += new System.EventHandler(this.pencarian_Click);
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
            this.btnclose.TabIndex = 40;
            this.btnclose.Text = "X";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // FormSupplierS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(210)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(904, 676);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.pencarian);
            this.Controls.Add(this.datagridview);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSupplierS";
            this.Text = "FormSupplierS";
            this.Load += new System.EventHandler(this.FormSupplierS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview;
        private Guna.UI2.WinForms.Guna2TextBox pencarian;
        private Guna.UI2.WinForms.Guna2Button btnclose;
    }
}