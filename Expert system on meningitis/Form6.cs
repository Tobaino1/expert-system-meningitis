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
    public partial class Form6 : Form
    {
        private MySqlConnection conn;
        private string server;
        private string database;
        private string uid;
        private string password;



        public Form6()

        {
            server = "localhost";
            database = "meningitis";
            uid = "root";
            password = "";

            string connString;

            connString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";

            conn = new MySqlConnection(connString);






            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            this.Hide();
            myform.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
                return;

            }

            if (textBox3.Text == string.Empty)
            {
                MessageBox.Show("field can't be empty, please enter a value!");
                return;

            }



            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
             con.Open();
             MySqlCommand cmd = new MySqlCommand("INSERT INTO user(`username`, `password`) VALUES ('" + textBox2.Text + "','" + textBox3.Text + "')", con);
               cmd.ExecuteNonQuery();
               MessageBox.Show("successfully created account");
               con.Close();



            // /* user mgt without db fxn (register code)
        //    string username = "";
         //   string password = "";

         //   username = textBox2.Text;
         //   password = textBox3.Text;

         //   MessageBox.Show("user account has been succesfully created!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
