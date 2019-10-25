using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Design_for_Registration_and_Login
{
    public partial class Feedback : Form
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = Public.user.getUsername() + "\n" + textBox1.Text + "\n";
            File.WriteAllText(Public.feedbackPath, x);
            MessageBox.Show("Thankyou for your feedback", ":)");
            LastForm f1 = new LastForm();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
    }
}
