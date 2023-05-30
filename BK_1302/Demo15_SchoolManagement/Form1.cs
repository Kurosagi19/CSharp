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

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTeacherName.Enabled = false;
            txtSchoolName.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            // Save to Database
            string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            // Show data from Database to WinForm
            string sql = "SELECT * FROM school";
            SqlDataAdapter da = new SqlDataAdapter(sql, strCon);
            DataSet ds = new DataSet();
            da.Fill(ds, "school");
            dtgSchool.DataSource = ds.Tables["school"].DefaultView;

            // Change column name
            dtgSchool.Columns[0].HeaderText = "ID";
            dtgSchool.Columns[1].HeaderText = "School Name";
            dtgSchool.Columns[2].HeaderText = "Teacher Name";

            dtgSchool.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
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
            txtTeacherName.Enabled = true;
            txtSchoolName.Enabled = true;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;

            // Save to Database
            string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string schoolName = txtSchoolName.Text;
            string sql = "INSERT INTO school (school_name) VALUES ('"+ schoolName +"')";
            //string sql = "UPDATE school SET school_name = 'School 2' WHERE id = 1";
            //string sql = "DELETE FROM school WHERE id = 1";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Add successful !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtTeacherName.Enabled = false;
            txtTeacherName.Text = "";
            txtSchoolName.Enabled = false;
            txtSchoolName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do your parents know u r gay?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            //string schoolName = txtSchoolName.Text;
            //string sql = "INSERT INTO school (school_name) VALUES ('" + schoolName + "')";
            //string sql = "UPDATE school SET school_name = 'School 2' WHERE id = 1";
            string sql = "DELETE FROM school WHERE id = 1";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
            MessageBox.Show("Deleted !", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save to Database
            string strCon = "Server = Kurosagi19; Database = C1302; Trusted_Connection = true";
            SqlConnection con = new SqlConnection(strCon);
            con.Open();

            string sql = "SELECT * FROM school";
            //string schoolName = txtSchoolName.Text;
            //string sql = "INSERT INTO school (school_name) VALUES ('" + schoolName + "')";
            //string sql = "UPDATE school SET school_name = 'School 2' WHERE id = 1";
            //string sql = "DELETE FROM school WHERE id = 1";

            SqlCommand command = new SqlCommand(sql, con);
            command.ExecuteNonQuery();
        }

        private void dtgSchool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgSchool_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtgSchool_SelectionChanged(object sender, EventArgs e)
        {
            string schoolName = dtgSchool.Rows[0].Cells["school_name"].Value.ToString();
            txtSchoolName.Text = schoolName;
        }
    }
}
