using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class CartForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.flowLayoutPanelCart = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonContinueShopping = new System.Windows.Forms.Button();
            this.groupBoxAddressPayment = new System.Windows.Forms.GroupBox();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.textBoxCardName = new System.Windows.Forms.TextBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.labelCardName = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAddressPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCart
            // 
            this.flowLayoutPanelCart.AutoScroll = true;
            this.flowLayoutPanelCart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelCart.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelCart.Location = new System.Drawing.Point(12, 50);
            this.flowLayoutPanelCart.Name = "flowLayoutPanelCart";
            this.flowLayoutPanelCart.Size = new System.Drawing.Size(760, 283);
            this.flowLayoutPanelCart.TabIndex = 0;
            this.flowLayoutPanelCart.WrapContents = false;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.labelTotalPrice.Location = new System.Drawing.Point(12, 336);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(760, 25);
            this.labelTotalPrice.TabIndex = 2;
            this.labelTotalPrice.Text = "Toplam: 0.00₺";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.Orange;
            this.buttonCheckout.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonCheckout.Location = new System.Drawing.Point(662, 570);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(110, 40);
            this.buttonCheckout.TabIndex = 4;
            this.buttonCheckout.Text = "Ödeme Yap";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // buttonContinueShopping
            // 
            this.buttonContinueShopping.BackColor = System.Drawing.SystemColors.Control;
            this.buttonContinueShopping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinueShopping.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonContinueShopping.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonContinueShopping.Image = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.arrow;
            this.buttonContinueShopping.Location = new System.Drawing.Point(12, 10);
            this.buttonContinueShopping.Name = "buttonContinueShopping";
            this.buttonContinueShopping.Size = new System.Drawing.Size(48, 30);
            this.buttonContinueShopping.TabIndex = 1;
            this.buttonContinueShopping.UseVisualStyleBackColor = false;
            this.buttonContinueShopping.Click += new System.EventHandler(this.buttonContinueShopping_Click);
            // 
            // groupBoxAddressPayment
            // 
            this.groupBoxAddressPayment.Controls.Add(this.textBoxCardNumber);
            this.groupBoxAddressPayment.Controls.Add(this.textBoxCardName);
            this.groupBoxAddressPayment.Controls.Add(this.labelCardNumber);
            this.groupBoxAddressPayment.Controls.Add(this.labelCardName);
            this.groupBoxAddressPayment.Controls.Add(this.textBoxAddress);
            this.groupBoxAddressPayment.Controls.Add(this.labelAddress);
            this.groupBoxAddressPayment.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBoxAddressPayment.Controls.Add(this.labelPaymentMethod);
            this.groupBoxAddressPayment.Location = new System.Drawing.Point(12, 374);
            this.groupBoxAddressPayment.Name = "groupBoxAddressPayment";
            this.groupBoxAddressPayment.Size = new System.Drawing.Size(760, 180);
            this.groupBoxAddressPayment.TabIndex = 3;
            this.groupBoxAddressPayment.TabStop = false;
            this.groupBoxAddressPayment.Text = "Adres ve Ödeme Bilgileri";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Location = new System.Drawing.Point(176, 140);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(554, 22);
            this.textBoxCardNumber.TabIndex = 7;
            this.textBoxCardNumber.Visible = false;
            // 
            // textBoxCardName
            // 
            this.textBoxCardName.Location = new System.Drawing.Point(176, 110);
            this.textBoxCardName.Name = "textBoxCardName";
            this.textBoxCardName.Size = new System.Drawing.Size(554, 22);
            this.textBoxCardName.TabIndex = 6;
            this.textBoxCardName.Visible = false;
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelCardNumber.Location = new System.Drawing.Point(10, 140);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(141, 21);
            this.labelCardNumber.TabIndex = 5;
            this.labelCardNumber.Text = "Kart Numarası:";
            this.labelCardNumber.Visible = false;
            // 
            // labelCardName
            // 
            this.labelCardName.AutoSize = true;
            this.labelCardName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelCardName.Location = new System.Drawing.Point(10, 110);
            this.labelCardName.Name = "labelCardName";
            this.labelCardName.Size = new System.Drawing.Size(95, 21);
            this.labelCardName.TabIndex = 4;
            this.labelCardName.Text = "Kart İsmi:";
            this.labelCardName.Visible = false;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(176, 21);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(554, 50);
            this.textBoxAddress.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelAddress.Location = new System.Drawing.Point(10, 20);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(69, 21);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Adres:";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Kredi Kartı",
            "Kapıda Ödeme"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(176, 80);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(554, 24);
            this.comboBoxPaymentMethod.TabIndex = 1;
            this.comboBoxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentMethod_SelectedIndexChanged);
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.labelPaymentMethod.Location = new System.Drawing.Point(10, 80);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(160, 21);
            this.labelPaymentMethod.TabIndex = 0;
            this.labelPaymentMethod.Text = "Ödeme Yöntemi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ALIŞVERİŞE DEVAM ET";
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.groupBoxAddressPayment);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.buttonContinueShopping);
            this.Controls.Add(this.flowLayoutPanelCart);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sepetim";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.groupBoxAddressPayment.ResumeLayout(false);
            this.groupBoxAddressPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCart;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonContinueShopping;
        private System.Windows.Forms.GroupBox groupBoxAddressPayment;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.TextBox textBoxCardName;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.Label labelCardName;
        private System.Windows.Forms.Label label1;
    }
}
