using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System
{
    public partial class hosgeldinizBolumu : Form
    {
        public hosgeldinizBolumu()
        {
            InitializeComponent();
        }

        private void buttonHosgeldin_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
