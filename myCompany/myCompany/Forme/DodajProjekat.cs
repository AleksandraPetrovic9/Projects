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
    public partial class DodajProjekat : Form
    {
        public String idSefa;
        public List<Vodja> vodje;
        public DodajProjekat(String idSefa)
        {
            InitializeComponent();
            this.idSefa = idSefa;
        }
    
        public DodajProjekat()
        {
            InitializeComponent();
          
       
        }
        private void DodajProjekat_Load(object sender, EventArgs e)
        {
            vodje = DataProvider.vratiSveVodje();
            foreach (Vodja s in vodje)
            {
                cmbVodja.Items.Add(s.ime + " " + s.prezime + " " + s.jmbg);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Projekat p = new Projekat();
            p.idSefa = idSefa;
          //  p.idProjekta = DataProvider.maxIdProjekta().ToString();
            p.naziv = textBox1.Text;
            p.prioritet = comboBox1.Text;
            p.rok = dateTimePicker2.Value;
            p.datumPocetka = dateTimePicker1.Value;
            if (p.datumPocetka > p.rok)
            {
                myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Neispravni datumi.");
                pp.ShowDialog();
            }
            else
            {
                Vodja v1 = new Vodja();
                v1 = vodje.ElementAt(cmbVodja.SelectedIndex);

                if (v1 == null)
                {
                    myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Nevalidan JMBG.");
                    pp.ShowDialog();
                }
                else
                {
                    p.idVodje = v1.idVodje;
                    DataProvider.dodajProjekat(p);
                }
            }
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajProjekat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
