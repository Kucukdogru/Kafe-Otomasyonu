using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace KafeOtomasyonu
{
    public partial class FrmUrunEkle : Form
    {

        public Kafe.ProductRow row;
        public bool yeni;
        FrmUrunler frmUrun = new FrmUrunler();
        public FrmUrunEkle()
        {
            InitializeComponent();
        }
       
        Database database = new Database();
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
                pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
                textBox4.Text = resimYolu;
                textBox4.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            con.Open();
            
            try
            {
                DataSet ds = new DataSet();
                ds.Clear();
                SqlCommand komut = new SqlCommand("INSERT INTO Product(Name, Price, ProductGroupId, PicturePath) VALUES ('" + textBox1.Text + "','" + Convert.ToDecimal(textBox2.Text) + "','" + (int)comboBox1.SelectedValue + "','" + textBox4.Text + "')", con);
                komut.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Urun basarılı bir sekilde eklendi");
                this.Hide();
                FrmUrunler frm = new FrmUrunler();
                frm.ShowDialog();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            this.productGroupTableAdapter1.Fill(this.kafe1.ProductGroup);
            //this.categoryTableAdapter.Fill(this.ticari.category);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
        }
    }
}
