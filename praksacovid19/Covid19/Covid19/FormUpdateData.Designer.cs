namespace Covid19
{
    partial class FormUpdateData
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numcases = new System.Windows.Forms.NumericUpDown();
            this.numdeaths = new System.Windows.Forms.NumericUpDown();
            this.numrecovered = new System.Windows.Forms.NumericUpDown();
            this.btnDisplayData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numcases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdeaths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrecovered)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 62);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(370, 30);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "New cases:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 281);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "New deaths:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "New recovered:";
            // 
            // numcases
            // 
            this.numcases.Location = new System.Drawing.Point(276, 219);
            this.numcases.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numcases.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numcases.Name = "numcases";
            this.numcases.Size = new System.Drawing.Size(196, 30);
            this.numcases.TabIndex = 4;
            // 
            // numdeaths
            // 
            this.numdeaths.Location = new System.Drawing.Point(276, 273);
            this.numdeaths.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numdeaths.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numdeaths.Name = "numdeaths";
            this.numdeaths.Size = new System.Drawing.Size(196, 30);
            this.numdeaths.TabIndex = 5;
            // 
            // numrecovered
            // 
            this.numrecovered.Location = new System.Drawing.Point(276, 339);
            this.numrecovered.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numrecovered.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numrecovered.Name = "numrecovered";
            this.numrecovered.Size = new System.Drawing.Size(196, 30);
            this.numrecovered.TabIndex = 6;
            // 
            // btnDisplayData
            // 
            this.btnDisplayData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayData.Location = new System.Drawing.Point(102, 127);
            this.btnDisplayData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplayData.Name = "btnDisplayData";
            this.btnDisplayData.Size = new System.Drawing.Size(370, 35);
            this.btnDisplayData.TabIndex = 7;
            this.btnDisplayData.Text = "Display";
            this.btnDisplayData.UseVisualStyleBackColor = true;
            this.btnDisplayData.Click += new System.EventHandler(this.btnDisplayData_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(102, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(307, 413);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(177, 481);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 35);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormUpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(562, 548);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDisplayData);
            this.Controls.Add(this.numrecovered);
            this.Controls.Add(this.numdeaths);
            this.Controls.Add(this.numcases);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormUpdateData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUpdateData";
            this.Load += new System.EventHandler(this.FormUpdateData_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormUpdateData_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numcases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdeaths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numrecovered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numcases;
        private System.Windows.Forms.NumericUpDown numdeaths;
        private System.Windows.Forms.NumericUpDown numrecovered;
        private System.Windows.Forms.Button btnDisplayData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}