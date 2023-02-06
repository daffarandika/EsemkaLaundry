namespace Laundry
{
    partial class TransactionUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbPrepaid = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepaidPackage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.tbPhone);
            this.gbCustomer.Controls.Add(this.lblName);
            this.gbCustomer.Controls.Add(this.linkLabel1);
            this.gbCustomer.Controls.Add(this.lblAddress);
            this.gbCustomer.Controls.Add(this.label5);
            this.gbCustomer.Controls.Add(this.label3);
            this.gbCustomer.Controls.Add(this.label2);
            this.gbCustomer.Location = new System.Drawing.Point(23, 84);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(615, 150);
            this.gbCustomer.TabIndex = 0;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(111, 35);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(126, 20);
            this.tbPhone.TabIndex = 6;
            this.tbPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(357, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "[Name]";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(108, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Not Found, Add New +";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(357, 70);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "[Address]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transaction Deposit";
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.service,
            this.prepaidPackage,
            this.pricePerUnit,
            this.totalUnit,
            this.subtotal,
            this.action});
            this.dgvTransaction.Location = new System.Drawing.Point(266, 258);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.Size = new System.Drawing.Size(372, 211);
            this.dgvTransaction.TabIndex = 1;
            this.dgvTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellClick);
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(92, 260);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(155, 21);
            this.cmbService.TabIndex = 2;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(92, 287);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(155, 20);
            this.tbPrice.TabIndex = 3;
            // 
            // tbTotal
            // 
            this.tbTotal.DecimalPlaces = 1;
            this.tbTotal.Location = new System.Drawing.Point(92, 314);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(155, 20);
            this.tbTotal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Service";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Price Per Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Unit";
            // 
            // cbPrepaid
            // 
            this.cbPrepaid.AutoSize = true;
            this.cbPrepaid.Location = new System.Drawing.Point(92, 340);
            this.cbPrepaid.Name = "cbPrepaid";
            this.cbPrepaid.Size = new System.Drawing.Size(130, 17);
            this.cbPrepaid.TabIndex = 8;
            this.cbPrepaid.Text = "Use Prepaid Package";
            this.cbPrepaid.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(92, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(563, 494);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 484);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Price :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(380, 484);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(14, 16);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(380, 512);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(14, 16);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(255, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 16);
            this.label11.TabIndex = 13;
            this.label11.Text = "Estimation Time :";
            // 
            // service
            // 
            this.service.HeaderText = "Service";
            this.service.Name = "service";
            this.service.ReadOnly = true;
            // 
            // prepaidPackage
            // 
            this.prepaidPackage.HeaderText = "Prepaid Package";
            this.prepaidPackage.Name = "prepaidPackage";
            this.prepaidPackage.ReadOnly = true;
            // 
            // pricePerUnit
            // 
            this.pricePerUnit.HeaderText = "Price per Unit";
            this.pricePerUnit.Name = "pricePerUnit";
            this.pricePerUnit.ReadOnly = true;
            // 
            // totalUnit
            // 
            this.totalUnit.HeaderText = "Total Unit";
            this.totalUnit.Name = "totalUnit";
            this.totalUnit.ReadOnly = true;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            this.action.ReadOnly = true;
            this.action.Text = "Add";
            // 
            // TransactionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbPrepaid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbCustomer);
            this.Name = "TransactionUC";
            this.Size = new System.Drawing.Size(663, 550);
            this.Load += new System.EventHandler(this.TransactionUC_Load);
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.NumericUpDown tbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbPrepaid;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn service;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepaidPackage;
        private System.Windows.Forms.DataGridViewTextBoxColumn pricePerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}
