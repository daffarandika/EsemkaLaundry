namespace Laundry
{
    partial class ViewTransactionUC
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
            this.dgvHeader = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.detailid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prepaidpackageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHeader
            // 
            this.dgvHeader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeader.Location = new System.Drawing.Point(6, 19);
            this.dgvHeader.Name = "dgvHeader";
            this.dgvHeader.Size = new System.Drawing.Size(616, 183);
            this.dgvHeader.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHeader);
            this.groupBox1.Location = new System.Drawing.Point(17, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 208);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Header Deposit";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDetail);
            this.groupBox2.Location = new System.Drawing.Point(23, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(628, 208);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detail Deposit";
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.detailid,
            this.servicename,
            this.prepaidpackageid,
            this.priceperunit,
            this.totalunit,
            this.completetime,
            this.action});
            this.dgvDetail.Location = new System.Drawing.Point(6, 19);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(616, 183);
            this.dgvDetail.TabIndex = 0;
            this.dgvDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "View Transaction";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(453, 47);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(186, 20);
            this.tbSearch.TabIndex = 25;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Search";
            // 
            // detailid
            // 
            this.detailid.HeaderText = "detailid";
            this.detailid.Name = "detailid";
            this.detailid.Visible = false;
            // 
            // servicename
            // 
            this.servicename.HeaderText = "Service Name";
            this.servicename.Name = "servicename";
            // 
            // prepaidpackageid
            // 
            this.prepaidpackageid.HeaderText = "Prepaid Package ID";
            this.prepaidpackageid.Name = "prepaidpackageid";
            // 
            // priceperunit
            // 
            this.priceperunit.HeaderText = "Price Per Unit";
            this.priceperunit.Name = "priceperunit";
            // 
            // totalunit
            // 
            this.totalunit.HeaderText = "Total Unit";
            this.totalunit.Name = "totalunit";
            // 
            // completetime
            // 
            this.completetime.HeaderText = "Complete Time";
            this.completetime.Name = "completetime";
            // 
            // action
            // 
            this.action.HeaderText = "Action";
            this.action.Name = "action";
            // 
            // ViewTransactionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewTransactionUC";
            this.Size = new System.Drawing.Size(663, 550);
            this.Load += new System.EventHandler(this.ViewTransactionUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeader)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHeader;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailid;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn prepaidpackageid;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn completetime;
        private System.Windows.Forms.DataGridViewButtonColumn action;
    }
}
