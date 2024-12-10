namespace Online_Restaurant_Order_Tracking_System.Forms
{
    partial class RegisterForm
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
            this.label_kayit_ekrani = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.buttonKayitOl = new System.Windows.Forms.Button();
            this.textBoxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelTelephoneNumber = new System.Windows.Forms.Label();
            this.labelPassword_register = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLasName = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_kayit_ekrani
            // 
            this.label_kayit_ekrani.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_kayit_ekrani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_kayit_ekrani.Font = new System.Drawing.Font("Mongolian Baiti", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kayit_ekrani.Location = new System.Drawing.Point(212, 60);
            this.label_kayit_ekrani.Name = "label_kayit_ekrani";
            this.label_kayit_ekrani.Size = new System.Drawing.Size(368, 72);
            this.label_kayit_ekrani.TabIndex = 0;
            this.label_kayit_ekrani.Text = "Kayıt Ekranı";
            this.label_kayit_ekrani.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_kayit_ekrani.Click += new System.EventHandler(this.label_kayit_ekrani_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxAdress);
            this.groupBox1.Controls.Add(this.labelAdress);
            this.groupBox1.Controls.Add(this.buttonKayitOl);
            this.groupBox1.Controls.Add(this.textBoxTelephoneNumber);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.labelTelephoneNumber);
            this.groupBox1.Controls.Add(this.labelPassword_register);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelLasName);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(216, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(197, 192);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdress.TabIndex = 12;
            this.textBoxAdress.TextChanged += new System.EventHandler(this.textBoxAdress_TextChanged);
            // 
            // labelAdress
            // 
            this.labelAdress.BackColor = System.Drawing.Color.Lavender;
            this.labelAdress.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelAdress.Location = new System.Drawing.Point(32, 192);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(100, 23);
            this.labelAdress.TabIndex = 11;
            this.labelAdress.Text = "Adres:";
            this.labelAdress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdress.Click += new System.EventHandler(this.labelAdress_Click);
            // 
            // buttonKayitOl
            // 
            this.buttonKayitOl.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonKayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKayitOl.Font = new System.Drawing.Font("Mongolian Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKayitOl.Location = new System.Drawing.Point(117, 227);
            this.buttonKayitOl.Name = "buttonKayitOl";
            this.buttonKayitOl.Size = new System.Drawing.Size(119, 34);
            this.buttonKayitOl.TabIndex = 10;
            this.buttonKayitOl.Text = "Kayıt Ol";
            this.buttonKayitOl.UseVisualStyleBackColor = false;
            this.buttonKayitOl.Click += new System.EventHandler(this.buttonKayitOl_Click);
            // 
            // textBoxTelephoneNumber
            // 
            this.textBoxTelephoneNumber.Location = new System.Drawing.Point(197, 161);
            this.textBoxTelephoneNumber.Name = "textBoxTelephoneNumber";
            this.textBoxTelephoneNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxTelephoneNumber.TabIndex = 9;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(197, 130);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 22);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(197, 94);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(197, 63);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 21);
            this.textBoxUsername.TabIndex = 6;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(197, 29);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // labelTelephoneNumber
            // 
            this.labelTelephoneNumber.BackColor = System.Drawing.Color.Lavender;
            this.labelTelephoneNumber.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelephoneNumber.Location = new System.Drawing.Point(32, 161);
            this.labelTelephoneNumber.Name = "labelTelephoneNumber";
            this.labelTelephoneNumber.Size = new System.Drawing.Size(100, 22);
            this.labelTelephoneNumber.TabIndex = 4;
            this.labelTelephoneNumber.Text = "Telefon No:";
            this.labelTelephoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTelephoneNumber.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelPassword_register
            // 
            this.labelPassword_register.BackColor = System.Drawing.Color.Lavender;
            this.labelPassword_register.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword_register.Location = new System.Drawing.Point(32, 129);
            this.labelPassword_register.Name = "labelPassword_register";
            this.labelPassword_register.Size = new System.Drawing.Size(100, 23);
            this.labelPassword_register.TabIndex = 3;
            this.labelPassword_register.Text = "Şifre:";
            this.labelPassword_register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.Color.Lavender;
            this.labelEmail.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(32, 94);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 22);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "E posta:";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLasName
            // 
            this.labelLasName.BackColor = System.Drawing.Color.Lavender;
            this.labelLasName.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLasName.Location = new System.Drawing.Point(32, 63);
            this.labelLasName.Name = "labelLasName";
            this.labelLasName.Size = new System.Drawing.Size(100, 21);
            this.labelLasName.TabIndex = 1;
            this.labelLasName.Text = "Soyad";
            this.labelLasName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.BackColor = System.Drawing.Color.Lavender;
            this.labelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelName.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(32, 29);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 20);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Ad:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.label2_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_kayit_ekrani);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_kayit_ekrani;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTelephoneNumber;
        private System.Windows.Forms.Label labelPassword_register;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLasName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonKayitOl;
        private System.Windows.Forms.TextBox textBoxTelephoneNumber;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.Label labelAdress;
    }
}