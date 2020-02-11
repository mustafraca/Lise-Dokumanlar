using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 eski = new Form1();
            eski.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                string islem = textBox2.Text;
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox3.Text);
            int sonuc = 0;
                switch (islem)
                {
                    case "+": sonuc = s1 + s2; break;
                    case "-": sonuc = s1 - s2; break;
                    case "*": sonuc = s1 * s2; break;
                    case "/": sonuc = s1 / s2; break;
                    default:
                        MessageBox.Show("HATA! İşlem olarak +,-,*,/ seçebilirsiniz");
                        break;
                }
                label5.Text = Convert.ToString(sonuc);
            }
            catch (FormatException fhata)
            {
                MessageBox.Show(fhata.Message);
            }
            catch (OverflowException ohata)
            {
                MessageBox.Show(ohata.Message);
            }
            catch (ArgumentException ahata)
            {
                MessageBox.Show(ahata.Message);
            }
            finally
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string kayan = this.Text;
            int x = kayan.Length;
            string ilkkayan, sonkarakter;
            ilkkayan = kayan.Substring(0, 1);
            sonkarakter = kayan.Substring(1, x - 1);
            this.Text = sonkarakter + ilkkayan;
        }
    }
}
