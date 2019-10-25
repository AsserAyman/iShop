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
    public partial class Forgot_Password : Form
    {
        List<String> securityList = new List<string>();
        public Forgot_Password()
        {
            InitializeComponent();


 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           /* if (textBox1.Text.Trim() != "" &&
                textBox9.Text.Trim() != "" &&
                textBox2.Text.Trim() != "" &&
                textBox3.Text.Trim() != "" &&
                textBox4.Text.Trim() != ""
                )
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }*/
        }

     

        private void button2_Click_1(object sender, EventArgs e)
        {
            var admin = Public.IdentifyAdmin(Public.admins, textBox9.Text, textBox1.Text, comboBox3.Text,
               textBox2.Text);
            var user = Public.IdentifyUser(Public.users, textBox9.Text, textBox1.Text, comboBox3.Text,
                textBox2.Text);

            if (Public.admins.Contains(admin))
            {
                if (textBox4.Text == textBox3.Text)
                {
                    admin.setPassword(textBox3.Text);
                    MessageBox.Show("Password successfully changed :)", "Success");
                    Public.SaveData();

                    Login f = new Login();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match", "Failed");
                }
            }
            else if (Public.users.Contains(user))
            {
                if (textBox4.Text == textBox3.Text)
                {
                    user.setPassword(textBox3.Text);
                    MessageBox.Show("Password successfully changed :)", "Success");
                    Public.SaveData();
                    Login f = new Login();
                    this.Hide();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password does not match", "Failed");
                }
            }
            else
            {
                MessageBox.Show("Cannot Identify User or Admin", "Failed");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.PasswordChar = textBox4.PasswordChar = default(char);

            }
            else
            {
                textBox3.PasswordChar = textBox4.PasswordChar = '*';
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
