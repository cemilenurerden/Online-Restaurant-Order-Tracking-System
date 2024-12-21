using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Restaurant_Order_Tracking_System.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // admin, user, worker
    }

}
