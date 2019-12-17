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

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Rice r = new Rice();
        oil o = new oil();
        Meat M = new Meat();
        sugar s = new sugar();
        Pasta p = new Pasta();
        fish f = new fish();
        Chicken c = new Chicken();
        Milk m = new Milk();
        Water w = new Water();
       
        private void supplyR(string n, Rice m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void supplyO(string n, oil m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void supplyMe(string n, Meat m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void supplyS(string n, sugar m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void supplyP(string n, Pasta m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void supplyF(string n, fish m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void supplyC(string n, Chicken m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void supplyMi(string n, Milk m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void supplyW(string n, Water m)
        {
            try
            {
                if (n == "")
                {
                    MessageBox.Show("Enter the quantity of supplies");
                }
                else if (int.Parse(n) <= 0)
                {
                    MessageBox.Show("Re-enter the quantity you want to supply");
                }
                else
                {
                    m.Countof += int.Parse(n);
                    MessageBox.Show("Your product has been supplied");
                }
            }
            catch
            {
                MessageBox.Show("Invalid quantity");
            }
        }
        private void showquantitybtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("        IN STOCK\n\n   Rice:\t "+ r.Count() + "\n   Water:\t " + w.Count() + "\n   Fish:\t " + f.Count() + "\n   Chick:\t " + c.Count()+ "\n   Milk:\t " + m.Count() + "\n   Pasta:\t " + p.Count()+ "\n   Sugar:\t " + s.Count() + "\n   Oil:\t " + o.Count() + "\n   Meat:\t "+ M.Count());
        }

        private void AddRice_Click(object sender, EventArgs e)
        {
            supplyR(RiceAdd.Text, r);
            RiceAdd.Text = "";
        }
        private void AddWater_Click(object sender, EventArgs e)
        {
            supplyW(wateradd.Text, w);
            wateradd.Text = "";
        }

        private void AddFish_Click(object sender, EventArgs e)
        {
            supplyF(fishadd.Text, f);
            fishadd.Text = "";
        }

        private void AddChick_Click(object sender, EventArgs e)
        {
            supplyC(chickenadd.Text, c);
            chickenadd.Text = "";
        }

        private void AddMilk_Click(object sender, EventArgs e)
        {
            supplyMi(milkadd.Text, m);
            milkadd.Text = "";
        }

        private void AddPasta_Click(object sender, EventArgs e)
        {
            supplyP(pastaadd.Text, p);
            pastaadd.Text = "";
        }

        private void AddSugar_Click(object sender, EventArgs e)
        {
            supplyS(sugaradd.Text, s);
            sugaradd.Text = "";
        }

        private void AddOil_Click(object sender, EventArgs e)
        {
            supplyO(oiladd.Text, o);
            oiladd.Text = "";
        }

        private void AddMeat_Click(object sender, EventArgs e)
        {
            supplyMe(meatadd.Text, M);
            meatadd.Text = "";
        }

        private void Gotoform2(object sender, EventArgs e)
        {
            this.Hide();
            Program.f2.Show();
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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosing();
            Program.f1.Close();
        }
    }
}
