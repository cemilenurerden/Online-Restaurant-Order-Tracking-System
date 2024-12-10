using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class menu 
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonHakkimizda = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelCorba = new System.Windows.Forms.Label();
            this.labelAnaYemek = new System.Windows.Forms.Label();
            this.labelSalata = new System.Windows.Forms.Label();
            this.labelHamburger = new System.Windows.Forms.Label();
            this.labelPasta = new System.Windows.Forms.Label();
            this.labelİçecek = new System.Windows.Forms.Label();
            this.buttonİcecekler = new System.Windows.Forms.Button();
            this.buttonTatli = new System.Windows.Forms.Button();
            this.buttonHamburger = new System.Windows.Forms.Button();
            this.buttonSalatalar = new System.Windows.Forms.Button();
            this.buttonAnaYemekler = new System.Windows.Forms.Button();
            this.buttonCorbalar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.buttonHakkimizda);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.pictureBoxLogo);
            this.groupBox1.Location = new System.Drawing.Point(43, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 82);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonHakkimizda
            // 
            this.buttonHakkimizda.BackColor = System.Drawing.Color.Gray;
            this.buttonHakkimizda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHakkimizda.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonHakkimizda.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonHakkimizda.Location = new System.Drawing.Point(229, 21);
            this.buttonHakkimizda.Name = "buttonHakkimizda";
            this.buttonHakkimizda.Size = new System.Drawing.Size(350, 50);
            this.buttonHakkimizda.TabIndex = 2;
            this.buttonHakkimizda.Text = "HAKKIMIZDA";
            this.buttonHakkimizda.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.add_to_cart;
            this.pictureBox1.Location = new System.Drawing.Point(742, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxLogo.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.ErrorImage")));
            this.pictureBoxLogo.Image = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.restaurant__1_;
            this.pictureBoxLogo.Location = new System.Drawing.Point(16, 21);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(47, 36);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelCorba
            // 
            this.labelCorba.BackColor = System.Drawing.Color.DimGray;
            this.labelCorba.Location = new System.Drawing.Point(75, 342);
            this.labelCorba.Name = "labelCorba";
            this.labelCorba.Size = new System.Drawing.Size(168, 23);
            this.labelCorba.TabIndex = 7;
            this.labelCorba.Text = "ÇORBALAR";
            this.labelCorba.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAnaYemek
            // 
            this.labelAnaYemek.BackColor = System.Drawing.Color.DimGray;
            this.labelAnaYemek.Location = new System.Drawing.Point(342, 342);
            this.labelAnaYemek.Name = "labelAnaYemek";
            this.labelAnaYemek.Size = new System.Drawing.Size(173, 23);
            this.labelAnaYemek.TabIndex = 8;
            this.labelAnaYemek.Text = "ANA YEMEKLER";
            this.labelAnaYemek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSalata
            // 
            this.labelSalata.BackColor = System.Drawing.Color.DimGray;
            this.labelSalata.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSalata.Font = new System.Drawing.Font("Microsoft New Tai Lue", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSalata.Location = new System.Drawing.Point(610, 342);
            this.labelSalata.Name = "labelSalata";
            this.labelSalata.Size = new System.Drawing.Size(184, 23);
            this.labelSalata.TabIndex = 9;
            this.labelSalata.Text = "SALATALAR";
            this.labelSalata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHamburger
            // 
            this.labelHamburger.BackColor = System.Drawing.Color.DimGray;
            this.labelHamburger.Location = new System.Drawing.Point(85, 605);
            this.labelHamburger.Name = "labelHamburger";
            this.labelHamburger.Size = new System.Drawing.Size(168, 23);
            this.labelHamburger.TabIndex = 10;
            this.labelHamburger.Text = "HAMBURGERLER";
            this.labelHamburger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPasta
            // 
            this.labelPasta.BackColor = System.Drawing.Color.DimGray;
            this.labelPasta.Location = new System.Drawing.Point(342, 605);
            this.labelPasta.Name = "labelPasta";
            this.labelPasta.Size = new System.Drawing.Size(173, 23);
            this.labelPasta.TabIndex = 11;
            this.labelPasta.Text = "PASTA";
            this.labelPasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelİçecek
            // 
            this.labelİçecek.BackColor = System.Drawing.Color.DimGray;
            this.labelİçecek.Location = new System.Drawing.Point(610, 605);
            this.labelİçecek.Name = "labelİçecek";
            this.labelİçecek.Size = new System.Drawing.Size(184, 23);
            this.labelİçecek.TabIndex = 12;
            this.labelİçecek.Text = "İÇECEKLER";
            this.labelİçecek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelİçecek.Click += new System.EventHandler(this.labelİçecek_Click);
            // 
            // buttonİcecekler
            // 
            this.buttonİcecekler.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonİcecekler.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.Tea_time;
            this.buttonİcecekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonİcecekler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonİcecekler.Location = new System.Drawing.Point(610, 404);
            this.buttonİcecekler.Name = "buttonİcecekler";
            this.buttonİcecekler.Size = new System.Drawing.Size(184, 185);
            this.buttonİcecekler.TabIndex = 5;
            this.buttonİcecekler.Text = "6";
            this.buttonİcecekler.UseVisualStyleBackColor = false;
            this.buttonİcecekler.Click += new System.EventHandler(this.buttonİcecekler_Click);
            // 
            // buttonTatli
            // 
            this.buttonTatli.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.Chocolate_Mousse_Cake;
            this.buttonTatli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTatli.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonTatli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTatli.Location = new System.Drawing.Point(342, 404);
            this.buttonTatli.Name = "buttonTatli";
            this.buttonTatli.Size = new System.Drawing.Size(173, 185);
            this.buttonTatli.TabIndex = 4;
            this.buttonTatli.Text = "5";
            this.buttonTatli.UseVisualStyleBackColor = true;
            // 
            // buttonHamburger
            // 
            this.buttonHamburger.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.Wholesome_Burger_Recipes_for_a_Healthy_Twist;
            this.buttonHamburger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHamburger.Location = new System.Drawing.Point(78, 404);
            this.buttonHamburger.Name = "buttonHamburger";
            this.buttonHamburger.Size = new System.Drawing.Size(175, 185);
            this.buttonHamburger.TabIndex = 3;
            this.buttonHamburger.Text = "4";
            this.buttonHamburger.UseVisualStyleBackColor = true;
            // 
            // buttonSalatalar
            // 
            this.buttonSalatalar.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources._498df6e469535f9243c82d6461a50cc7;
            this.buttonSalatalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSalatalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalatalar.Location = new System.Drawing.Point(610, 136);
            this.buttonSalatalar.Name = "buttonSalatalar";
            this.buttonSalatalar.Size = new System.Drawing.Size(184, 188);
            this.buttonSalatalar.TabIndex = 2;
            this.buttonSalatalar.Text = "3";
            this.buttonSalatalar.UseVisualStyleBackColor = true;
            // 
            // buttonAnaYemekler
            // 
            this.buttonAnaYemekler.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.Patates_Dilimleri_Üstünde_Ispanak_Beğendi;
            this.buttonAnaYemekler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAnaYemekler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnaYemekler.Location = new System.Drawing.Point(342, 136);
            this.buttonAnaYemekler.Name = "buttonAnaYemekler";
            this.buttonAnaYemekler.Size = new System.Drawing.Size(173, 188);
            this.buttonAnaYemekler.TabIndex = 1;
            this.buttonAnaYemekler.Text = "2";
            this.buttonAnaYemekler.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonAnaYemekler.UseVisualStyleBackColor = true;
            // 
            // buttonCorbalar
            // 
            this.buttonCorbalar.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources.domatesli_arpa_şehriye;
            this.buttonCorbalar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCorbalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorbalar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCorbalar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonCorbalar.Location = new System.Drawing.Point(78, 136);
            this.buttonCorbalar.Name = "buttonCorbalar";
            this.buttonCorbalar.Size = new System.Drawing.Size(175, 188);
            this.buttonCorbalar.TabIndex = 0;
            this.buttonCorbalar.Text = "1";
            this.buttonCorbalar.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonCorbalar.UseVisualStyleBackColor = true;
            this.buttonCorbalar.Click += new System.EventHandler(this.buttonCorbalar_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::Online_Restaurant_Order_Tracking_System.Properties.Resources._4994444c2a8447af58521d63b78b4b02;
            this.ClientSize = new System.Drawing.Size(904, 671);
            this.Controls.Add(this.labelİçecek);
            this.Controls.Add(this.labelPasta);
            this.Controls.Add(this.labelHamburger);
            this.Controls.Add(this.labelSalata);
            this.Controls.Add(this.labelAnaYemek);
            this.Controls.Add(this.labelCorba);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonİcecekler);
            this.Controls.Add(this.buttonTatli);
            this.Controls.Add(this.buttonHamburger);
            this.Controls.Add(this.buttonSalatalar);
            this.Controls.Add(this.buttonAnaYemekler);
            this.Controls.Add(this.buttonCorbalar);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCorbalar;
        private Button buttonHakkimizda;
        private System.Windows.Forms.Button buttonAnaYemekler;
        private System.Windows.Forms.Button buttonSalatalar;
        private System.Windows.Forms.Button buttonHamburger;
        private System.Windows.Forms.Button buttonTatli;
        private System.Windows.Forms.Button buttonİcecekler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCorba;
        private System.Windows.Forms.Label labelAnaYemek;
        private System.Windows.Forms.Label labelSalata;
        private System.Windows.Forms.Label labelHamburger;
        private System.Windows.Forms.Label labelPasta;
        private System.Windows.Forms.Label labelİçecek;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}