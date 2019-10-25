using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp2
{
    public partial class addProduct : Form
    {
        public addProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_iphone f1 = new add_iphone();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin_interface f1 = new admin_interface();
             this.Hide();
             f1.ShowDialog();
             this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_ipad f1 = new add_ipad();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add_mac f1 = new add_mac();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            add_apple_watch f1 = new add_apple_watch();
            this.Hide();
            f1.ShowDialog();
            this.Close();
    }

        private void addProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
