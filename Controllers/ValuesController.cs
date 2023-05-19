using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BUILDAPI.Models;

namespace BUILDAPI.Controllers
{
    public class ValuesController : ApiController
    {
        BAL bal = new BAL();

    
       [Route("api/values/GetLogin")]
        [HttpGet]
        public string GetLogin(string email, string password)
        {
            
            Login login = new Login();
            login.Useremail = email;
            login.Userpassword = password;
            string response = bal.GetLogin(login);

         
            return response;

        }


        [Route("api/values/Getperson")]
        [HttpGet]

        public UpdateUser  Getperson(int a)
        {

            FindUser fu = new FindUser();
            
            return fu.FinderrUser(a);

        }


        [Route("api/values/GetU")]
        [HttpGet]

        public IEnumerable<string> GetU(string email, string password)
        {
            Login login = new Login();
            login.Useremail = email;
            login.Userpassword = password;

            return bal.GetU(login);

        }


        [Route("api/values/Register")]
        [HttpPost]

        public string Register(string name, string surname, string email,string  dob ,string password)
        {
            Register register = new Register();
            register.Username = name;
            register.Usersurname = surname;
            register.Useremail = email;
            register.Userpassword = password;
            register.UserDOB = dob;
            register.IsDeletedUser = "FALSE";

            string r = bal.Register(register);
         
            
            return r;
        }


        [Route("api/values/Updateuser")]
        [HttpPut]
        public string Updateuser( int a ,[FromBody] UpdateUser userman)

        {
            FindUser fu = new FindUser();
            string d =" User not book found";
          
            fu.FinderrUser(a);

           
                
            if (fu.FinderrUser(a) != null)
            {
                d = bal.Upddateuser(userman, a);
            }
            
            return d ;
        }

        [Route("api/values/DeactivateUser")]
        [HttpPut]

        public string DeactivateUser(string a)
        {

            string c= bal.DeactivateUser(a);

            return c;
        }


    }













}

