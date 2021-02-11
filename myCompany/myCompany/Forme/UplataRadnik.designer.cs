namespace myCompany
{
    partial class IsplataRadnik
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
            this.dgvIsplata = new System.Windows.Forms.DataGridView();
            this.datumIsplate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIzadji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsplata)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIsplata
            // 
            this.dgvIsplata.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvIsplata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvIsplata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIsplata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datumIsplate,
            this.iznos});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIsplata.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIsplata.GridColor = System.Drawing.Color.CadetBlue;
            this.dgvIsplata.Location = new System.Drawing.Point(46, 32);
            this.dgvIsplata.Name = "dgvIsplata";
            this.dgvIsplata.RowHeadersWidth = 51;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvIsplata.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIsplata.RowTemplate.Height = 24;
            this.dgvIsplata.Size = new System.Drawing.Size(317, 309);
            this.dgvIsplata.TabIndex = 0;
            // 
            // datumIsplate
            // 
            this.datumIsplate.HeaderText = "Datum isplate";
            this.datumIsplate.MinimumWidth = 6;
            this.datumIsplate.Name = "datumIsplate";
            this.datumIsplate.Width = 125;
            // 
            // iznos
            // 
            this.iznos.HeaderText = "Iznos";
            this.iznos.MinimumWidth = 6;
            this.iznos.Name = "iznos";
            this.iznos.Width = 125;
            // 
            // btnIzadji
            // 
            this.btnIzadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzadji.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzadji.Location = new System.Drawing.Point(168, 379);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(9, 11, 9, 11);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(195, 39);
            this.btnIzadji.TabIndex = 11;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // IsplataRadnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(397, 431);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.dgvIsplata);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IsplataRadnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UplataRadnik";
            this.Load += new System.EventHandler(this.IsplataRadnik_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.IsplataRadnik_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIsplata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIsplata;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumIsplate;
        private System.Windows.Forms.DataGridViewTextBoxColumn iznos;
        private System.Windows.Forms.Button btnIzadji;
    }
}