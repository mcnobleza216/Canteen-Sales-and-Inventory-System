using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URS_Canteen_Sales_and_Inventory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {


        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            
            Form3 f3 = new Form3();
            f3.ShowDialog();

        }

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
            
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Hide();
            Form3 f3 = new Form3();
            f3.Hide();
            Form4 f4 = new Form4();
            f4.Hide();
            Form5 f5 = new Form5();
            f5.Hide();
            Form6 f6 = new Form6();
            f6.Hide();
            Form7 f7 = new Form7();
            f7.Hide();
            Form8 f8 = new Form8();
            f8.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }
    }
}
