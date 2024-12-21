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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDailyOrders
            // 
            this.dataGridViewDailyOrders.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dataGridViewDailyOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDailyOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewDailyOrders.Name = "dataGridViewDailyOrders";
            this.dataGridViewDailyOrders.RowHeadersWidth = 51;
            this.dataGridViewDailyOrders.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewDailyOrders.TabIndex = 0;
            this.dataGridViewDailyOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDailyOrders_CellContentClick);
            // 
            // buttonPrintReport
            // 
            this.buttonPrintReport.BackColor = System.Drawing.Color.Brown;
            this.buttonPrintReport.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPrintReport.Location = new System.Drawing.Point(650, 368);
            this.buttonPrintReport.Name = "buttonPrintReport";
            this.buttonPrintReport.Size = new System.Drawing.Size(122, 52);
            this.buttonPrintReport.TabIndex = 1;
            this.buttonPrintReport.Text = "Raporu Yazdır";
            this.buttonPrintReport.UseVisualStyleBackColor = false;
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
