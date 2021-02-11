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
    public partial class ProfilRadnik : Form
    {
        public Radnik radnik = new Radnik();
        public List<Zadatak> zadaci = new List<Zadatak>();
        public ProfilRadnik(Radnik r)
        {
            InitializeComponent();
            radnik = r;
            lblIme.Text = r.ime;
            lblPrezime.Text = r.prezime;
            zadaci = DataProvider.vratiZadatkeZaRadnika(radnik.idRadnika);
        }

        private void btnIsplata_Click(object sender, EventArgs e)
        {
            List<String> lista = DataProvider.vratiIplatu(radnik.idRadnika);
            if (lista == null)
            {
                MessageBox.Show("Ne postoji nijedna uplata.");
                return;
            }
                
            IsplataRadnik ir = new IsplataRadnik(lista);
            ir.ShowDialog();

        }

        private void ProfilRadnik_Load(object sender, EventArgs e)
        {
            if(zadaci != null)
            {
                foreach(Zadatak z in zadaci)
                {
                    dgvZadaci.Rows.Add(z.naziv, z.obavljeno, z.opis);
                }
                
            }
        }

        private void btnOdmor_Click(object sender, EventArgs e)
        {
            ZahtevSlobodniDani zsd = new ZahtevSlobodniDani(radnik);
            zsd.ShowDialog();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProfilRadnik_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
