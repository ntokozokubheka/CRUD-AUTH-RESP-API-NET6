using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BUILDAPI.Models
{
    public class DEL
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);

        SqlCommand cmd = null;

        SqlDataAdapter da = null;

        DataTable dt = null;

        public string DeactivateUser( string a)
        {

            int b = 0;

            cmd = new SqlCommand("UPDATE Users SET Userstatus ='"+b+ "'WHERE ID ='" +a+"';", con);


            con.Open();


            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                return "successful account deletion";

            }
            else

                return "failed account deletion";
        }


    }
}