using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUILDAPI.Models
{
    public class Register
    {
        public string Useremail { get; set; }

        public string Userpassword { get; set; }

        public string Username { get; set; }
        public string Usersurname { get; set; }
        public string UserDOB { get; set; }

        public string IsDeletedUser { get; set; }


    }
}