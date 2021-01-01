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
    public partial class FrmKullaniciEkle : Form
    {
        public FrmKullaniciEkle()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != textBox5.Text)
            {
                MessageBox.Show("Şifreler Eşleşmiyor");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CASPER\Desktop\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True;");
                con.Open();
                MessageBox.Show("Connection Succesfull");
                SqlCommand cmd = new SqlCommand("Insert Into [User] (UserName, Password, Name, Surname) VALUES('" + textBox3.Text + "' , '" + textBox4.Text + "' , '" + textBox1.Text + "','" + textBox2.Text + "')  ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Kullanıcı Başarılı Bir Şekilde Eklendi.");
                FrmUrunler frm = new FrmUrunler();
                frm.ShowDialog();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
