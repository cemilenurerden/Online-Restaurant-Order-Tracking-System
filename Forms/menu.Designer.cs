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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAllProducts = new System.Windows.Forms.Button();
            this.groupBoxHeader = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonHakkimizda = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.flowLayoutPanelCategories.SuspendLayout();
            this.groupBoxHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.Controls.Add(this.flowLayoutPanelCategories);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 100);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(800, 500);
            this.panelMenu.TabIndex = 0;
            // 
            // flowLayoutPanelCategories
            // 
            this.flowLayoutPanelCategories.AutoScroll = true;
            this.flowLayoutPanelCategories.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelCategories.Controls.Add(this.buttonAllProducts);
            this.flowLayoutPanelCategories.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanelCategories.Name = "flowLayoutPanelCategories";
            this.flowLayoutPanelCategories.Size = new System.Drawing.Size(760, 444);
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
            this.groupBoxHeader.BackColor = System.Drawing.Color.Silver;
            this.groupBoxHeader.Controls.Add(this.button1);
            this.groupBoxHeader.Controls.Add(this.pictureBox2);
            this.groupBoxHeader.Controls.Add(this.pictureBox1);
            this.groupBoxHeader.Controls.Add(this.buttonHakkimizda);
            this.groupBoxHeader.Controls.Add(this.pictureBoxLogo);
            this.groupBoxHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxHeader.Location = new System.Drawing.Point(0, 0);
            this.groupBoxHeader.Name = "groupBoxHeader";
            this.groupBoxHeader.Size = new System.Drawing.Size(800, 100);
            this.groupBoxHeader.TabIndex = 1;
            this.groupBoxHeader.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.add_user;
            this.button1.Location = new System.Drawing.Point(485, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 50);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(723, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(662, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // buttonHakkimizda
            // 
            this.buttonHakkimizda.BackColor = System.Drawing.Color.Gray;
            this.buttonHakkimizda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHakkimizda.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonHakkimizda.ForeColor = System.Drawing.Color.White;
            this.buttonHakkimizda.Location = new System.Drawing.Point(100, 30);
            this.buttonHakkimizda.Name = "buttonHakkimizda";
            this.buttonHakkimizda.Size = new System.Drawing.Size(200, 40);
            this.buttonHakkimizda.TabIndex = 1;
            this.buttonHakkimizda.Text = "Hakkımızda";
            this.buttonHakkimizda.UseVisualStyleBackColor = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.restaurant__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 30);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(60, 40);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // menu
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.groupBoxHeader);
            this.Name = "menu";
            this.Text = "Menü";
            this.Load += new System.EventHandler(this.menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.flowLayoutPanelCategories.ResumeLayout(false);
            this.groupBoxHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCategories;
        private System.Windows.Forms.Button buttonAllProducts;
        private System.Windows.Forms.GroupBox groupBoxHeader;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonHakkimizda;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}
