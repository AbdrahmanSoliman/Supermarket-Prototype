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
    public partial class Form1 : Form
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

        public Form1()
        {
            InitializeComponent();
            Loader();
            cartLoader();
            cartreset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            button1.Focus();
            if (textBox1.Text == "user" && textBox2.Text == "1234")
            {
                this.Hide();
                Program.f2.Show();
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Enter the username and password");
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                Program.f3.Show();
            }
            else
            {
                MessageBox.Show("Invalid username/password");
            }
            textBox1.Text = textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loader()
        {
            try
            {
                using (FileStream fs = new FileStream("stock.txt", FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);

                    r.Countof = Convert.ToInt32(sr.ReadLine());
                    w.Countof = Convert.ToInt32(sr.ReadLine());
                    f.Countof = Convert.ToInt32(sr.ReadLine());
                    c.Countof = Convert.ToInt32(sr.ReadLine());
                    m.Countof = Convert.ToInt32(sr.ReadLine());
                    p.Countof = Convert.ToInt32(sr.ReadLine());
                    s.Countof = Convert.ToInt32(sr.ReadLine());
                    o.Countof = Convert.ToInt32(sr.ReadLine());
                    M.Countof = Convert.ToInt32(sr.ReadLine());
                }
            }
            catch
            {
                //File Not created yet
            }
            
        }
        private void cartLoader()
        {
            try
            {
                using (FileStream fs = new FileStream("Carttemp.txt", FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);
                    while (true)
                    {
                        switch (sr.ReadLine())
                        {
                            case "r":
                                r.Countof++;
                                break;
                            case "w":
                                w.Countof++;
                                break;
                            case "f":
                                f.Countof++;
                                break;
                            case "c":
                                c.Countof++;
                                break;
                            case "m":
                                m.Countof++;
                                break;
                            case "p":
                                p.Countof++;
                                break;
                            case "s":
                                s.Countof++;
                                break;
                            case "o":
                                o.Countof++;
                                break;
                            case "M":
                                M.Countof++;
                                break;
                            default:
                                return;
                        }
                    }
                }
            }
            catch
            {
                // File Not Created Yet
            }
        }
        private void cartreset()
        {
            using (FileStream fs = new FileStream("Carttemp.txt", FileMode.Create, FileAccess.Write))
            {
                StreamWriter sr = new StreamWriter(fs);
                sr.Write("");
                sr.Flush();
            }
        }
    }
}

