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
    public partial class cart : Form
    {
      void loadCart()
        {
            dataGridView1.Rows.Clear();
            foreach (var item in variable.cart_list)
            {

                dataGridView1.Rows.Add(
                    item.name,
                    item.color,
                    item.size.ToString(),
                    item.price.ToString(),
                    item.number_of_items.ToString(),
                (item.number_of_items * item.price).ToString()
                     );




            }

        }
        public cart()
        {
            InitializeComponent();
            loadCart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {   if (variable.cart_list.Count == 0)
                MessageBox.Show("The cart is already empty");
            else
            {
                variable.cart.edit_cart(comboBox1.Text, Convert.ToInt32(comboBox2.Text), comboBox3.Text, Convert.ToInt32(comboBox4.Text));
                loadCart();
            }
        }
        bool checkCartEmpty ()
        {
            if (variable.cart_list.Count == 0)
                return true;
            else
                return false;

        }
        private void cart_Load(object sender, EventArgs e)
        {
            if (checkCartEmpty())
            {
                label2.Hide();comboBox1.Hide();
                label3.Hide(); comboBox2.Hide();
                label4.Hide(); comboBox3.Hide();
                label5.Hide(); comboBox4.Hide();
            }
            else
            {
                foreach (var m in variable.cart_list)
                {
                    comboBox1.Text = m.name;
                    comboBox2.Text = m.size.ToString();
                    comboBox3.Text = m.color;
                    comboBox4.Text = "1";              
                    break;
                }
            }
            foreach(var m in variable.cart_list)
            {
               if(!comboBox1.Items.Contains(m.name)) comboBox1.Items.Add(m.name);
                if (!comboBox1.Items.Contains(m.size)) comboBox2.Items.Add(m.size);
                if (!comboBox1.Items.Contains(m.color)) comboBox3.Items.Add(m.color);
             //   if (!comboBox1.Items.Contains(m.number_of_items)) comboBox4.Items.Add(m.number_of_items);
            }
            
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {if (variable.cart_list.Count != 0)
            {
                Pay pay = new Pay();
                this.Hide();
                pay.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("The Cart is Empty", "Warning");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
