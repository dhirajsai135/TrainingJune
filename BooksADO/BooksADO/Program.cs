using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace BooksADO
{
    class Program
    {
        public void InsertBooks()
        {
            SqlConnection con = new SqlConnection("server=LAPTOP-1S1CRF3N\\SQLEXPRESS01;Integrated security=true;database=BookDB;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("insert into tbl_Book values('Malgudi Days',4,700)", con);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.InsertBooks();
            SqlConnection con = new SqlConnection("server=LAPTOP-1S1CRF3N\\SQLEXPRESS01;Integrated security=true;database=BookDB;Trusted_Connection=True;");
            SqlCommand cmd = new SqlCommand("select * from tbl_Book", con);
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
                Console.WriteLine(rdr["BookId"] + " " + rdr["BookTitle"] + " " + rdr["BookPrice"].ToString());
            con.Close();
            Console.ReadLine();
        }
    }
}
