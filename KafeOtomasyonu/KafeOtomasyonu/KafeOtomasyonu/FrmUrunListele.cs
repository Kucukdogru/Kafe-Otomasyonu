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
    public partial class FrmUrunListele : Form
    {
        public FrmUrunListele()
        {
            InitializeComponent();
        }

        private void ürünleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        //Listele
        private void kayitGetir()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            try
            {
                con.Open();
                MessageBox.Show("Connection Successful");
                SqlCommand komut = new SqlCommand("SELECT ProductNumber, Name, Price, ProductGroupId, PicturePath from Product", con);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
                DataTable dt = new DataTable();
                da.Fill(dt);
                //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
                dataGridView1.DataSource = dt;
                //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Failed"); 
            }
            
        }

        private void FrmUrunListele_Load(object sender, EventArgs e)
        {
            this.productGroupTableAdapter1.Fill(this.kafe1.ProductGroup);
            //dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
            kayitGetir();                      
        }
        

        //Ekleme
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            con.Open();
            try
            {
                MessageBox.Show(comboBox1.SelectedIndex.ToString());
                MessageBox.Show(comboBox1.SelectedValue.ToString());
                DataSet ds = new DataSet();
                ds.Clear();
                SqlCommand komut = new SqlCommand("INSERT INTO Product(Name, Price, ProductGroupId, PicturePath) VALUES ('" + textBox1.Text + "','" + Convert.ToDecimal(textBox2.Text) + "','" + (int)comboBox1.SelectedValue + "','" + textBox4.Text + "')", con);
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Urun basarılı bir sekilde eklendi");
                kayitGetir();
                this.Hide();
                FrmUrunler frm = new FrmUrunler();
                frm.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
            //DataTable tablo = new DataTable();
            //tablo.Rows.Add(textBox1.Text, Convert.ToDecimal(textBox2.Text), comboBox1.SelectedIndex, textBox4.Text);
            //dataGridView1.DataSource = tablo;
                        
        }


        //Gözat
        private void button2_Click(object sender, EventArgs e)
        {            
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    openFileDialog1.Title = "Resim Seçiniz";
                    openFileDialog1.InitialDirectory = @"C:\Users\CASPER\Downloads";
                    openFileDialog1.Filter = "Tüm Dosyalar (*.*) | *.* | Resim Dosyaları|*.png; *.jpg;";
                    openFileDialog1.FilterIndex = 1;
                    string resimYolu = openFileDialog1.FileName;
                    pictureBox1.ImageLocation = resimYolu;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    textBox4.Text = resimYolu;
                    textBox4.Enabled = false;

                }
            
        }
        

        //Silme
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                //{
                    int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
                con.Open();
                MessageBox.Show("Connection Succesful");
                SqlCommand cmd = new SqlCommand("Delete from Product Where ProductNumber='" + id + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kayıt Başarılı Bir Şekilde Silindi");
                kayitGetir();
                //}
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        //Güncelleme
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            try
            {
                con.Open();
                MessageBox.Show("Connection Successful");
                int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
                SqlCommand cmd = new SqlCommand("Update Product Set Name=@Name,Price=@Price,ProductGroupId=@ProductGroupId,PicturePath=@PicturePath Where ProductNumber='"+ id + "'", con);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(textBox2.Text));
                cmd.Parameters.AddWithValue("@ProductGroupId", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@PicturePath", textBox4.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Urun basarılı bir sekilde GÜNCELLENDİ");
                kayitGetir();

                //DataSet ds = new DataSet();
                //ds.Clear();
                ////strsql.Append(Update genelbilgi Set Tc_no = '"+TB_TC.Text+"', ")

                //SqlCommand komut = new SqlCommand("Update [Product] Set Name='" + textBox1.Text + "','" + "' + Price='" + Convert.ToDecimal(textBox2.Text) + "','" + "' + ProductGroupId='" + comboBox1.SelectedIndex + "','" + "' + PicturePath='" + textBox4.Text + "'", con);
                //komut.ExecuteNonQuery();
                //con.Close();
                //MessageBox.Show("Urun basarılı bir sekilde GÜNCELLENDİ");
                //this.Hide();
                //FrmUrunler frm = new FrmUrunler();
                //frm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
           
        }

        //İptal
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }


        //datagridview cell content click
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        //Ekle fonksiyonu
        private void Ekle()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            try
            {
                con.Open();
                MessageBox.Show("Connection Successful");
                SqlCommand cmd = new SqlCommand("insert into Product (Name,Price,ProductGroupId,PicturePath) values (@Name,@Price,@ProductGroupId,@PicturePath)", con);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(textBox2.Text));
                cmd.Parameters.AddWithValue("@ProductGroupId", comboBox1.SelectedIndex);
                cmd.Parameters.AddWithValue("@PicturePath", textBox4.Text);

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Connection Failed");
            }
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Selected)
            {            
                //seçli satırın backcolor rengini kırmızı yapıyoruz.
                e.CellStyle.SelectionBackColor = Color.Red;                
            }
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUrunEkle ekle = new FrmUrunEkle();
            ekle.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //[0] sütun numarası
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].ToString();
        }
    }
}
