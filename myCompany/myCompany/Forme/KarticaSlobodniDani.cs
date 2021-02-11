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
    public partial class KarticaSlobodniDani : Form
    {
        public int vodja;
        public KarticaSlobodniDani()
        {
            InitializeComponent();
        }
        public KarticaSlobodniDani(int v)
        {
            this.vodja = v;
            InitializeComponent();
        }
        private void KarticaSlobodniDani_Load(object sender, EventArgs e)
        {
            if (this.vodja == 1)
            {
                List<Radnik> radnici = DataProvider.vratiRadnikeZaSlobodneDane();

                dataGridView1.Rows.Clear();
                int i = 0;

                foreach (Radnik a in radnici)//
                {


                    string iddana = DataProvider.vratiIdDana(a.idRadnika);
                    SlobodniDani sd = DataProvider.vratiSlobodanDan(iddana);


                    string[] row = new string[] { a.ime, a.prezime, a.odmor.ToString(), a.jmbg, a.zanimanje };

                    dataGridView1.Rows.Add(row);

                    if (sd.pregledano == "da") dataGridView1.Rows[i].Cells[5].Value = true;
                    else dataGridView1.Rows[i].Cells[5].Value = false;
                    if (sd.odobreno == "da") dataGridView1.Rows[i].Cells[6].Value = true;
                    else dataGridView1.Rows[i].Cells[6].Value = false;
                    i++;
                }
            }
            else if (this.vodja == 2)
            {
                List<Vodja> vodje = DataProvider.vratiVodjeZaSlobodneDane();

                dataGridView1.Rows.Clear();
                int i = 0;

                foreach (Vodja a in vodje)//
                {


                    string iddana = DataProvider.vratiIdDanaVodje(a.idVodje);//
                    SlobodniDani sd = DataProvider.vratiSlobodanDan(iddana);

                    string v = "vodja";
                    string[] row = new string[] { a.ime, a.prezime, a.odmor.ToString(), a.jmbg, v };

                    dataGridView1.Rows.Add(row);

                    if (sd.pregledano == "da") dataGridView1.Rows[i].Cells[5].Value = true;
                    else dataGridView1.Rows[i].Cells[5].Value = false;
                    if (sd.odobreno == "da") dataGridView1.Rows[i].Cells[6].Value = true;
                    else dataGridView1.Rows[i].Cells[6].Value = false;
                    i++;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.vodja == 1)
            {
                for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
                {

                    string jmbgRadnika = dataGridView1.Rows[rows].Cells[3].Value.ToString();
                    if (jmbgRadnika != null)
                    {
                        string idr = DataProvider.vratiRadnikaPoJmbgu(jmbgRadnika).idRadnika;
                        string pregledano = (Convert.ToBoolean(dataGridView1.Rows[rows].Cells[5].Value) == true) ? "da" : "ne";
                        string odobreno = (Convert.ToBoolean(dataGridView1.Rows[rows].Cells[6].Value) == true) ? "da" : "ne";

                        // MessageBox.Show(pregledano + " " + odobreno);
                        DataProvider.izmeniSlobodneDane(idr, pregledano, odobreno, this.vodja);
                    }


                }
            }
            else if (this.vodja == 2)
            {
                for (int rows = 0; rows < dataGridView1.Rows.Count - 1; rows++)
                {

                    string jmbgRadnika = dataGridView1.Rows[rows].Cells[3].Value.ToString();
                    if (jmbgRadnika != null)
                    {
                        string idr = DataProvider.vratiVodjuPoJmbgu(jmbgRadnika).idVodje;
                        string pregledano = (Convert.ToBoolean(dataGridView1.Rows[rows].Cells[5].Value) == true) ? "da" : "ne";
                        string odobreno = (Convert.ToBoolean(dataGridView1.Rows[rows].Cells[6].Value) == true) ? "da" : "ne";

                        // MessageBox.Show(pregledano + " " + odobreno);
                        DataProvider.izmeniSlobodneDane(idr, pregledano, odobreno, this.vodja);
                    }


                }
            }
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KarticaSlobodniDani_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
