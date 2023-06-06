using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo15_SchoolManagement
{
    public partial class FormComboBox : Form
    {
        public FormComboBox()
        {
            InitializeComponent();
        }

        private void FormComboBox_Load(object sender, EventArgs e)
        {
            var listCategory = new List<object>();

            // Tạo đối tượng ẩn danh
            var cat1 = new {id = "1", catName = "Car"};
            listCategory.Add(cat1);

            var cat2 = new { id = "2", catName = "Bike" };
            listCategory.Add(cat2);

            MessageBox.Show(listCategory.Count.ToString());

            cbbCategory.ValueMember = "id";
            cbbCategory.DisplayMember = "catName";

            // Hiện Data trong list ra ComboBox
            cbbCategory.DataSource = listCategory;
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string catName = cbbCategory.Text;
            MessageBox.Show(catName);

            // Hiện dữ liệu được lưu trong listCategory ra
            //string cbbData = cbbCategory.Items[cbbCategory.SelectedIndex].ToString();
            //MessageBox.Show(cbbData);

            // Hiện id
            //MessageBox.Show(cbbCategory.SelectedValue.ToString());

            int id = Int32.Parse(cbbCategory.SelectedValue.ToString());
            MessageBox.Show(id.ToString());
        }
    }
}
