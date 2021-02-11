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
using myCompany.Forme;

namespace myCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String stranica = DataProvider.login(txtUser.Text, txtPass.Text);
            if(stranica==null)
            {
                MessageBox.Show("Unesite validan email i sifru.");
            }
            if(stranica=="sef")
            {
                Sef sef = new Sef();
                sef = DataProvider.vratiSefaPoEmailu(txtUser.Text);
                //vratiSefa(txtUser.Text);
                ProfilSef profilSefa = new ProfilSef(sef);
                profilSefa.Show();
            }
            else if(stranica=="vodja")
            {
                Vodja vodja = new Vodja();
                vodja = DataProvider.vratiVodjuPoEmailu(txtUser.Text);
                //vratiSefa(txtUser.Text);
                ProfilVodja profilVodje = new ProfilVodja(vodja);
                profilVodje.Show();
            }
            else if(stranica=="radnik")
            {
                Radnik radnik = new Radnik();
                radnik = DataProvider.vratiRadnikaPoEmailu(txtUser.Text);
                //vratiSefa(txtUser.Text);
                ProfilRadnik profilRadnika = new ProfilRadnik(radnik);
                profilRadnika.Show();
            }
            //MessageBox.Show(stranica);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
