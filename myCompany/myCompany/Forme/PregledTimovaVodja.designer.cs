namespace myCompany
{
    partial class PregledTimovaVodja
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
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radnici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvTimovi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.aktivan,
            this.radnici});
            this.dgvTimovi.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvTimovi.Location = new System.Drawing.Point(23, 27);
            this.dgvTimovi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvTimovi.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimovi.RowTemplate.Height = 24;
            this.dgvTimovi.Size = new System.Drawing.Size(386, 324);
            this.dgvTimovi.TabIndex = 0;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.MinimumWidth = 6;
            this.naziv.Name = "naziv";
            this.naziv.Width = 125;
            // 
            // aktivan
            // 
            this.aktivan.HeaderText = "Aktivan";
            this.aktivan.MinimumWidth = 6;
            this.aktivan.Name = "aktivan";
            this.aktivan.Width = 125;
            // 
            // radnici
            // 
            this.radnici.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.radnici.HeaderText = "Radnici";
            this.radnici.MinimumWidth = 6;
            this.radnici.Name = "radnici";
            this.radnici.Width = 74;
            // 
            // btnIzadji
            // 
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(212, 360);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(197, 38);
            this.btnIzadji.TabIndex = 4;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // PregledTimovaVodja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(499, 443);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvTimovi);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PregledTimovaVodja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PregledTimovaVodja";
            this.Load += new System.EventHandler(this.PregledTimovaVodja_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PregledTimovaVodja_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktivan;
        private System.Windows.Forms.DataGridViewTextBoxColumn radnici;
        private System.Windows.Forms.Button btnIzadji;
    }
}