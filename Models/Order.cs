using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Restaurant_Order_Tracking_System.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int userId { get; set; }
        public int ProductId { get; set; }
        public int quantity { get; set; }
        public decimal unitPrice { get; set; }
        public decimal totalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public String status { get; set; }
        public string address { get; set; }
        public String paymentMethod { get; set; }
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
        s,
        BankTransfer,
        CashOnDelivery
    }
}
