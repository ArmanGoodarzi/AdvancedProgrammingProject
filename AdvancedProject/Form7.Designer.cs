namespace AdvancedProject
{
    partial class Form7
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSupplier = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.buttonAddPurchase = new System.Windows.Forms.Button();
            this.dataGridViewPurchases = new System.Windows.Forms.DataGridView();
            this.ColumnSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxSupplier
            // 
            this.comboBoxSupplier.FormattingEnabled = true;
            this.comboBoxSupplier.Location = new System.Drawing.Point(12, 95);
            this.comboBoxSupplier.Name = "comboBoxSupplier";
            this.comboBoxSupplier.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSupplier.TabIndex = 0;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(12, 145);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProduct.TabIndex = 1;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(12, 185);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownQuantity.TabIndex = 2;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(34, 213);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(91, 22);
            this.textBoxUnitPrice.TabIndex = 3;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(34, 241);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.ReadOnly = true;
            this.textBoxTotalPrice.Size = new System.Drawing.Size(91, 22);
            this.textBoxTotalPrice.TabIndex = 4;
            // 
            // buttonAddPurchase
            // 
            this.buttonAddPurchase.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonAddPurchase.Location = new System.Drawing.Point(34, 269);
            this.buttonAddPurchase.Name = "buttonAddPurchase";
            this.buttonAddPurchase.Size = new System.Drawing.Size(150, 30);
            this.buttonAddPurchase.TabIndex = 5;
            this.buttonAddPurchase.Text = "افزودن خرید";
            this.buttonAddPurchase.UseVisualStyleBackColor = false;
            this.buttonAddPurchase.Click += new System.EventHandler(this.buttonAddPurchase_Click);
            // 
            // dataGridViewPurchases
            // 
            this.dataGridViewPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPurchases.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSupplier,
            this.ColumnProduct,
            this.ColumnQuantity,
            this.ColumnUnitPrice,
            this.ColumnTotalPrice,
            this.ColumnDate});
            this.dataGridViewPurchases.Location = new System.Drawing.Point(218, 12);
            this.dataGridViewPurchases.Name = "dataGridViewPurchases";
            this.dataGridViewPurchases.RowHeadersWidth = 51;
            this.dataGridViewPurchases.RowTemplate.Height = 24;
            this.dataGridViewPurchases.Size = new System.Drawing.Size(554, 437);
            this.dataGridViewPurchases.TabIndex = 6;
            // 
            // ColumnSupplier
            // 
            this.ColumnSupplier.HeaderText = "Supplier";
            this.ColumnSupplier.MinimumWidth = 6;
            this.ColumnSupplier.Name = "ColumnSupplier";
            this.ColumnSupplier.Width = 125;
            // 
            // ColumnProduct
            // 
            this.ColumnProduct.HeaderText = "Product";
            this.ColumnProduct.MinimumWidth = 6;
            this.ColumnProduct.Name = "ColumnProduct";
            this.ColumnProduct.Width = 125;
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.MinimumWidth = 6;
            this.ColumnQuantity.Name = "ColumnQuantity";
            this.ColumnQuantity.Width = 125;
            // 
            // ColumnUnitPrice
            // 
            this.ColumnUnitPrice.HeaderText = "Unit Price";
            this.ColumnUnitPrice.MinimumWidth = 6;
            this.ColumnUnitPrice.Name = "ColumnUnitPrice";
            this.ColumnUnitPrice.Width = 125;
            // 
            // ColumnTotalPrice
            // 
            this.ColumnTotalPrice.HeaderText = "Total Price";
            this.ColumnTotalPrice.MinimumWidth = 6;
            this.ColumnTotalPrice.Name = "ColumnTotalPrice";
            this.ColumnTotalPrice.Width = 125;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "DateTime";
            this.ColumnDate.MinimumWidth = 6;
            this.ColumnDate.Name = "ColumnDateTime";
            this.ColumnDate.Width = 125;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "صفحه ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(12, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 43);
            this.button2.TabIndex = 8;
            this.button2.Text = "داشبورد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 76);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "فروشگاه";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "محصولات";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "قیمت واحد";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "جمع کل";
            // 
            // Form7
            // 
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewPurchases);
            this.Controls.Add(this.buttonAddPurchase);
            this.Controls.Add(this.textBoxTotalPrice);
            this.Controls.Add(this.textBoxUnitPrice);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.comboBoxSupplier);
            this.Name = "Form7";
            this.Text = "مدیریت خرید";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form7_FormClosing);
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPurchases;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxSupplier;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Button buttonAddPurchase;

        // Column declarations for DataGridView
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
