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
using myCompany;
namespace myCompany.Forme
{
    public partial class upravljanjeProjektima : Form
    {

        List<Projekat> projekti = new List<Projekat>();
        Sef sef = new Sef();
   
        public upravljanjeProjektima(Sef s)
        {
            InitializeComponent();
            sef = s;
            projekti = DataProvider.vratiProjekteZaSefa(sef.idSefa);
            
        }
        private void ocitajListu() {
            listView1.Items.Clear();
            projekti = DataProvider.vratiProjekteZaSefa(sef.idSefa);
            if (projekti != null)
            { string kraj;
              
                foreach (Projekat p in projekti)
                {
                    if (p.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = p.datumKraja.ToShortDateString();
                   ListViewItem item = new ListViewItem(new string[] { p.idProjekta, p.naziv, p.prioritet, p.datumPocetka.ToShortDateString(), p.rok.ToShortDateString(),kraj });

                    listView1.Items.Add(item);

                }
            }
            listView1.Refresh();
        }
        private void upravljanjeProjektima_Load(object sender, EventArgs e)
        {
            this.ocitajListu();
        }

      

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            DodajProjekat dp = new DodajProjekat(sef.idSefa);
            dp.ShowDialog();
            this.ocitajListu();
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite projekat koji zelite da azurirate.");
                return;
            }

            String idP = listView1.SelectedItems[0].SubItems[0].Text;
            Projekat p = DataProvider.vratiProjektePoIDu(idP);
            AzurirajProjekat ap = new AzurirajProjekat(p);
            ap.ShowDialog();
            this.ocitajListu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite projekat koji zelite da uklonite.");
                return;
            }

            String idP=listView1.SelectedItems[0].SubItems[0].Text;
            DataProvider.obrisiProjekat(idP);
            this.ocitajListu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            projekti = DataProvider.vratiProjekteZaSefaPoNazivu(sef.idSefa,textBox1.Text);
            if (projekti != null)
            {
                string kraj;
                foreach (Projekat p in projekti)
                {
                    if (p.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = p.datumKraja.ToShortDateString();
                    ListViewItem item = new ListViewItem(new string[] { p.idProjekta, p.naziv, p.prioritet, p.datumPocetka.ToShortDateString(), p.rok.ToShortDateString(),kraj });

                    listView1.Items.Add(item);

                }
            }
            listView1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            projekti = DataProvider.vratiProjekteZaSefaPoPrioritetu(sef.idSefa, comboBox1.Text);
            if (projekti != null)
            {
                string kraj;
                foreach (Projekat p in projekti)
                {
                    if (p.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = p.datumKraja.ToShortDateString();

                    ListViewItem item = new ListViewItem(new string[] { p.idProjekta, p.naziv, p.prioritet, p.datumPocetka.ToShortDateString(), p.rok.ToShortDateString(), kraj });

                    listView1.Items.Add(item);

                }
            }
            listView1.Refresh();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (checkBox1.Checked==true)
            {
                projekti = DataProvider.vratiProjekteZaSefaNezavrsene(sef.idSefa);
            }
            else
                projekti = DataProvider.vratiProjekteZaSefa(sef.idSefa);
            if (projekti != null)
            {
                string kraj;

                foreach (Projekat p in projekti)
                {
                    if (p.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = p.datumKraja.ToShortDateString();
                    ListViewItem item = new ListViewItem(new string[] { p.idProjekta, p.naziv, p.prioritet, p.datumPocetka.ToShortDateString(), p.rok.ToShortDateString(), kraj });

                    listView1.Items.Add(item);

                }
            }
            listView1.Refresh();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string datum= dateTimePicker1.Value.Year.ToString() + "-" +dateTimePicker1.Value.Month.ToString() + "-" +dateTimePicker1.Value.Day.ToString();
          

            listView1.Items.Clear();
            projekti = DataProvider.vratiProjekteZaSefaPoRoku(sef.idSefa,datum);
            if (projekti != null)
            {
                string kraj;

                foreach (Projekat p in projekti)
                {
                    if (p.datumKraja == DateTime.MinValue)

                        kraj = "";
                    else
                        kraj = p.datumKraja.ToShortDateString();

                    ListViewItem item = new ListViewItem(new string[] { p.idProjekta, p.naziv, p.prioritet, p.datumPocetka.ToShortDateString(), p.rok.ToShortDateString(),kraj });

                    listView1.Items.Add(item);

                }
            }
            listView1.Refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ocitajListu();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void upravljanjeProjektima_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
    
}
