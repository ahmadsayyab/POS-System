﻿using System;
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
    public class Services
    {
      public static  string connString = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;
        public static SqlConnection conn = new SqlConnection(connString);


        public DataTable LoadProductData()
        {
            SqlConnection conn = new SqlConnection(connString);
            string query = "SELECT * FROM Products";

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            sda.Fill(dt);

            
            return dt;
        }

    }



}
