using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace veritabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitaplarDataSet.Tablo1' table. You can move, or remove it, as needed.
            this.tablo1TableAdapter.Fill(this.kitaplarDataSet.Tablo1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text =="1")
            {
                MessageBox.Show("Zaten İlk Kayıttasınız");
            }
            else
            {
                bindingSource1.MoveFirst();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "6")
            {
                MessageBox.Show("Zaten Son Kayıttasınız");
            }
            else
            {
                bindingSource1.MoveLast();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int no;
            no = bindingSource1.Position;
            bindingSource1.RemoveAt(no);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tablo1TableAdapter.Update(this.kitaplarDataSet.Tablo1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2();
            x.Show(); this.Hide();
        }
    }
}
