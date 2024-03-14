using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uiui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textPassword.Text;
            string user = textUser.Text;

            if ( password =="ds@etefmc" && user == "admin")
            {
                MessageBox.Show("Login confirmado!");
            }
            else
            {
                lblAnswer.Text = "Login ou senha incorreto, tente novamente";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
