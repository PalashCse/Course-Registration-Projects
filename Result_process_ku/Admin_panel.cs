using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Result_processing_ku
{
    public partial class Admin_panel : Form
    {
        public Admin_panel()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string Ad_dis = comboBox2.Text;
            string course_no = comboBox1.Text;
            string course_title = textBox1.Text;
            string credit_hour = comboBox3.Text;
            string Styear = textBox3.Text;
            string Stterm = textBox4.Text;


            if (Styear == "3" && Stterm == "1")
            {
                string query = "INSERT into Course_31(Course_no,Course_title,Credit_hour) values('" + course_no + "','" + course_title + "','" + credit_hour + "')";
                SaveInformation(query);
                MessageBox.Show("Information Savsed Successfully.");
            }
            else if (Styear == "2" && Stterm == "1")
            {
                string query = "INSERT into Course_21(Course_no,Course_title,Credit_hour) values('" + course_no + "','" + course_title + "','" + credit_hour + "')";
                SaveInformation(query);
                MessageBox.Show("Information Savsed Successfully.");
            }
            else
            {
                MessageBox.Show("Something Missing.Please Insert Carefully.");
            }

        }

        public void SaveInformation(string query)
        {
            try
            {
                SqlConnection Conn = Databaseconnection.Get_con();
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.ExecuteNonQuery();
                Conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Mainloginform m = new Mainloginform();
            this.Hide();
            m.Show();

        }

        private void updatebutton_Click(object sender, EventArgs e)
        {
            string Ad_dis = comboBox2.Text;
            string course_no = comboBox1.Text;
            string course_title = textBox1.Text;
            string credit_hour = comboBox3.Text;
            string Styear = textBox3.Text;
            string Stterm = textBox4.Text;

            if (Styear == "3" && Stterm == "1")
            {
                string query = "UPDATE  Course_31 SET Course_no ='" + comboBox1.Text + "', Course_title='" + textBox1.Text + "',Credit_hour='" + comboBox3.Text + "'";
                SaveInformation(query);
                MessageBox.Show("Information Updated Successfully.");


            }
            else if (Styear == "2" && Stterm == "1")
            {
                string query = "UPDATE  Course_21 SET Course_no ='" + comboBox1.Text + "', Course_title='" + textBox1.Text + "',Credit_hour='" + comboBox3.Text + "'";
                SaveInformation(query);
                MessageBox.Show("Information Updated Successfully.");

            }
            else
            {
                MessageBox.Show("Something Missing");
            }

            
                
            

        }

        private void Marks_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Admin_panel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectdatabaseDataSet3.Marks_entries' table. You can move, or remove it, as needed.
            this.marks_entriesTableAdapter.Fill(this.projectdatabaseDataSet3.Marks_entries);


        }

        private void savembutton_Click(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(global::Result_processing_ku.Properties.Settings.Default.projectdatabaseConnectionString);
            try
            {
                String query = " INSERT into Marks_entries(Student_ID,Course_NO,CT_Mark,Attendence,Sec_A,Sec_B,Final_mark,GPA) values('" + textBox2.Text + "','" + comboBox4.Text + "','" + textBox5.Text + "','" + comboBox5.Text + "','" + textBox6.Text + "','" + textBox9.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                SqlCommand slc = new SqlCommand(query, sc);
                sc.Open();
                slc.ExecuteNonQuery();
                MessageBox.Show("Information Savsed .");
                this.marks_entriesTableAdapter.Fill(this.projectdatabaseDataSet3.Marks_entries);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Add the value !");
            }
            finally
            {
                //SqlConnection sq = Databaseconnection.disconnect();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Mainloginform m = new Mainloginform();
            this.Hide();
            m.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void result_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}
