namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class OrderStatusForm
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
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.buttonUpdateStatus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.Size = new System.Drawing.Size(760, 350);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // buttonUpdateStatus
            // 
            this.buttonUpdateStatus.Location = new System.Drawing.Point(650, 380);
            this.buttonUpdateStatus.Name = "buttonUpdateStatus";
            this.buttonUpdateStatus.Size = new System.Drawing.Size(122, 40);
            this.buttonUpdateStatus.TabIndex = 1;
            this.buttonUpdateStatus.Text = "Durumu Güncelle";
            this.buttonUpdateStatus.UseVisualStyleBackColor = true;
            this.buttonUpdateStatus.Click += new System.EventHandler(this.ButtonUpdateStatus_Click);
            // 
            // OrderStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.buttonUpdateStatus);
            this.Controls.Add(this.dataGridViewOrders);
            this.Name = "OrderStatusForm";
            this.Text = "Sipariş Durumları";
            this.Load += new System.EventHandler(this.OrderStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Button buttonUpdateStatus;
    }
}
