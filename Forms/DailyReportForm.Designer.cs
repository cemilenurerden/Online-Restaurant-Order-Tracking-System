namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class DailyReportForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridViewDailyOrders = new System.Windows.Forms.DataGridView();
            this.buttonPrintReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataGridViewDailyOrders
            // 
            this.dataGridViewDailyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDailyOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDailyOrders.Name = "dataGridViewDailyOrders";
            this.dataGridViewDailyOrders.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewDailyOrders.TabIndex = 0;
            // 
            // buttonPrintReport
            // 
            this.buttonPrintReport.Location = new System.Drawing.Point(650, 380);
            this.buttonPrintReport.Name = "buttonPrintReport";
            this.buttonPrintReport.Size = new System.Drawing.Size(122, 40);
            this.buttonPrintReport.TabIndex = 1;
            this.buttonPrintReport.Text = "Raporu Yazdır";
            this.buttonPrintReport.UseVisualStyleBackColor = true;
            this.buttonPrintReport.Click += new System.EventHandler(this.ButtonPrintReport_Click);
            // 
            // DailyReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.buttonPrintReport);
            this.Controls.Add(this.dataGridViewDailyOrders);
            this.Name = "DailyReportForm";
            this.Text = "Günlük Sipariş Raporu";
            this.Load += new System.EventHandler(this.DailyReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewDailyOrders;
        private System.Windows.Forms.Button buttonPrintReport;
    }
}
