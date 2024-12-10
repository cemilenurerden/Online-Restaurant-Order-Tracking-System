namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class ReportForm
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
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.reportTypeComboBox = new System.Windows.Forms.ComboBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.reportDataGridView = new System.Windows.Forms.DataGridView();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(30, 20);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(200, 22);
            this.startDatePicker.TabIndex = 0;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(250, 20);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(200, 22);
            this.endDatePicker.TabIndex = 1;
            // 
            // reportTypeComboBox
            // 
            this.reportTypeComboBox.FormattingEnabled = true;
            this.reportTypeComboBox.Items.AddRange(new object[] {
            "Günlük",
            "Aylık",
            "Yıllık"});
            this.reportTypeComboBox.Location = new System.Drawing.Point(470, 20);
            this.reportTypeComboBox.Name = "reportTypeComboBox";
            this.reportTypeComboBox.Size = new System.Drawing.Size(150, 24);
            this.reportTypeComboBox.TabIndex = 2;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(640, 16);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(100, 30);
            this.generateReportButton.TabIndex = 3;
            this.generateReportButton.Text = "Rapor Al";
            this.generateReportButton.UseVisualStyleBackColor = true;
            // 
            // reportDataGridView
            // 
            this.reportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportDataGridView.Location = new System.Drawing.Point(30, 70);
            this.reportDataGridView.Name = "reportDataGridView";
            this.reportDataGridView.RowHeadersWidth = 51;
            this.reportDataGridView.RowTemplate.Height = 24;
            this.reportDataGridView.Size = new System.Drawing.Size(710, 300);
            this.reportDataGridView.TabIndex = 4;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(640, 380);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(100, 30);
            this.exportButton.TabIndex = 5;
            this.exportButton.Text = "PDF İndir";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // ReportForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.reportDataGridView);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.reportTypeComboBox);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Name = "ReportForm";
            this.Text = "Raporlama Paneli";
            ((System.ComponentModel.ISupportInitialize)(this.reportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.ComboBox reportTypeComboBox;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DataGridView reportDataGridView;
        private System.Windows.Forms.Button exportButton;
    }
}
