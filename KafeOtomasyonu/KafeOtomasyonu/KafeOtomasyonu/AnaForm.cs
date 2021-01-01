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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Alanlarını Boş Bırakamazsınız.");
                return;
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\KafeOtomasyonu\KafeOtomasyonu\KafeOtomasyonu\Kafe.mdf;Integrated Security=True");
            
            con.Open();
            MessageBox.Show("Connection Successful");
            
            SqlCommand cmd = new SqlCommand("SELECT * FROM [User] Where UserName = '" +  textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Kullanıcı Adı Ve Şifre Doğru");
                this.Hide();
                FrmMasa masa = new FrmMasa();
                masa.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Ve Şifre Yanlış");
            }
            con.Close();           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
