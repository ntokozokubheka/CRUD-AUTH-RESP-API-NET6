using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace BUILDAPI.Models
{
    public class GUL
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);

        SqlDataAdapter da = null;

        DataTable dt = new DataTable();

        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public IEnumerable<string> GetU(Login login)
        {
            da = new SqlDataAdapter(" Select * from Users where Useremail ='" + login.Useremail + "'and Userpassword = '" + login.Userpassword + "' ", con);


            dt = new DataTable();

            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                return new string[] { dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString() };
            }
            else

                return new string[] { "user not found"};
        }
        }
       

            
        }






