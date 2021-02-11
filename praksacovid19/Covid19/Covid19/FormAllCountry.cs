using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Covid19.QueryEntities;

namespace Covid19
{
    public partial class FormAllCountry : Form
    {
        public FormAllCountry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }
            
            string country = comboBox1.SelectedItem.ToString();
           
            List<DateInfo> list = DataProvider.DataInfoForAdmin(country).OrderBy(o => DateTime.ParseExact(o.Date, "dd/MM/yyyy", null)).ToList(); 

           
            foreach (var i in list)
            {

                chart.Series["SeriesNewCases"].Points.AddXY(i.Date, i.NewCases);
                chart.Series["SeriesNewDeaths"].Points.AddXY(i.Date, i.NewDeaths);
                chart.Series["SeriesNewRecovered"].Points.AddXY(i.Date, i.NewRecovered);

            }

        }

        private void chartNewCases_Click(object sender, EventArgs e)
        {

        }

        private void FormAllCountry_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAllCountry_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                           this.DisplayRectangle);
        }
    }
}
