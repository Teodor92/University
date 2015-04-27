namespace SimpleBookSotre.Tools.Migrator
{
    using System;
    using System.Data.SqlClient;
    using System.Linq;

    using SimpleBookStore.Data;
    using SimpleBookStore.Data.Models;

    public class Program
    {
        internal static void Main(string[] args)
        {
            MigrateBooksTable();
            MigrateGuestBook();
            MigrateShopingCart();
        }

        private static void MigrateBooksTable()
        {
            var uow = new SbsData();

            const string ConnectionString = "Data Source=.;Initial Catalog=BooksDBSQL;Integrated Security=True";
            const string queryString = "SELECT * FROM dbo.Books";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var bookType = reader.GetString(1);

                        var type = uow.BookTypes.All().FirstOrDefault(x => x.Name == bookType);
                        if (type == null)
                        {
                            type = new BookType()
                            {
                                Name = bookType
                            };

                            uow.BookTypes.Add(type);
                            uow.SaveChanges();
                        }

                        var book = new Book()
                        {
                            BookId = reader.GetString(0),
                            TypeId = type.Id,
                            Title = reader.GetString(2),
                            Author = reader.GetString(3),
                            Description = reader.GetString(4),
                            Price = reader.GetDecimal(5),
                            Quantity = reader.GetInt32(6),
                            IsOnSale = reader.GetBoolean(7)
                        };

                        var bookExists = uow.Books.All().Any(x => x.BookId == book.BookId);

                        if (!bookExists)
                        {
                            uow.Books.Add(book);
                            uow.SaveChanges();
                        }
                    }

                    Console.WriteLine("Done");

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void MigrateGuestBook()
        {
            var uow = new SbsData();

            if (!uow.Guests.All().Any())
            {
                const string ConnectionString = "Data Source=.;Initial Catalog=BooksDBSQL;Integrated Security=True";
                const string queryString = "SELECT * FROM dbo.gestbook";

                using (SqlConnection connection =
                    new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {

                            var guest = new Guest()
                            {
                                Name = reader.GetString(0),
                                Email = reader.GetString(1)
                            };

                            uow.Guests.Add(guest);
                            uow.SaveChanges();
                        }

                        Console.WriteLine("Done");

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private static void MigrateShopingCart()
        {
            var uow = new SbsData();

            const string ConnectionString = "Data Source=.;Initial Catalog=BooksDBSQL;Integrated Security=True";
            const string queryString = "SELECT * FROM dbo.ShopCart";

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var bookId = reader.GetString(1);
                        var book = uow.Books.All().FirstOrDefault(x => x.BookId == bookId);

                        if (book != null)
                        {
                            var cartItem = new ShopingCartItem()
                            {
                                OrderId = reader.GetString(0),
                                BookId = book.Id,
                            };

                            uow.ShopingCart.Add(cartItem);
                            uow.SaveChanges();
                        }
                    }

                    Console.WriteLine("Done");

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
