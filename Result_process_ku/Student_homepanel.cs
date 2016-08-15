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
    
    public partial class Student_homepanel : Form
    {

        Boolean a = false; 
        public Student_homepanel()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            string Stid = Studentid.Text;
            string Stname = Studentname.Text;
            string Stdisc = Discipline.Text;
            string Stsessn = Session.Text;
            string Stschool = School_name.Text;
            string Styear = Year.Text;
            string Stterm = Term.Text;
            
            if (Stid != "" && Stdisc != "" && Stname != "" && Stschool != "" && Stsessn != "")
            {
                string query = "INSERT into Student_info values('" + Stid + "','" + Stname + "','" + Stdisc + "','" + Stsessn + "','" + Stschool + "','" + Stterm + "','" + Styear + "')";
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

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            string Stid = Studentid.Text;
            string Stname = Studentname.Text;
            string Stdisc = Discipline.Text;
            string Stsessn = Session.Text;
            string Stschool = School_name.Text;
            string Styear = Year.Text;
            string Stterm = Term.Text;
            if (Studentid.Text != "" && Studentname.Text != "")
            {
                string query = "UPDATE Student_info  SET Student_name='" + Studentname.Text + "', Student_id='" + Studentid.Text + "', Discipline_name='" + Discipline.Text + "', Student_session ='" + Session.Text + "', Student_school ='" + School_name.Text + "', Student_term = '" + Term.Text + "', Student_year='" + Year.Text + "'where Student_id = '" + Stid + "'";
                SaveInformation(query);
                MessageBox.Show("Information Updated Successfully.");


            }

            else
            {
                MessageBox.Show("Something Missing");
            }
        }



        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Mainloginform m = new Mainloginform();
            this.Hide();
            m.Show();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Student_homepanel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectdatabaseDataSet3.Marks_entries' table. You can move, or remove it, as needed.
            this.marks_entriesTableAdapter.Fill(this.projectdatabaseDataSet3.Marks_entries);
            // TODO: This line of code loads data into the 'projectdatabaseDataSet.Course_32' table. You can move, or remove it, as needed.
            this.course_32TableAdapter.Fill(this.projectdatabaseDataSet.Course_32);

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SqlConnection sc=new SqlConnection(global::Result_processing_ku.Properties.Settings.Default.projectdatabaseConnectionString);
            try
            {
                String query = " INSERT into Course_32(Course_no,Course_title,Credit_hour) values('" + textBox1.Text + "','" + textBox6.Text + "','" + textBox5.Text + "')";
                SqlCommand slc = new SqlCommand(query, sc);
                sc.Open();
                slc.ExecuteNonQuery();
                MessageBox.Show("Information Savsed .");
                this.course_32TableAdapter.Fill(this.projectdatabaseDataSet.Course_32);
                

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.course_32TableAdapter.Fill(this.projectdatabaseDataSet.Course_32);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Mainloginform m = new Mainloginform();
            this.Hide();
            m.Show();
        }

        private void showbutton_Click(object sender, EventArgs e)
        
        {
                SqlConnection sql=Databaseconnection.Get_con();

                if (comboBox3.Text == "3" && comboBox4.Text=="2")
              {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Course_32 ",sql);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.DataSource = dt;

              }
                else if (comboBox3.Text == "3" && comboBox4.Text == "1")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Course_31 ", sql);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
               
                
                
                //this.course_32TableAdapter.Fill(this.projectdatabaseDataSet.Course_32);
                //sql.Close();

            

           

        }

        private void cancelbutton2_Click(object sender, EventArgs e)
        {
            Mainloginform m = new Mainloginform();
            this.Hide();
            m.Show();

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            SqlConnection sql = Databaseconnection.Get_con();
            
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Marks_entries where  Student_ID = '" + textBox2.Text + "' ", sql);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dataGridView3.DataSource = dt;
                }


        }
        
    }
}
    

