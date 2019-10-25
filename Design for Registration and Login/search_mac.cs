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
    public partial class search_mac : Form
    {
        public search_mac()
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

        private void button1_Click(object sender, EventArgs e)
        {
            variable.MAC.Search_by_name_size_color(comboBox1.Text, Convert.ToInt32(comboBox3.Text), comboBox2.Text);
        }

        private void search_mac_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
