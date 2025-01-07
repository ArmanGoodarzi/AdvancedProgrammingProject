using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            if (form.IsDisposed == true)
            {
                form = new Form1();
            }
            form.Show();
        }

        private void buttonCustomerForm_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form = new Form3();
            if (form.IsDisposed == true)
            {
                form = new Form3();
            }
            form.Show();
        }

        private void buttonInventoryForm_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            if (f4.IsDisposed == true)
            {
                f4 = new Form4();
            }
            f4.Show();
        }

        private void buttonSaleForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            if(f5.IsDisposed == true)
            {
                f5 = new Form5();
            }
            f5.Show();
        }

        private void buttonPurchaseForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            if (f7.IsDisposed == true)
            {
                f7 = new Form7();
            }
            f7.Show();
        }

        private void buttonFinancialReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            if (f6.IsDisposed == true)
            {
                f6 = new Form6();
            }
            f6.Show();
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            if (f8.IsDisposed == true)
            {
                f8 = new Form8();
            }
            f8.Show();
        }
    }
}
