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
using Design_for_Registration_and_Login;

namespace WindowsFormsApp2
{
    public partial class admin_interface : Form
    {
        //public static products newproduct = new products();

        public admin_interface()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            addProduct f1 = new addProduct();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            remove_product f1 = new remove_product();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit_product f1 = new edit_product();
            this.Hide();
            f1.ShowDialog();
            this.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            variable.IPHONE.clear();
            variable.IPAD.clear();
            variable.MAC.clear();
            variable.APPLE_WATCH.clear();
            variable.IPHONE.Display();
            variable.IPAD.Display();
            variable.MAC.Display();
            variable.APPLE_WATCH.Display();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            search_product f1 = new search_product();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            display f1 = new display();
            this.Hide();
            f1.ShowDialog();
            this.Close();
            //variable.IPHONE.Display();
            //variable.IPAD.Display();
            //variable.MAC.Display();
            //variable.APPLE_WATCH.Display();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
