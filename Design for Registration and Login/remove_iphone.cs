using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class remove_iphone : Form
    {
        public remove_iphone()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            remove_product f1 = new remove_product();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            variable.IPHONE.Delete_Product_AtSpecific_name_size_color(comboBox1.Text,Convert.ToInt32(comboBox3.Text),comboBox2.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
