using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeOtomasyonu
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }
        Database database = new Database();

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUrunEkle ekle = new FrmUrunEkle();
            ekle.ShowDialog();
        }

        private void ürünleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            FrmUrunListele listele = new FrmUrunListele();
            listele.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (Control item in this.groupBox1.Controls)
            {
                if(item is CheckBox)
                {
                    if (((CheckBox)item).Checked == true)
                    {
                        listBox1.Items.Add(((CheckBox)item).Text.ToString());
                    }
                }
            }
            Hesap();
        }

        private void Hesap()
        {
            double tutar = 0;
            if (checkBox1.Checked)
            {
                tutar += 15;
            }
            if (checkBox2.Checked)
            {
                tutar += 25;
            }
            if (checkBox3.Checked)
            {
                tutar += 20;
            }
            if (checkBox4.Checked)
            {
                tutar += 8;
            }
            if (checkBox5.Checked)
            {
                tutar += 18;
            }
            if (checkBox6.Checked)
            {
                tutar += 13;
            }
            if (checkBox7.Checked)
            {
                tutar += 12;
            }
            if (checkBox8.Checked)
            {
                tutar += 10;
            }
            if (checkBox9.Checked)
            {
                tutar += 15;
            }
            if (checkBox10.Checked)
            {
                tutar += 19;
            }
            if (checkBox11.Checked)
            {
                tutar += 10;
            }
            if (checkBox12.Checked)
            {
                tutar += 15;
            }
            if (checkBox13.Checked)
            {
                tutar += 10;
            }
            if (checkBox14.Checked)
            {
                tutar += 15;
            }
            if (checkBox15.Checked)
            {
                tutar += 10;
            }
            if (checkBox16.Checked)
            {
                tutar += 15;
            }

            textBox1.Text = tutar.ToString();
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hesap Ödendi");
            listBox1.Items.Clear();
            /*foreach (Control item in this.Controls)
            { 
                if (item is CheckBox)
                {
                    item.Checked = false;
                }

            }*/
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciEkle frm = new FrmKullaniciEkle();
            frm.ShowDialog();
            this.Hide();
        }

        private void kullanıcıListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKullaniciListele frm = new FrmKullaniciListele();
            frm.ShowDialog();
        }
    }
}
