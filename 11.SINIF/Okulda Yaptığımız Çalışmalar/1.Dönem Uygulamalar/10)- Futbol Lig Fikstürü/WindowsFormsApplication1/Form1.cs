using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SuperLig : Form
    {
        
        public SuperLig()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox2.Text) + Convert.ToInt16(textBox3.Text) + Convert.ToInt16(textBox4.Text) > Convert.ToInt16(textBox1.Text))
            {
                MessageBox.Show("Beşiktaş Takımının Maç Sayısını Fazla Girdiniz.!", "UYARI!");
                textBox2.Text = " "; textBox3.Text = " "; textBox4.Text = " ";
            }
            else if (Convert.ToInt16(textBox5.Text) + Convert.ToInt16(textBox6.Text) + Convert.ToInt16(textBox7.Text) > Convert.ToInt16(textBox1.Text))
            {
                MessageBox.Show("Galatasaray Takımının Maç Sayısını Fazla Girdiniz.!", "UYARI!");
                textBox5.Text = " "; textBox6.Text = " "; textBox7.Text = " ";
            }
            else if (Convert.ToInt16(textBox8.Text) + Convert.ToInt16(textBox9.Text) + Convert.ToInt16(textBox10.Text) > Convert.ToInt16(textBox1.Text))
            {
                MessageBox.Show("Fenerbahçe Takımının Maç Sayısını Fazla Girdiniz.!", "UYARI!");
                textBox8.Text = " "; textBox9.Text = " "; textBox10.Text = " ";
            }
            else if (Convert.ToInt16(textBox11.Text) + Convert.ToInt16(textBox12.Text) + Convert.ToInt16(textBox13.Text) > Convert.ToInt16(textBox1.Text))
            {
                MessageBox.Show("KOCAELİSPOR Takımının Maç Sayısını Fazla Girdiniz.!", "UYARI!");
                textBox11.Text = " "; textBox12.Text = " "; textBox13.Text = " ";
            }
            else
            {
                int bjk = Convert.ToInt16(textBox2.Text) + Convert.ToInt16(textBox3.Text) + Convert.ToInt16(textBox4.Text);
                label9.Text = Convert.ToString(bjk);
                int gs = Convert.ToInt16(textBox5.Text) + Convert.ToInt16(textBox6.Text) + Convert.ToInt16(textBox7.Text);
                label10.Text = Convert.ToString(gs);
                int fb = Convert.ToInt16(textBox8.Text) + Convert.ToInt16(textBox9.Text) + Convert.ToInt16(textBox10.Text);
                label11.Text = Convert.ToString(fb);
                int KS = Convert.ToInt16(textBox11.Text) + Convert.ToInt16(textBox12.Text) + Convert.ToInt16(textBox13.Text);
                label12.Text = Convert.ToString(KS);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bjkgp = Convert.ToInt16(textBox2.Text) * 3;
            int gsgp = Convert.ToInt16(textBox5.Text) * 3;
            int fbgp = Convert.ToInt16(textBox8.Text) * 3;
            int ksgp = Convert.ToInt16(textBox11.Text) * 3;

            int bjkbp = Convert.ToInt16(textBox3.Text) * 1;
            int gsbp = Convert.ToInt16(textBox6.Text) * 1;
            int fbbp = Convert.ToInt16(textBox9.Text) * 1;
            int ksbp = Convert.ToInt16(textBox11.Text) * 1;
                        
            label13.Text = Convert.ToString(bjkgp + bjkbp);
            label14.Text = Convert.ToString(gsgp + gsbp);
            label15.Text = Convert.ToString(fbgp + fbbp);
            label16.Text = Convert.ToString(ksgp + ksbp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(textBox2.Text) + Convert.ToInt16(textBox3.Text) + Convert.ToInt16(textBox4.Text) < Convert.ToInt16(textBox1.Text))
            {
                label17.Text = label2.Text;
            }
            if (Convert.ToInt16(textBox5.Text) + Convert.ToInt16(textBox6.Text) + Convert.ToInt16(textBox7.Text) < Convert.ToInt16(textBox1.Text))
            {
                label18.Text = label3.Text;
            }
            if (Convert.ToInt16(textBox8.Text) + Convert.ToInt16(textBox9.Text) + Convert.ToInt16(textBox10.Text) < Convert.ToInt16(textBox1.Text))
            {
                label19.Text = label4.Text;
            }
            if (Convert.ToInt16(textBox11.Text) + Convert.ToInt16(textBox12.Text) + Convert.ToInt16(textBox13.Text) < Convert.ToInt16(textBox1.Text))
            {
                label20.Text = label5.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt16(label9.Text) > (Convert.ToInt16(label10.Text) & Convert.ToInt16(label11.Text) & Convert.ToInt16(label12.Text)))
            {
                label21.Text = label2.Text;
            }
            if (Convert.ToInt16(label10.Text) > (Convert.ToInt16(label9.Text) & Convert.ToInt16(label11.Text) & Convert.ToInt16(label12.Text)))
            {
                label21.Text = label3.Text;
            }
            if (Convert.ToInt16(label11.Text) > (Convert.ToInt16(label9.Text) & Convert.ToInt16(label10.Text) & Convert.ToInt16(label12.Text)))
            {
                label21.Text = label4.Text;
            }
            if (Convert.ToInt16(label12.Text) > (Convert.ToInt16(label9.Text) & Convert.ToInt16(label10.Text) & Convert.ToInt16(label11.Text)))
            {
                label21.Text = "KOCAELİ"; label21.ForeColor = Color.Green;
                label22.Text = "SPOR"; label22.ForeColor = Color.Black;
            }
            
        }
    }
}
