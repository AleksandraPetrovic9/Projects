namespace myCompany.Forme
{
    partial class FormirajTimForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listViewSviSlobodniRadnici = new System.Windows.Forms.ListView();
            this.idRadnika = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zanimanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.plata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivTima = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listViewTim = new System.Windows.Forms.ListView();
            this.idRadnika1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ime1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zanimanje1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Plata1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnIzaberiRadnika = new System.Windows.Forms.Button();
            this.btnIzbaciRadnika = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.btnFormirajTim = new System.Windows.Forms.Button();
            this.btnZadajZadatak = new System.Windows.Forms.Button();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prikaz slobodnih radnika";
            // 
            // listViewSviSlobodniRadnici
            // 
            this.listViewSviSlobodniRadnici.BackColor = System.Drawing.Color.CadetBlue;
            this.listViewSviSlobodniRadnici.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idRadnika,
            this.ime,
            this.prezime,
            this.email,
            this.zanimanje,
            this.plata});
            this.listViewSviSlobodniRadnici.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listViewSviSlobodniRadnici.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewSviSlobodniRadnici.FullRowSelect = true;
            this.listViewSviSlobodniRadnici.GridLines = true;
            this.listViewSviSlobodniRadnici.HideSelection = false;
            this.listViewSviSlobodniRadnici.Location = new System.Drawing.Point(17, 61);
            this.listViewSviSlobodniRadnici.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewSviSlobodniRadnici.Name = "listViewSviSlobodniRadnici";
            this.listViewSviSlobodniRadnici.Size = new System.Drawing.Size(562, 271);
            this.listViewSviSlobodniRadnici.TabIndex = 2;
            this.listViewSviSlobodniRadnici.UseCompatibleStateImageBehavior = false;
            this.listViewSviSlobodniRadnici.View = System.Windows.Forms.View.Details;
            // 
            // idRadnika
            // 
            this.idRadnika.Text = "idRadnika";
            // 
            // ime
            // 
            this.ime.Text = "Ime";
            // 
            // prezime
            // 
            this.prezime.Text = "Prezime";
            // 
            // email
            // 
            this.email.Text = "Email";
            // 
            // zanimanje
            // 
            this.zanimanje.Text = "Zanimanje";
            // 
            // plata
            // 
            this.plata.Text = "Plata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(14, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Unesite naziv tima";
            // 
            // txtNazivTima
            // 
            this.txtNazivTima.Location = new System.Drawing.Point(143, 359);
            this.txtNazivTima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNazivTima.Name = "txtNazivTima";
            this.txtNazivTima.Size = new System.Drawing.Size(116, 21);
            this.txtNazivTima.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(14, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clanovi tima";
            // 
            // listViewTim
            // 
            this.listViewTim.BackColor = System.Drawing.Color.CadetBlue;
            this.listViewTim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idRadnika1,
            this.Ime1,
            this.Prezime1,
            this.Email1,
            this.Zanimanje1,
            this.Plata1});
            this.listViewTim.ForeColor = System.Drawing.SystemColors.Window;
            this.listViewTim.FullRowSelect = true;
            this.listViewTim.GridLines = true;
            this.listViewTim.HideSelection = false;
            this.listViewTim.Location = new System.Drawing.Point(16, 415);
            this.listViewTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewTim.Name = "listViewTim";
            this.listViewTim.Size = new System.Drawing.Size(562, 173);
            this.listViewTim.TabIndex = 6;
            this.listViewTim.UseCompatibleStateImageBehavior = false;
            this.listViewTim.View = System.Windows.Forms.View.Details;
            // 
            // idRadnika1
            // 
            this.idRadnika1.Text = "idRadnika";
            // 
            // Ime1
            // 
            this.Ime1.Text = "Ime";
            // 
            // Prezime1
            // 
            this.Prezime1.Text = "Prezime";
            // 
            // Email1
            // 
            this.Email1.Text = "Email";
            // 
            // Zanimanje1
            // 
            this.Zanimanje1.Text = "Zanimanje";
            this.Zanimanje1.Width = 75;
            // 
            // Plata1
            // 
            this.Plata1.Text = "Plata";
            this.Plata1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Plata1.Width = 90;
            // 
            // btnIzaberiRadnika
            // 
            this.btnIzaberiRadnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzaberiRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzaberiRadnika.Location = new System.Drawing.Point(431, 354);
            this.btnIzaberiRadnika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzaberiRadnika.Name = "btnIzaberiRadnika";
            this.btnIzaberiRadnika.Size = new System.Drawing.Size(149, 39);
            this.btnIzaberiRadnika.TabIndex = 7;
            this.btnIzaberiRadnika.Text = "Izaberi radnika";
            this.btnIzaberiRadnika.UseVisualStyleBackColor = true;
            this.btnIzaberiRadnika.Click += new System.EventHandler(this.btnIzaberiRadnika_Click);
            // 
            // btnIzbaciRadnika
            // 
            this.btnIzbaciRadnika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzbaciRadnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzbaciRadnika.Location = new System.Drawing.Point(431, 604);
            this.btnIzbaciRadnika.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzbaciRadnika.Name = "btnIzbaciRadnika";
            this.btnIzbaciRadnika.Size = new System.Drawing.Size(149, 41);
            this.btnIzbaciRadnika.TabIndex = 8;
            this.btnIzbaciRadnika.Text = "Izbaci radnika";
            this.btnIzbaciRadnika.UseVisualStyleBackColor = true;
            this.btnIzbaciRadnika.Click += new System.EventHandler(this.btnIzbaciRadnika_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(376, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Filtriraj po:";
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Ime",
            "Prezime",
            "Zanimanje"});
            this.filterComboBox.Location = new System.Drawing.Point(474, 13);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(104, 24);
            this.filterComboBox.TabIndex = 10;
            this.filterComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.filterComboBox_MouseClick);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Location = new System.Drawing.Point(240, 13);
            this.textBoxFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(116, 21);
            this.textBoxFilter.TabIndex = 11;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // btnFormirajTim
            // 
            this.btnFormirajTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormirajTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFormirajTim.Location = new System.Drawing.Point(17, 606);
            this.btnFormirajTim.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFormirajTim.Name = "btnFormirajTim";
            this.btnFormirajTim.Size = new System.Drawing.Size(121, 40);
            this.btnFormirajTim.TabIndex = 13;
            this.btnFormirajTim.Text = "Formiraj tim";
            this.btnFormirajTim.UseVisualStyleBackColor = true;
            this.btnFormirajTim.Click += new System.EventHandler(this.btnFormirajTim_Click);
            // 
            // btnZadajZadatak
            // 
            this.btnZadajZadatak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZadajZadatak.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZadajZadatak.Location = new System.Drawing.Point(222, 606);
            this.btnZadajZadatak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnZadajZadatak.Name = "btnZadajZadatak";
            this.btnZadajZadatak.Size = new System.Drawing.Size(120, 40);
            this.btnZadajZadatak.TabIndex = 14;
            this.btnZadajZadatak.Text = "Zadaj zadatak";
            this.btnZadajZadatak.UseVisualStyleBackColor = true;
            this.btnZadajZadatak.Click += new System.EventHandler(this.btnZadajZadatak_Click);
            // 
            // btnIzadji
            // 
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzadji.Location = new System.Drawing.Point(431, 654);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(149, 39);
            this.btnIzadji.TabIndex = 15;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // FormirajTimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(636, 705);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.btnZadajZadatak);
            this.Controls.Add(this.btnFormirajTim);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIzbaciRadnika);
            this.Controls.Add(this.btnIzaberiRadnika);
            this.Controls.Add(this.listViewTim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazivTima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewSviSlobodniRadnici);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormirajTimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormirajTim";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormirajTimForm_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSviSlobodniRadnici;
        private System.Windows.Forms.ColumnHeader idRadnika;
        private System.Windows.Forms.ColumnHeader ime;
        private System.Windows.Forms.ColumnHeader prezime;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader zanimanje;
        private System.Windows.Forms.ColumnHeader plata;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivTima;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listViewTim;
        private System.Windows.Forms.ColumnHeader idRadnika1;
        private System.Windows.Forms.ColumnHeader Ime1;
        private System.Windows.Forms.ColumnHeader Prezime1;
        private System.Windows.Forms.ColumnHeader Email1;
        private System.Windows.Forms.ColumnHeader Zanimanje1;
        private System.Windows.Forms.ColumnHeader Plata1;
        private System.Windows.Forms.Button btnIzaberiRadnika;
        private System.Windows.Forms.Button btnIzbaciRadnika;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Button btnFormirajTim;
        private System.Windows.Forms.Button btnZadajZadatak;
        private System.Windows.Forms.Button btnIzadji;
    }
}