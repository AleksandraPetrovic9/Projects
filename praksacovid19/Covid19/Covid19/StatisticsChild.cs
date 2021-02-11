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
    public partial class StatisticsChild : Form
    {
        DateTime datumOd;
        DateTime datumDo;
        String drzava;
        public StatisticsChild()
        {
            InitializeComponent();
        }
        public StatisticsChild(DateTime datumOd, DateTime datumDo, String drzava)
        {
            InitializeComponent();
            this.datumDo = datumDo;
            this.datumOd = datumOd;
            this.drzava = drzava;

            //setNewCases();
            //setNewDeaths();
            //setNewRecovered();
            // MessageBox.Show(drzava + " " + datumOd.ToString());
        }

        private void setNewCases()
        {
            chartPoDatumima.Titles.Add("Number of new cases");
            
            for (DateTime i = this.datumOd; i<=this.datumDo; i=i.AddDays(1))
            {
               
                string datum = i.ToString("dd/MM/yyyy");
               
                DateInfo di = DataProvider.DateForOneDay(drzava, datum);
                   chartPoDatumima.Series["SeriesDates"].Points.AddXY(di.Date, di.NewCases);
            }
        }

        private void setNewDeaths()
        {
            chartPreminuli.Titles.Add("Number of deceased");

            for (DateTime i = datumOd; i <= datumDo; i = i.AddDays(1))
            {

                string datum = i.ToString("dd/MM/yyyy");
                
                DateInfo di = DataProvider.DateForOneDay(drzava, datum);
                chartPreminuli.Series["SeriesDates"].Points.AddXY(di.Date, di.NewDeaths);
            }
        }

        private void setNewRecovered()
        {
            chartOporavljeni.Titles.Add("Number of recovered");

            for (DateTime i = datumOd; i <= datumDo; i = i.AddDays(1))
            {

                string datum = i.ToString("dd/MM/yyyy");
                
                DateInfo di = DataProvider.DateForOneDay(drzava, datum);
                chartOporavljeni.Series["SeriesDates"].Points.AddXY(di.Date, di.NewRecovered);
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatisticsChild_Load(object sender, EventArgs e)
        {


            setNewCases();
            setNewDeaths();
            setNewRecovered();
        }

        private void StatisticsChild_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                          this.DisplayRectangle);
        }
    }
}
