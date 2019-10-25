using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Design_for_Registration_and_Login
{
    public partial class MainPage : Form
    {  
        public MainPage()
        {
            InitializeComponent();
            Public.LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register f1 = new Register();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
