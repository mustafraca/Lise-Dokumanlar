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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kitaplarDataSet1.Tablo1' table. You can move, or remove it, as needed.
            this.tablo1TableAdapter.Fill(this.kitaplarDataSet1.Tablo1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            x.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int no = bindingSource1.Position;
            bindingSource1.RemoveAt(no);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tablo1TableAdapter.Update(this.kitaplarDataSet1.Tablo1);
        }
    }
}
