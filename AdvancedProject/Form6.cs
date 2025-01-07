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
    public partial class Form6 : Form
    {
        SqlConnection connection = null;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\AdvancedProject\AdvancedProject\DataBaseDB.mdf;Integrated Security=True";
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
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
            LoadInvoicesItems();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            
            if (comboBoxReport.SelectedIndex > 0) 
            {
                
                string selectedItem = comboBoxReport.SelectedItem.ToString();

                
                string[] parts = selectedItem.Split(',');

                
                StringBuilder reportContent = new StringBuilder();

                foreach (var part in parts)
                {
                    reportContent.AppendLine(part.Trim()); 
                }

                textBoxReport.Text = reportContent.ToString();
            }
            else
            {
                MessageBox.Show("Please select an invoice from the list.");
            }
        }



        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void LoadInvoicesItems()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT CustomerID,CustomerName,FoodName,NumberOfFoods,DrinkName,NumberOfDrinks,Total,InvoiceDate FROM InvoiceTable";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        comboBoxReport.Items.Add("Select");
                        comboBoxReport.SelectedIndex = 0;
                        while (reader.Read())
                        {
                            string item = $"آیدی مشترک: {reader["CustomerID"]},نام مشترک: {reader["CustomerName"]},غذا: {reader["FoodName"]},تعداد غذا: {reader["NumberOfFoods"]}" +
                                $"نوشیدنی: {reader["DrinkName"]},تعداد نوشیدنی: {reader["NumberOfDrinks"]},مبلغ کل: {reader["Total"]},تاریخ و ساعت: {reader["InvoiceDate"]}";
                            comboBoxReport.Items.Add(item);
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
    }
}
