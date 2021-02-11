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
    public partial class PregledProjekataVodja : Form
    {
        List<Projekat> projekti = new List<Projekat>();
        Vodja vodja = new Vodja();
        public PregledProjekataVodja(Vodja v)
        {
            InitializeComponent();
            vodja = v;
            projekti = DataProvider.vratiProjekteZaVodju(vodja.idVodje);
        }

        private void PregledProjekataVodja_Load(object sender, EventArgs e)
        {
            if (projekti != null)
            {
                foreach (Projekat z in projekti)
                {
                    string kraj;
                    if (z.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = z.datumKraja.ToShortDateString();
                    dgvZadaci.Rows.Add(z.naziv, z.prioritet,z.datumPocetka.ToShortDateString(), z.rok.ToShortDateString(),kraj, z.idProjekta);
                }
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PregledProjekataVodja_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvZadaci.SelectedRows.Count == 0)
            {
                myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Odaberite zadatak.");
                pp.ShowDialog();
                return;
            }
            DataGridViewRow row = dgvZadaci.CurrentCell.OwningRow;
            string idP = row.Cells["idProjekta"].Value.ToString();
            Projekat p = DataProvider.vratiProjektePoIDu(idP);
            DateTime datumK = dateTimePicker1.Value;
            p.datumKraja = datumK;

            DataProvider.izmeniProjekat(p);

            dgvZadaci.Rows.Clear();
            projekti = DataProvider.vratiProjekteZaVodju(vodja.idVodje);
            if (projekti != null)
            {
                foreach (Projekat z in projekti)
                {
                    string kraj;
                    if (p.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = p.datumKraja.ToShortDateString();
                    dgvZadaci.Rows.Add(z.naziv, z.prioritet,z.datumPocetka.ToShortDateString(), z.rok.ToShortDateString(), kraj,  z.idProjekta);
                }
            }



        }
    }
}
