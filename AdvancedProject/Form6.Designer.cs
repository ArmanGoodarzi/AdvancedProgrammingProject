namespace AdvancedProject
{
    partial class Form6
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
            this.comboBoxReport = new System.Windows.Forms.ComboBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxReport
            // 
            this.comboBoxReport.Location = new System.Drawing.Point(12, 16);
            this.comboBoxReport.Name = "comboBoxReport";
            this.comboBoxReport.Size = new System.Drawing.Size(395, 24);
            this.comboBoxReport.TabIndex = 0;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(413, 6);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(175, 42);
            this.buttonGenerateReport.TabIndex = 1;
            this.buttonGenerateReport.Text = "صدور گزارش";
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(12, 54);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.ReadOnly = true;
            this.textBoxReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxReport.Size = new System.Drawing.Size(576, 274);
            this.textBoxReport.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(499, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "صفحه ورود";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(12, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "داشبورد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form6
            // 
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(600, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxReport);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.textBoxReport);
            this.Name = "Form6";
            this.Text = "گزارشات";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form6_FormClosing);
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxReport;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.TextBox textBoxReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}