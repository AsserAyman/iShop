using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;

namespace WindowsFormsApp1
{
    public partial class add_ipad : Form
    {
        public add_ipad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addProduct f1 = new addProduct();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            variable.IPAD.Add_product(comboBox1.Text, Convert.ToInt32(comboBox3.Text), Convert.ToDouble(textBox1.Text), comboBox2.Text);

            variable.IPAD.Display();
        }
    }
}
