using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo07_WinFormApp
{
    public partial class MainTitle : Form
    {
        public MainTitle()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get value
            //string title = lbTitle.Text;
            //MessageBox.Show(title);

            // Set value
            //lbTitle.Text = "404 NOT FOUND";

            // Change Text Color
            lbTitle.ForeColor = Color.White;
            // Change Background Color
            lbTitle.BackColor = Color.Red;

            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("Value: " + txtNum1.Text);
        }

        private void MainTitle_Resize(object sender, EventArgs e)
        {
            MessageBox.Show("Lolicon detected ! Calling police !");
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Something Happened");
            string a = txtNum1.Text;
            int numa = int.Parse(a);

            string b = txtNum2.Text;
            int numb = int.Parse(b);

            int result = numa + numb;

            txtResult.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void txtClearAll_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResult.Text = "";
        }
    }
}
