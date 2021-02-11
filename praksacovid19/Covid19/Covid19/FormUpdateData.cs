using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Covid19.QueryEntities;

namespace Covid19
{
    public partial class FormUpdateData : Form
    {
        string country;
        public FormUpdateData()
        {
            InitializeComponent();
        }
        public FormUpdateData(string c)
        {
            this.country = c;
            InitializeComponent();
        }
        private void FormUpdateData_Load(object sender, EventArgs e)
        {


        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            DateInfo di,di1;
            di= DataProvider.DateForOneDay(country, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            di1 = DataProvider.DateForOneDay(country, dateTimePicker1.Value.ToString("d/M/yyyy"));
           
            if ( di==null && di1 == null)
            {
                MessageBox.Show("There isn't data for that day.");
            }
            else if (di!=null) { 
                numcases.Value = Convert.ToInt32(di.NewCases.Trim());
                numdeaths.Value = Convert.ToInt32(di.NewDeaths.Trim());
                numrecovered.Value = Convert.ToInt32(di.NewRecovered.Trim());
            }
            else if(di1!=null)
            {
                numcases.Value = Convert.ToInt32(di1.NewCases.Trim());
                numdeaths.Value = Convert.ToInt32(di1.NewDeaths.Trim());
                numrecovered.Value = Convert.ToInt32(di1.NewRecovered.Trim());
            }
         
        }

        private void button1_Click(object sender, EventArgs e)//update
        {
            DataProvider.UpdateData(country, dateTimePicker1.Value.ToString("dd/MM/yyyy"), numcases.Value.ToString(), numdeaths.Value.ToString(), numrecovered.Value.ToString());
           // MessageBox.Show("Data was updated.");
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataProvider.DeleteData(country, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            numcases.Value = 0;
            numdeaths.Value = 0;
            numrecovered.Value = 0;
          
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUpdateData_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                          this.DisplayRectangle);
        }
    }
}
