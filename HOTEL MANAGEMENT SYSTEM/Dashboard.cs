using HOTEL_MANAGEMENT_SYSTEM.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomerRegistration_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnCustomerRegistration.Left +18;
            uC_AddRoom1.Visible = false;
            uC_CustomerCheckOut1.Visible = false;
            uC_CustomerRegistration1.Visible = true;
            uC_CustomerRegistration1.BringToFront();
            customerDetails1.Visible = false;
            uC_Employee1.Visible = false;
           

        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            MovingPanel.Left = btnRoom.Left + 18;
            uC_AddRoom1.Visible = true;
            uC_CustomerRegistration1.Visible = false;
            uC_CustomerCheckOut1.Visible = false;
            customerDetails1.Visible = false;
            uC_Employee1.Visible = false;



        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible=false;
            uC_CustomerRegistration1.Visible = false;
            uC_CustomerCheckOut1.Visible = true;
            uC_CustomerCheckOut1.BringToFront() ;
            MovingPanel.Left = btnCheckout.Left +12;
            customerDetails1.Visible = false;
            uC_Employee1.Visible = false;

        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            customerDetails1.Visible = true;
            customerDetails1.BringToFront();
            uC_AddRoom1.Visible=false ;
            uC_CustomerCheckOut1.Visible=false ;
            uC_CustomerRegistration1.Visible=false;
            uC_Employee1.Visible=false;

            MovingPanel.Left = btnCustomerDetail.Left +12;
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            uC_CustomerRegistration1.Visible=false;
            uC_CustomerCheckOut1.Visible=false;
            uC_AddRoom1.Visible=false ;
            customerDetails1.Visible=false;
            uC_Employee1.Visible = true;
            MovingPanel.Left = btnStaff.Left +12;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            uC_AddRoom1.Visible = false;
            uC_CustomerRegistration1.Visible = false;
            btnRoom.PerformClick();
        }

        private void uC_CustomerCheckOut1_Load(object sender, EventArgs e)
        {

        }

        private void uC_CustomerRegistration1_Load(object sender, EventArgs e)
        {
                    }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void uC_CustomerCheckOut1_Load_1(object sender, EventArgs e)
        {

        }

        private void uC_Employee1_Load(object sender, EventArgs e)
        {

        }
    }
}
