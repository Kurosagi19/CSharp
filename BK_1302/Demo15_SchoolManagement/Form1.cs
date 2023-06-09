using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo15_SchoolManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            // Kết nối với database
            string strCon = "Server = Kurosagi19; Database = ASSIGNMENT; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            // Hiển thị dữ liệu từ database ra windows form
            string sql = "SELECT * FROM building";
            SqlDataAdapter da = new SqlDataAdapter(sql, strCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "building");
            dtgBuilding.DataSource = ds.Tables["building"].DefaultView;

            // Đổi tên cột
            dtgBuilding.Columns[0].HeaderText = "ID";
            dtgBuilding.Columns[1].HeaderText = "Building Name";
            dtgBuilding.Columns[2].HeaderText = "Address";
            dtgBuilding.Columns[3].HeaderText = "Room Quantity";
            // Kích cỡ cột tự động
            dtgBuilding.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();

            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtRoomQuantity.Enabled = false;
            txtID.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSchoolName_Click(object sender, EventArgs e)
        {

        }

        private void txtSchoolName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtID.Enabled = true;
            txtID.Text = "";
            txtAddress.Enabled = true;
            txtAddress.Text = "";
            txtName.Enabled = true;
            txtName.Text = "";
            txtRoomQuantity.Enabled = true;
            txtRoomQuantity.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtID.Enabled = false;
            txtID.Text = "";
            txtName.Enabled = false;
            txtName.Text = "";
            txtAddress.Enabled = false;
            txtAddress.Text = "";
            txtRoomQuantity.Enabled = false;
            txtRoomQuantity.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtID.Enabled = false;
            txtAddress.Enabled = false;
            txtName.Enabled = false;
            txtRoomQuantity.Enabled = false;

            if (txtID.Text == "")
            {
                MessageBox.Show("Please input ID");
            } else
            {
                string strCon = "Server = Kurosagi19; Database = ASSIGNMENT; Trusted_Connection = true";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();

                string sql = "DELETE FROM building WHERE building_id = " + txtID.Text + "";

                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtID.Text = "";
                txtName.Text = "";
                txtAddress.Text = "";
                txtRoomQuantity.Text = "";

                loadData();
            }
        }

        //private int number = 0;
        private void dtgSchool_SelectionChanged(object sender, EventArgs e)
        {
            //string buildingName = dtgBuilding.Rows[0].Cells["name"].Value.ToString();
            //txtAddress.Text = buildingName;
            //string iD = dtgBuilding.Rows[0].Cells["building_id"].Value.ToString();
            //txtID.Text = iD;

            try
            {
                DataGridViewRow row = this.dtgBuilding.SelectedRows[0];
                string ID = row.Cells["building_id"].Value.ToString();
                string BuildingName = row.Cells["name"].Value.ToString();
                string Address = row.Cells["address"].Value.ToString();
                string RoomQuantity = row.Cells["room_quantity"].Value.ToString();
                txtID.Text = ID;
                txtName.Text = BuildingName;
                txtAddress.Text = Address;
                txtRoomQuantity.Text = RoomQuantity;
            } catch (Exception ex)
            {

            }

            //number++;
            //MessageBox.Show("You have clicked 1 row in DataGridView " + number + " time");
        }

        private void dtgSchool_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtgBuilding.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            txtID.Enabled = true;
            txtAddress.Enabled = true;
            txtName.Enabled = true;
            txtRoomQuantity.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtID.Enabled = false;
            txtAddress.Enabled = false;
            txtName.Enabled = false;
            txtRoomQuantity.Enabled = false;

            string strCon = "Server = Kurosagi19; Database = ASSIGNMENT; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string sql = $"UPDATE building SET name = '{txtName.Text}', address = '{txtAddress.Text}', room_quantity = {txtRoomQuantity.Text} WHERE building_id = {txtID.Text}";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Updated !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtID.Enabled = false;
            txtAddress.Enabled = false;
            txtName.Enabled = false;
            txtRoomQuantity.Enabled = false;

            string strCon = "Server = Kurosagi19; Database = ASSIGNMENT; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string sql = "INSERT INTO building (name, address, room_quantity) VALUES ('"+txtName.Text+"', '"+txtAddress.Text+"', '"+txtRoomQuantity.Text+"')";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Saved !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
        }
    }
}
