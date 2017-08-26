namespace SHOP_CENTER
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btm_sales_entry = new System.Windows.Forms.Button();
            this.btm_pro_receive = new System.Windows.Forms.Button();
            this.btm_add = new System.Windows.Forms.Button();
            this.btm_report = new System.Windows.Forms.Button();
            this.btm_exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Stock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btm_sales_entry
            // 
            this.btm_sales_entry.Location = new System.Drawing.Point(634, 61);
            this.btm_sales_entry.Name = "btm_sales_entry";
            this.btm_sales_entry.Size = new System.Drawing.Size(118, 48);
            this.btm_sales_entry.TabIndex = 0;
            this.btm_sales_entry.Text = "Sales Entry";
            this.btm_sales_entry.UseVisualStyleBackColor = true;
            this.btm_sales_entry.Click += new System.EventHandler(this.btm_sales_entry_Click);
            // 
            // btm_pro_receive
            // 
            this.btm_pro_receive.Location = new System.Drawing.Point(634, 111);
            this.btm_pro_receive.Name = "btm_pro_receive";
            this.btm_pro_receive.Size = new System.Drawing.Size(118, 44);
            this.btm_pro_receive.TabIndex = 1;
            this.btm_pro_receive.Text = "Product Receive";
            this.btm_pro_receive.UseVisualStyleBackColor = true;
            this.btm_pro_receive.Click += new System.EventHandler(this.btm_pro_receive_Click);
            // 
            // btm_add
            // 
            this.btm_add.Location = new System.Drawing.Point(634, 156);
            this.btm_add.Name = "btm_add";
            this.btm_add.Size = new System.Drawing.Size(118, 44);
            this.btm_add.TabIndex = 2;
            this.btm_add.Text = "New Item Add";
            this.btm_add.UseVisualStyleBackColor = true;
            this.btm_add.Click += new System.EventHandler(this.btm_add_Click);
            // 
            // btm_report
            // 
            this.btm_report.Location = new System.Drawing.Point(634, 205);
            this.btm_report.Name = "btm_report";
            this.btm_report.Size = new System.Drawing.Size(118, 44);
            this.btm_report.TabIndex = 3;
            this.btm_report.Text = "Report";
            this.btm_report.UseVisualStyleBackColor = true;
            this.btm_report.Click += new System.EventHandler(this.btm_report_Click);
            // 
            // btm_exit
            // 
            this.btm_exit.Location = new System.Drawing.Point(634, 309);
            this.btm_exit.Name = "btm_exit";
            this.btm_exit.Size = new System.Drawing.Size(118, 44);
            this.btm_exit.TabIndex = 4;
            this.btm_exit.Text = "Exit";
            this.btm_exit.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(62, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 361);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_Stock
            // 
            this.button_Stock.Location = new System.Drawing.Point(634, 258);
            this.button_Stock.Name = "button_Stock";
            this.button_Stock.Size = new System.Drawing.Size(118, 44);
            this.button_Stock.TabIndex = 6;
            this.button_Stock.Text = "Stock";
            this.button_Stock.UseVisualStyleBackColor = true;
            this.button_Stock.Click += new System.EventHandler(this.button_Stock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(836, 444);
            this.Controls.Add(this.button_Stock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btm_exit);
            this.Controls.Add(this.btm_report);
            this.Controls.Add(this.btm_add);
            this.Controls.Add(this.btm_pro_receive);
            this.Controls.Add(this.btm_sales_entry);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Canteen Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btm_sales_entry;
        private System.Windows.Forms.Button btm_pro_receive;
        private System.Windows.Forms.Button btm_add;
        private System.Windows.Forms.Button btm_report;
        private System.Windows.Forms.Button btm_exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Stock;
    }
}