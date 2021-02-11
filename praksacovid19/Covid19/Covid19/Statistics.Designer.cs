namespace Covid19
{
    partial class Statistics
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
            this.dgvNajvise = new System.Windows.Forms.DataGridView();
            this.zemlja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNajmanje = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDatumOd = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbZemlje = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDatumDo = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajvise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajmanje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNajvise
            // 
            this.dgvNajvise.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvNajvise.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNajvise.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNajvise.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvNajvise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNajvise.ColumnHeadersHeight = 29;
            this.dgvNajvise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.zemlja,
            this.broj});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNajvise.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvNajvise.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvNajvise.Location = new System.Drawing.Point(87, 92);
            this.dgvNajvise.Name = "dgvNajvise";
            this.dgvNajvise.ReadOnly = true;
            this.dgvNajvise.RowHeadersWidth = 51;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvNajvise.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNajvise.RowTemplate.Height = 24;
            this.dgvNajvise.Size = new System.Drawing.Size(411, 242);
            this.dgvNajvise.TabIndex = 0;
            // 
            // zemlja
            // 
            this.zemlja.HeaderText = "Country";
            this.zemlja.MinimumWidth = 6;
            this.zemlja.Name = "zemlja";
            this.zemlja.ReadOnly = true;
            this.zemlja.Width = 114;
            // 
            // broj
            // 
            this.broj.HeaderText = "Active cases";
            this.broj.MinimumWidth = 6;
            this.broj.Name = "broj";
            this.broj.ReadOnly = true;
            this.broj.Width = 157;
            // 
            // dgvNajmanje
            // 
            this.dgvNajmanje.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dgvNajmanje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNajmanje.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvNajmanje.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgvNajmanje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNajmanje.ColumnHeadersHeight = 29;
            this.dgvNajmanje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgvNajmanje.GridColor = System.Drawing.Color.RosyBrown;
            this.dgvNajmanje.Location = new System.Drawing.Point(87, 438);
            this.dgvNajmanje.Name = "dgvNajmanje";
            this.dgvNajmanje.ReadOnly = true;
            this.dgvNajmanje.RowHeadersWidth = 51;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgvNajmanje.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNajmanje.RowTemplate.Height = 24;
            this.dgvNajmanje.Size = new System.Drawing.Size(411, 242);
            this.dgvNajmanje.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Country";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 114;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Active cases";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "The 5 countries that currently have the least active cases";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "The 5 countries that currently have the most active cases";
            // 
            // dtpDatumOd
            // 
            this.dtpDatumOd.Location = new System.Drawing.Point(727, 233);
            this.dtpDatumOd.Name = "dtpDatumOd";
            this.dtpDatumOd.Size = new System.Drawing.Size(224, 30);
            this.dtpDatumOd.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Filter:";
            // 
            // cbZemlje
            // 
            this.cbZemlje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbZemlje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbZemlje.FormattingEnabled = true;
            this.cbZemlje.Location = new System.Drawing.Point(722, 135);
            this.cbZemlje.Name = "cbZemlje";
            this.cbZemlje.Size = new System.Drawing.Size(304, 30);
            this.cbZemlje.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(724, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date from";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Country";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrikaz.Location = new System.Drawing.Point(728, 451);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(224, 40);
            this.btnPrikaz.TabIndex = 9;
            this.btnPrikaz.Text = "Display";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(723, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date to";
            // 
            // dtpDatumDo
            // 
            this.dtpDatumDo.Location = new System.Drawing.Point(727, 348);
            this.dtpDatumDo.Name = "dtpDatumDo";
            this.dtpDatumDo.Size = new System.Drawing.Size(224, 30);
            this.dtpDatumDo.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(802, 640);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(224, 40);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1132, 735);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpDatumDo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbZemlje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDatumOd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNajmanje);
            this.Controls.Add(this.dgvNajvise);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistics";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Statistics_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajvise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajmanje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNajvise;
        private System.Windows.Forms.DataGridView dgvNajmanje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDatumOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbZemlje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDatumDo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn zemlja;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}