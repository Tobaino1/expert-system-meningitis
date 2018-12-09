using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Expert_system_on_meningitis
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            this.Hide();
              myform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            if (checkBox1.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
       
       

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 myform = new Form5();
            this.Hide();
            myform.Show();
        }

        private void checkBox43_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox65_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox34_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form7 myform = new Form7();
            this.Hide();
            myform.Show();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox18.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox17.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (checkBox20.Checked)
            {
                MessageBox.Show("TUBERCULOSIS / MENINGITIS");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
