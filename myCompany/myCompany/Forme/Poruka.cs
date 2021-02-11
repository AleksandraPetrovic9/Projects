using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myCompany.Forme
{
    public partial class Poruka : Form
    {
        public Poruka(String poruka)
        {
            InitializeComponent();
            lblPoruka.ForeColor = Color.White;
            lblPoruka.Text = poruka;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Poruka_Paint_1(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                          this.DisplayRectangle);
        }
    }
}
