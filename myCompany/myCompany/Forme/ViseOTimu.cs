using myCompany.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace myCompany
{
    public partial class ViseOTimu : Form
    {
        public string projekat;
        public ViseOTimu()
        {
            InitializeComponent();
        }
        public ViseOTimu(string projekat)
        {
            this.projekat = projekat;
            InitializeComponent();
        }

        private void ViseOTimu_Load(object sender, EventArgs e)
        {
            /* PRE IZMENE
            Vodja v = DataProvider.nadjiVodjuTima(this.projekat);
            //:TODO da li mozemo po nazivu tima da nalazimo radnike a ne po IDju

            List<Radnik> radnici = DataProvider.nadjiRadnike(this.projekat);

            lblVodja.Text = v.ime + " " + v.prezime;
          
            listView1.Items.Clear();
            foreach (Radnik t in radnici)
            {

                ListViewItem item = new ListViewItem(new string[] { t.ime, t.prezime,t.telefon,t.zanimanje,t.plata });

                listView1.Items.Add(item);

            }
            listView1.Refresh(); */

            //POSLE IZMENE

            Vodja v = DataProvider.nadjiVodjuTima(this.projekat);
            List<Radnik> radnici = DataProvider.nadjiRadnike(this.projekat);

            lblVodja.Text = v.ime + " " + v.prezime;
            List<Radnik> radnici1 = new List<Radnik>();
            radnici1 = radnici.Select(t => t.email).Distinct().Select(i => radnici.First(t => t.email == i)).ToList();

            listView1.Items.Clear();
            foreach (Radnik t in radnici1)
            {

                ListViewItem item = new ListViewItem(new string[] { t.ime, t.prezime, t.telefon, t.zanimanje, t.plata, t.email });

                listView1.Items.Add(item);

            }
            listView1.Refresh();

        }

        private void btnIzbrisiTim_Click(object sender, EventArgs e)
        {
            Vodja v = DataProvider.nadjiVodjuTima(this.projekat);
            //MessageBox.Show("ID VODJE TIMA:" + v.idVodje);
            List<Radnik> radnici = DataProvider.nadjiRadnike(this.projekat);

           

            foreach(Radnik r in radnici)
            {
                //SET SLOBODAN=DA
                DataProvider.PromeniSlobodnostRadnika(r.idRadnika,"da");
            }
            // DataProvider.vratTimoveZaVodju(v.idVodje);
            DataProvider.obrisiTimoveZaVodju(v.idVodje);

            listView1.Refresh();
            myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Uspesno ste obrisali tim.");
            pp.ShowDialog();
            this.DialogResult = DialogResult.OK;
           // this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViseOTimu_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
