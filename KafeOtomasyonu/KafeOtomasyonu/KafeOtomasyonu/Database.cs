using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KafeOtomasyonu
{
    class Database
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");

        public bool connection()
        {
            try
            {
                con.Open();
                MessageBox.Show("Connection Successful");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Failed");
                return false;
            }
        }

        //Ürün
        public SqlDataReader selectProductGroup()
        {
            SqlCommand cmd = new SqlCommand("Select Name from ProductGroup", con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
         
        }
        //insert
        public void addProduct(string Name, double Price, int ProductGroupId, string PicturePath)
        {
            SqlCommand cmd = new SqlCommand("Insert into Product (ProductNumber, Name, Price, ProductGroupId, PicturePath) values (@productNumber, @name, @price, @productGroupId, @picturePath)");
            //cmd.Parameters.AddWithValue("@productNumber", ProductNumber);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@productGroupId", ProductGroupId);
            cmd.Parameters.AddWithValue("@picturePath", PicturePath);
            cmd.ExecuteNonQuery();
        }

        /*public SqlDataReader selectUserFunction(string UserName, string Password)
        {
            SqlCommand sel=new SqlCommand("Select count(*) from User where UserName=@UserName")
        }*/
    }
}
