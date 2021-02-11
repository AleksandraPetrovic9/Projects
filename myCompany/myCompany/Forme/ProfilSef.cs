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
using myCompany.Forme;

namespace myCompany
{
   
    public partial class ProfilSef : Form
    {
        public Sef sef;
        public int vodja;
        public ProfilSef()
        {
            InitializeComponent();
        }
        public ProfilSef(Sef s)
        {
            this.sef = s;
            InitializeComponent();
        }

        private void ProfilSef_Load(object sender, EventArgs e)
        {
            lblIme.Text = sef.ime;
            lblPrezime.Text = sef.prezime;
            lblEmail.Text = sef.email;
            lblTelefon.Text = sef.telefon;
        }

        private void btnTimovi_Click(object sender, EventArgs e)
        {
            KarticaTimovi kt = new KarticaTimovi();
            kt.Show();
        }

        private void btnRadnici_Click(object sender, EventArgs e)
        {
            KarticaRadnici kr = new KarticaRadnici();
            kr.Show();
        }

        private void btnZahtevi_Click(object sender, EventArgs e)
        {
            this.vodja = 1;
            KarticaSlobodniDani ksd = new KarticaSlobodniDani(this.vodja);
            ksd.Show();
        }

        private void btnZahteviVodje_Click(object sender, EventArgs e)
        {
            this.vodja = 2;
            KarticaSlobodniDani ksd = new KarticaSlobodniDani(vodja);
            ksd.Show();
        }

        private void btnProjekti_Click(object sender, EventArgs e)
        {
            upravljanjeProjektima up = new upravljanjeProjektima(sef);
            up.Show();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfilSef_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider.isplatiVodje(sef.idSefa);
            DataProvider.isplatiRadnike(sef.idSefa);
            myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Izvrsena je uplata.");
            pp.ShowDialog();
        }
    }
}
