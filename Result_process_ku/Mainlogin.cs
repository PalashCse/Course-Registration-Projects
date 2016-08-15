using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Result_processing_ku
{
    public partial class Mainloginform : Form
    {
        public Mainloginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Adminbutton_Click(object sender, EventArgs e)
        {
            Admin_Login al = new Admin_Login();
            this.Hide();
            al.Show();

        }

        private void Studentbutton_Click(object sender, EventArgs e)
        {
            Student_Login sl = new Student_Login();
            this.Hide();
            sl.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
