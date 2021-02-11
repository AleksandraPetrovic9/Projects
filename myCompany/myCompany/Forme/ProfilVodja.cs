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

namespace myCompany.Forme
{
    public partial class ProfilVodja : Form
    {
        public Vodja vodjaTima;
        public ProfilVodja()
        {
            InitializeComponent();
        }
        public ProfilVodja(Vodja v)
        {
            InitializeComponent();
            this.vodjaTima = v;
        }

        private void VodjaTima_Load(object sender, EventArgs e)
        {
            //this.vodjaTima = DataProvider.GetVodja("1");
            //MessageBox.Show("ID vodje:"+vodjaTima.idVodje.ToString());

            this.ImePopuni.Text = vodjaTima.ime;
            this.PrezimePopuni.Text = vodjaTima.prezime;
            this.PopuniEmail.Text = vodjaTima.email;
        }

        private void btnFormirajTim_Click(object sender, EventArgs e)
        {
            FormirajTimForm formirajTimForma = new FormirajTimForm(vodjaTima);
            if (formirajTimForma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               // this.PopuniPodacima();
            }
        }

        private void btnPregledProjekata_Click(object sender, EventArgs e)
        {
            PregledProjekataVodja pzv = new PregledProjekataVodja(vodjaTima);
            pzv.ShowDialog();
        }

        private void btnPregledTima_Click(object sender, EventArgs e)
        {
            PregledTimovaVodja ptv = new PregledTimovaVodja(vodjaTima);
            ptv.ShowDialog();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSlobodniDani_Click(object sender, EventArgs e)
        {
            ZahtevSlobodniDani zsd = new ZahtevSlobodniDani(vodjaTima);
            zsd.ShowDialog();
        }

        private void ProfilVodja_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
