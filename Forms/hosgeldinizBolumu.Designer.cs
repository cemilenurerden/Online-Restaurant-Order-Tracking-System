namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class hosgeldinizBolumu
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
            this.buttonHosgeldin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHosgeldin
            // 
            this.buttonHosgeldin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonHosgeldin.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources._4994444c2a8447af58521d63b78b4b02;
            this.buttonHosgeldin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHosgeldin.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHosgeldin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHosgeldin.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHosgeldin.ForeColor = System.Drawing.Color.White;
            this.buttonHosgeldin.Location = new System.Drawing.Point(424, 137);
            this.buttonHosgeldin.Name = "buttonHosgeldin";
            this.buttonHosgeldin.Size = new System.Drawing.Size(385, 149);
            this.buttonHosgeldin.TabIndex = 0;
            this.buttonHosgeldin.Text = "CEES RESTAURANT";
            this.buttonHosgeldin.UseVisualStyleBackColor = false;
            this.buttonHosgeldin.Click += new System.EventHandler(this.buttonHosgeldin_Click);
            // 
            // hosgeldinizBolumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.c7993eb4364414034ce368088cffa6c0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(921, 701);
            this.Controls.Add(this.buttonHosgeldin);
            this.Name = "hosgeldinizBolumu";
            this.Text = "hosgeldinizBolumu";
            this.Load += new System.EventHandler(this.hosgeldinizBolumu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHosgeldin;
    }
}