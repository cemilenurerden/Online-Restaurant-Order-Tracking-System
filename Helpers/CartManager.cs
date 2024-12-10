using System.Collections.Generic;
using Online_Restaurant_Order_Tracking_System.Models;

namespace Online_Restaurant_Order_Tracking_System.Helpers
{
    public class CartManager
    {
        private static CartManager _instance;
        public List<CartItem> Cart { get; private set; }

        private CartManager()
        {
            Cart = new List<CartItem>();
        }

        public static CartManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CartManager();
                }
                return _instance;
            }
        }
    }
}
