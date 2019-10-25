using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.IO;



namespace Design_for_Registration_and_Login
{
    public partial class Rate : Form
    {
        public string rate = "";
        public Rate()
        {
            InitializeComponent();
            System.Drawing.Point[] p = new System.Drawing.Point[8];
            p[0] = new Point(0, 25);
            p[1] = new Point(20, 20);
            p[2] = new Point(25, 0);
            p[3] = new Point(30, 20);
            p[4] = new Point(50, 25);
            p[5] = new Point(30, 30);
            p[6] = new Point(25, 50);
            p[7] = new Point(20, 30);
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddPolygon(p);
            System.Drawing.Region r = new System.Drawing.Region(gp);
            button1.Region = r;
            button2.Region = r;
            button3.Region = r;
            button4.Region = r;
            button5.Region = r;
        }
        private void Rate_Load(object sender, EventArgs e)
        {

        }

       
        private void button6_Click(object sender, EventArgs e)
        {
       
            string existing = File.ReadAllText(Public.feedbackPath);
            string x =existing+ Public.user.getUsername() + "\r" + rate + "\r" + textBox1.Text + '\r';
             File.WriteAllText(Public.feedbackPath, x);
        
            
            MessageBox.Show("Thankyou for using iShop ");
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            rate = "1/5 ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            rate = "2/5 ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            rate = "3/5 ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Yellow;
            button5.BackColor = Color.White;
            rate = "4/5 ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button2.BackColor = Color.Yellow;
            button3.BackColor = Color.Yellow;
            button4.BackColor = Color.Yellow;
            button5.BackColor = Color.Yellow;
            rate = " 5/5 ";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
