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
    public partial class KullaniciGirisi : Form
    {
        //OleDbConnection baglan = new OleDbConnection();
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanı.accdb");
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            baglan.Open();

            string ıd = "Select * from giris where ıd='" + textBox1.Text + "'";
            string sifre = "Select * from giris where sifre='" + textBox2.Text + "'";
            string okulno = "Select * from giris where okul_no='" + textBox3.Text + "'";
            OleDbCommand komut = new OleDbCommand(ıd, baglan);
            OleDbCommand komut2 = new OleDbCommand(sifre, baglan);
            OleDbCommand komut3 = new OleDbCommand(okulno, baglan);
            OleDbDataReader reader = komut.ExecuteReader();
            OleDbDataReader reader2 = komut2.ExecuteReader();
            OleDbDataReader reader3 = komut3.ExecuteReader();
            reader.Read(); reader2.Read();
            if (reader.HasRows == true && reader2.HasRows == true && reader3.HasRows == true)
            {
                MessageBox.Show("Girdiğiniz Bilgiler Doğru. Sisteme Giriş Yapılıyor.");
                Menü menü = new Menü();
                menü.Show(); this.Hide();
                baglan.Close();
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı.");
                baglan.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitMenüsü kayitmenü = new KayitMenüsü();
            kayitmenü.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglan.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=veritabanı.accdb");
            baglan.Close();
            Close();
        }

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
