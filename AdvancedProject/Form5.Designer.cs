namespace AdvancedProject
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.comboBoxDrinks = new System.Windows.Forms.ComboBox();
            this.comboBoxFoods = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.Location = new System.Drawing.Point(12, 300);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(638, 24);
            this.comboBoxCustomer.TabIndex = 0;
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(467, 70);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(185, 40);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "انتخاب و ثبت";
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(467, 116);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(185, 40);
            this.buttonRemoveItem.TabIndex = 3;
            this.buttonRemoveItem.Text = "حذف ";
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonPrint.Location = new System.Drawing.Point(467, 162);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(185, 40);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "چاپ فاکتور";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.ColumnHeadersHeight = 29;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(14, 9);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.RowHeadersWidth = 51;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(447, 282);
            this.dataGridViewInvoices.TabIndex = 8;
            // 
            // comboBoxDrinks
            // 
            this.comboBoxDrinks.FormattingEnabled = true;
            this.comboBoxDrinks.Location = new System.Drawing.Point(13, 360);
            this.comboBoxDrinks.Name = "comboBoxDrinks";
            this.comboBoxDrinks.Size = new System.Drawing.Size(638, 24);
            this.comboBoxDrinks.TabIndex = 9;
            // 
            // comboBoxFoods
            // 
            this.comboBoxFoods.FormattingEnabled = true;
            this.comboBoxFoods.Location = new System.Drawing.Point(12, 330);
            this.comboBoxFoods.Name = "comboBoxFoods";
            this.comboBoxFoods.Size = new System.Drawing.Size(639, 24);
            this.comboBoxFoods.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(603, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "تعداد غذا";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "تعداد نوشیدنی";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(467, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 40);
            this.button1.TabIndex = 18;
            this.button1.Text = "صفحه ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(467, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 40);
            this.button2.TabIndex = 19;
            this.button2.Text = "داشبورد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(467, 9);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown1.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(467, 45);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(104, 22);
            this.numericUpDown2.TabIndex = 21;
            // 
            // Form5
            // 
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(672, 392);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFoods);
            this.Controls.Add(this.comboBoxDrinks);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.buttonAddItem);
            this.Controls.Add(this.buttonRemoveItem);
            this.Name = "Form5";
            this.Text = "صفحه صدور فاکتور";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form5_FormClosing);
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.ComboBox comboBoxDrinks;
        private System.Windows.Forms.ComboBox comboBoxFoods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}