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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'okulDataSet.öğrenci' table. You can move, or remove it, as needed.
            this.öğrenciTableAdapter.Fill(this.okulDataSet.öğrenci);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            öğrenciTableAdapter.Update(okulDataSet.öğrenci);
            dataGridView1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int no = bindingSource1.Position;
            bindingSource1.RemoveAt(no);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            öğrenciTableAdapter.Update(okulDataSet.öğrenci);
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Kaydetmediğiniz Veriler Silinecekti!! Çıkmak İstediğinize Emin Misiniz?", "ÇIKIŞ", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (x == DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingSource1.AddNew();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            int no = bindingSource1.Position;
            bindingSource1.RemoveAt(no);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }

        private void dateTimePicker1_Move(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
