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
    public partial class Pay : Form
    { double x;
        int isCreditCardValid = 0;
        public Pay()
        {
            InitializeComponent();
             x = 0;
            foreach (var i in variable.cart_list)
            {
                x += i.price * i.number_of_items;
            }
            label4.Text = "Total price is " + x.ToString()+" $";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = default(char);
            }else
                textBox2.PasswordChar = '*';

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Public.user.getUsername() && textBox2.Text == Public.user.getPassword() 
                && textBox3.Text == Public.user.getCredit()
                )
            {   foreach(var item in variable.cart_list)
                {
                    if (item.name.Contains("iPhone"))
                        variable.IPHONE.Delete_Product_AtSpecific_name_size_color(item.name, item.size, item.color);
                    if (item.name.Contains("iPad"))
                        variable.IPAD.Delete_Product_AtSpecific_name_size_color(item.name, item.size, item.color);
                    if (item.name.Contains("Mac"))
                        variable.MAC.Delete_Product_AtSpecific_name_size_color(item.name, item.size, item.color);
                    if (item.name.Contains("Watch"))
                        variable.APPLE_WATCH.Delete_Product_AtSpecific_name_size_color(item.name, item.size, item.color);
                }
                ConfirmOrder f = new ConfirmOrder();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Information is incorrect", "Validation Failed");
            }
        }

        private void Pay_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "DrTasneemAgmadDrFelkoleya")
            {
                isCreditCardValid ++;
                if (isCreditCardValid==1)
                {
                    x -= (x * 0.2);
                    label4.Text = "Total Price is : ";
                    label4.Text += x.ToString() + '$';
                    MessageBox.Show("PromoCode Activated 20% off ", "Congratulations");
                }
            }
            else
                MessageBox.Show("PromoCode Not Valid ", "Sorry");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            cart f = new cart();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
