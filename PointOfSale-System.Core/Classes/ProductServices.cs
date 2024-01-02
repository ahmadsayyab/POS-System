using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PointOfSale_System.Core.Classes
{
    public class ProductServices
    {
        

        bool result;
        //Add product data into the database
        public bool Add(Product product)
        {
           

            string query = "INSERT INTO Products VALUES (@name,@price, @quantity)";

            using (SqlCommand cmd = new SqlCommand(query, Services.conn))
            {
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);

                Services.conn.Open();

                
                int a = cmd.ExecuteNonQuery();


                result = a > 0;
                Services.conn.Close();
            }
           
            

            return result;
        }


        //Update Product data in the database
        public bool Update(Product product, int id)
        {
           
            string query = "UPDATE Products SET Name = @name, Price = @price, Quantity = @quantity WHERE Id = @id";

            using (SqlCommand cmd = new SqlCommand(query, Services.conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", product.Name);
                cmd.Parameters.AddWithValue("@price", product.Price);
                cmd.Parameters.AddWithValue("@quantity", product.Quantity);

             
                Services.conn.Open();

                int a = cmd.ExecuteNonQuery();

               
                result = a > 0;
                Services.conn.Close();
            }
            return result;
        }



        //delete product data from the database
        public bool Delete(int id)
        {

            string query = "DELETE FROM Products WHERE Id = @id ";

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



        //Search product by name
        public DataTable Search(string name)
        {
            string query = "SELECT * FROM Products WHERE Name LIKE @name + '%'";

            SqlDataAdapter sda = new SqlDataAdapter(query, Services.conn);
            sda.SelectCommand.Parameters.AddWithValue("@name", name);

            DataTable data = new DataTable();
            sda.Fill(data);

            return data;

            
            
            
        }

    }
}
