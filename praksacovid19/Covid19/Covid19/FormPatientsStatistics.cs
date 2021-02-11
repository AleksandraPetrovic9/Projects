using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Covid19
{
    public partial class FormPatientsStatistics : Form
    {
        public FormPatientsStatistics()
        {
            InitializeComponent();
        
          
        }

        private void FormPatientsStatistics_Load(object sender, EventArgs e)
        {

            FillChartSex();
            FillChartYears();
            FillChartState();
            FillContactNumber();
            FillDeceasedFemaleMale();
            }
        public void FillDeceasedFemaleMale()
        {
          Title title= chartDeceased.Titles.Add("Percentage of deceased persons per sex");//procenat
            title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            chartDeceased.Series["SeriesDeceased"].IsValueShownAsLabel = true;
            int[] niz = DataProvider.DeceasedMaleFemale();
           // chartDeceased.Series["SeriesDeceased"].Points.AddXY("num", niz[0]);
            chartDeceased.Series["SeriesDeceased"].Points.AddXY("female", niz[0]);
            chartDeceased.Series["SeriesDeceased"].Points.AddXY("male", niz[1]);
            chartDeceased.Series["SeriesDeceased"].Points[0].Color = Color.FromArgb(85, 66, 68);
            chartDeceased.Series["SeriesDeceased"].Points[1].Color = Color.LightGray;//FromArgb(85,66,68);
          //  chartStanje.Series["SeriesStanje"].Points[2].Color = Color.FromArgb(126, 66, 66);//crvena
        }
        public void FillContactNumber()
        {
            //kontakt
             int pom = DataProvider.ContactNumber();
           
       lblKontakt.Text = "On average, a person is in contact with  " + DataProvider.ContactNumber().ToString() + " people.";


        }
        public void FillChartSex()
        {
            int count = DataProvider.AllPatients().Count();
            int countFemale = DataProvider.InfectedFemaleMale() * 100 / count;
            int countMale = (count - DataProvider.InfectedFemaleMale()) * 100 / count;
            int undef = 100 - countFemale - countMale;
            //pol
           Title title= chartPol.Titles.Add("Percentage of infected persons per sex.");
            title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            chartPol.Series["SeriesPol"].IsValueShownAsLabel = true;
            chartPol.Series["SeriesPol"].Points.AddXY("Female", countFemale);
            chartPol.Series["SeriesPol"].Points[0].Color = Color.LightGray;//FromArgb(85,66,68);
            chartPol.Series["SeriesPol"].Points.AddXY("Male", countMale);
            chartPol.Series["SeriesPol"].Points[1].Color = Color.FromArgb(85, 66, 68);//
            chartPol.Series["SeriesPol"].Points.AddXY("undefined", undef);
            chartPol.Series["SeriesPol"].Points[2].Color = Color.FromArgb(126, 66, 66); 
        }
        public  void FillChartYears()
        {
           Title title= chartGodine.Titles.Add("Percentage of infected persons per age.");
            title.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            chartPol.Series["SeriesPol"].IsValueShownAsLabel = true;
            int []niz = DataProvider.InfectedAge();
            chartGodine.Series["SeriesGodine"].Points.AddXY("0", niz[0]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("10", niz[1]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("20", niz[2]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("30",niz[3]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("40", niz[4]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("50", niz[5]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("60", niz[6]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("70",niz[7]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("80", niz[8]);
            chartGodine.Series["SeriesGodine"].Points.AddXY("90", niz[9]);
           // chartGodine.Series["SeriesGodine"].Points.AddXY("undefined", 100-niz[9]-niz[8]-niz[7]-niz[6]-niz[5]-niz[4]-niz[3]-niz[2]-niz[1]-niz[0]);
        }
        public void FillChartState()
        {
            int isolated = DataProvider.Isolated();
            int released = DataProvider.Released();
            int deceased = DataProvider.Deceased();
            int undef = 100 - isolated - released - deceased;
             // chartStanje.Titles.Add("State of infected persons.");
            Title title = chartStanje.Titles.Add("State of infected persons.");
            title.ForeColor = System.Drawing.Color.FromArgb(255, 255,255);
            chartStanje.Series["SeriesStanje"].IsValueShownAsLabel = true;
            chartStanje.Series["SeriesStanje"].Points.AddXY("released", released );
            chartStanje.Series["SeriesStanje"].Points.AddXY("isolated", isolated);
            chartStanje.Series["SeriesStanje"].Points.AddXY("deceased", deceased);
            chartStanje.Series["SeriesStanje"].Points.AddXY("undefined", undef); //proveri da li da ostane ili ne
           
            chartStanje.Series["SeriesStanje"].Points[0].Color = Color.FromArgb(85,66,68);
            chartStanje.Series["SeriesStanje"].Points[1].Color = Color.LightGray;//FromArgb(85,66,68);
            chartStanje.Series["SeriesStanje"].Points[2].Color = Color.FromArgb(126, 66, 66);//crvena
            chartStanje.Series["SeriesStanje"].Points[3].Color = Color.DarkGray;//FromArgb(85,66,68);
        }

        private void chartPol_Click(object sender, EventArgs e)
        {

        }

        private void lblKontakt_Click(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chartStanje_Click(object sender, EventArgs e)
        {

        }

        private void FormPatientsStatistics_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                          this.DisplayRectangle);
        }
    }
}
