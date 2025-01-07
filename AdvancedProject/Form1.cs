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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        { 
            string enteredUsername = textBoxUsername.Text;
            string enteredPassword = textBoxPassword.Text;
            if (enteredUsername == "Admin" && enteredPassword == "8520")
            {
                this.Hide();
                Form2 mainForm = new Form2();
                if (mainForm.IsDisposed == true)
                {
                    mainForm = new Form2();
                }
                mainForm.Show();
            }
            else
            {
                lblError.Text = "نام کاربری یا رمز عبور اشتباه است";
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
