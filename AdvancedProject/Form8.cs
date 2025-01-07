using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdvancedProject
{
    public partial class Form8 : Form
    {
        SqlConnection connection = null;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\AdvancedProject\AdvancedProject\DataBaseDB.mdf;Integrated Security=True";
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // اتصال به دیتابیس
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadItemsIntoDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            string supplierName = textBox1.Text;
            string address = textBox2.Text;
            string phoneNumber = textBox3.Text;


            string query = "INSERT INTO Suppliers (SupplierName,Address,PhoneNumber) VALUES (@SupplierName,@Address,@PhoneNumber)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SupplierName", supplierName);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Record insert successfully");
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadItemsIntoDataGridView();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            string newSupplierName = textBox1.Text;
            string newAddress = textBox2.Text;
            string newPhoneNumber = textBox3.Text;

            string query = "UPDATE Suppliers SET SupplierName = @SupplierName, Address = Address ,PhoneNumber = @PhoneNumber  WHERE ID = @ID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@SupplierName", newSupplierName);
                    command.Parameters.AddWithValue("@Address", newAddress);
                    command.Parameters.AddWithValue("@PhoneNumber", newPhoneNumber);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Record update successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadItemsIntoDataGridView();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox1.Text = selectedRow.Cells["SupplierName"].Value.ToString();
                textBox2.Text = selectedRow.Cells["Address"].Value.ToString();
                textBox3.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

            string query = "DELETE FROM Suppliers WHERE ID = @ID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Record delete successfully");
                }
            }
            catch (Exception ex4)
            {
                MessageBox.Show(ex4.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadItemsIntoDataGridView();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            if (f1.IsDisposed == true)
            {
                f1 = new Form1();
            }
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 form = new Form2();
            if (form.IsDisposed == true)
            {
                form = new Form2();
            }
            form.Show();
        }

        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void LoadItemsIntoDataGridView()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Suppliers";

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
