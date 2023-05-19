using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BUILDAPI.Models
{
    public class UAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);

        SqlCommand cmd = null;

        SqlDataAdapter da = null;

        DataTable dt = null;

        public string Upddateuser(UpdateUser updateuser, int a ) 
        {

           

            cmd = new SqlCommand( "UPDATE Users SET Username ='"+ updateuser.Username +"', Usersurname = '"+updateuser.Usersurname+ "'  , Useremail = '" + updateuser.Useremail+ "', Userpassword = '" + updateuser.Userpassword + "', UserDOB = '" + updateuser.UserDOB + "' , UserStatus = '" + updateuser.IsDeletedUser + "'WHERE ID ='" + a+"';" ,con);


            con.Open();


            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                return "successful update";

            }
            else

                return "failed update";
        }





    }
}