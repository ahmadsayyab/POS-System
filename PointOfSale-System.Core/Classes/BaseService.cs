using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale_System;

namespace PointOfSale_System.Core.Classes
{
    public class BaseService
    {
      public static  string connString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public static SqlConnection conn = new SqlConnection(connString);
        protected int ExecuteNonQuery(string query, List<SqlParameter> parameters) 
        {
            try
            {

           
            using (SqlCommand cmd = new SqlCommand(query,conn))
            {
                cmd.Parameters.AddRange(parameters.ToArray());
                


                conn.Open();

                return cmd.ExecuteNonQuery();
            }
            }
            finally
            {
                conn.Close();

            }
        }

        public DataTable LoadProductData()
        {
            SqlConnection conn = new SqlConnection(connString);
            //string query = "SELECT * FROM Products";
            string query = "SELECT * FROM Products WHERE IsActive = 1";


            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            
            return dt;
        }

    }



}
