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
    public partial class Form4 : Form
    {
        SqlConnection connection = null;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\AdvancedProject\AdvancedProject\DataBaseDB.mdf;Integrated Security=True";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
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
            LoadFoodsIntoDataGridView();
            LoadDrinksIntoDataGridView();
            LoadProductsIntoDataGridView();
        }

        private void buttonSubmitFood_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            string foodName = textBox1.Text;
            decimal foodPrice = decimal.Parse(textBox2.Text);

            string query = "INSERT INTO Food (FoodName,FoodPrice) VALUES (@FoodName,@FoodPrice)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FoodName", foodName);
                    command.Parameters.AddWithValue("@FoodPrice", foodPrice);

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
            LoadFoodsIntoDataGridView();
        }

        private void buttonEditFood_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridViewFoodItems.CurrentRow.Cells["ID"].Value);
            string newFoodName = textBox3.Text;
            decimal newFoodPrice = decimal.Parse(textBox4.Text);

            string query = "UPDATE Food SET FoodName = @FoodName, FoodPrice = @FoodPrice WHERE ID = @ID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@FoodName", newFoodName);
                    command.Parameters.AddWithValue("@FoodPrice", newFoodPrice);

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
            LoadFoodsIntoDataGridView();
        }

        private void dataGridViewFoodItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewFoodItems.Rows[e.RowIndex];

                textBox3.Text = selectedRow.Cells["FoodName"].Value.ToString();
                textBox4.Text = selectedRow.Cells["FoodPrice"].Value.ToString();
            }
        }

        private void buttonDeleteFood_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridViewFoodItems.CurrentRow.Cells["ID"].Value);

            string query = "DELETE FROM Food WHERE ID = @ID";

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
            LoadFoodsIntoDataGridView();
        }

        private void buttonSubmitDrink_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            string drinkName = textBox5.Text;
            decimal drinkPrice = decimal.Parse(textBox6.Text);

            string query = "INSERT INTO Drink (DrinkName,DrinkPrice) VALUES (@DrinkName,@DrinkPrice)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DrinkName", drinkName);
                    command.Parameters.AddWithValue("@DrinkPrice", drinkPrice);

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
            LoadDrinksIntoDataGridView();
        }

        private void buttonEditDrink_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridViewDrinkItems.CurrentRow.Cells["ID"].Value);
            string newDrinkName = textBox7.Text;
            decimal newDrinkPrice = decimal.Parse(textBox8.Text);

            string query = "UPDATE Drink SET DrinkName = @DrinkName, DrinkPrice = @DrinkPrice WHERE ID = @ID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@DrinkName", newDrinkName);
                    command.Parameters.AddWithValue("@DrinkPrice", newDrinkPrice);

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
            LoadDrinksIntoDataGridView();
        }

        private void dataGridViewDrinkItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewDrinkItems.Rows[e.RowIndex];

                textBox7.Text = selectedRow.Cells["DrinkName"].Value.ToString();
                textBox8.Text = selectedRow.Cells["DrinkPrice"].Value.ToString();
            }
        }

        private void buttonDeleteDrink_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridViewDrinkItems.CurrentRow.Cells["ID"].Value);

            string query = "DELETE FROM Drink WHERE ID = @ID";

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
            LoadDrinksIntoDataGridView();
        }

        private void buttonSubmitProduct_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            string productItem = textBox9.Text;
            decimal productPrice = decimal.Parse(textBox10.Text);

            string query = "INSERT INTO Product (ProductItem,ProductPrice) VALUES (@ProductItem,@ProductPrice)";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ProductItem", productItem);
                    command.Parameters.AddWithValue("@ProductPrice", productPrice);

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
            LoadProductsIntoDataGridView();
        }

        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);
            string newProductItem = textBox11.Text;
            decimal newProductPrice = decimal.Parse(textBox12.Text);

            string query = "UPDATE Product SET ProductItem = @ProductItem, ProductPrice = @ProductPrice WHERE ID = @ID";

            try
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    command.Parameters.AddWithValue("@ProductItem", newProductItem);
                    command.Parameters.AddWithValue("@ProductPrice", newProductPrice);

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
            LoadProductsIntoDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                textBox11.Text = selectedRow.Cells["ProductItem"].Value.ToString();
                textBox12.Text = selectedRow.Cells["ProductPrice"].Value.ToString();
            }
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID"].Value);

            string query = "DELETE FROM Product WHERE ID = @ID";

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
            LoadProductsIntoDataGridView();
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

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void LoadFoodsIntoDataGridView()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Food";

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewFoodItems.DataSource = dataTable;
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
        private void LoadDrinksIntoDataGridView()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Drink";

            try
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewDrinkItems.DataSource = dataTable;
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
        private void LoadProductsIntoDataGridView()
        {
            if (connection == null || connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            string query = "SELECT * FROM Product";

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
