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

namespace myCompany.Forme
{
    public partial class AzurirajProjekat : Form
    {
        private Projekat stari;
        public AzurirajProjekat(Projekat p)
        {
            InitializeComponent();
            stari = p;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(""+textBox2.Text);
            Vodja v = DataProvider.vratiVodjuPoJmbgu(textBox2.Text);
            stari.prioritet = comboBox1.Text;
            stari.naziv = textBox1.Text;
            stari.idVodje = v.idVodje;
            stari.datumPocetka = dateTimePicker1.Value;
            stari.rok = dateTimePicker2.Value;
            DataProvider.izmeniProjekat(stari);
            this.Close();
        }

        private void AzurirajProjekat_Load(object sender, EventArgs e)
        {
            Vodja v = DataProvider.GetVodja(stari.idVodje);
            textBox1.Text = stari.naziv;

            textBox2.Text = v.jmbg;
            dateTimePicker1.Value = stari.datumPocetka;
            dateTimePicker2.Value = stari.rok;
            comboBox1.SelectedText = stari.prioritet;
            comboBox1.SelectedValue = stari.prioritet;


        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AzurirajProjekat_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
