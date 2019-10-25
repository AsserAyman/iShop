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
    public partial class search_product : Form
    {
        public search_product()
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
           search_iphone f1 = new search_iphone();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            search_ipad f1 = new search_ipad();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            search_mac f1 = new search_mac();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search_apple_watch f1 = new search_apple_watch();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void search_product_Load(object sender, EventArgs e)
        {

        }
    }
}
