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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 myform = new Form3();
            this.Hide();
            myform.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 myform = new Form5();
            this.Hide();
            myform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 myform = new Form4();
            this.Hide();
            myform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 myform = new Form6();
            this.Hide();
            myform.Show();
        }
    }
}
