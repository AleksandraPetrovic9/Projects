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
    public partial class SelfAssessmentTest : Form
    {
        public SelfAssessmentTest()
        {
            InitializeComponent();
        }

        private void btnProsledi_Click(object sender, EventArgs e)
        {
            if(txtMail.Text == "")
            {
                MessageBox.Show("Enter mail address!");
                return;
            }
            String result = "False";

            if (numTemp.Value > 38)
                result = "True";
            else
            {
                if(cbKasalj.Checked && cbDisanje.Checked && cbUmor.Checked && cbMisici.Checked && cbDah.Checked)
                    result = "True";
                else if(cbKasalj.Checked && cbDisanje.Checked)
                    result = "True";
                else if (cbKasalj.Checked && cbUmor.Checked)
                    result = "True";
                else if (cbKasalj.Checked && cbMisici.Checked)
                    result = "True";
                else if (cbKasalj.Checked && cbDah.Checked)
                    result = "True";
                else if(cbKasalj.Checked && cbMisici.Checked && cbDah.Checked)
                    result = "True";
                else if (cbKasalj.Checked && cbDisanje.Checked && cbUmor.Checked)
                    result = "True";
                else if (cbKasalj.Checked && cbDisanje.Checked && cbDah.Checked)
                    result = "True";
                else if (cbKasalj.Checked && cbUmor.Checked && cbMisici.Checked && cbDah.Checked)
                    result = "True";
            }

            DataProvider.AddSymptom(txtMail.Text, cbKasalj.Checked.ToString(), cbDisanje.Checked.ToString(), cbUmor.Checked.ToString(), numTemp.Value.ToString(), cbMisici.Checked.ToString(), cbDah.Checked.ToString(), result);

            if (result.Equals("True"))
                MessageBox.Show("It is necessary to contact a doctor!");
            else
                MessageBox.Show("It is not necessary to contact a doctor!");

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelfAssessmentTest_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                          this.DisplayRectangle);
        }
    }
}
