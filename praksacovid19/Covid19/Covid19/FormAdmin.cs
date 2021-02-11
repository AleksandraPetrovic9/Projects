using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Covid19.QueryEntities;
namespace Covid19
{
    public partial class FormAdmin : Form
    {
        Admin admin;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(Admin a)
        {
            InitializeComponent();
            admin = a;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            //zemlje.OrderBy(o => o.Country).ToList();
            label1.Text = admin.country;
            List<DateInfo> list = DataProvider.DataInfoForAdmin(admin.country).OrderBy(o => DateTime.ParseExact(o.Date, "dd/MM/yyyy", null)).ToList();
        //    List<DateInfo> sortList = list.OrderBy(i => (DateTime.ParseExact(i.Date, "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)).ToString()).ToList();
            // chartNewCases.Titles.Add("New cases");
            // chartNewCases.Series["SeriesNewCases"].IsValueShownAsLabel = true;
            //kroz for petlju da upisuje datum i broj zarazenih 

            foreach (var i in list)
            {

                chartNewCases.Series["SeriesNewCases"].Points.AddXY(i.Date, i.NewCases);
               chartNewCases.Series["SeriesNewDeaths"].Points.AddXY(i.Date, i.NewDeaths);
                chartNewCases.Series["SeriesNewRecovered"].Points.AddXY(i.Date, i.NewRecovered);
              
            }
           // MessageBox.Show(list.Count.ToString());
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FormAddData fad = new FormAddData(admin.country);
            fad.Show();
        }

       

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            FormUpdateData fud = new FormUpdateData(admin.country);
            fud.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAllCountry fac = new FormAllCountry();
            fac.Show();
        }

        private void chartNewCases_Click(object sender, EventArgs e)
        {

        }

        private void FormAdmin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                           this.DisplayRectangle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
