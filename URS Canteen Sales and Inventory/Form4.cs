using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace URS_Canteen_Sales_and_Inventory
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new
            MySqlConnection("server = localhost; database = light; username = root; password=;");

        private void buttonSales_Click(object sender, EventArgs e)
        {
            
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void buttonInventory_Click(object sender, EventArgs e)
        {
            
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void buttonRecords_Click(object sender, EventArgs e)
        {
            
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT SUM(`Stocks`) FROM `products`", conn);
                MySqlDataAdapter SDA = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                SDA.SelectCommand = com;

                SDA.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT SUM(`Price`) FROM `products`", conn);
                MySqlDataAdapter SDA = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                SDA.SelectCommand = com;

                SDA.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
