using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BUILDAPI.Models
{
    public class DBconnection
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);

        SqlCommand cmd = null;

        SqlDataAdapter da = null;

        DataTable dt = null;

        public string Register(Register register)
         {

            string b = "FALSE";
             cmd = new SqlCommand("Insert INTO Users(Username,Usersurname,Useremail,Userpassword,UserDOB,UserStatus ) VALUES ('" + register.Username + "','" + register.Usersurname + "','" + register.Useremail + "','" + register.Userpassword + "','" + register.UserDOB + "','"+b+"')", con);

            con.Open();


            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                return "registration successful";

            }
            else

                return "registration failed";
        }



    }
}