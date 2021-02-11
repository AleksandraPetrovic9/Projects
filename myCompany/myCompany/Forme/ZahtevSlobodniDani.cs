using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myCompany.QueryEntities;

namespace myCompany
{
    public partial class ZahtevSlobodniDani : Form
    {
        Radnik radnik = new Radnik();
        Vodja vodja = new Vodja();
        List<Sef> sefovi = new List<Sef>();
        public ZahtevSlobodniDani(Radnik r)
        {
            InitializeComponent();
            radnik = r;
            vodja = null;
            sefovi = DataProvider.vratiSveSefove();
            foreach(Sef s in sefovi)
            {
                cmbSef.Items.Add(s.ime + " " + s.prezime);
            }
        }

        public ZahtevSlobodniDani(Vodja v)
        {
            InitializeComponent();
            vodja = v;
            radnik = null;
            sefovi = DataProvider.vratiSveSefove();
            foreach (Sef s in sefovi)
            {
                cmbSef.Items.Add(s.ime + " " + s.prezime);
            }
        }

        private void btnZahtev_Click(object sender, EventArgs e)
        {
            DateTime d1 = dtpDatumOd.Value;
            DateTime d2 = dtpDatumDo.Value;
            int dani =  (int)(d2 - d1).TotalDays;

            if((radnik != null) && (dani > radnik.odmor))
            {
                //MessageBox.Show("Nemate dovoljno slobodnih dana.");
                myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Nemate dovoljno slobodnih dana.");
                pp.ShowDialog();
                return;
            }

            if ((vodja != null) && (dani > vodja.odmor))
            {
                //MessageBox.Show("Nemate dovoljno slobodnih dana.");
                myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Nemate dovoljno slobodnih dana.");
                pp.ShowDialog();
                return;
            }

            if (cmbSef.SelectedIndex == -1)
            {
                //MessageBox.Show("Izaberite sefa.");
                myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Izaberite sefa.");
                pp.ShowDialog();
                return;
            }
            //MessageBox.Show(cmbSef.SelectedIndex.ToString());
            if(vodja == null)
                DataProvider.posaljiZahtevZaSlobodneDane(radnik.idRadnika, sefovi.ElementAt(cmbSef.SelectedIndex).idSefa, d1, d2, "radnik");
            else
                DataProvider.posaljiZahtevZaSlobodneDane(vodja.idVodje, sefovi.ElementAt(cmbSef.SelectedIndex).idSefa, d1, d2, "vodja");

            //MessageBox.Show("Prosledjen zahtev.");
            myCompany.Forme.Poruka poruka = new myCompany.Forme.Poruka("Prosledjen zahtev.");
            poruka.ShowDialog();
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZahtevSlobodniDani_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
