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
    public partial class Student_Login : Form
    {
        public Student_Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Studentid_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Spassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            char[] mes = new char[10];
            string username = Studentid.Text;
            string psword = Spassword.Text;
            string query = "SELECT * from Stlogin where Student_id = '" + username + "'and Password ='" + psword + "'";
            Boolean check = search(query);
            if (check)
            {
                Student_homepanel m = new Student_homepanel();
                this.Hide();
                m.Show();
            }
            else if (username == "" || psword == "")
            {
                MessageBox.Show("Usernane and password are invalid");

            }
            else
            {
                MessageBox.Show("Usernane and password are invalid");
            }
        }

        Boolean search(string a)
        {
            int sh = 0;
            SqlConnection conn = Databaseconnection.Get_con();
            SqlCommand cmd = new SqlCommand(a, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            sh = dt.Rows.Count;
            if (sh != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Mainloginform m = new Mainloginform();
            this.Hide();
            m.Show();
        }

        private void Signupbutton_Click(object sender, EventArgs e)
        {
            Createaccount ca = new Createaccount();
            this.Hide();
            ca.Show();
        }
    }
}
