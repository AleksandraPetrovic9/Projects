using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid19
{
    public partial class FormAddData : Form
    {
        public string country;
        public FormAddData()
        {
            InitializeComponent();
        }
        public FormAddData(string c)
        {
            InitializeComponent();
           this.country = c;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("dd/MM/yyyy");
           // MessageBox.Show(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            string cases = numCases.Value.ToString();
            string deaths = numDeaths.Value.ToString();
            string recovered = numRecovered.Value.ToString();

            DataProvider.AddData(country, date, cases, deaths, recovered);
           // MessageBox.Show("Successfully add data.");
        }

        private void FormAddData_Load(object sender, EventArgs e)
        {
            textBox1.Text = country;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddData_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                           this.DisplayRectangle);
        }
    }
}
