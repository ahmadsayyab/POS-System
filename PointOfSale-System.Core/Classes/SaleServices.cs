using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_System.Core.Classes
{
    public class SaleServices
    {

        bool result;
        public bool Add(int id, Sale sale)
        {
           
                string query = "INSERT INTO Sales (ProductId, QuantitySold, TotalAmount) VALUES (@productId, @quantity, @totalAmount)";

                using (SqlCommand cmd = new SqlCommand(query, Services.conn))
                {
                    cmd.Parameters.AddWithValue("@productId", id);
                    cmd.Parameters.AddWithValue("@quantity", sale.QuantitySold);
                    cmd.Parameters.AddWithValue("@totalAmount", sale.TotalAmount);
                    Services.conn.Open();
                    int a = cmd.ExecuteNonQuery();


                     result = a > 0;
                     Services.conn.Close();
                }
            return result;

        }


        public bool Delete(int id)
        {
            string query = "DELETE FROM Sales WHERE Id = @id ";

            using (SqlCommand cmd = new SqlCommand(query, Services.conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                Services.conn.Open();

                int a = cmd.ExecuteNonQuery();
                result = a > 0;
                Services.conn.Close();
            }
            return result;
        }
    }
}
