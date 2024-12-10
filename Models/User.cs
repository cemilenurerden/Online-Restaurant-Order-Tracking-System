using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Restaurant_Order_Tracking_System.Models
{
    public class User
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string adress { get; set; }
        public string password { get; set; }
        public UserRole role { get; set; }

        public enum UserRole
        {
            admin,
            user,
            worker
        }

    }
}
