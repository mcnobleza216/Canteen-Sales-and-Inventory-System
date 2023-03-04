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
    public partial class Form5 : Form
    {
        public Form5()
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

        private void buttonExpenses_Click(object sender, EventArgs e)
        {
        
            Form4 f4 = new Form4();
            f4.ShowDialog();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT * FROM `products`", conn);
                MySqlDataAdapter SDA = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                SDA.SelectCommand = com;

                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            try
            {
                conn.Open();

                MySqlCommand com = new MySqlCommand("SELECT SUM(`Stocks`) FROM `products`", conn);
                MySqlDataAdapter SDA = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                SDA.SelectCommand = com;

                SDA.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            search("");
        }
        public void search(string value)
        {

            string query = "SELECT * FROM `products` WHERE CONCAT(`ID` , `Food/Drinks`, `Stocks`, `Price`) LIKE '%" + value + "%' ";

            MySqlDataAdapter msd = new MySqlDataAdapter(query, conn);

            DataTable tab = new DataTable();

            msd.Fill(tab);

            dataGridView1.DataSource = tab;
        }



        private void BTN_SEARCH_Click(object sender, EventArgs e)
        {
            search(textBoxValueToSearch.Text);
        }


        private void textBoxValueToSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
