using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VeriTabanıDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class DB
        {
            OleDbConnection baglanti;

            public bool baglantikontrol()
            {
                try
                {
                    baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanı.accdb");
                    baglanti.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB _vt = new DB();
            if (_vt.baglantikontrol() == true)
            {
                label1.Text = "Veri Tabanı ile Bağlantı Kuruldu.";
            }

            else
            {
                label1.Text = "Hata! Veri Tabanı ile Bağlantı Kurulamadı.";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanı.accdb");
            baglan.Open();
            OleDbCommand ekleme = new OleDbCommand("insert into giris(ıd,sifre) values(@ıd,@sifre)", baglan);
            

            ekleme.Parameters.Add("ıd", textBox1.Text);
            ekleme.Parameters.Add("sifre", textBox2.Text);


            int sonuc = ekleme.ExecuteNonQuery();

            if (sonuc > 0)
            {
                label4.Text = "Başarıyla Kayıt Oldunuz";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection();
            baglan.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanı.accdb");
            baglan.Open();
            string ıd = "Select * from giris where ıd='" + textBox1.Text + "'";
            string sifre = "Select * from giris where sifre='" + textBox2.Text + "'";
            OleDbCommand komut = new OleDbCommand(ıd, baglan);
            OleDbCommand komut2 = new OleDbCommand(sifre, baglan);
            OleDbDataReader reader = komut.ExecuteReader();
            OleDbDataReader reader2 = komut2.ExecuteReader();
            reader.Read(); reader2.Read();
            if (reader.HasRows == true && reader2.HasRows == true)
            {
                MessageBox.Show("Bilgiler Doğru. Sisteme Giriş Yapılıyor.");
                Form2 x = new Form2();
                x.Show(); this.Hide();
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı.");
                baglan.Close();
            }
        }
    }
}
