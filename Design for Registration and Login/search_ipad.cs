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
    public partial class search_ipad : Form
    {
        public search_ipad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_product f1 = new search_product();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            variable.IPAD.Search_by_name_size_color(comboBox1.Text, Convert.ToInt32(comboBox3.Text), comboBox2.Text);
        }
    }
}
