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
    public partial class FormirajTimForm : Form
    {
        public Vodja vodja;
        public List<Radnik> listaSlobodnihRadnika = new List<Radnik>();
        public List<Radnik> listaIzabranihRadnika = new List<Radnik>();
        public FormirajTimForm()
        {
            InitializeComponent();
            filterComboBox.SelectedItem= filterComboBox.Items[0];
        }
        public FormirajTimForm(Vodja vodjaTima)
        {
            InitializeComponent();
            this.vodja = vodjaTima;
            
            listaSlobodnihRadnika = DataProvider.GetSlobodniRadnici();
            this.PopuniPodacima();
            filterComboBox.SelectedItem = filterComboBox.Items[0];

        }
        public void PopuniPodacima()
        {
            listViewSviSlobodniRadnici.Items.Clear();

            foreach(Radnik r in listaSlobodnihRadnika)
            {
                ListViewItem item = new ListViewItem(new string[] { r.idRadnika, r.ime, r.prezime, r.email, r.zanimanje,r.plata });
               
                listViewSviSlobodniRadnici.Items.Add(item);
               // MessageBox.Show(r.ime);
            }
            listViewSviSlobodniRadnici.Refresh();

            
        }

        private void btnIzaberiRadnika_Click(object sender, EventArgs e)
        {
            if(listViewSviSlobodniRadnici.SelectedItems.Count==0)
            {
                MessageBox.Show("Izaberite radnika!");
                return;
            }
            foreach (ListViewItem item in listViewSviSlobodniRadnici.SelectedItems)
            {
                //MessageBox.Show(item.SubItems[0].Text);
                string id = item.SubItems[0].Text;
                //listaID.Add(id);
                foreach(Radnik radnik in listaSlobodnihRadnika.ToList())
                {
                    if(id==radnik.idRadnika)
                    {
                        listaIzabranihRadnika.Add(radnik);
                        listaSlobodnihRadnika.Remove(radnik);
                    }
                }
                
            }
            this.PopuniPodacima();

            this.PopuniPodacimaTim();
            
        }

        private void PopuniPodacimaTim()
        {
            listViewTim.Items.Clear();

            foreach (Radnik r in listaIzabranihRadnika)
            {
                ListViewItem item1 = new ListViewItem(new string[] { r.idRadnika, r.ime, r.prezime, r.email, r.zanimanje, r.plata });

                listViewTim.Items.Add(item1);
            }

            listViewTim.Refresh();
        }

        private void btnIzbaciRadnika_Click(object sender, EventArgs e)
        {
            if (listViewTim.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite radnika!");
                return;
            }
            foreach (ListViewItem item1 in listViewTim.SelectedItems)
            {
                //MessageBox.Show(item1.SubItems[0].Text);
                string id = item1.SubItems[0].Text;
                //listaID.Add(id);
                foreach (Radnik radnik in listaIzabranihRadnika.ToList())
                {
                    if (id == radnik.idRadnika)
                    {
                        listaSlobodnihRadnika.Add(radnik);
                        listaIzabranihRadnika.Remove(radnik);
                    }
                }

            }
            this.PopuniPodacima();

            this.PopuniPodacimaTim();
        }
        private void Filtriraj()
        {
            listViewSviSlobodniRadnici.Items.Clear();

            string filterListe = filterComboBox.SelectedItem.ToString();

            //MessageBox.Show(filterListe);

            this.FiltrirajPoParametru(filterListe);

            listViewSviSlobodniRadnici.Refresh();
        }

        private void filterComboBox_MouseClick(object sender, MouseEventArgs e)
        {
            this.Filtriraj();
        }
        private void FiltrirajPoParametru(string filterListe)
        {
            foreach (Radnik r in listaSlobodnihRadnika)
            {
                if (filterListe == "Ime")
                {
                    if (r.ime.ToLower().Contains(textBoxFilter.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(new string[] { r.idRadnika, r.ime, r.prezime, r.email, r.zanimanje, r.plata });
                        listViewSviSlobodniRadnici.Items.Add(item);
                    }
                }
                if (filterListe == "Prezime")
                {
                    if (r.prezime.ToLower().Contains(textBoxFilter.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(new string[] { r.idRadnika, r.ime, r.prezime, r.email, r.zanimanje, r.plata });
                        listViewSviSlobodniRadnici.Items.Add(item);
                    }
                }
                if (filterListe == "Zanimanje")
                {
                    if (r.zanimanje.ToLower().Contains(textBoxFilter.Text.ToLower()))
                    {
                        ListViewItem item = new ListViewItem(new string[] { r.idRadnika, r.ime, r.prezime, r.email, r.zanimanje, r.plata });
                        listViewSviSlobodniRadnici.Items.Add(item);
                    }
                }
                listViewSviSlobodniRadnici.Refresh();
            }
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            this.Filtriraj();
        }

        private void btnZadajZadatak_Click(object sender, EventArgs e)
        {
            if (listViewTim.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite radnika!");
                return;
            }
            if (listViewTim.SelectedItems.Count > 1)
            {
                MessageBox.Show("Izaberite samo jednog radnika!");
                return;
            }

            string id = listViewTim.SelectedItems[0].Text;

            foreach(Radnik radnik in listaIzabranihRadnika)
            {
                if(radnik.idRadnika==id)
                {
                    ZadajZadatakForm zadajZadatakForm = new ZadajZadatakForm(radnik,this.vodja);
                    if (zadajZadatakForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.PopuniPodacima();
                        this.PopuniPodacimaTim();
                    }
                }
            }

        }

        private void btnFormirajTim_Click(object sender, EventArgs e)
        {
            //formira se veza tim izmedju vodje i radnika
            foreach (Radnik radnik in listaIzabranihRadnika)
            {
                Tim tim = new Tim();
                tim.naziv = txtNazivTima.Text;
                tim.idRadnika = radnik.idRadnika;
                tim.idVodje = this.vodja.idVodje;
                tim.aktivan = "da";
                tim.idTima = DataProvider.GetTimId();
                DataProvider.AddTim(tim);
                //promenim da je svaki radnik sada zauzet,SET SLOBODAN=NE
                DataProvider.PromeniSlobodnostRadnika(radnik.idRadnika,"ne");
            }

            myCompany.Forme.Poruka pp = new myCompany.Forme.Poruka("Uspesno formiran tim.");
            pp.ShowDialog();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
            this.Close();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormirajTimForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
