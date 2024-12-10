namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class EmployeeHomePage
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Dispose işlemi.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonOrderStatus = new System.Windows.Forms.Button();
            this.buttonDailyReport = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelWelcome.Location = new System.Drawing.Point(100, 20);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(600, 40);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Hoş Geldiniz, Çalışan!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOrderStatus
            // 
            this.buttonOrderStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonOrderStatus.Location = new System.Drawing.Point(100, 100);
            this.buttonOrderStatus.Name = "buttonOrderStatus";
            this.buttonOrderStatus.Size = new System.Drawing.Size(200, 50);
            this.buttonOrderStatus.TabIndex = 1;
            this.buttonOrderStatus.Text = "Sipariş Durumu";
            this.buttonOrderStatus.UseVisualStyleBackColor = true;
            this.buttonOrderStatus.Click += new System.EventHandler(this.ButtonOrderStatus_Click);
            // 
            // buttonDailyReport
            // 
            this.buttonDailyReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDailyReport.Location = new System.Drawing.Point(100, 170);
            this.buttonDailyReport.Name = "buttonDailyReport";
            this.buttonDailyReport.Size = new System.Drawing.Size(200, 50);
            this.buttonDailyReport.TabIndex = 2;
            this.buttonDailyReport.Text = "Günlük Rapor";
            this.buttonDailyReport.UseVisualStyleBackColor = true;
            this.buttonDailyReport.Click += new System.EventHandler(this.ButtonDailyReport_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLogout.Location = new System.Drawing.Point(600, 300);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(120, 40);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Çıkış Yap";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // EmployeeHomePage
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonDailyReport);
            this.Controls.Add(this.buttonOrderStatus);
            this.Controls.Add(this.labelWelcome);
            this.Name = "EmployeeHomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çalışan Paneli";
            this.Load += new System.EventHandler(this.EmployeeHomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonOrderStatus;
        private System.Windows.Forms.Button buttonDailyReport;
        private System.Windows.Forms.Button buttonLogout;
    }
}
