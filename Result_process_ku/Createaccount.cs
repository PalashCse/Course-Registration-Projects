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
    public partial class Createaccount : Form
    {
        Boolean confirm;

        public Createaccount()
        {
            InitializeComponent();
        }

        private void Createaccount_Load(object sender, EventArgs e)
        {

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            String username = Crt_username.Text;
            String pass = Crt_password.Text;
            String cpass = Cnfrm_password.Text;

            if (username != "" && pass != "" && cpass != "" && pass == cpass)
            {
                String query = "INSERT INTO Stlogin VALUES('" + username + "','" + pass + "')";
                SaveInformation(query);
                if (confirm)
                {
                    MessageBox.Show("SignUp Complete Successfully.");
                    this.Hide();
                    Student_Login log = new Student_Login();
                    log.Show();
                }
                else
                {
                    MessageBox.Show("Something wrong");
                }
            }
            else
            {
                MessageBox.Show("Please Input Password Carefully.");
            }
        }

        public void SaveInformation(string query)
        {
            try
            {
                SqlConnection conn = Databaseconnection.Get_con();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                confirm = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

