using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  Covid19.QueryEntities;
namespace Covid19
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text, password= txtPassword.Text;
            Admin admin = DataProvider.Login(email,password);
            if (admin == null)
            {
                MessageBox.Show("The email or password is incorrect.");
            }
           
              
                FormAdmin fa = new FormAdmin(admin);
                fa.Show();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 5),
                           this.DisplayRectangle);
        }
    }
}
