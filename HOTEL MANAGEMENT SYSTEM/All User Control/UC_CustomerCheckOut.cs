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
    public partial class UC_CustomerCheckOut : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerCheckOut()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UC_CustomerCheckOut_Load(object sender, EventArgs e)
        {
            query = "select Customer.Cid,Customer.Cname,Customer.mobile,Customer.nationality,Customer.gender,Customer.dob,Customer.idproof,Customer.address,Customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from Customer inner join rooms on Customer.roomId=rooms.roomId where chekout='No'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select Customer.Cid,Customer.Cname,Customer.mobile,Customer.nationality,Customer.gender,Customer.dob,Customer.idproof,Customer.address,Customer.checkin,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from Customer inner join rooms on Customer.roomId=rooms.roomId where Cname like '"+txtName.Text+ "%' and chekout = 'No'";
            DataSet ds = fn.GetData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }

        int id;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()) ;
                txtCName.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() ;
                txtRoom.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString() ;
            }

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(txtCName.Text != "")
            {
                if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    string cdate = txtChechOutDate.Text ;
                    query = "update Customer set chekout='Yes', checkout ='"+cdate+"' where cid="+id+" update rooms set booked ='No' where roomNo ='" + txtRoom.Text + "'";
                    fn.SetData(query, "Check Out Successfull...");
                    UC_CustomerCheckOut_Load(this, null);
                    ClearAll ();

                }
            }
            else
            {
                MessageBox.Show("No Customer is Selected .","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        public void ClearAll()
        {
            txtCName.Clear();
            txtRoom.Clear();
            txtName.Clear();
            txtChechOutDate.ResetText();
        }

        private void UC_CustomerCheckOut_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
