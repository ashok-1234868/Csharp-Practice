using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOconectivity
{
    internal class Connection
    {
        public void Insert(string name1,int age1)
        {
            // insert values in tables
            string name = name1;
            int age = age1;
            string str = "Data Source=DESKTOP-B8HHSVO\\SQLEXPRESS;Initial Catalog=DEMO;Persist Security Info=True;User ID=sa;Password=1234;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(str);

            con.Open();
            string comment= $"insert into detail values('{name}',{age})";
            SqlCommand cmd = new SqlCommand(comment,con);
            cmd.ExecuteNonQuery();
            //SqlDataReader dr=cmd.ExecuteReader();
            con.Close();
           
        }
        public void Display()
        {
            string str = "Data Source=DESKTOP-B8HHSVO\\SQLEXPRESS;Initial Catalog=DEMO;Persist Security Info=True;User ID=sa;Password=1234;TrustServerCertificate=True";
            SqlConnection con = new SqlConnection(str);

            con.Open();
            string comment = "select * from detail";
            SqlCommand cmd = new SqlCommand(comment, con);
            //cmd.ExecuteNonQuery();
            SqlDataReader dr = cmd.ExecuteReader();
            //DISPLAYING THE DATA'S:

            while (dr.Read())
            {
                Console.WriteLine(dr[0] + "\t" + dr[1]);
            }

            con.Close();
        }
    }
}
