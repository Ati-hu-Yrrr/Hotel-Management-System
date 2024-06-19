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
    public partial class CustomerDetails : UserControl
    {
        function fn = new function();
        string query;
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                query = "select Customer.Cid, Customer.Cname,Customer.mobile,Customer.nationality,Customer.gender, Customer.dob,Customer.idproof, Customer.address,Customer.checkin,Customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from Customer inner join rooms on Customer.roomId=rooms.roomId";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if(txtSearchBy.SelectedIndex == 1)
            { query = "select Customer.Cid, Customer.Cname,Customer.mobile,Customer.nationality,Customer.gender, Customer.dob,Customer.idproof, Customer.address,Customer.checkin,Customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from Customer inner join rooms on Customer.roomId=rooms.roomId where checkout is null";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                query = "select Customer.Cid, Customer.Cname,Customer.mobile,Customer.nationality,Customer.gender, Customer.dob,Customer.idproof, Customer.address,Customer.checkin,Customer.checkout,rooms.roomNo,rooms.roomType,rooms.bed,rooms.price from Customer inner join rooms on Customer.roomId=rooms.roomId where checkout is not null";
                DataSet ds = fn.GetData(query);
                guna2DataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
