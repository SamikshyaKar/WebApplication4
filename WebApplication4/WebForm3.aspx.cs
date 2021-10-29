using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication4
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd2 = new SqlCommand("Insert into tblproduct values(22,'motoro',45,4)", con);
                con.Open();
                int rows =(int)cmd2.ExecuteNonQuery();
                Response.Write("Inserted rows are : "+ rows.ToString());


            }
        }
    }
}