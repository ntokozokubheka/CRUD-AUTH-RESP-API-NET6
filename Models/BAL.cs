using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUILDAPI.Models
{
    public class BAL
    {


        DBconnection db = new DBconnection();

        public string Register(Register register)
        {


            return db.Register(register);

        }




        public string GetLogin(Login login)
        {

            DAL dal = new DAL();

            string response = dal.GetLogin(login);

            return response;

        }

        public IEnumerable<string> GetU(Login login)
        {

            GUL gul = new GUL();

            return gul.GetU(login);

    }

        public string Upddateuser(UpdateUser updateuser, int a)
        {

            UAL ual = new UAL();

            return ual.Upddateuser( updateuser,a);

            
        }

        public string DeactivateUser(string a)
        {

            DEL del = new DEL();


            return del.DeactivateUser(a);
        }



}
}