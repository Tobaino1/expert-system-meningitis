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

       
        private void button37_Click(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }

        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (checkBox33.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (checkBox32.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (checkBox31.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (checkBox24.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (checkBox38.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (checkBox37.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            if (checkBox36.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (checkBox35.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (checkBox40.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            if (checkBox66.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (checkBox57.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            if (checkBox56.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (checkBox42.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (checkBox52.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            if (checkBox51.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if (checkBox50.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            if (checkBox49.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (checkBox46.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (checkBox45.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (checkBox44.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (checkBox43.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (checkBox65.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (checkBox64.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (checkBox63.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (checkBox62.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (checkBox61.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (checkBox60.Checked)
            {
                MessageBox.Show("FEVER");
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (checkBox59.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button62_Click(object sender, EventArgs e)
        {
            if (checkBox55.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (checkBox54.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox22.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (checkBox41.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (checkBox21.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (checkBox34.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (checkBox39.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                MessageBox.Show("MALARIA");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (checkBox23.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (checkBox58.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            if (checkBox58.Checked)
            {
                MessageBox.Show("TYPHOID FEVER");
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (checkBox47.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            if (checkBox48.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (checkBox53.Checked)
            {
                MessageBox.Show("TUBERCULOSIS");
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (checkBox69.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (checkBox68.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (checkBox67.Checked)
            {
                MessageBox.Show("MENINGITIS");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox19.Checked)
            {
                MessageBox.Show("CHOLERA");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox71.Checked)
            {
                MessageBox.Show("Alcoholism  Autoimmune disorders(e.g., lupus) Conditions like HIV / AIDS, cancer, or diabetes Immunosuppressive drugs(e.g., corticosteroids, chemotherapy) , Intravenous drug abuse, Removal of the spleen Smoking, Not receiving the mumps, Haemophilus influenzae type b, and pneumococcal vaccines(especially children aged 2 and younger) increases the risk for meningitis.");
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            if (checkBox74.Checked)
            {
                MessageBox.Show("Age is also a risk factor for meningitis. It is more common in people younger than 5 years old and those older than 60. People between the ages of 15 and 24 who live in boarding schools and college dormitories are also at increased risk.");
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (checkBox73.Checked) 
            {
                MessageBox.Show("Living and working with large groups of people (e.g., military bases, child care facilities) increases the risk for infectious meningitis.");
                            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox72.Checked)
            {
                MessageBox.Show("People who work with domestic animals (e.g., dairy farmers, ranchers) and pregnant women are at increased risk for meningitis associated with listeriosis (disease transmitted from animals to humans via soil). Listeriosis can be transmitted from mother to fetus through the placenta, causing spontaneous abortion. The disease is usually fatal in newborns");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (checkBox75.Checked)
            {
                MessageBox.Show("Head injuries and brain surgery also put patients at risk for meningitis.");

            }
        }
    }
}
