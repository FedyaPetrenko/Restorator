using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using Restorator.Model;

namespace Restorator.DataAcces
{
    public static class StorageDbConnection
    {
        public static IList<Product> GetProducts()
        {
            var products = new ObservableCollection<Product>();
            try
            {
                using (
                    var connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RestoratorDb"].ConnectionString))
                {
                    var command = new SqlCommand("SELECT * FROM Products", connection);

                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        products.Add(new Product((Guid) dataReader["ProductId"], dataReader["Name"].ToString(),
                            dataReader["Description"].ToString(), (int?) dataReader["Price"], (int?) dataReader["Count"]));
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return products;
        }

        public static void AddProduct(Product product)
        {
            try
            {
                using (
                    var connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RestoratorDb"].ConnectionString))
                {
                    connection.Open();
                    var cmd =
                        new SqlCommand("INSERT INTO [Products] ([Name], [Description], [Price], [Count])" +
                                       "VALUES (@Name, @Description, @Price, @Count)", connection);
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Count", product.Count);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public static void DeleteProduct(Guid productId)
        {
            try
            {
                using (
                    var connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RestoratorDb"].ConnectionString))
                {
                    connection.Open();
                    var cmd = new SqlCommand("DELETE FROM [Products] WHERE [ProductId] = @ProductId", connection);
                    cmd.Parameters.AddWithValue("@ProductId", productId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public static void SaveChanges(Product product)
        {
            try
            {
                using (
                    var connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RestoratorDb"].ConnectionString))
                {
                    connection.Open();
                    var cmd =
                        new SqlCommand("UPDATE [Products] SET [Name]=@Name," +
                                       "[Description]=@Description, [Price]=@Price, [Count]=@Count " +
                                       "WHERE [ProductId]=@ProductId", connection);
                    cmd.Parameters.AddWithValue("@ProductId", product.ProductId);
                    cmd.Parameters.AddWithValue("@Name", product.Name);
                    cmd.Parameters.AddWithValue("@Description", product.Description);
                    cmd.Parameters.AddWithValue("@Price", product.Price);
                    cmd.Parameters.AddWithValue("@Count", product.Count);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static IList<Product> FindProduct(string name)
        {
            var products = new ObservableCollection<Product>();
            try
            {
                using (
                    var connection =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["RestoratorDb"].ConnectionString))
                {
                    var command = new SqlCommand("SELECT * FROM [Products] WHERE [Name]=@Name ", connection);
                    command.Parameters.AddWithValue("@Name", name);

                    connection.Open();
                    var dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        products.Add(new Product((Guid)dataReader["ProductId"], dataReader["Name"].ToString(),
                            dataReader["Description"].ToString(), (int?)dataReader["Price"], (int?)dataReader["Count"]));
                    }
                    dataReader.Close();
                    dataReader.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return products;
        }
    }
}
