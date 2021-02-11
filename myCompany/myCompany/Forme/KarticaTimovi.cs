using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myCompany;
using myCompany.QueryEntities;

namespace myCompany
{
    public partial class KarticaTimovi : Form
    {
  
        public KarticaTimovi()
        {
            InitializeComponent();
        }

        private void KarticaTimovi_Load(object sender, EventArgs e)
        {
            /* PRE PROMENE
            List<Tim> timovi = new List<Tim>();
            timovi =  DataProvider.vratiTimove();
            listView1.Items.Clear();
            foreach (Tim t in timovi)
            {

                ListViewItem item = new ListViewItem(new string[] { t.naziv,t.aktivan });

                listView1.Items.Add(item);
              
            }
            listView1.Refresh();*/

            //POSLE PROMENE

            this.PopuniPodacima();
            
        }
       private void PopuniPodacima()
        {
            List<Tim> timovi = new List<Tim>();
            timovi = DataProvider.vratiTimove();
            List<Tim> timovi1 = new List<Tim>();
            timovi1 = timovi.Select(t => t.naziv).Distinct().Select(i => timovi.First(t => t.naziv == i)).ToList();
            listView1.Items.Clear();
            foreach (Tim t in timovi1)
            {

                ListViewItem item = new ListViewItem(new string[] { t.naziv, t.aktivan });

                listView1.Items.Add(item);

            }
            listView1.Refresh();
        }
        private void btnVidiVise_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite projekat.");
                return;
            }

            string nazivProjekta = listView1.SelectedItems[0].SubItems[0].Text.ToString();
           ViseOTimu vt = new ViseOTimu(nazivProjekta);
            if(vt.ShowDialog()==DialogResult.OK)
            {
                this.PopuniPodacima();
            }
           

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KarticaTimovi_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
