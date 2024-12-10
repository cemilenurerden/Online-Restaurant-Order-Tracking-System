using System;
using System.Windows.Forms;

namespace Online_Restaurant_Order_Tracking_System.Forms
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            this.Size = new System.Drawing.Size(800, 600); // Tüm formlar için boyut
            this.StartPosition = FormStartPosition.CenterScreen; // Tüm formlar için ortalama
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}


    