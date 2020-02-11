using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Yazıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.PageSettings = printDocument1.DefaultPageSettings;
            if (pageSetupDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.DefaultPageSettings = pageSetupDialog1.PageSettings;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Resim dosyaları|" + "*.bmp;*.jpg;*.gif;*.wmf;*.tif;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float x1, x2, x3, y, y2 = 0;
            Font etiket_fontu = new Font("Tahoma", 12, FontStyle.Bold);
            Font yazı_fontu = new Font("Tahoma", 12, FontStyle.Regular);
            Font baslık_fontu = new Font("Tahoma", 12, FontStyle.Bold);
            string metin;
            System.Drawing.Printing.PageSettings p;
            p = printDocument1.DefaultPageSettings;

            x1 = p.Margins.Left;
            metin = "Telefon Numarası:";
            x2 = x1 + e.Graphics.MeasureString(metin, etiket_fontu).Width;
            x3 = x2 + 200;
            y = p.Margins.Top;

            metin = "Personel Bilgileri:";
            e.Graphics.DrawString(metin, baslık_fontu, Brushes.Black, x1, y);
            y += e.Graphics.MeasureString(metin, baslık_fontu).Height;

            e.Graphics.DrawLine(new Pen(Color.Blue, 2), x1, y, p.PaperSize.Width - p.Margins.Left, y);
            y += 2;

            metin = "Adı Soyadı:";
            e.Graphics.DrawString(metin, etiket_fontu, Brushes.Black, x1, y);
            metin = textBox1.Text;
            e.Graphics.DrawString(metin, yazı_fontu, Brushes.Black, x2, y);

            metin = "Fotoğrafı:";
            e.Graphics.DrawString(metin, etiket_fontu, Brushes.Black, x3, y);
            y += e.Graphics.MeasureString(metin, etiket_fontu).Height;

            metin = "Telefon Numarası:";
            e.Graphics.DrawString(metin, etiket_fontu,Brushes.Black, x1, y);
            metin = textBox2.Text;
            e.Graphics.DrawString(metin, yazı_fontu, Brushes.Black, x2, y);
            try 
	        {	        
		        e.Graphics.DrawImage(pictureBox1.Image, x3, y, 150, 150);
                y2 = y + 150;
	        }
	        catch
	        {
                metin = "Resim Yazdırılamadı!";
                e.Graphics.DrawString(metin, yazı_fontu, Brushes.Blue, x3, y);
	        }
            y += e.Graphics.MeasureString(metin, etiket_fontu).Height;

            metin = "Adresi:";
            e.Graphics.DrawString(metin, etiket_fontu, Brushes.Black, x1, y);
            metin = textBox3.Text;
            e.Graphics.DrawString(metin, yazı_fontu, Brushes.Black, new RectangleF(x2, y, x3 - x2, p.PaperSize.Height));
            y += e.Graphics.MeasureString(metin, etiket_fontu).Height;
            if (y2 > y)
	        {
		        e.Graphics.DrawLine(new Pen(Color.Blue, 2), x1, y2, p.PaperSize.Width - p.Margins.Left, y2);
	        }
            else
	        {
                e.Graphics.DrawLine(new Pen(Color.Blue, 2), x1, y, p.PaperSize.Width - p.Margins.Left, y);
	        }

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
