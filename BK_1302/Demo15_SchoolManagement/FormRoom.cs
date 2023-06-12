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
using System.Xml.Linq;

namespace Demo15_SchoolManagement
{
    public partial class FormRoom : Form
    {
        public FormRoom()
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
            string sql = "SELECT * FROM room INNER JOIN building ON room.building_id = building.building_id";
            SqlDataAdapter da = new SqlDataAdapter(sql, strCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "room");
            dtgRoom.DataSource = ds.Tables["room"].DefaultView;

            // Đổi tên cột
            dtgRoom.Columns[0].HeaderText = "Room ID";
            dtgRoom.Columns[1].HeaderText = "Room Name";
            dtgRoom.Columns[2].HeaderText = "Room Number";
            dtgRoom.Columns[3].HeaderText = "Floor";
            dtgRoom.Columns[4].HeaderText = "Building ID";
            dtgRoom.Columns[5].HeaderText = "Building ID";
            dtgRoom.Columns[6].HeaderText = "Building Name";
            dtgRoom.Columns[7].HeaderText = "Building Address";

            // Kích cỡ cột tự động
            dtgRoom.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            loadData();

            txtRoomName.Enabled = false;
            txtRoomNumber.Enabled = false;
            txtFloor.Enabled = false;
            txtBuildingID.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtRoomName.Enabled = true;
            txtRoomNumber.Enabled = true;
            txtFloor.Enabled = true;
            txtBuildingID.Enabled = true;

            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtRoomName.Enabled = true;
            txtRoomNumber.Enabled = true;
            txtFloor.Enabled = true;
            txtBuildingID.Enabled = true;

            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtRoomName.Enabled = false;
            txtRoomNumber.Enabled = false;
            txtFloor.Enabled = false;
            txtBuildingID.Enabled = false;

            string strCon = "Server = Kurosagi19; Database = ASSIGNMENT; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string sql = $"UPDATE room SET room_name = '{txtRoomName.Text}', room_number = '{txtRoomNumber.Text}', floor_number = '{txtFloor.Text}', building_id = '{txtBuildingID.Text}' WHERE room_id = {txtRoomID.Text}";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Updated !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            txtRoomName.Enabled = false;
            txtRoomNumber.Enabled = false;
            txtFloor.Enabled = false;
            txtBuildingID.Enabled = false;

            if (txtRoomID.Text == "")
            {
                MessageBox.Show("Please input ID");
            }
            else
            {
                string strCon = "Server = Kurosagi19; Database = ASSIGNMENT; Trusted_Connection = true";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();

                string sql = "DELETE FROM building WHERE building_id = " + txtRoomID.Text + "";

                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtRoomName.Text = "";
                txtRoomNumber.Text = "";
                txtFloor.Text = "";
                txtBuildingID.Text = "";

                loadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtRoomName.Enabled = false;
            txtRoomNumber.Enabled = false;
            txtFloor.Enabled = false;
            txtBuildingID.Enabled = false;

            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            string strCon = "Server = Kurosagi19; Database = ASSIGNMENT; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string sql = "INSERT INTO room (room_name, room_number, floor_number, building_id) VALUES ('"+ txtRoomName.Text +"', "+ txtRoomNumber.Text +", "+ txtFloor.Text +", "+ txtBuildingID.Text +")";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Saved !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtRoomID.Enabled = false;
            txtRoomID.Text = "";
            txtRoomName.Enabled = false;
            txtRoomName.Text = "";
            txtFloor.Enabled = false;
            txtFloor.Text = "";
            txtBuildingID.Enabled = false;
            txtBuildingID.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Exit?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var formLogin = new FormLogin();
                formLogin.Closed += (s, args) => this.Close();
                formLogin.Show();
            }
        }

        private void btnBuilding_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formBuilding = new FormBuilding();
            formBuilding.Closed += (s, args) => this.Close();
            formBuilding.Show();
        }

        private void dtgRoom_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dtgRoom.SelectedRows[0];
                string roomID = row.Cells["room_id"].Value.ToString();
                string roomName = row.Cells["room_name"].Value.ToString();
                string roomNumber = row.Cells["room_number"].Value.ToString();
                string floorNumber = row.Cells["floor_number"].Value.ToString();
                string buildingID = row.Cells["building_id"].Value.ToString();
                txtRoomID.Text = roomID;
                txtRoomName.Text = roomName;
                txtRoomNumber.Text = roomNumber;
                txtFloor.Text = floorNumber;
                txtBuildingID.Text = buildingID;
            }
            catch (Exception ex)
            {

            }
        }

        private void dtgRoom_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtgRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
