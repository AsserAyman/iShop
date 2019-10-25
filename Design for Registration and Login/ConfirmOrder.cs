using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_for_Registration_and_Login
{
    public partial class ConfirmOrder : Form
    {
        public ConfirmOrder()
        {
            InitializeComponent();
            label3.Text = "Hello " +  Public.user.getFirstName() + " " + Public.user.getLastName() + ",";
            label2.Text = $"We are Glad to tell you your order has been confirmed \n" +
                $"We will contact you according to your email \n {Public.user.getEmail()} \n" +
                $"and your Mobile is \n {Public.user.getMobile()} \n" +
                $"and your Address is {Public.user.getAddress()} " +
                $"\n\n\n\n " +
                $"Thanks for using our service";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LastForm f = new LastForm();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
