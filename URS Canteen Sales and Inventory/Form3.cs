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
    public partial class Form3 : Form
    {
        
        public Form3()
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {


            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transaction;
                transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;

                cmd.CommandText = "INSERT INTO products (`ID`, `Category`, `Food/Drinks`, `Stocks`, `Price`) VALUES ('" + ID.Text + "','" + Category.Text + "','" + Food.Text + "','" + Stockss.Text + "','" + price.Text + "')";
                cmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Products has been added!");

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
        }



        private void Category_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transaction;
                transaction = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transaction;

                cmd.CommandText = "UPDATE `products` SET `Category` = '" + Category.Text + "',`Food/Drinks` = '" + Food.Text + "',`Stocks` = '" + Stockss.Text + "',`Price` = '" + price.Text + "'" +"WHERE `products`.`ID` = '" +ID.Text +"'";
                cmd.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Products has been updated!");

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
        }

        private void button6_Click(object sender, EventArgs e)
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Category.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Food.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Stockss.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            price.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transation;
                transation = conn.BeginTransaction();
                cmd.Connection = conn;
                cmd.Transaction = transation;

                cmd.CommandText = "DELETE FROM `products` WHERE `products`.`ID` = '" + ID.Text + "'";
                cmd.ExecuteNonQuery();

                transation.Commit();

                MessageBox.Show("Row deleted");

                MySqlCommand com = new MySqlCommand("SELECT * FROM `products`", conn);
                MySqlDataAdapter SDA = new MySqlDataAdapter();
                DataTable dt = new DataTable();

                SDA.SelectCommand = com;

                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            finally
            {
                conn.Close();
            }
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


