using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.All_User_Control
{
    public partial class UC_Employee : UserControl
    {
        function fn = new function();
        string query;
        public UC_Employee()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            
            getMaxID();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text !="" && txtMobile.Text !="" && txtGender.Text != "" &&  txtEmail.Text != "" && txtUsername.Text!= "" &&  txtPassword.Text !="")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string pass = txtPassword.Text;
                query = "insert into employee (ename,mobile,gender,emailid,username,pass) values ('"+name+ "',"+mobile+ ",'"+gender+ "','"+email+ "','"+username+ "','"+pass+"')";
                fn.SetData(query , "Employee Registered.");

                ClearAll();
                getMaxID();
            }
            else
            {
                MessageBox.Show("Fill All Fields","warning......!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(guna2DataGridView1);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(guna2DataGridView2);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Are U Sure", "Confirmation........!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid=" + txtID.Text + "";
                    fn.SetData(query, "Record Deleted Sucessfully.");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }

        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }






        //*****************************************
        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSet.Text = (num + 1).ToString();
            }
        }

        public void ClearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }
        public void setEmployee(DataGridView dgv)
        {
            query = "select * from employee";
            DataSet ds = fn.GetData(query);
            dgv.DataSource = ds.Tables[0];

        }

        
    }
}
