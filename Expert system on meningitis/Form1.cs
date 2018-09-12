using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Expert_system_on_meningitis
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
        int i;

        //   string username = "admin1";
        //  string password = "pass12345";



        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from user WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'", con);
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (i == 0)

            {
                MessageBox.Show("wrong user login details, please try again!");
            }
            else
            {
                MessageBox.Show("Correct User Login details!");
                Form2 myform = new Form2();
                this.Hide();
                myform.Show();
            }
            con.Close();


            //  if (textBox1.Text == username)
            // {
            //      if (textBox2.Text == password)
            //     {
            //     MessageBox.Show("Correct User Login details!");
            //    Form2 myform = new Form2();
            //   this.Hide();
            //   myform.Show();
            //   }
            //    else
            //  {
            //      MessageBox.Show("username / password incorrect, try again!");
            //   }
              
        }
    
  


private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
   

     }
  }