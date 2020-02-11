using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ÇokAmaçlıProgram
{
    public partial class KayitMenüsü : Form
    {
        public KayitMenüsü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanı.accdb");
            baglan.Open();
            OleDbCommand ekleme = new OleDbCommand("insert into giris(ıd,sifre, ad_soyad, okul_no) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", baglan);

            int sonuc = ekleme.ExecuteNonQuery();
            
            if (sonuc > 0)
            {
                MessageBox.Show("Başarıyla Kayıt Oldunuz. Yönlendiriliyorsunuz.");
                KullaniciGirisi giris = new KullaniciGirisi();
                giris.Show(); this.Hide();
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Üzgünüz Kayıt Olamadınız. Tekrar Deneyin.");
                baglan.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void KayitMenüsü_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KullaniciGirisi x = new KullaniciGirisi();
            x.Show(); this.Hide();
        }
    }
}
