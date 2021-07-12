using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TaskDDL17th.Models
{
    public class DeptModel
    {
        public DataTable GetDepartment()
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection("data source=LAPTOP-1S1CRF3N\\SQLEXPRESS01;database=AdventureWorks2019;Integrated Security=true");
            SqlCommand cmd = new SqlCommand("select DepartmentID,Name from HumanResources.Department", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;

        }
    }
}