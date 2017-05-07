using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Sql;

namespace MvcApplication1
{
    public class BLL
    {
        
        public int GetCount()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Select top 1 Cnt from dbo.Counter";
            using (con)
            {
                con.Open();
                return (int)cmd.ExecuteScalar();
            }
            
        }
        public void Increment()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update dbo.Counter set cnt=cnt+1 where cnt<10";
            using (con)
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}