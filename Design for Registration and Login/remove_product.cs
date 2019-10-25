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
    public partial class remove_product : Form
    {
        public remove_product()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            admin_interface f1 = new admin_interface();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            remove_iphone f1 = new remove_iphone();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            remove_ipad f1 = new remove_ipad();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            remove_mac f1 = new remove_mac();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            remove_apple_watch f1 = new remove_apple_watch();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void remove_product_Load(object sender, EventArgs e)
        {

        }
    }
}
