namespace myCompany
{
    partial class ProfilRadnik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.btnIsplata = new System.Windows.Forms.Button();
            this.btnOdmor = new System.Windows.Forms.Button();
            this.dgvZadaci = new System.Windows.Forms.DataGridView();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obavljeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZadaci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(166, 37);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(53, 20);
            this.lblIme.TabIndex = 2;
            this.lblIme.Text = "label3";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(166, 89);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(53, 20);
            this.lblPrezime.TabIndex = 3;
            this.lblPrezime.Text = "label4";
            // 
            // btnIsplata
            // 
            this.btnIsplata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIsplata.Location = new System.Drawing.Point(50, 429);
            this.btnIsplata.Name = "btnIsplata";
            this.btnIsplata.Size = new System.Drawing.Size(217, 35);
            this.btnIsplata.TabIndex = 5;
            this.btnIsplata.Text = "Prikazi sve uplate";
            this.btnIsplata.UseVisualStyleBackColor = true;
            this.btnIsplata.Click += new System.EventHandler(this.btnIsplata_Click);
            // 
            // btnOdmor
            // 
            this.btnOdmor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdmor.Location = new System.Drawing.Point(273, 429);
            this.btnOdmor.Name = "btnOdmor";
            this.btnOdmor.Size = new System.Drawing.Size(223, 35);
            this.btnOdmor.TabIndex = 4;
            this.btnOdmor.Text = "Potrazi slobodne dane";
            this.btnOdmor.UseVisualStyleBackColor = true;
            this.btnOdmor.Click += new System.EventHandler(this.btnOdmor_Click);
            // 
            // dgvZadaci
            // 
            this.dgvZadaci.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvZadaci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvZadaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZadaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.obavljeno,
            this.opis});
            this.dgvZadaci.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvZadaci.Location = new System.Drawing.Point(50, 143);
            this.dgvZadaci.Name = "dgvZadaci";
            this.dgvZadaci.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvZadaci.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvZadaci.RowTemplate.Height = 24;
            this.dgvZadaci.Size = new System.Drawing.Size(446, 264);
            this.dgvZadaci.TabIndex = 6;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.MinimumWidth = 6;
            this.naziv.Name = "naziv";
            this.naziv.Width = 125;
            // 
            // obavljeno
            // 
            this.obavljeno.HeaderText = "Obavljeno";
            this.obavljeno.MinimumWidth = 6;
            this.obavljeno.Name = "obavljeno";
            this.obavljeno.Width = 125;
            // 
            // opis
            // 
            this.opis.HeaderText = "Opis";
            this.opis.MinimumWidth = 6;
            this.opis.Name = "opis";
            this.opis.Width = 125;
            // 
            // btnIzadji
            // 
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(301, 478);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(195, 39);
            this.btnIzadji.TabIndex = 7;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // ProfilRadnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(531, 563);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvZadaci);
            this.Controls.Add(this.btnIsplata);
            this.Controls.Add(this.btnOdmor);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfilRadnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfilRadnik";
            this.Load += new System.EventHandler(this.ProfilRadnik_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ProfilRadnik_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZadaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Button btnIsplata;
        private System.Windows.Forms.Button btnOdmor;
        private System.Windows.Forms.DataGridView dgvZadaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn obavljeno;
        private System.Windows.Forms.DataGridViewTextBoxColumn opis;
        private System.Windows.Forms.Button btnIzadji;
    }
}