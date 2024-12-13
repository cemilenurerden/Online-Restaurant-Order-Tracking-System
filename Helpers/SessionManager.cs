using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Restaurant_Order_Tracking_System.Helpers
{
    public static class SessionManager
    {
        private static bool _isLoggedIn = false;
        private static int _userId;
        

        public static bool IsLoggedIn
        {
            get { return _isLoggedIn; }
            set { _isLoggedIn = value; }
        }  public static int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
    }


}
