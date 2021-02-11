namespace myCompany
{
    partial class PregledProjekataVodja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvZadaci = new System.Windows.Forms.DataGridView();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prioritet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumPocetka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumKraja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProjekta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZadaci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZadaci
            // 
            this.dgvZadaci.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvZadaci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvZadaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZadaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.naziv,
            this.prioritet,
            this.datumPocetka,
            this.rok,
            this.datumKraja,
            this.IdProjekta});
            this.dgvZadaci.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvZadaci.Location = new System.Drawing.Point(10, 22);
            this.dgvZadaci.Margin = new System.Windows.Forms.Padding(2);
            this.dgvZadaci.Name = "dgvZadaci";
            this.dgvZadaci.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvZadaci.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvZadaci.RowTemplate.Height = 24;
            this.dgvZadaci.Size = new System.Drawing.Size(679, 302);
            this.dgvZadaci.TabIndex = 1;
            // 
            // btnIzadji
            // 
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(508, 343);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(181, 41);
            this.btnIzadji.TabIndex = 3;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(297, 343);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Azuriraj datum kraja";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(69, 363);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // naziv
            // 
            this.naziv.HeaderText = "Naziv";
            this.naziv.MinimumWidth = 6;
            this.naziv.Name = "naziv";
            this.naziv.Width = 125;
            // 
            // prioritet
            // 
            this.prioritet.HeaderText = "Prioritet";
            this.prioritet.MinimumWidth = 6;
            this.prioritet.Name = "prioritet";
            this.prioritet.Width = 125;
            // 
            // datumPocetka
            // 
            this.datumPocetka.HeaderText = "Datum pocetka";
            this.datumPocetka.MinimumWidth = 6;
            this.datumPocetka.Name = "datumPocetka";
            this.datumPocetka.Width = 125;
            // 
            // rok
            // 
            this.rok.HeaderText = "Rok";
            this.rok.MinimumWidth = 6;
            this.rok.Name = "rok";
            this.rok.Width = 125;
            // 
            // datumKraja
            // 
            this.datumKraja.HeaderText = "Datum kraja";
            this.datumKraja.MinimumWidth = 6;
            this.datumKraja.Name = "datumKraja";
            this.datumKraja.Width = 125;
            // 
            // IdProjekta
            // 
            this.IdProjekta.HeaderText = "Column1";
            this.IdProjekta.Name = "IdProjekta";
            this.IdProjekta.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesite datum kraja za azuriranje ";
            // 
            // PregledProjekataVodja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(712, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvZadaci);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PregledProjekataVodja";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PregledProjekataVodja";
            this.Load += new System.EventHandler(this.PregledProjekataVodja_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PregledProjekataVodja_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZadaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZadaci;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn prioritet;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumPocetka;
        private System.Windows.Forms.DataGridViewTextBoxColumn rok;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumKraja;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProjekta;
        private System.Windows.Forms.Label label1;
    }
}