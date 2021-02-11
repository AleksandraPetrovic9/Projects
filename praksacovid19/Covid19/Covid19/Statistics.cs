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
    public partial class Statistics : Form
    {
        List<CountryInfo> zemlje = DataProvider.AllCountry();
        public Statistics()
        {
            InitializeComponent();
            List<CountryInfo> sortiraneZemlje = zemlje.OrderBy(o => Int32.Parse(o.Active)).ToList();
            
            for(int i=0; i<5; i++)
            {
                dgvNajmanje.Rows.Add(sortiraneZemlje.ElementAt(i).Country, sortiraneZemlje.ElementAt(i).Active);
            }
            for(int i=sortiraneZemlje.Count-1; i> sortiraneZemlje.Count - 6; i--)
            {
                dgvNajvise.Rows.Add(sortiraneZemlje.ElementAt(i).Country, sortiraneZemlje.ElementAt(i).Active);
            }

            List<CountryInfo> sortiraneZemljePoNazivu = zemlje.OrderBy(o => o.Country).ToList();

            foreach(CountryInfo ci in sortiraneZemljePoNazivu)
            {
                cbZemlje.Items.Add(ci.Country);
            }

        }

        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            if (cbZemlje.SelectedItem == null)
            {
                MessageBox.Show("Choose country first!");
                return;
            }

            String zemlja = cbZemlje.SelectedItem.ToString();
            DateTime dtOd = dtpDatumOd.Value;
            DateTime dtDo = dtpDatumDo.Value;

           

            if(dtOd < new DateTime(2020,01,21) || dtOd > new DateTime(2020, 07, 27))
            {
                MessageBox.Show("Date from must be in range 21/01/2020 to 27/07/2020!");
                return;
            }

            if (dtDo < new DateTime(2020, 01, 21) || dtDo > new DateTime(2020, 07, 27))
            {
                MessageBox.Show("Date to must be in range 21/01/2020 to 27/07/2020!");
                return;
            }

            StatisticsChild sc = new StatisticsChild(dtOd, dtDo, zemlja);
            sc.Show();
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Statistics_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                          this.DisplayRectangle);
        }
    }
}
