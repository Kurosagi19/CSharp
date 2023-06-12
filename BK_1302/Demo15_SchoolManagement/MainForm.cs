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

namespace Demo15_SchoolManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

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
    }
}
