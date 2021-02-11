namespace Covid19
{
    partial class StatisticsChild
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
            this.chartPoDatumima = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzadji = new System.Windows.Forms.Button();
            this.chartPreminuli = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartOporavljeni = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartPoDatumima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPreminuli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOporavljeni)).BeginInit();
            this.SuspendLayout();
            // 
            // chartPoDatumima
            // 
            this.chartPoDatumima.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartPoDatumima.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPoDatumima.Legends.Add(legend1);
            this.chartPoDatumima.Location = new System.Drawing.Point(100, 42);
            this.chartPoDatumima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartPoDatumima.Name = "chartPoDatumima";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Firebrick;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "SeriesDates";
            this.chartPoDatumima.Series.Add(series1);
            this.chartPoDatumima.Size = new System.Drawing.Size(611, 222);
            this.chartPoDatumima.TabIndex = 2;
            this.chartPoDatumima.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Graphical display of data";
            // 
            // btnIzadji
            // 
            this.btnIzadji.Location = new System.Drawing.Point(843, 958);
            this.btnIzadji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIzadji.Name = "btnIzadji";
            this.btnIzadji.Size = new System.Drawing.Size(115, 54);
            this.btnIzadji.TabIndex = 5;
            this.btnIzadji.Text = "Izadji";
            this.btnIzadji.UseVisualStyleBackColor = true;
            this.btnIzadji.Click += new System.EventHandler(this.btnIzadji_Click);
            // 
            // chartPreminuli
            // 
            this.chartPreminuli.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chartPreminuli.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPreminuli.Legends.Add(legend2);
            this.chartPreminuli.Location = new System.Drawing.Point(100, 259);
            this.chartPreminuli.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartPreminuli.Name = "chartPreminuli";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.BorderColor = System.Drawing.Color.Transparent;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Firebrick;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "SeriesDates";
            this.chartPreminuli.Series.Add(series2);
            this.chartPreminuli.Size = new System.Drawing.Size(611, 230);
            this.chartPreminuli.TabIndex = 6;
            this.chartPreminuli.Text = "chart1";
            // 
            // chartOporavljeni
            // 
            this.chartOporavljeni.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chartOporavljeni.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartOporavljeni.Legends.Add(legend3);
            this.chartOporavljeni.Location = new System.Drawing.Point(100, 480);
            this.chartOporavljeni.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartOporavljeni.Name = "chartOporavljeni";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series3.BorderColor = System.Drawing.Color.Transparent;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Firebrick;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "SeriesDates";
            this.chartOporavljeni.Series.Add(series3);
            this.chartOporavljeni.Size = new System.Drawing.Size(611, 262);
            this.chartOporavljeni.TabIndex = 7;
            this.chartOporavljeni.Text = "chart1";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(678, 725);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(146, 28);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // StatisticsChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(835, 764);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.chartOporavljeni);
            this.Controls.Add(this.chartPreminuli);
            this.Controls.Add(this.btnIzadji);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartPoDatumima);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StatisticsChild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsChild";
            this.Load += new System.EventHandler(this.StatisticsChild_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StatisticsChild_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.chartPoDatumima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPreminuli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOporavljeni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPoDatumima;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzadji;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPreminuli;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOporavljeni;
        private System.Windows.Forms.Button btnCancel;
    }
}