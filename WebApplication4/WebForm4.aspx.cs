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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

          

        }

        

        protected void TextBoxProduct_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GetProduct_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {

                
                SqlCommand cmd = new SqlCommand("select * from tblproduct where ProdName Like @Productname ", con);
                con.Open();
                cmd.Parameters.AddWithValue("@productname", TextBoxProduct.Text+ "%");
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();


            }
        }
    }
}