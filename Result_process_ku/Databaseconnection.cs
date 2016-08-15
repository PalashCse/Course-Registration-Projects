using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data.SqlClient;

namespace Result_processing_ku
{
    class Databaseconnection
    {
         

        public static SqlConnection Get_con()
        {
            string con = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\Term 3-1\All projects\Result processing ku\Result processing ku\projectdatabase.mdf;Integrated Security=True";
            
            SqlConnection Conn = new SqlConnection(con);
            Conn.Open();
            return Conn;
        }

        public static SqlConnection disconnect(SqlConnection conn)
        {
            conn.Close();
            return conn;
        }


        
    }
}

