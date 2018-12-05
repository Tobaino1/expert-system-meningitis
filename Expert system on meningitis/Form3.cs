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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from patientreg ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["name"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["address"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["age"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["phone_no"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["gender"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["card_no"].ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 myform = new Form2();
            this.Hide();
            myform.Show();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO patientreg (`name`, `address`, `age`, `phone_no`, `gender`, `card_no`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been succesfully inserted in the database");
            con.Close();
            

    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `patientreg` WHERE card_no = '" + textBox7.Text + "'", con);
               
            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been successfully deleted");
            con.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `patientreg` SET `name`= '" + textBox1.Text + "',`address`= '" + textBox2.Text + "',`age`= '" + textBox3.Text + "',`phone_no`= '" + textBox4.Text + "',`gender`= '" + textBox5.Text + "',`card_no`= '" + textBox6.Text +"' WHERE card_no = '" + textBox7.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been successfully updated");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 myform = new Form4();
            this.Hide();
            myform.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form3 myform = new Form3();
            this.Hide();
            myform.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
