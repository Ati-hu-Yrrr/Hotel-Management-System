using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.All_User_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtRoomNo.Text != "" && txtType.Text !="" && txtBed.Text != "" && txtPrice.Text != "")
            {
                string roomno= txtRoomNo.Text;
                string type= txtType.Text; 
                string bed = txtBed.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query = "insert into rooms(roomNo,roomType,Bed,Price)values( '"+roomno+"','"+type+"','"+bed+"','"+price+"' )";
                fn.SetData(query, "ROOM ADDED.");
                UC_AddRoom_Load(this,null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Fill All Fields","Warning !!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "Select * from Rooms";
            DataSet ds = fn.GetData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtType.SelectedIndex=-1;
            txtBed.SelectedIndex=-1;
            txtPrice.Clear();

        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this,null);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
