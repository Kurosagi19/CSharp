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
            string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            // Hiển thị dữ liệu từ database ra windows form
            string sql = "SELECT * FROM school";
            SqlDataAdapter da = new SqlDataAdapter(sql, strCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "school");
            dtgSchool.DataSource = ds.Tables["school"].DefaultView;

            // Đổi tên cột
            dtgSchool.Columns[0].HeaderText = "ID";
            dtgSchool.Columns[1].HeaderText = "School Name";
            dtgSchool.Columns[2].HeaderText = "Teacher Number";
            dtgSchool.Columns[3].HeaderText = "Student Number";
            // Kích cỡ cột tự động
            dtgSchool.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();

            txtTeacherNum.Enabled = false;
            txtSchoolName.Enabled = false;
            txtStudentNum.Enabled = false;
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
            txtSchoolName.Enabled = true;
            txtSchoolName.Text = "";
            txtTeacherNum.Enabled = true;
            txtTeacherNum.Text = "";
            txtStudentNum.Enabled = true;
            txtStudentNum.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtSchoolName.Enabled = false;
            txtTeacherNum.Enabled = false;
            txtStudentNum.Enabled = false;

            // Lưu dữ liệu vào database
            string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string sql = "INSERT INTO school (school_name, teacher_num, student_num) VALUES ('"+ txtSchoolName.Text +"', '"+ txtTeacherNum.Text +"', '"+ txtStudentNum.Text +"')";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Added !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
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
            txtTeacherNum.Enabled = false;
            txtTeacherNum.Text = "";
            txtSchoolName.Enabled = false;
            txtSchoolName.Text = "";
            txtStudentNum.Enabled = false;
            txtStudentNum.Text = "";
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
            if(txtID.Text == "")
            {
                MessageBox.Show("Please input ID");
            } else
            {
                string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
                SqlConnection con = new SqlConnection(strCon);
                con.Open();

                string sql = "DELETE FROM school WHERE id = " + txtID.Text + "";

                SqlCommand command = new SqlCommand(sql, con);
                command.ExecuteNonQuery();
                MessageBox.Show("Deleted !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData();
            }
        }

        //private int number = 0;
        private void dtgSchool_SelectionChanged(object sender, EventArgs e)
        {
            string schoolName = dtgSchool.Rows[0].Cells["school_name"].Value.ToString();
            txtSchoolName.Text = schoolName;
            string iD = dtgSchool.Rows[0].Cells["id"].Value.ToString();
            txtID.Text = iD;

            try
            {
                DataGridViewRow row = this.dtgSchool.SelectedRows[0];
                string ID = row.Cells["id"].Value.ToString();
                string SchoolName = row.Cells["school_name"].Value.ToString();
                string TeacherNum = row.Cells["teacher_num"].Value.ToString();
                string StudentNum = row.Cells["student_num"].Value.ToString();
                txtID.Text = ID;
                txtSchoolName.Text = SchoolName;
                txtTeacherNum.Text = TeacherNum;
                txtStudentNum.Text = StudentNum;
            } catch (Exception ex)
            {

            }

            //number++;
            //MessageBox.Show("You have clicked 1 row in DataGridView " + number + " time");
        }

        private void dtgSchool_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtgSchool.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            btnUpdate.Enabled = true;

            txtID.Enabled = true;
            txtSchoolName.Enabled = true;
            txtTeacherNum.Enabled = true;
            txtStudentNum.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string sql = $"UPDATE school SET school_name = '{txtSchoolName.Text}' WHERE id = {txtID.Text}";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Updated !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
        }
    }
}
