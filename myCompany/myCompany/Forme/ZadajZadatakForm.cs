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

namespace myCompany.QueryEntities
{
    public partial class ZadajZadatakForm : Form
    {
        public Radnik radnik;
        public Vodja vodja;
        public Zadatak zadatak;
        public ZadajZadatakForm()
        {
            InitializeComponent();
        }
        public ZadajZadatakForm(Radnik radnik,Vodja vodja)
        {
            this.radnik = radnik;
            this.vodja = vodja;
            InitializeComponent();

            this.lblPopuniIme.Text = this.radnik.ime;
            this.lblPopuniPrezime.Text = this.radnik.prezime;
            this.lblPopuniZanimanje.Text = this.radnik.zanimanje;
            this.lblPopuniPlata.Text = this.radnik.plata;

        }

        private void btnKreirajZadatak_Click(object sender, EventArgs e)
        {
            
            zadatak = new Zadatak();
            string naziv = txtNazivZadatka.Text;
            string opis = opisZadatkaRichTextBox.Text;
            string obavljeno = "ne";
            string aktivan = "da";
            zadatak.idRadnika = this.radnik.idRadnika;
            zadatak.idVodje = this.vodja.idVodje;
            zadatak.naziv = naziv;
            zadatak.obavljeno = obavljeno;
            zadatak.opis = opis;
            zadatak.aktivan = aktivan;
            //SELECT MAX("idVodje") FROM "MyCompany"."Vodja";
            string idVodje = DataProvider.GetVodjaId();
            //MessageBox.Show(idVodje);
            zadatak.idVodje = idVodje;
            zadatak.idZadatka = DataProvider.GetZadatakId();
            DataProvider.ZadajZadatak(zadatak, this.radnik);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZadajZadatakForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
