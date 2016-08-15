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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void Apassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adminid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Mainloginform m = new Mainloginform();
            this.Hide();
            m.Show();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

            char[] mes = new char[10];
            string username = Adminid.Text;
            string psword = Apassword.Text;
            string query = "SELECT * from Ad_Login where Admin_id = '" + username + "'and Password ='" + psword + "'";
            Boolean check = search(query);
            if (check)
            {
                Admin_panel m = new Admin_panel();
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
    }
}
