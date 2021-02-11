using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Covid19;
using Covid19.QueryEntities;
using LiveCharts.WinForms;
using LiveCharts.Maps;
using System.Xml;

namespace Covid19
{
    public partial class Form1 : Form
    {
        public LiveCharts.WinForms.GeoMap geoMap;
        public Form1()
        {
            InitializeComponent();

            this.geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
              List<CountryInfo> countries = DataProvider.AllCountry();
            /*  List<CountryInfo> sortcountries = countries.OrderBy(o => Int32.Parse(o.Confirmed)).ToList();
              List<CountryInfo> maxCountries = new List<CountryInfo>();
              for (int i = sortcountries.Count - 1; i > sortcountries.Count - 7; i--)
              {
                  maxCountries.Add(sortcountries.ElementAt(i));
              }
              keyValues["US"] = Convert.ToInt32(maxCountries.ElementAt(0).Active);
              keyValues["BR"] = Convert.ToInt32(maxCountries.ElementAt(1).Active);
              keyValues["IN"] = Convert.ToInt32(maxCountries.ElementAt(2).Active);
              keyValues["RU"] = Convert.ToInt32(maxCountries.ElementAt(3).Active);
              keyValues["ZA"] = Convert.ToInt32(maxCountries.ElementAt(4).Active);
              keyValues["MX"] = Convert.ToInt32(maxCountries.ElementAt(5).Active);*/
            XmlDocument doc = new XmlDocument();
            doc.Load("World.xml");
            XmlNodeList idList = doc.GetElementsByTagName("Id");
            XmlNodeList nameList = doc.GetElementsByTagName("Name");
            for (int i = 0; i < idList.Count; i++)
            {
                //MessageBox.Show(idList[i].InnerXml);
                //MessageBox.Show(nameList[i].InnerXml);
            }


            for (int i = 0; i < idList.Count; i++)
            {
                CountryInfo ci = DataProvider.getCountryInfo(nameList[i].InnerXml);
                if(idList[i].InnerXml.Equals("US"))
                {
                    ci = DataProvider.getCountryInfo(idList[i].InnerXml);
                    keyValues[idList[i].InnerXml] = Convert.ToInt32(ci.Active);
                }
                else
                keyValues[idList[i].InnerXml] = Convert.ToInt32(ci.Active);


            }
            geoMap.HeatMap = keyValues;


            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
          
            geoMap.Hoverable = true;
            geoMap.EnableZoomingAndPanning = true;
           
            geoMap.LandClick += GeoMap_LandClick;




            for (int i = 0; i < 10; i++) // idList.Count; i++)
            {

               // this.Controls[i].ForeColor = ColorTranslator.FromHtml("#f54242");
               // this.Controls[i].BackColor = ColorTranslator.FromHtml("#f54242");
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*LiveCharts.WinForms.GeoMap */this.geoMap = new LiveCharts.WinForms.GeoMap();
            Dictionary<string, double> keyValues = new Dictionary<string, double>();
            List<CountryInfo> countries = DataProvider.AllCountry();
            List<CountryInfo> sortcountries = countries.OrderBy(o => Int32.Parse(o.Confirmed)).ToList();
            List<CountryInfo> maxCountries = new List<CountryInfo>();
            for (int i = sortcountries.Count - 1; i > sortcountries.Count - 7; i--)
            {
                maxCountries.Add(sortcountries.ElementAt(i));
            }
            //MessageBox.Show(maxCountries.ElementAt(0).Country + ", " + maxCountries.ElementAt(1).Country + ", " + maxCountries.ElementAt(2).Country + ", " + maxCountries.ElementAt(3).Country + ", " + maxCountries.ElementAt(4).Country + ", " + maxCountries.ElementAt(5).Country + ", " );

            //da ubacimo zemlje koje imaju najvise zarazenih 
          //  keyValues["US"] = Convert.ToInt32(maxCountries.ElementAt(0).Active);
            keyValues["BR"] = Convert.ToInt32(maxCountries.ElementAt(1).Active);
            keyValues["IN"] = Convert.ToInt32(maxCountries.ElementAt(2).Active);
            keyValues["RU"] = Convert.ToInt32(maxCountries.ElementAt(3).Active);
            keyValues["ZA"] = Convert.ToInt32(maxCountries.ElementAt(4).Active);
            keyValues["MX"] = Convert.ToInt32(maxCountries.ElementAt(5).Active);



            geoMap.HeatMap = keyValues;

            geoMap.Source = $"{Application.StartupPath}\\World.xml";
            this.Controls.Add(geoMap);
            geoMap.Dock = DockStyle.Fill;
            geoMap.LandClick += GeoMap_LandClick;

        }
        private void GeoMap_LandClick(object arg1, LiveCharts.Maps.MapData arg2)
        {
            CountryInfo ci = new CountryInfo();
            if (arg2.Name.Equals("United States"))
             ci = DataProvider.getCountryInfo("US");
            else
                ci = DataProvider.getCountryInfo(arg2.Name);
           
            if(ci.Country == null)
            {
                MessageBox.Show("Nisu pronadjeni podaci za izabranu zemlju.");
            }
            else
            {
                FormStatistic fs = new FormStatistic(ci);
                fs.Show();
               // MessageBox.Show(ci.Country + System.Environment.NewLine +
               //"Ukupan broj potvrdjenih slučajeva " + ci.Confirmed + System.Environment.NewLine +
               //"Ukupan broj izlečenih " + ci.Recovered + System.Environment.NewLine +
               //"Ukupan broj preminulih " + ci.Deaths + System.Environment.NewLine +
               //"Ukupan broj trenutno aktivnih slučajeva " + ci.Active + System.Environment.NewLine);
            }
           
        }

        private void covid19StatistcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics formStat = new Statistics();
            formStat.Show();
        }

        private void patientStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPatientsStatistics fps = new FormPatientsStatistics();
            fps.Show();
        }

        private void selfassessmentTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelfAssessmentTest formTest = new SelfAssessmentTest();
            formTest.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin fl = new FormLogin();
            fl.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                           this.DisplayRectangle);
        }
    }
}
 