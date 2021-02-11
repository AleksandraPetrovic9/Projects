using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCompany
{
    public partial class IsplataRadnik : Form
    {
        public List<String> lista;
        public IsplataRadnik(List<String> lista)
        {
            InitializeComponent();
            this.lista = lista;
          
        }

        private void IsplataRadnik_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < lista.Count; i += 2)
            {
                dgvIsplata.Rows.Add(lista.ElementAt(i), lista.ElementAt(i + 1));
            }
            
        }

    
        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IsplataRadnik_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                         this.DisplayRectangle);
        }
    }
}
