using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        
        Rice r = new Rice();
        oil o = new oil();
        Meat M = new Meat();
        sugar s = new sugar();
        Pasta p = new Pasta();
        fish f = new fish();
        Chicken c = new Chicken();
        Milk m = new Milk();
        Water w = new Water();
        double t = 0;//total//
        public Form2()
        {
            InitializeComponent();
            cartreset();
        }
        class Node
        {
            string name;
            double price;
            Node next;

            public string DataN
            {
                set { name = value; }
                get { return name; }
            }
            public double DataP
            {
                set { price = value; }
                get { return price; }
            }

            public Node Next
            {
                set { next = value; }
                get { return next; }
            }

            public Node(string datan, double datap)
            {
                this.name = datan;
                
                this.price = datap;
                next = null;
            }
        }
        class linkedlist
        {

            public Node start;
            public Node tail;
            public void add(string datan, double datap)
            {
                Node tmp = new Node(datan, datap);
                if (start == null)
                {
                    start = tmp;
                    tail = tmp;
                }
                else
                {
                    tail.Next = tmp;
                    tail = tmp;
                }
            }
            public void display()
            {
                string cart = "Your Order: \n\n\t";
                Node q = start;

                if (start == null)
                {
                    MessageBox.Show("Cart is empty");
                }
                else
                {
                    while (q != null)
                    {
                        cart += q.DataN + "\n\tPrice " + q.DataP + "\n\n\t";
                        q = q.Next;
                    }
                    MessageBox.Show(cart);

                }

            }
            public void clr()
            {
                start = null;
                tail = null;
            }
            
        }
        linkedlist l = new linkedlist();
        

        private void AddRiceBtn(object sender, EventArgs e)
            {
             //add rice//
            if (r.Count() == 0)
            {
                numofrice.Text = Convert.ToString(r.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (r.Count() >0)
            {
                r.minize();
                Carttemp("r");
                t += r.price();
                l.add(r.name(), r.price());//add product in linked list//
                //to show num of product after press Add//
                numofrice.Text = Convert.ToString(r.Count()) + "in stock";
            }
        }
        private void Adddoilbtn(object sender, EventArgs e)
        {
            //oil//
            if (o.Count() == 0)
            {
                numofoil.Text = Convert.ToString(o.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (o.Count() > 0)
            {
                o.minize();
                Carttemp("o");
                t += o.price();
                l.add(o.name(), o.price());//add product in linked list//
                //to show num of product after press Add//
                numofoil.Text = Convert.ToString(o.Count()) + "in stock";
            }
        }
        private void AddmeatBtn(object sender, EventArgs e)
        {
            //meat//
            if (M.Count() == 0)
            {
                numofmeat.Text = Convert.ToString(M.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (M.Count() > 0)
            {
                M.minize();
                Carttemp("M");
                t += M.price();
                l.add(M.name(), M.price());//add product in linked list//
                //to show num of product after press Add//
                numofmeat.Text = Convert.ToString(M.Count()) + "in stock";
            }
        }
        private void AddsugarBtn(object sender, EventArgs e)
        {
            //sugar//
            if (s.Count() == 0)
            {
                numofsugar.Text = Convert.ToString(s.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (s.Count() > 0)
            {
                s.minize();
                Carttemp("s");
                t += s.price();
                l.add(s.name(), s.price());//add product in linked list//
                //to show num of product after press Add//
                numofsugar.Text = Convert.ToString(s.Count()) + "in stock";
            }
        }
         private void AddPastaBtn(object sender, EventArgs e)
            {
            //pasta//
            if (p.Count() == 0)
            {
                numofpasta.Text = Convert.ToString(p.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (p.Count() > 0)
            {
                p.minize();
                Carttemp("p");
                t += p.price();
                l.add(p.name(), p.price());//add product in linked list//
                //to show num of product after press Add//
                numofpasta.Text = Convert.ToString(p.Count()) + "in stock";
            }
            
        }
         private void AddFishBtn(object sender, EventArgs e)
        {
            //fish//
            if (f.Count() == 0)
            {
                numoffish.Text = Convert.ToString(f.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (f.Count() > 0)
            {
                f.minize();
                Carttemp("f");
                t += f.price();
                l.add(f.name(), f.price());//add product in linked list//
                //to show num of product after press Add//
                numoffish.Text = Convert.ToString(f.Count()) + "in stock";
            }
        }
         private void AddchickenBtn(object sender, EventArgs e)
            {
            //chicken//
            if (c.Count() == 0)
            {
                numofchicken.Text = Convert.ToString(c.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (c.Count() > 0)
            {
                c.minize();            
                Carttemp("c");
                t += c.price();
                l.add(c.name(), c.price());//add product in linked list//
                //to show num of product after press Add//
                numofchicken.Text = Convert.ToString(c.Count()) + "in stock";
            }
        }
         private void AddmilkBtn(object sender, EventArgs e)
        {
            //milk//
            if (m.Count() == 0)
            {
                numofmilk.Text = Convert.ToString(m.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (m.Count() > 0)
            {
                m.minize();
                Carttemp("m");
                t += m.price();
                l.add(m.name(), m.price());//add product in linked list//
                //to show num of product after press Add//
                numofmilk.Text = Convert.ToString(m.Count()) + "in stock";
            }
        }
         private void AddwaterBtn(object sender, EventArgs e)
            {
            //water//
            if (w.Count() == 0)
            {
                numofwater.Text = Convert.ToString(w.Count()) + "in stock";
                MessageBox.Show("out of stock");
            }
            else if (w.Count() > 0)
            {
                w.minize();
                Carttemp("w");
                t += w.price();
                l.add(w.name(), w.price());//add product in linked list//
                //to show num of product after press Add//
                numofwater.Text = Convert.ToString(w.Count()) + "in stock";
            }
        }
         private void totalOrderBtn(object sender, EventArgs e)
            {
            if (t == 0)
            {
                MessageBox.Show("Fill your cart firstly");
                return;
            }
            MessageBox.Show("Total price: " + t);
            cartreset();
            if (t != 0)
            {
                pictureBox12.CreateGraphics().FillRectangle(Brushes.OrangeRed, 0, 0, 15, 15);
            }
            }
         private void NextOrderBtn(object sender, EventArgs e)
            {
            pictureBox12.CreateGraphics().Clear(Color.White);
            t = 0;
            l.clr();
            MessageBox.Show("Your cart has been reset");
            }
         private void sowinmychart_pic_click(object sender, EventArgs e)
            {
             //display order after click in cart picture//
             l.display();
            }
        private void shownumberofproductBtn(object sender, EventArgs e)
        {
            //number of any product in stock//
            numofrice.Text = r.Count()+"in stock";
            numofsugar.Text = s.Count() + "in stock";
            numofmeat.Text = M.Count() + "in stock";
            numofmilk.Text = m.Count() + "in stock";
            numofpasta.Text = p.Count()+"in stock";
            numofwater.Text = w.Count() + "in stock";
            numoffish.Text = f.Count() + "in stock";
            numofchicken.Text = c.Count()+ "in stock";
            numofoil.Text= o.Count()+ "in stock";
        }

        private void Admin_page_btn_Click(object sender, EventArgs e)
        {

            this.Hide();
            Program.f1.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosing();
            Program.f1.Close();
        }

        private void OnClosing()
        {
            using (FileStream fs = new FileStream("stock.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(r.Countof);
                sr.WriteLine(w.Countof);
                sr.WriteLine(f.Countof);
                sr.WriteLine(c.Countof);
                sr.WriteLine(m.Countof);
                sr.WriteLine(p.Countof);
                sr.WriteLine(s.Countof);
                sr.WriteLine(o.Countof);
                sr.WriteLine(M.Countof);
                sr.Flush();
            }
        }
        private void Carttemp(string name)
        {
            using(FileStream fs = new FileStream("Carttemp.txt", FileMode.Append, FileAccess.Write))
            {
                StreamWriter sr = new StreamWriter(fs);
                sr.WriteLine(name);
                sr.Flush();
            }
        }

        private void cartreset()
        {
            using(FileStream fs = new FileStream("Carttemp.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter sr = new StreamWriter(fs);
                sr.Write("");
                sr.Flush();
            }
        }
    }
}
 


