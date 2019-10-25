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
    public partial class add_apple_watch : Form
    {
        public add_apple_watch()
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
            variable.APPLE_WATCH.Add_product(comboBox1.Text, Convert.ToInt32(comboBox3.Text), Convert.ToDouble(textBox1.Text), comboBox2.Text);

            variable.APPLE_WATCH.Display();
        }

        private void add_apple_watch_Load(object sender, EventArgs e)
        {

        }
    }
}
