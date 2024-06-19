using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGEMENT_SYSTEM.All_User_Control
{
    public partial class UC_CustomerRegistration : UserControl
    {
        function fn = new function();
        string query;
        public UC_CustomerRegistration()
        {
            InitializeComponent();
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    public void setComboBox(string query , ComboBox combo)
        {
            SqlDataReader sdr = fn.getforcombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i< sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
                
            }
            sdr.Close();
        }

        private void txtRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
            query = "select roomNo from rooms where bed ='" + txtBed.Text + "' and roomType = '" + txtRoom.Text + "' and booked = 'No'";
            setComboBox(query,txtRoomNo);
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoom.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }
        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price , roomId from rooms where roomNo = '"+txtRoomNo.Text+"' ";
            DataSet ds = fn.GetData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void UC_CustomerRegistration_Load(object sender, EventArgs e)
        {

        }

        private void btnAlloteRoom_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtContact.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtdob.Text != "" && txtIdProof.Text != "" && txtAddress.Text != "" && txtCheckIn.Text != "" && txtPrice.Text != "")
            {
                string name = txtName.Text;
                Int64 mobile = Int64.Parse(txtContact.Text);
                string national = txtNationality.Text;
                string gender = txtGender.Text;
                string dob = txtdob.Text;
                string idproof = txtIdProof.Text;
                string address = txtAddress.Text;
                string checkin = txtCheckIn.Text;
                query = "insert into Customer(cname,mobile,nationality,gender,dob,idproof,address,checkin,roomId) values ('"+name+"',"+mobile+",'"+national+"','"+gender+ "','"+dob+ "','"+idproof+ "','"+address+ "','"+checkin+"',"+rid+") update rooms set booked='Yes' where roomNo='"+txtRoomNo.Text+"' ";
                fn.SetData(query, "RoomNo" + txtRoomNo.Text + "Allocation Successful"); 
                clearAll();
            }
            else
            {
                MessageBox.Show("All Field Are Madetory.","Information !!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void clearAll()
        {
            txtName.Clear();
            txtContact.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtdob.ResetText();
            txtIdProof.Clear();
            txtAddress.Clear();
            txtCheckIn.ResetText();
            txtBed.SelectedIndex = -1;
            txtRoomNo.SelectedIndex = -1;
            txtRoom.SelectedIndex = -1;
            txtPrice.Clear();
            
        }

        private void UC_CustomerRegistration_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
