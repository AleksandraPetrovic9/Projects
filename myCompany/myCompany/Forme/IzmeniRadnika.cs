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
    public partial class IzmeniRadnika : Form
    {
        public Radnik radnik;
        public IzmeniRadnika()
        {
            InitializeComponent();
        }
        public IzmeniRadnika(Radnik r)
        {
            this.radnik = r;
            InitializeComponent();
        }
        private void IzmeniRadnika_Load(object sender, EventArgs e)
        {
            txtIme.Text= radnik.ime;
            txtPrezime.Text = radnik.prezime;
            txtEmail.Text = radnik.email;
            txtJmbg.Text = radnik.jmbg;
            txtOdmor.Text = radnik.odmor.ToString();
            txtPlata.Text = radnik.plata;
            txtRacun.Text = radnik.racun;
            txtTelefon.Text = radnik.telefon;
          
            if(radnik.slobodan=="da")
            {cmbSlobodan.SelectedIndex = cmbSlobodan.Items.IndexOf("Da"); }
            else
            { cmbSlobodan.SelectedIndex = cmbSlobodan.Items.IndexOf("Ne"); }

            if (radnik.zanimanje == "koder") { cmbZanimanje.SelectedIndex = cmbZanimanje.Items.IndexOf("Koder"); } 
            else { cmbZanimanje.SelectedIndex = cmbZanimanje.Items.IndexOf("Tester"); }
            //cmbSlobodan.SelectedItem= radnik.slobodan;
         
            //cmbZanimanje.SelectedItem = radnik.zanimanje;

          
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            

            DataProvider.izmeniRadnika(txtIme.Text, txtPrezime.Text, txtEmail.Text, txtTelefon.Text, txtJmbg.Text, txtOdmor.Text, txtPlata.Text, cmbSlobodan.SelectedItem.ToString().ToLower(), cmbZanimanje.SelectedItem.ToString().ToLower());
        //    MessageBox.Show(cmbSlobodan.SelectedItem.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IzmeniRadnika_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
