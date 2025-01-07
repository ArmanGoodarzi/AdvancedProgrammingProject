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

namespace AdvancedProject
{
    public partial class Form7 : Form
    {
        SqlConnection connection = null;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\AdvancedProject\AdvancedProject\DataBaseDB.mdf;Integrated Security=True";
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
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
            LoadProducts();
            LoadSuppliers();
            LoadPurchasesIntoDataGridView();
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
            this.Close();
            Form2 form = new Form2();
            if (form.IsDisposed == true)
            {
                form = new Form2();
            }
            form.Show();
        }

        private void buttonAddPurchase_Click(object sender, EventArgs e)
        {
            AddPurchase();
        }

        private void AddPurchase()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            string supplier = comboBoxSupplier.SelectedItem?.ToString();
            string product = comboBoxProduct.SelectedItem?.ToString();
            int quantity = (int)numericUpDownQuantity.Value;
            decimal unitPrice = decimal.Parse(textBoxUnitPrice.Text);
            decimal totalPrice = quantity * unitPrice;

            textBoxTotalPrice.Text = totalPrice.ToString();


            if (string.IsNullOrEmpty(supplier) || string.IsNullOrEmpty(product))
            {
                MessageBox.Show("Please select a supplier and a product.");
                return;
            }
            string query = "INSERT INTO Purchases (Supplier,Product,Quantity,UnitPrice,TotalPrice,DateTime) " +
                "VALUES (@Supplier,@Product,@Quantity,@UnitPrice,@TotalPrice,@DateTime)";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Supplier", supplier);
                    cmd.Parameters.AddWithValue("@Product", product);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);
                    cmd.Parameters.AddWithValue("@UnitPrice", unitPrice);
                    cmd.Parameters.AddWithValue("@TotalPrice", totalPrice);
                    cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record insert successfully");
                }
                comboBoxSupplier.SelectedIndex = -1;
                comboBoxProduct.SelectedIndex = -1;
                numericUpDownQuantity.Value = 0;
                textBoxUnitPrice.Clear();
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



        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        private void LoadProducts()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Product";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxProduct.Items.Add("Select");
                        comboBoxProduct.SelectedIndex = 0;
                        while (reader.Read())
                        {
                            string item = $"ID: {reader["ID"]},ProductItem: {reader["ProductItem"]}";                              
                            comboBoxProduct.Items.Add(item);
                        }
                    }
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
        private void LoadSuppliers()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Suppliers";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxSupplier.Items.Add("Select");
                        comboBoxSupplier.SelectedIndex = 0;
                        while (reader.Read())
                        {
                            string item = $"ID: {reader["ID"]},SupplierName: {reader["SupplierName"]},Address: {reader["Address"]},PhoneNumber: {reader["PhoneNumber"]}";                 
                            comboBoxSupplier.Items.Add(item);
                        }
                    }
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
        private void LoadPurchasesIntoDataGridView()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            dataGridViewPurchases.Columns.Clear();
            string query = "SELECT * FROM Purchases";

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewPurchases.DataSource = dataTable;
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
