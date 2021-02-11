namespace Covid19
{
    partial class FormPatientsStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartPol = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGodine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblKontakt = new System.Windows.Forms.Label();
            this.chartStanje = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.chartDeceased = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGodine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStanje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeceased)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPol
            // 
            this.chartPol.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartPol.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPol.Legends.Add(legend1);
            this.chartPol.Location = new System.Drawing.Point(76, 26);
            this.chartPol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartPol.Name = "chartPol";
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.Transparent;
            series1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "SeriesPol";
            series1.ShadowColor = System.Drawing.Color.Transparent;
            this.chartPol.Series.Add(series1);
            this.chartPol.Size = new System.Drawing.Size(365, 318);
            this.chartPol.TabIndex = 0;
            this.chartPol.Text = "chart1";
            this.chartPol.Click += new System.EventHandler(this.chartPol_Click);
            // 
            // chartGodine
            // 
            this.chartGodine.BackColor = System.Drawing.Color.Transparent;
            this.chartGodine.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartGodine.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGodine.Legends.Add(legend2);
            this.chartGodine.Location = new System.Drawing.Point(484, 26);
            this.chartGodine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartGodine.Name = "chartGodine";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Firebrick;
            series2.IsVisibleInLegend = false;
            series2.LabelForeColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "SeriesGodine";
            this.chartGodine.Series.Add(series2);
            this.chartGodine.Size = new System.Drawing.Size(608, 252);
            this.chartGodine.TabIndex = 1;
            this.chartGodine.Text = "chart1";
            // 
            // lblKontakt
            // 
            this.lblKontakt.AutoSize = true;
            this.lblKontakt.Location = new System.Drawing.Point(88, 687);
            this.lblKontakt.Name = "lblKontakt";
            this.lblKontakt.Size = new System.Drawing.Size(54, 19);
            this.lblKontakt.TabIndex = 2;
            this.lblKontakt.Text = "labela";
            this.lblKontakt.Click += new System.EventHandler(this.lblKontakt_Click);
            // 
            // chartStanje
            // 
            this.chartStanje.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartStanje.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartStanje.Legends.Add(legend3);
            this.chartStanje.Location = new System.Drawing.Point(76, 349);
            this.chartStanje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartStanje.Name = "chartStanje";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "SeriesStanje";
            this.chartStanje.Series.Add(series3);
            this.chartStanje.Size = new System.Drawing.Size(365, 311);
            this.chartStanje.TabIndex = 3;
            this.chartStanje.Text = "chart1";
            this.chartStanje.Click += new System.EventHandler(this.chartStanje_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(957, 687);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chartDeceased
            // 
            this.chartDeceased.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chartDeceased.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDeceased.Legends.Add(legend4);
            this.chartDeceased.Location = new System.Drawing.Point(547, 349);
            this.chartDeceased.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartDeceased.Name = "chartDeceased";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "SeriesDeceased";
            this.chartDeceased.Series.Add(series4);
            this.chartDeceased.Size = new System.Drawing.Size(365, 311);
            this.chartDeceased.TabIndex = 6;
            this.chartDeceased.Text = "chart1";
            // 
            // FormPatientsStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1123, 730);
            this.Controls.Add(this.chartDeceased);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chartStanje);
            this.Controls.Add(this.lblKontakt);
            this.Controls.Add(this.chartGodine);
            this.Controls.Add(this.chartPol);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPatientsStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPatientsStatistics";
            this.Load += new System.EventHandler(this.FormPatientsStatistics_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormPatientsStatistics_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.chartPol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGodine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStanje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDeceased)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPol;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGodine;
        private System.Windows.Forms.Label lblKontakt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStanje;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDeceased;
    }
}