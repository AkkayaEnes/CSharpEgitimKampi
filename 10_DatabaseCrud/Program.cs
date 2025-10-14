using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud ---> Create-Read-Update-Delete

            Console.WriteLine("**** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");
            #region Kategori Ekleme İşlemi

            //Console.WriteLine("Eklemek istediğiniz kategori adı: ");
            //string kategoriAdi = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NJ2LCKE;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand sql = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //sql.Parameters.AddWithValue("@p1", kategoriAdi);
            //sql.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarıyla eklendi.");

            #endregion


            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //Console.Write("Ürün Aktif mi? (0-1): ");
            //productStatus = bool.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NJ2LCKE;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand sql = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)", connection);
            //sql.Parameters.AddWithValue("@p1", productName);
            //sql.Parameters.AddWithValue("@p2", productPrice);
            //sql.Parameters.AddWithValue("@p3", productStatus);
            //sql.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün başarıyla eklendi.");


            #endregion


            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NJ2LCKE;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand sql = new SqlCommand("Select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(sql);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString());
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi
            //Console.WriteLine("Silinecek İd giriniz: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NJ2LCKE;initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand sqlQuery = new SqlCommand("Delete from tblproduct where ProductId=@productId", connection);
            //sqlQuery.Parameters.AddWithValue("@productId", productId);
            //sqlQuery.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Başarıyla silindi.");


            #endregion

            #region Ürün Düzenleme İşlemi

            Console.WriteLine("Düzenlenecek İd giriniz: ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Düzenlenecek Adı giriniz: ");
            string productName = Console.ReadLine();

            Console.WriteLine("Düzenlenecek Fiyatı giriniz: ");
            int productPrice = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NJ2LCKE;initial catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand sqlQuery = new SqlCommand("UPDATE tblproduct SET productName=@p2, productPrice=@p3 WHERE productId=@p1", connection);
            sqlQuery.Parameters.AddWithValue("@p1", productId);
            sqlQuery.Parameters.AddWithValue("@p2", productName);
            sqlQuery.Parameters.AddWithValue("@p3", productPrice);
            sqlQuery.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Ürün düzenlendi.");

            #endregion

            Console.Read();
        }
    }
}
