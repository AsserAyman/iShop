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
    public partial class Register : Form
    {
        List<int> list = new List<int>();
        List<String> genderlList = new List<string>();
        List<String> securityList = new List<string>();

        void add()
        {
            for (int i = 15; i < 60; i++)
            {
                list.Add(i);
            }

        }

        public Register()
        {
            InitializeComponent();
            button1.Enabled = false;
            add();
            comboBox1.DataSource = list;

        }
  
        

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != textBox8.Text)
            {
                MessageBox.Show("Please re-check your password and re-enter password fields", "Password Error");

            }

            else
            {
                if (checkBox2.Checked)
                {
                    if (Public.isEmailUinque(Public.users, Public.admins, textBox3.Text) || Public.isUinque(Public.users, Public.admins, textBox9.Text))
                    {
                        MessageBox.Show("Username or Email exist", "Registration has failed ");
                    }
                    else if (
                        textBox1.Text.Trim() == "" ||
                        textBox2.Text.Trim() == "" ||
                        textBox3.Text.Trim() == "" ||
                        textBox4.Text.Trim() == "" ||
                        textBox5.Text.Trim() == "" ||
                        textBox8.Text.Trim() == "" ||
                        textBox9.Text.Trim() == "" ||
                        textBox10.Text.Trim() == ""||
                        comboBox2.Text == "Choose Gender" ||
                        comboBox3.Text == "Choose Question"
                        )
                    {
                        MessageBox.Show("Some information were left empty,\n please fill them and try again",
                            "Registration has failed ");
                    }
                    else if (!textBox3.Text.Contains(".com") || !textBox3.Text.Contains("@"))
                    {
                        MessageBox.Show("Email must include Symbol '@' \n and '.com'", "Email NOT Valid");
                    }
                    else if (textBox5.Text.Length != 11)
                    {
                        MessageBox.Show("Mobile Number Must include 11 digits", "Mobile Number Error");
                    }
                    else if (comboBox2.Text != "Male" || comboBox2.Text != "Female" || comboBox2.Text != "Other")
                    {
                        MessageBox.Show("Error in Choosing", "Error");
                    }
                    else
                    {
                        var admin = new Admin(textBox1.Text, textBox2.Text, textBox9.Text, textBox8.Text, comboBox2.Text,
                            textBox3.Text, textBox5.Text, textBox4.Text, comboBox3.Text, textBox10.Text, comboBox1.Text
                            
                        );
                        Public.admins.Add(admin);
                        Public.SaveData();
                        Login f1 = new Login();
                        this.Hide();
                        f1.ShowDialog();
                        this.Close();
                    }

                }
                else
                {
                    if (Public.isEmailUinque(Public.users, Public.admins, textBox3.Text) || Public.isUinque(Public.users, Public.admins, textBox9.Text))
                    {
                        MessageBox.Show("Username or Email exist", "Registration has failed ");
                    }
                    else if (textBox6.Text.Length != 16)
                    {

                        MessageBox.Show(
                            "ïnvalid Credit card number please try again\nCredit Card number is valid if it is only 16 digits ",
                            "Invalid credit card");

                    }
                    else if (
                        textBox1.Text.Trim() == "" ||
                        textBox2.Text.Trim() == "" ||
                        textBox3.Text.Trim() == "" ||
                        textBox4.Text.Trim() == "" ||
                        textBox5.Text.Trim() == "" ||
                        textBox8.Text.Trim() == "" ||
                        textBox9.Text.Trim() == "" ||
                        textBox10.Text.Trim() == "" ||
                        comboBox2.Text == "Choose Gender"||
                        comboBox3.Text == "Choose Question"
                        )

                    {
                        MessageBox.Show("Some information were left empty,\n please fill them and try again",
                            "Registration has failed ");
                    }
                    else if (!textBox3.Text.Contains(".com") || !textBox3.Text.Contains("@") )
                    {
                        MessageBox.Show("Email must include Symbol '@' \n and '.com'","Email NOT Valid");
                    }
                    else if (textBox5.Text.Length != 11)
                    {
                        MessageBox.Show("Mobile Number Must include 11 digits", "Mobile Number Error");
                    }
                    else if (comboBox2.Text != "Male" && comboBox2.Text != "Female" && comboBox2.Text != "Other")
                    {
                        MessageBox.Show("Error in Choosing","Error");
                    }
                    else
                    {
                        var user = new User(textBox1.Text, textBox2.Text, textBox9.Text, textBox8.Text, comboBox2.Text,
                            textBox3.Text, textBox5.Text, textBox4.Text, comboBox3.Text, textBox10.Text, textBox6.Text, comboBox1.Text);
                        Public.users.Add(user);
                        Public.SaveData();
                        Login f1 = new Login();
                        this.Hide();
                        f1.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            { textBox6.Hide(); label6.Hide(); }
            else
            { textBox6.Show(); label6.Show(); }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox7.PasswordChar = textBox8.PasswordChar = default(char);
            }
            else
            {
                textBox7.PasswordChar = textBox8.PasswordChar = '*';
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
