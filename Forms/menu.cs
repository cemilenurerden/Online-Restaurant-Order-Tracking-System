using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class menu : BaseForm
    {
        public menu()
        {
            InitializeComponent();
        }

        private void labelİçecek_Click(object sender, EventArgs e)
        {

        }

        private void buttonİcecekler_Click(object sender, EventArgs e)
        {

        }

        private void buttonCorbalar_Click(object sender, EventArgs e)
        {
            var corbalarForm = new bos_dosya(); // Kategori ID: 1 (Çorbalar)
            this.Hide();

            corbalarForm.ShowDialog(); // Kategoriyi aç
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
