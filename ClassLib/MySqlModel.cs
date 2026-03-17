using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace ClassLib
{
    public class MySqlModel
    {
        private const string connStr = "server=localhost;user=root;database=tapok_db;password=vertrigo;port=3306";

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "SELECT artikul, naimenovanie, edinica_izmereniya, cena, postavshchik_id, proizvoditel_id, kategoriya_id, deystvuyushchaya_skidka, kolichestvo_na_sklade, opisanie_tovara, foto FROM tovary";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            Product product = new Product(
                                reader.GetString(0),
                                reader.GetString(1),
                                reader.GetString(2),
                                reader.GetDouble(3),
                                reader.GetInt32(4),
                                reader.GetInt32(5),
                                reader.GetInt32(6),
                                reader.GetInt32(7),
                                reader.GetInt32(8),
                                reader.GetString(9),
                                reader.GetString(10)
                            );

                            products.Add(product);
                        }

                        return products;
                    }
                }
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public User Authorize(string login, string password)
        {
            User user = null;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "SELECT id, rol_id, fio, login, parol FROM polzovateli WHERE login = @login AND parol = @parol";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@parol", password);
                    
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new User(
                                reader.GetInt32(0),
                                reader.GetInt32(1),
                                reader.GetString(2),
                                reader.GetString(3),
                                reader.GetString(4)
                            );
                        }

                        return user;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddProduct(Product product)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "INSERT INTO tovary(artikul, naimenovanie, edinica_izmereniya, cena, postavshchik_id, proizvoditel_id, kategoriya_id, deystvuyushchaya_skidka, kolichestvo_na_sklade, opisanie_tovara, foto) " 
                        + "VALUES (@artikul, @naimenovanie, @edinica_izmereniya, @cena, @postavshchik_id, @proizvoditel_id, @kategoriya_id, @deystvuyushchaya_skidka, @kolichestvo_na_sklade, @opisanie_tovara, @foto)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@artikul", product.Article);
                    cmd.Parameters.AddWithValue("@naimenovanie", product.Name);
                    cmd.Parameters.AddWithValue("@edinica_izmereniya", product.Unit);
                    cmd.Parameters.AddWithValue("@cena", product.Price);
                    cmd.Parameters.AddWithValue("@postavshchik_id", product.SupplierId);
                    cmd.Parameters.AddWithValue("@proizvoditel_id", product.ManufacturerId);
                    cmd.Parameters.AddWithValue("@kategoriya_id", product.CategoryId);
                    cmd.Parameters.AddWithValue("@deystvuyushchaya_skidka", product.Discount);
                    cmd.Parameters.AddWithValue("@kolichestvo_na_sklade", product.Amount);
                    cmd.Parameters.AddWithValue("@opisanie_tovara", product.Description);
                    cmd.Parameters.AddWithValue("@foto", product.ImagePath);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetCategories()
        {
            List<string> categories = new List<string>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "SELECT nazvanie FROM kategorii_tovara";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader.GetString(0));
                        }

                        return categories;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetManufacturers() 
        {
            List<string> manufacturers = new List<string>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "SELECT nazvanie FROM proizvoditeli";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            manufacturers.Add(reader.GetString(0));
                        }

                        return manufacturers;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> GetSuppliers()
        {
            List<string> suppliers = new List<string>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "SELECT nazvanie FROM postavshchiki";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(reader.GetString(0));
                        }

                        return suppliers;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "UPDATE tovary SET naimenovanie = @naimenovanie, edinica_izmereniya = @edinica_izmereniya, cena = @cena, " +
                        "postavshchik_id = @postavshchik_id, proizvoditel_id = @proizvoditel_id, kategoriya_id = @kategoriya_id, " +
                        "deystvuyushchaya_skidka = @deystvuyushchaya_skidka, kolichestvo_na_sklade = @kolichestvo_na_sklade, opisanie_tovara = @opisanie_tovara, foto = @foto " +
                        "WHERE artikul = @artikul";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@naimenovanie", product.Name);
                    cmd.Parameters.AddWithValue("@edinica_izmereniya", product.Unit);
                    cmd.Parameters.AddWithValue("@cena", product.Price);
                    cmd.Parameters.AddWithValue("@postavshchik_id", product.SupplierId);
                    cmd.Parameters.AddWithValue("@proizvoditel_id", product.ManufacturerId);
                    cmd.Parameters.AddWithValue("@kategoriya_id", product.CategoryId);
                    cmd.Parameters.AddWithValue("@deystvuyushchaya_skidka", product.Discount);
                    cmd.Parameters.AddWithValue("@kolichestvo_na_sklade", product.Amount);
                    cmd.Parameters.AddWithValue("@opisanie_tovara", product.Description);
                    cmd.Parameters.AddWithValue("@foto", product.ImagePath);
                    cmd.Parameters.AddWithValue("@artikul", product.Article);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteProduct(string article)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "DELETE FROM tovary WHERE artikul = @artikul";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@artikul", article);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connStr))
                {
                    connection.Open();

                    string query = "SELECT z.nomer_zakaza, z.data_zakaza, z.data_dostavki, pv.adres, p.fio, z.kod_polucheniya, z.status_zakaza FROM zakazy z " +
                        "JOIN punkty_vydachi pv ON z.adres_punkta_vydachi_id = pv.id " +
                        "JOIN polzovateli p ON z.fio_klienta_id = p.id;";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order(
                                reader.GetInt32(0), 
                                reader.GetDateTime(1), 
                                reader.GetDateTime(2), 
                                reader.GetString(3),
                                reader.GetString(4),
                                reader.GetInt32(5),
                                reader.GetString(6)
                            );

                            orders.Add(order);
                        }

                        return orders;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
