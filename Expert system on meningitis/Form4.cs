using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expert_system_on_meningitis
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string WebPage =textBox1.Text.Trim();
            webBrowser1.Navigate(WebPage);
            webBrowser2.Navigate(WebPage);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 myform = new Form3();
            this.Hide();
            myform.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            this.Hide();
            myform.Show();
        }
    }
}
