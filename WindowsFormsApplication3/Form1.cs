using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Focus();
            button1.Focus();
            if (textBox1.Text == "user" && textBox2.Text == "1234")
            {
                this.Hide();
                Program.f2.Show();
                textBox1.Text = textBox2.Text = "";
            }
            else if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Enter the username and password");
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                this.Hide();
                Program.f3.Show();
                textBox1.Text = textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid username/password");
                textBox1.Text = textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
