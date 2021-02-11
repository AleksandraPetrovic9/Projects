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
    public partial class DodajRadnika : Form
    {
        public DodajRadnika()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(cmbZanimanje.SelectedItem.ToString());
            if (txtEmail.Text == "")
            {
                myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Morate uneti email.");
                pp.ShowDialog();
                return;
            }
            DataProvider.dodajRadnika(txtIme.Text, txtPrezime.Text,txtEmail.Text, txtPlata.Text, cmbSlobodan.SelectedItem.ToString().ToLower(), txtTelefon.Text, txtJmbg.Text, txtRacun.Text, txtOdmor.Text, cmbZanimanje.SelectedItem.ToString());
            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void DodajRadnika_Load(object sender, EventArgs e)
        {
            cmbZanimanje.SelectedIndex = cmbZanimanje.Items.IndexOf("Koder");
            cmbSlobodan.SelectedIndex = cmbSlobodan.Items.IndexOf("Da");
            txtOdmor.Text = 0.ToString();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajRadnika_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
