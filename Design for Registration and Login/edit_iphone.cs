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
    public partial class edit_iphone : Form
    {
        public edit_iphone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           edit_product f1 = new edit_product();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void edit_iphone_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            variable.IPHONE.edit_By_name_color_size(comboBox1.Text,Convert.ToInt32(comboBox2.Text),Convert.ToDouble(textBox1.Text),comboBox3.Text,comboBox9.Text,comboBox8.Text, Convert.ToInt32(comboBox7.Text));
        }
    }
}
