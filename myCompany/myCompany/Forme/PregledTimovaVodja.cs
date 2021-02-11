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
    public partial class PregledTimovaVodja : Form
    {
        List<Tim> timovi = new List<Tim>();
        Vodja vodja = new Vodja();
        public PregledTimovaVodja(Vodja v)
        {
            InitializeComponent();
            vodja = v;
            timovi = DataProvider.vratTimoveZaVodju(vodja.idVodje);
        }

        private void PregledTimovaVodja_Load(object sender, EventArgs e)
        {
            String nazivTima = timovi.ElementAt(0).naziv;
            String radnici = "";
            if (timovi != null)
            {
                for (int i=0; i<timovi.Count; i++)
                {
                    Tim t = timovi.ElementAt(i);
                    nazivTima = t.naziv;
                    if (nazivTima == t.naziv)
                    {
                        Tim t1 = t;
                        while(t1.naziv == t.naziv)
                        {
                           // MessageBox.Show(t1.naziv);
                            Radnik r = DataProvider.vratiRadnikaPoIdu(t1.idRadnika);
                            radnici += r.ime + " " + r.prezime + " ";
                           // MessageBox.Show(i.ToString());

                            i++;
                            if (i < timovi.Count)
                            {
                                t1 = timovi.ElementAt(i);
                            } 
                            else break;
                            //MessageBox.Show(i.ToString());
                        }
                    }
                    i--;
                    dgvTimovi.Rows.Add(t.naziv, t.aktivan, radnici);
                    radnici = "";

                    
                }
            }
        }

        private List<Tim> izbaciDuplikate()
        {
            List<Tim> filtriraniTimovi = new List<Tim>();
            //filtriraniTimovi = timovi;

            foreach (Tim t in timovi)
            {
                if (!filtriraniTimovi.Contains(t))
                    filtriraniTimovi.Add(t);
            }
            return timovi;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PregledTimovaVodja_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
