namespace AdvancedProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.buttonCustomerForm = new System.Windows.Forms.Button();
            this.buttonInventoryForm = new System.Windows.Forms.Button();
            this.buttonSaleForm = new System.Windows.Forms.Button();
            this.buttonPurchaseForm = new System.Windows.Forms.Button();
            this.buttonFinancialReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCustomerForm
            // 
            this.buttonCustomerForm.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonCustomerForm.Location = new System.Drawing.Point(611, 72);
            this.buttonCustomerForm.Name = "buttonCustomerForm";
            this.buttonCustomerForm.Size = new System.Drawing.Size(160, 76);
            this.buttonCustomerForm.TabIndex = 0;
            this.buttonCustomerForm.Text = "مدیریت مشترکین";
            this.buttonCustomerForm.UseVisualStyleBackColor = false;
            this.buttonCustomerForm.Click += new System.EventHandler(this.buttonCustomerForm_Click_1);
            // 
            // buttonInventoryForm
            // 
            this.buttonInventoryForm.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonInventoryForm.Location = new System.Drawing.Point(611, 177);
            this.buttonInventoryForm.Name = "buttonInventoryForm";
            this.buttonInventoryForm.Size = new System.Drawing.Size(160, 76);
            this.buttonInventoryForm.TabIndex = 1;
            this.buttonInventoryForm.Text = "مدیریت موجودی";
            this.buttonInventoryForm.UseVisualStyleBackColor = false;
            this.buttonInventoryForm.Click += new System.EventHandler(this.buttonInventoryForm_Click_1);
            // 
            // buttonSaleForm
            // 
            this.buttonSaleForm.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonSaleForm.Location = new System.Drawing.Point(611, 279);
            this.buttonSaleForm.Name = "buttonSaleForm";
            this.buttonSaleForm.Size = new System.Drawing.Size(160, 76);
            this.buttonSaleForm.TabIndex = 2;
            this.buttonSaleForm.Text = "مدیریت فروش";
            this.buttonSaleForm.UseVisualStyleBackColor = false;
            this.buttonSaleForm.Click += new System.EventHandler(this.buttonSaleForm_Click);
            // 
            // buttonPurchaseForm
            // 
            this.buttonPurchaseForm.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonPurchaseForm.Location = new System.Drawing.Point(12, 72);
            this.buttonPurchaseForm.Name = "buttonPurchaseForm";
            this.buttonPurchaseForm.Size = new System.Drawing.Size(160, 76);
            this.buttonPurchaseForm.TabIndex = 3;
            this.buttonPurchaseForm.Text = "مدیریت خرید";
            this.buttonPurchaseForm.UseVisualStyleBackColor = false;
            this.buttonPurchaseForm.Click += new System.EventHandler(this.buttonPurchaseForm_Click);
            // 
            // buttonFinancialReports
            // 
            this.buttonFinancialReports.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonFinancialReports.Location = new System.Drawing.Point(12, 177);
            this.buttonFinancialReports.Name = "buttonFinancialReports";
            this.buttonFinancialReports.Size = new System.Drawing.Size(160, 76);
            this.buttonFinancialReports.TabIndex = 4;
            this.buttonFinancialReports.Text = "گزارشات ";
            this.buttonFinancialReports.UseVisualStyleBackColor = false;
            this.buttonFinancialReports.Click += new System.EventHandler(this.buttonFinancialReports_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(327, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "صفحه ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.Goldenrod;
            this.buttonAdmin.Location = new System.Drawing.Point(12, 279);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(160, 76);
            this.buttonAdmin.TabIndex = 9;
            this.buttonAdmin.Text = "پنل ادمین";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonFinancialReports);
            this.Controls.Add(this.buttonPurchaseForm);
            this.Controls.Add(this.buttonSaleForm);
            this.Controls.Add(this.buttonInventoryForm);
            this.Controls.Add(this.buttonCustomerForm);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.Text = "داشبورد";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCustomerForm;
        private System.Windows.Forms.Button buttonInventoryForm;
        private System.Windows.Forms.Button buttonSaleForm;
        private System.Windows.Forms.Button buttonPurchaseForm;
        private System.Windows.Forms.Button buttonFinancialReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAdmin;
    }
}