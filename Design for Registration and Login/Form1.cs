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
    public partial class Form1 : Form
    {
        private string facebookurl = "https://www.facebook.com/asser.ayman.1";
        private string instagramurl = "https://www.instagram.com/asserayman1/?hl=en";
        private string twitterurl = "https://twitter.com/Asseraman";
        int PW;
        bool Hided;
        public Form1()
        {
            InitializeComponent();
            panel2.Width = 0;
            PW = 70;
            Hided = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            iPhones f1 = new iPhones();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Apple_WatchesForm2 f1 = new Apple_WatchesForm2();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MacBooks f1 = new MacBooks();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iPads f1 = new iPads();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   if (Hided)
            { panel2.Width += 20;
                if(panel2.Width>=PW)
                {
                    timer1.Stop();
                    Hided = false;
                    this.Refresh();
                }
            }
            else
            {
                panel2.Width -= 20;
                if (panel2.Width <= 0)
                {
                    timer1.Stop();
                    Hided = true;
                    this.Refresh();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(facebookurl);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(twitterurl);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(instagramurl);
        }
    }
}
