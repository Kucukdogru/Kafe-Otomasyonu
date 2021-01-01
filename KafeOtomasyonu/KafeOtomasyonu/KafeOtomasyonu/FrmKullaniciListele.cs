using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KafeOtomasyonu
{
    public partial class FrmKullaniciListele : Form
    {
        public FrmKullaniciListele()
        {
            InitializeComponent();
        }
        private void getir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("SELECT UserNumber, UserName, Name, Surname from [User]", con);

            DataTable dt = new DataTable();

            // Şimdi DataSet'e bak bu senin tablon ona sahip çık diyelim..
            //DataSet.tables.add(dt);

            // Şimdi körpüyü kurma zamanı yani DataAdaptor ve sorgusu...
            SqlDataAdapter kopru = new SqlDataAdapter(cmd);

            // Buda bittikten sora sıra geldi bu tabloya verileri doldurmaya..
            kopru.Fill(dt);

            // E herşey hazır.. veriler artık elimizde datatable'ın içinde duruo, şimdi tek yapmamız gereken datagridview'a bak gridview al sana tablo, içindede veriler var.. al bunları göster demek..
            dataGridView1.DataSource = dt;

        }
        private void doldur()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            
                con.Open();
                MessageBox.Show("Connection Successful");
                SqlCommand komut = new SqlCommand("SELECT UserNumber, UserName, Name, Surname from User", con);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
                DataTable dt = new DataTable();
                da.Fill(dt);
                //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
                dataGridView1.DataSource = dt;
                //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
                con.Close();

            

        }

        private void FrmKullaniciListele_Load(object sender, EventArgs e)
        {
            getir();
            //doldur();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //[0] sütun numarası
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            con.Open();
            MessageBox.Show("Connection Succesful");
            //SqlCommand cmd = new SqlCommand("Update [User] Set UserName='" + textBox1.Text + "','" + "' + Name='" + textBox2.Text + "','" + "'+ Surname='" + textBox3.Text + "','" + "'", con);
            SqlCommand cmd = new SqlCommand("Update [User] Set UserName=@UserName , Name=@Name , Surname=@Surname Where UserNumber='" + id + "'", con);
            cmd.Parameters.AddWithValue("@UserName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Surname", textBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar Basarılı Bir Şekilde Guncellendi:)");
            con.Close();
            getir();
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {
                //seçli satırın backcolor rengini kırmızı yapıyoruz.
                e.CellStyle.SelectionBackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            con.Open();
            MessageBox.Show("Connection Succesful");
            //SqlCommand cmd = new SqlCommand("Update [User] Set UserName='" + textBox1.Text + "','" + "' + Name='" + textBox2.Text + "','" + "'+ Surname='" + textBox3.Text + "','" + "'", con);
            SqlCommand cmd = new SqlCommand("Insert Into [User] ( UserName,Name,Surname,Password) Values(@UserName ,@Name ,@Surname, @Password) ", con);
            cmd.Parameters.AddWithValue("@UserName", textBox3.Text);
            cmd.Parameters.AddWithValue("@Name", textBox1.Text);
            cmd.Parameters.AddWithValue("@Surname", textBox2.Text);
            cmd.Parameters.AddWithValue("@Password", textBox4.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Kayıtlar Basarılı Bir Şekilde Eklendi:)");
            con.Close();
            getir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
                con.Open();
                MessageBox.Show("Connection Succesful");
                SqlCommand cmd = new SqlCommand("Delete from [User] Where UserNumber='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi");
                getir();
            }
            else
            {
                MessageBox.Show("Lütfen Silinecek Kaydı Seçiniz");
            }
        }
    }
}
