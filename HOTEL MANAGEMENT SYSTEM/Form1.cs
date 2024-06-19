using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        function fn = new function();
        string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
           

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query ="select username,pass from employee where username ='"+txtuser.Text+"' and pass ='"+txtpassword.Text+"'";
            DataSet ds = fn.GetData(query);



            if (ds.Tables[0].Rows.Count !=0)
            {
                labelerror.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();

            }
            else
            {
                labelerror.Visible = true;
                txtpassword.Clear();
            }
         }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = true ;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
        }

       
    }
}
