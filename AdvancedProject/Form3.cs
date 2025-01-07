using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject
{
    public partial class Form3 : Form
    {
        SqlConnection connection = null;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\AdvancedProject\AdvancedProject\DataBaseDB.mdf;Integrated Security=True";
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // اتصال به دیتابیس
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Connection is open");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadCustomersIntoDataGridView();
        }

        private void buttonSubmitCustomer_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string contact = textBox2.Text;
            string address = textBox3.Text;

            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            string query = "INSERT INTO Customer (Name, Contact , Address) VALUES (@Name , @Contact , @Address)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Contact", contact);
                    command.Parameters.AddWithValue("@Address", address);

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
            LoadCustomersIntoDataGridView();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells["ID"].Value);
            string newName = textBox4.Text;
            string newContact = textBox5.Text;
            string newAddress = textBox6.Text;

            string query = "UPDATE Customer SET Name = @Name , Contact = @Contact , Address = @Address WHERE ID = @ID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@Name", newName);
                    command.Parameters.AddWithValue("@Contact", newContact);
                    command.Parameters.AddWithValue("@Address", newAddress);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Record update successfully");

                }
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
            finally
            {
                connection.Close();
            }
            LoadCustomersIntoDataGridView();
        }

        private void dataGridViewCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewCustomers.Rows[e.RowIndex];

                textBox4.Text = selectedRow.Cells["Name"].Value.ToString();
                textBox5.Text = selectedRow.Cells["Contact"].Value.ToString();
                textBox6.Text = selectedRow.Cells["Address"].Value.ToString();
            }
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }


            int id = Convert.ToInt32(dataGridViewCustomers.CurrentRow.Cells["ID"].Value);

            string query = "DELETE FROM Customer WHERE ID = @ID";

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
            LoadCustomersIntoDataGridView();
        }

        

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            if (f1.IsDisposed == true)
            {
                f1 = new Form1();
            }
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form = new Form2();
            if (form.IsDisposed == true)
            {
                form = new Form2();
            }
            form.Show();
        }

        private void LoadCustomersIntoDataGridView()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Customer";

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewCustomers.DataSource = dataTable;
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
