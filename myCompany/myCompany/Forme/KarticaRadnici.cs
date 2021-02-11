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
    public partial class KarticaRadnici : Form
    {
        public List<Radnik> sviRadnici;
        public KarticaRadnici()
        {
          
            InitializeComponent();
        }
        public void ucitajRadnike()
        {
            List<Radnik> radnici = DataProvider.vratiRadnike();
            sviRadnici = radnici;
            listView1.Items.Clear();
            foreach (Radnik t in radnici)
            {

                ListViewItem item = new ListViewItem(new string[] { t.ime, t.prezime, t.telefon, t.zanimanje, t.plata, t.email, t.jmbg });

                listView1.Items.Add(item);

            }
            listView1.Refresh();
        }

        private void KarticaRadnici_Load(object sender, EventArgs e)
        {


            comboBox1.SelectedItem = comboBox1.Items[0];
            ucitajRadnike();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajRadnika dr = new DodajRadnika();


            List<Radnik> radnici = DataProvider.vratiRadnike();
 
            if ( dr.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                ucitajRadnike();
              

            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite radnika.");
                return;
            }

            string id = (DataProvider.vratiRadnikaPoEmailu(listView1.SelectedItems[0].SubItems[5].Text.ToString()).idRadnika);
            DataProvider.obrisiRadnika(id);

            ucitajRadnike();
            

        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberite radnika.");
                return;
            }
            String jmbg = listView1.SelectedItems[0].SubItems[6].Text.ToString();
            // MessageBox.Show(jmbg);
            Radnik r = DataProvider.vratiRadnikaPoJmbgu(jmbg);

            IzmeniRadnika iz = new IzmeniRadnika(r);
           // iz.Show();

            if (iz.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ucitajRadnike();


            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filter= comboBox1.SelectedItem.ToString();
            filtriraj(filter);
        }
        private void filtriraj(string filter)
        {
            listView1.Items.Clear();
            foreach (Radnik r in sviRadnici)
            {
                if (filter == "Ime")
                {
                    if (r.ime.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(new string[] {  r.ime, r.prezime,r.telefon,  r.zanimanje, r.plata, r.email,r.jmbg});
                        listView1.Items.Add(item);
                    }
                }
               else if (filter == "Prezime")
                {
                    if (r.prezime.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(new string[] { r.ime, r.prezime, r.telefon, r.zanimanje, r.plata, r.email, r.jmbg });
                        listView1.Items.Add(item);
                    }
                }
               else if (filter == "Zanimanje")
                {
                    if (r.zanimanje.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(new string[] { r.ime, r.prezime, r.telefon, r.zanimanje, r.plata, r.email, r.jmbg });
                        listView1.Items.Add(item);
                    }
                }
                else if (filter == "Plata")
                {
                    if (r.plata.ToLower().Contains(textBox1.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(new string[] { r.ime, r.prezime, r.telefon, r.zanimanje, r.plata, r.email, r.jmbg });
                        listView1.Items.Add(item);
                    }
                }
                listView1.Refresh();
            }
            listView1.Refresh();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KarticaRadnici_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}