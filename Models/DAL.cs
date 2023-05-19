using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace BUILDAPI.Models
{
    public class DAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);

        SqlDataAdapter da = null;

        DataTable dt = new DataTable();


        public string GetLogin(Login login)


        {

            da = new SqlDataAdapter(" Select * from Users where Useremail ='" + login.Useremail + "'and Userpassword = '" + login.Userpassword + "' ", con);


            dt = new DataTable();

            da.Fill(dt);


            if (dt.Rows.Count > 0 )
            {
                string e = dt.Rows[0][6].ToString();

                if (e == "FALSE")


                    return "Logged In ";
                else
                    return "Acccount was deleted";
            }
            else
            {
                return "Log In Failde ,try again";

            }

        }


    }
}

