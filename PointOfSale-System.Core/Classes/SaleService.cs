using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale_System.Core.Classes
{
    public class SaleService : BaseService
    {

        bool result;
        public bool Add(int id, Sale sale)
        {
           
                string query = "INSERT INTO Sales (ProductId, QuantitySold, TotalAmount, DiscountPerItem) VALUES (@productId, @quantity, @totalAmount, @discountPerItem)";

            
            var parameters = new List<SqlParameter> {
            new SqlParameter("@productId", id),
            new SqlParameter("@quantity", sale.QuantitySold),
            new SqlParameter("@totalAmount", sale.TotalAmount),
            new SqlParameter("@discountPerItem", sale.DiscountPerItem)
        };
            return ExecuteNonQuery(query, parameters) > 0;

            //using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@productId", id);
            //        cmd.Parameters.AddWithValue("@quantity", sale.QuantitySold);
            //        cmd.Parameters.AddWithValue("@totalAmount", sale.TotalAmount);
            //        cmd.Parameters.AddWithValue("@discountPerItem", sale.DiscountPerItem);
            //        conn.Open();
            //        int a = cmd.ExecuteNonQuery();


            //         result = a > 0;
            //        conn.Close();
            //    }
            //return result;

        }


       
    }
}
