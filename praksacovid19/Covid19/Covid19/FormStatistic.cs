using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Covid19.QueryEntities;

namespace Covid19
{
    public partial class FormStatistic : Form
    {
        CountryInfo zemlja = new CountryInfo();
        //String zemlja;
        public FormStatistic()
        {
            InitializeComponent();
        }

        public FormStatistic(CountryInfo zemlja)
        {
            InitializeComponent();
            this.zemlja = zemlja;
            txtCountry.Text = zemlja.Country;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormStatistic_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        { 
            DateTime dtOd = dtpDatumOd.Value;
            DateTime dtDo = dtpDatumDo.Value;

            if (dtOd < new DateTime(2020, 01, 21) || dtOd > new DateTime(2020, 07, 27))
            {
                MessageBox.Show("Date from must be in range 21/01/2020 to 27/07/2020!");
                return;
            }

            if (dtDo < new DateTime(2020, 01, 21) || dtDo > new DateTime(2020, 07, 27))
            {
                MessageBox.Show("Date to must be in range 21/01/2020 to 27/07/2020!");
                return;
            }

            StatisticsChild sc = new StatisticsChild(dtOd, dtDo, zemlja.Country);
            sc.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(@"D:\PraksaCovid19\Repository\praksacovid19\" + zemlja.Country+".csv"))
            {
                sw.WriteLine("Date,New cases,New deaths,New recovered");
                for (DateTime i = dtpDatumOd.Value; i <= dtpDatumDo.Value; i = i.AddDays(1))
                {
                    string datum = i.ToString("dd/MM/yyyy");
                    DateInfo di = DataProvider.DateForOneDay(zemlja.Country, datum);
                    sw.WriteLine(datum + "," + di.NewCases + "," + di.NewDeaths + "," + di.NewRecovered);
                }
               
                MessageBox.Show("Data saved successfully");
            }
        }
    }
}
