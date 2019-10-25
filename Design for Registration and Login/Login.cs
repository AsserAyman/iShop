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

namespace Design_for_Registration_and_Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            button1.Enabled = false;        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password f1 = new Forgot_Password();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var admin = Public.AdminLogIn(Public.admins, textBox1.Text, textBox2.Text);
                if (Public.admins.Contains(admin))
                {
                    MessageBox.Show("Hello,\n " + admin.getUsername(), "Success");
                    admin_interface f1 = new admin_interface();
                    this.Hide();
                    f1.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login error");
                }
            }
            else
            {
                Public.user = Public.UserLogIn(Public.users, textBox1.Text, textBox2.Text);
                if (Public.users.Contains(Public.user))
                {
                    Form1 f1 = new Form1();
                    this.Hide();
                    f1.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login error");

                }

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.PasswordChar = default(char);
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
