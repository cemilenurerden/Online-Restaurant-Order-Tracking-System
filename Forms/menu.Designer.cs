using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class menu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAllProducts = new System.Windows.Forms.Button();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.flowLayoutPanelCategories.SuspendLayout();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelMenu.Controls.Add(this.flowLayoutPanelCategories);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 114);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(684, 486);
            this.panelMenu.TabIndex = 0;
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.AutoScroll = true;
            this.flowLayoutPanelCategories.BackColor = System.Drawing.Color.DarkKhaki;
            this.flowLayoutPanelCategories.Controls.Add(this.buttonAllProducts);
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(20, 17);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(639, 447);
            this.flowLayoutPanelCategories.TabIndex = 1;
            // 
            // buttonAllProducts
            // 
            this.buttonAllProducts.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonAllProducts.ForeColor = System.Drawing.Color.White;
            this.buttonAllProducts.Location = new System.Drawing.Point(5, 5);
            this.buttonAllProducts.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAllProducts.Name = "buttonAllProducts";
            this.buttonAllProducts.Size = new System.Drawing.Size(200, 100);
            this.buttonAllProducts.TabIndex = 0;
            this.buttonAllProducts.Text = "Tüm Ürünler";
            this.buttonAllProducts.UseVisualStyleBackColor = false;
            this.buttonAllProducts.Click += new System.EventHandler(this.buttonAllProducts_Click);
            // 
            // groupBoxHeader
            // 
            this.groupBoxHeader.BackColor = System.Drawing.Color.Thistle;
            this.groupBoxHeader.Controls.Add(this.button2);
            this.groupBoxHeader.Controls.Add(this.button1);
            this.groupBoxHeader.Controls.Add(this.pictureBoxLogo);
            this.groupBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(684, 114);
            this.groupBoxHeader.TabIndex = 1;
            this.groupBoxHeader.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Image = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.shopping_online;
            this.button2.Location = new System.Drawing.Point(530, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 50);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.add_user;
            this.button1.Location = new System.Drawing.Point(597, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 50);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.restaurant__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(36, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(89, 70);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // menu
            // 
            this.ClientSize = new System.Drawing.Size(684, 600);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.groupBoxHeader);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.flowLayoutPanelCategories.ResumeLayout(false);
            this.groupBoxHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.Button buttonAllProducts;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private Button button1;
        private Button button2;
    }
}
