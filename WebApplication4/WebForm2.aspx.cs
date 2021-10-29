using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection Con1 = new SqlConnection(CS))
            {
                SqlCommand cmd1 = new SqlCommand("select Count(ProdID) from tblproduct", Con1);
                Con1.Open();
               int total_rows= ((int) cmd1.ExecuteScalar());
                Response.Write("Total rows= "+ total_rows.ToString() );
               
               
            }
        }
    }
}