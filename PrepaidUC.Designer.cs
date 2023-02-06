namespace Laundry
{
    partial class PrepaidUC
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
            this.dgvPrepaid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepaid)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrepaid
            // 
            this.dgvPrepaid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrepaid.Location = new System.Drawing.Point(28, 67);
            this.dgvPrepaid.Name = "dgvPrepaid";
            this.dgvPrepaid.Size = new System.Drawing.Size(601, 283);
            this.dgvPrepaid.TabIndex = 0;
            // 
            // PrepaidUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvPrepaid);
            this.Name = "PrepaidUC";
            this.Size = new System.Drawing.Size(663, 550);
            this.Load += new System.EventHandler(this.PrepaidUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrepaid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrepaid;
    }
}
