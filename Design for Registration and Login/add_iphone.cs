using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class add_iphone : Form
    {
        public add_iphone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variable.IPHONE.Add_product(comboBox1.Text, Convert.ToInt32(comboBox3.Text), Convert.ToDouble(textBox1.Text), comboBox2.Text);

              variable.IPHONE.Display();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addProduct f1 = new addProduct();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
