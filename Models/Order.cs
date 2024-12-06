using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Restaurant_Order_Tracking_System.Models
{
    public class Order
    {
        public int siparisId { get; set; }
        public int userId { get; set; }
        public int urunId { get; set; }
        public int quantity { get; set; }
        public int unitPrice { get; set; }
        public int totalPrice { get; set; }
        public DateTime date { get; set; }
        public OrderStatus status { get; set; }
        public string address { get; set; }
        public PaymentMethod paymentMethod { get; set; }
    }

    public enum OrderStatus
    {
        Preparing,
        Shipped,
        Delivered,
        Cancelled
    }

    public enum PaymentMethod
    {
        CreditCard,
        BankTransfer,
        CashOnDelivery
    }
}
