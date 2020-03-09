using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Backend_Test
{
    public partial class LoginPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            lblErrorMessage.Visible = false;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string config = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["backend_testConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(config);
            SqlCommand cmd = new SqlCommand("SELECT COUNT(1) FROM UserTable WHERE username=@username AND password=@password", conn);

            conn.Open();
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count == 1)
            {
                Session["username"] = username.Text.Trim();
                Response.Redirect("WebForm1.aspx");

            }
            else
            {
                lblErrorMessage.Visible = true;
            }
            cmd.ExecuteNonQuery();

            conn.Close();
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("registration.aspx");
        }
    }
}