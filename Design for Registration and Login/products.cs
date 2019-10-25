using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2;
using Design_for_Registration_and_Login;

namespace WindowsFormsApp2
{
   
    public class Node
    {
      public int  id = 0;
        public Node next;

        public string name;
        public string color;
        public double price;
        public int size;
       

        public  Node()
        {
            next = null;
            price = 0;
            size = 0;
            name = "";
            color = "";
        }

        public  Node(string namex, int sizex, double pricex, string colorx)
        {
            next = null;
            price = pricex;
            color = colorx;
            name = namex;
            size = sizex;
        }
    }

    public class products

    {
        private int size;
        private Node head;
        private Node tail;

        public products()
        {
            head = tail = null;
            size = 0;
        }

        public void Add_product(string namex, int sizex, double pricex, string colorx)
        {
            Node newNode = new Node(namex, sizex, pricex, colorx);
            if (size == 0)
            {
                head = tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }

            size++;
            newNode.id = size + 1;
        }

        public string Display()
        {
            Node temp = head;
            string display = "";
            for (int i = 0; i < size; i++)
            {
            
                display += (temp.name);
                display += " ";
                display += (temp.size.ToString());
                display += " ";
                display += (temp.price.ToString());
                display += " ";
                display += (temp.color);
                display += " ";
                display += "\n ";


                temp = temp.next;

            }

            return display;
        }

        public int Length()
        {
            return size;
        }

        public void clear()
        {
            if (size == 0)
            {
                MessageBox.Show("already empty");
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {

                head = null;
                head = temp;
                temp = temp.next;
            }


            head = tail = null;
            size = 0;
        }

        public void Search_by_name_size_color(string name, int sizee, string color)
        {
            bool flag = false;
            Node temp = head;
            for (int i = 0; i < size; i++)
            {
                if (name == temp.name && sizee == temp.size && color == temp.color)
                {
                    MessageBox.Show(temp.name + "\n" + temp.size + "\n" + temp.price + "\n" + temp.color + "\n",
                        "element" + i);

                    flag = true;
                }

                temp = temp.next;
            }

            if (flag == false)
                MessageBox.Show("not found");
        }

        public double Search_by_name_size_color_for_user(string name, int sizee, string color)
        {
            bool flag = false;
            Node temp = head;
            double t = new double();
            for (int i = 0; i < size; i++)
            {
                if (name == temp.name && sizee == temp.size && color == temp.color)
                {

                    flag = true;
                 t=temp.price;
                    
                }

             
                temp = temp.next;

            }

            if (flag == false)
            {
              //  MessageBox.Show("not found");
                return 0;
            }
            else
            {
                return t;
            }
        }
    

    public  void edit_By_name_color_size(string namex, int sizex, double pricex, string colorx,string name , string color, int sizee)
    {
        bool sure = false;
        Node temp = head;
        for (int i = 0; i < size; i++)
        {
            if (name == temp.name && sizee == temp.size && color == temp.color)
            {
                temp.size = sizex;
                temp.price = pricex;
                temp.name = namex;
                temp.color = colorx;
                sure = true;
            }
            
        }

        if (sure == false)
            MessageBox.Show("item not found \n");

    }

    public  void Delete_Product_AtSpecific_name_size_color(string name,int sizee , string color)

    {
        bool sure = false;
        Node temp = head;
        Node del = head;
        for (int i = 0; i < size; i++)
        {
            if (name == temp.name && sizee == temp.size && color == temp.color&& i == 0)
            {
                head = head.next;
                sure = true;
            }
            else if (name == temp.name && sizee == temp.size && color == temp.color && i != 0)
            {
                for (int j = 0; j < i - 1; j++)
                    del = del.next;
                del.next = temp.next;
                temp.next = null;
                sure = true;
                break;
            }

            if (sure == false)
                temp = temp.next;
        }

        if (sure == true)
            size--;
        else
            MessageBox.Show("node not found");
    }
    }
}

public class cart_product
{
    public string name;
    public string color;
    public int size;
    public double price;
    public int number_of_items;
    public int counter;
    public cart_product()
    {
        name = "";
        color = "";
        size = 0;
        price = 0;
        number_of_items = 0;
        counter = 0;
    }
    public cart_product(string namex, int sizex, double pricex, string colorx, int numofitemss)
    {
        name = namex;
        color = colorx;
        size = sizex;
        price = pricex;
        number_of_items = numofitemss;
        counter++;
        MessageBox.Show("added");

    }
    //public string Display()
    //{
    //   // Node temp = head;

    //    string display = "";
    //    for (int i = 0; i < counter; i++)
    //    {
    //        display += (variable.cart.name);
    //        display += " ";
    //        display += (variable.cart.color);
    //        display += " ";
    //        display += (variable.cart.size.ToString());
    //        display += " ";
    //        display += (variable.cart.price.ToString());
    //        display += " ";
    //        display += (variable.cart.number_of_items);
    //        display += " ";
    //        display += (variable.cart.number_of_items* variable.cart.price);
    //        display += " ";
    //        display += "\n ";

    //    }

    //    return display;
    //}

    public void edit_cart(string namex, int sizex, string colorx, int num)
    {


        bool sure = false;

        for (int i = 0; i < counter; i++)
        {
            if (namex == variable.cart.name && sizex == variable.cart.size && colorx == variable.cart.color)
            {
                if ((variable.cart.number_of_items - num) <= 0)
                {
                    //variable.cart.size = new int();
                    //variable.cart.price = new int();
                    //variable.cart.name = "";
                    //variable.cart.color = "";

                    //variable.cart.number_of_items -= num;
                    //  variable.cart.counter--;
                    sure = true;
                    variable.cart_list.Remove(variable.cart);
                }
                else
                {
                    variable.cart.number_of_items -= num;
                    sure = true;
                    break;
                }

                //sure = true;
            }

        }

        if (sure == false)
            MessageBox.Show("item not found \n");


    }

}
public static class variable
{
    public static products IPHONE = new products();
    public static products MAC = new products();
    public static products IPAD = new products();
    public static products APPLE_WATCH = new products();
    public static cart_product cart = new cart_product();
    public static List<cart_product> cart_list = new List<cart_product>();
    
}

public static class load
{
    public static void loadFromfileIPHONE()
    {
        int x ;
        double y;
        string d, c;
        var productfile = new StreamReader("../../IPHONE.txt");
        string data = productfile.ReadLine();
        while (data != null)
        {
            d = data;
            c = productfile.ReadLine();
            x = Convert.ToInt32(productfile.ReadLine());
            y = Convert.ToDouble(productfile.ReadLine());
            variable.IPHONE.Add_product(d,x,y,c);
            data = productfile.ReadLine();
        }
       
    }
    public static void loadFromfileIPAD()
    {
        int x;
        double y;
        string d, c;
        var productfile = new StreamReader("../../IPAD.txt");
        string data = productfile.ReadLine();
        while (data != null)
        {
            d = data;
            c = productfile.ReadLine();
            x = Convert.ToInt32(productfile.ReadLine());
            y = Convert.ToDouble(productfile.ReadLine());
            variable.IPAD.Add_product(d, x, y, c);
            data = productfile.ReadLine();
        }

    }
    public static void loadFromfileMAC()
    {
        int x;
        double y;
        string d, c;
        var productfile = new StreamReader("../../MAC.txt");
        string data = productfile.ReadLine();
        while (data != null)
        {
            d = data;
            c = productfile.ReadLine();
            x = Convert.ToInt32(productfile.ReadLine());
            y = Convert.ToDouble(productfile.ReadLine());
            variable.MAC.Add_product(d, x, y, c);
            data = productfile.ReadLine();
        }

    }
    public static void loadFromfileAPPLE_WATCH()
    {
        int x;
        double y;
        string d, c;
        var productfile = new StreamReader("../../APPLE_WATCH.txt");
        string data = productfile.ReadLine();
        while (data != null)
        {
            d = data;
            c = productfile.ReadLine();
            x = Convert.ToInt32(productfile.ReadLine());
            y = Convert.ToDouble(productfile.ReadLine());
            variable.APPLE_WATCH.Add_product(d, x, y, c);
            data = productfile.ReadLine();
        }

    }
}