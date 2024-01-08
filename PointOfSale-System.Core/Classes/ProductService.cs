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
    public class ProductService:BaseService
    {
        

        bool result;
        //Add product data into the database
        public bool Add(Product product)
        {

            string query = "INSERT INTO Products (Name, Price, Quantity, IsActive) VALUES (@name, @price, @quantity, @isActive)";
            var parameters = new List<SqlParameter> {
            new SqlParameter("@name", product.Name),
            new SqlParameter("@price", product.Price),
            new SqlParameter("@quantity", product.Quantity),
            new SqlParameter("@isActive", 1)  // Set IsActive to 1
           };
            return ExecuteNonQuery(query, parameters) > 0;

        }


        //Update Product data in the database
        public bool Update(Product product, int id)
        {
           
            string query = "UPDATE Products SET Name = @name, Price = @price, Quantity = @quantity WHERE Id = @id";

            var parameters = new List<SqlParameter> {
               // new SqlParameter("@id", product.Id) ,
                new SqlParameter("@id", id) ,
                new SqlParameter("@name", product.Name),
                new SqlParameter("@price", product.Price),
                new SqlParameter("@quantity", product.Quantity),
                //new SqlParameter("@isActive", 1)
            };
           
                 return ExecuteNonQuery(query, parameters)>0;

        }



        //delete product data from the database
        public bool Delete(int id)
        {

            //string query = "DELETE FROM Products WHERE Id = @id ";
            string query = "UPDATE Products SET IsActive = 0 WHERE Id = @id";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                BaseService.conn.Open();

                int a = cmd.ExecuteNonQuery();
                result = a > 0;
                conn.Close();
            }
            return result;
        }



        //Search product by name
        public DataTable Search(string name)
        {
            string query = "SELECT * FROM Products WHERE Name LIKE @name + '%'";

            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.Parameters.AddWithValue("@name", name);

            DataTable data = new DataTable();
            sda.Fill(data);

            return data;

            
            
            
        }

    }
}
