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

            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
            con.Open();
            MySqlDataAdapter sda = new MySqlDataAdapter("select * from diagnosis_record ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["name"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["address"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["age"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["gender"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["card_number"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["diagnosis_report"].ToString();

            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
           


        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO diagnosis_record (`name`, `address`, `age`, `gender`, `card_number`, `diagnosis_report`) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" +listBox1.Text + "','" + textBox6.Text + "','" + textBox4.Text + "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("record has been succesfully inserted in the database");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `diagnosis_record` SET `name`= '" + textBox1.Text + "',`address`= '" + textBox2.Text + "',`age`= '" + textBox3.Text + "',`gender`= '" + listBox1.Text + "',`diagnosis_report`= '" + textBox4.Text + "' WHERE card_number = '" + textBox5.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis record has been successfully updated");
            con.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("server=localhost;user id=root;database=meningitis");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `diagnosis_record` WHERE card_number = '" + textBox5.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis record has been successfully deleted");
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = dataGridView1.SelectedRows[0].Index;
            textBox1.Text = dataGridView1.Rows[n].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[n].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[n].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[n].Cells[3].Value.ToString();
            listBox1.Text = dataGridView1.Rows[n].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[n].Cells[5].Value.ToString();


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
    }
}
