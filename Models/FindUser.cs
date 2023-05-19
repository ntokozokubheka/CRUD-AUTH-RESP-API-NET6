using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace BUILDAPI.Models
{
    public class FindUser
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapicon"].ConnectionString);

        SqlDataAdapter da = null;

        DataTable dt = new DataTable();


        public UpdateUser FinderrUser(int a)



        {
            da = new SqlDataAdapter(" Select * from Users where ID ='" + a + "'", con);


            dt = new DataTable();

            da.Fill(dt);

            

            UpdateUser us = new UpdateUser();

           

            if (dt.Rows.Count > 0)
            {
                us.UserID =dt.Rows[0][0].ToString();
                us.Username = dt.Rows[0][1].ToString(); 
                us.Usersurname= dt.Rows[0][2].ToString();
                us.Useremail = dt.Rows[0][3].ToString();
                us.Userpassword = dt.Rows[0][4].ToString();
                us.UserDOB = dt.Rows[0][5].ToString();
                us.IsDeletedUser = dt.Rows[0][6].ToString();

                return us;
            
            }

               
                else
                    return us;
            }
          

        }
    }
