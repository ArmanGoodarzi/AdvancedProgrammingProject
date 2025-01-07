using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject
{
    public partial class Form5 : Form
    {
        SqlConnection connection = null;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\AdvancedProject\AdvancedProject\DataBaseDB.mdf;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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
            LoadSaleData();
            LoadCustomersItems();
            LoadFoodItems();
            LoadDrinkItems();
        }
        
        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            
            if (comboBoxCustomer.SelectedIndex <= 0 || comboBoxFoods.SelectedIndex <= 0 || comboBoxDrinks.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a customer, food, and drink.");
                return;
            }

            
            string customer = comboBoxCustomer.SelectedItem.ToString();
            string[] customerDetails = customer.Split(',');
            int customerID = int.Parse(customerDetails[0].Replace("ID:", "").Trim());
            string customerName = customerDetails[1].Replace("Name:", "").Trim();

            string food = comboBoxFoods.SelectedItem.ToString();
            string[] foodDetails = food.Split(',');
            string foodName = foodDetails[1].Replace("FoodName:", "").Trim();
            decimal foodPrice = decimal.Parse(foodDetails[2].Replace("FoodPrice:", "").Trim());
            int foodQty = (int)numericUpDown1.Value;
            decimal totalFoodPrice = foodPrice * foodQty;

            string drink = comboBoxDrinks.SelectedItem.ToString();
            string[] drinkDetails = drink.Split(',');
            string drinkName = drinkDetails[1].Replace("DrinkName:", "").Trim();
            decimal drinkPrice = decimal.Parse(drinkDetails[2].Replace("DrinkPrice:", "").Trim());
            int drinkQty = (int)numericUpDown2.Value;
            decimal totalDrinkPrice = drinkPrice * drinkQty;

            
            decimal totalPrice = totalFoodPrice + totalDrinkPrice;

            
            DateTime saleDateTime = DateTime.Now;

            
            string query = @"INSERT INTO InvoiceTable (CustomerID, CustomerName, FoodName, FoodPrice, NumberOfFoods, FoodTotalPrice, 
                    DrinkName, DrinkPrice, NumberOfDrinks, DrinkTotalPrice, Total, InvoiceDate) 
                    VALUES (@CustomerID, @CustomerName, @FoodName, @FoodPrice, @NumberOfFoods, @FoodTotalPrice, 
                            @DrinkName, @DrinkPrice, @NumberOfDrinks, @DrinkTotalPrice, @Total, @InvoiceDate)";

            try
            {
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", customerID);
                    command.Parameters.AddWithValue("@CustomerName", customerName);
                    command.Parameters.AddWithValue("@FoodName", foodName);
                    command.Parameters.AddWithValue("@FoodPrice", foodPrice);
                    command.Parameters.AddWithValue("@NumberOfFoods", foodQty);
                    command.Parameters.AddWithValue("@FoodTotalPrice", totalFoodPrice);
                    command.Parameters.AddWithValue("@DrinkName", drinkName);
                    command.Parameters.AddWithValue("@DrinkPrice", drinkPrice);
                    command.Parameters.AddWithValue("@NumberOfDrinks", drinkQty);
                    command.Parameters.AddWithValue("@DrinkTotalPrice", totalDrinkPrice);
                    command.Parameters.AddWithValue("@Total", totalPrice);
                    command.Parameters.AddWithValue("@InvoiceDate", saleDateTime);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Record insert successfully");
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
            LoadSaleData();
        }
        

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                
                var result = MessageBox.Show("Are you sure you want to remove the selected item?",
                                             "Confirm Removal",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    
                    foreach (DataGridViewRow row in dataGridViewInvoices.SelectedRows)
                    {
                        dataGridViewInvoices.Rows.RemoveAt(row.Index);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            if (dataGridViewInvoices.SelectedRows.Count > 0)
            {
                if (dataGridViewInvoices.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewInvoices.SelectedRows[0];

                    string customerID = selectedRow.Cells["CustomerID"].Value.ToString();
                    string customerName = selectedRow.Cells["CustomerName"].Value.ToString();
                    string foodName = selectedRow.Cells["FoodName"].Value.ToString();
                    string numberOfFoods = selectedRow.Cells["NumberOfFoods"].Value.ToString();
                    string drinkName = selectedRow.Cells["DrinkName"].Value.ToString();
                    string numberOfDrinks = selectedRow.Cells["NumberOfDrinks"].Value.ToString();
                    string total = selectedRow.Cells["Total"].Value.ToString();
                    string invoiceDate = selectedRow.Cells["InvoiceDate"].Value.ToString();

                    string printContent = $"Invoice Date: {invoiceDate}\n\n" +
                                          $"Customer ID: {customerID}\n" +
                                          $"Customer Name: {customerName}\n\n" +
                                          $"Food: {foodName}\n" +
                                          $"Number of Foods: {numberOfFoods}\n\n" +
                                          $"Drink: {drinkName}\n" +
                                          $"Number of Drinks: {numberOfDrinks}\n\n" +
                                          $"Total Price: {total}\n";

                    PrintDocument printDoc = new PrintDocument();
                    printDoc.PrintPage += (s, args) => PrintPage(s, args, printContent);


                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDoc;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDoc.Print();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an invoice to print.", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e, string content)
        {

            
            Font printFont = new Font("Arial", 12);
            float lineHeight = printFont.GetHeight(e.Graphics);
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;

            
            foreach (string line in content.Split('\n'))
            {
                e.Graphics.DrawString(line, printFont, Brushes.Black, x, y);
                y += lineHeight;
            }
        }
        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        
        private void LoadSaleData()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            string query = "SELECT CustomerID,CustomerName,FoodName,NumberOfFoods,DrinkName,NumberOfDrinks,Total,InvoiceDate FROM InvoiceTable";

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query,connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewInvoices.DataSource = dataTable;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
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
            this.Close();
            Form2 form = new Form2();
            if (form.IsDisposed == true)
            {
                form = new Form2();
            }
            form.Show();
        }

        private void LoadCustomersItems()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Customer";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxCustomer.Items.Add("Select");
                        comboBoxCustomer.SelectedIndex = 0;
                        while (reader.Read())
                        {
                            string item = $"ID: {reader["ID"]},Name: {reader["Name"]},Contact: {reader["Contact"]},Address: {reader["Address"]}";
                            comboBoxCustomer.Items.Add(item);
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
        private void LoadFoodItems()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Food";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxFoods.Items.Add("Select");
                        comboBoxFoods.SelectedIndex = 0;
                        while (reader.Read())
                        {
                            string item = $"ID: {reader["ID"]},FoodName: {reader["FoodName"]},FoodPrice: {reader["FoodPrice"]}";
                            comboBoxFoods.Items.Add(item);
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

        private void LoadDrinkItems()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            string query = "SELECT * FROM Drink";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxDrinks.Items.Add("Select");
                        comboBoxDrinks.SelectedIndex = 0;
                        while (reader.Read())
                        {
                            string item = $"ID: {reader["ID"]},DrinkName: {reader["DrinkName"]},DrinkPrice: {reader["DrinkPrice"]}";
                            comboBoxDrinks.Items.Add(item);
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
    }
}
