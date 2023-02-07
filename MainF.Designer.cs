namespace Laundry
{
    partial class MainF
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
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnPackage = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.btnPrepaid = new System.Windows.Forms.Button();
            this.btnViewTransaction = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblHello = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(12, 90);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(124, 23);
            this.btnEmployee.TabIndex = 0;
            this.btnEmployee.Text = "Manage Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnService
            // 
            this.btnService.Location = new System.Drawing.Point(12, 119);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(124, 23);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Manage Service";
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnPackage
            // 
            this.btnPackage.Location = new System.Drawing.Point(12, 149);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(124, 23);
            this.btnPackage.TabIndex = 2;
            this.btnPackage.Text = "Manage Package";
            this.btnPackage.UseVisualStyleBackColor = true;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(12, 178);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(124, 23);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "Transaction Deposit";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // btnPrepaid
            // 
            this.btnPrepaid.Location = new System.Drawing.Point(12, 207);
            this.btnPrepaid.Name = "btnPrepaid";
            this.btnPrepaid.Size = new System.Drawing.Size(124, 23);
            this.btnPrepaid.TabIndex = 4;
            this.btnPrepaid.Text = "Prepaid Package";
            this.btnPrepaid.UseVisualStyleBackColor = true;
            this.btnPrepaid.Click += new System.EventHandler(this.btnPrepaid_Click);
            // 
            // btnViewTransaction
            // 
            this.btnViewTransaction.Location = new System.Drawing.Point(12, 236);
            this.btnViewTransaction.Name = "btnViewTransaction";
            this.btnViewTransaction.Size = new System.Drawing.Size(124, 23);
            this.btnViewTransaction.TabIndex = 5;
            this.btnViewTransaction.Text = "View Transaction";
            this.btnViewTransaction.UseVisualStyleBackColor = true;
            this.btnViewTransaction.Click += new System.EventHandler(this.btnViewTransaction_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(762, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Logout";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Esemka Laundry";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(384, 17);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "label2";
            // 
            // lblHello
            // 
            this.lblHello.AutoSize = true;
            this.lblHello.Location = new System.Drawing.Point(579, 17);
            this.lblHello.Name = "lblHello";
            this.lblHello.Size = new System.Drawing.Size(35, 13);
            this.lblHello.TabIndex = 9;
            this.lblHello.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(172, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 550);
            this.panel1.TabIndex = 10;
            // 
            // MainF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 669);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHello);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btnViewTransaction);
            this.Controls.Add(this.btnPrepaid);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnPackage);
            this.Controls.Add(this.btnService);
            this.Controls.Add(this.btnEmployee);
            this.Name = "MainF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esemka Laundry";
            this.Load += new System.EventHandler(this.MainF_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnService;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Button btnPrepaid;
        private System.Windows.Forms.Button btnViewTransaction;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblHello;
        private System.Windows.Forms.Panel panel1;
    }
}