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
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected  void Button1_Click (object sender, EventArgs e)
        {
            string config = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["backend_testConnectionString"].ConnectionString;
            SqlConnection conn = new SqlConnection(config);
            string query = "INSERT INTO NewRego (UName, Email, UserName, Password, CPassword) VALUE (@txtUname, @txtEmail, @txtUserName, @txtPassword, @txtCpassword)";
            SqlCommand cmd = new SqlCommand(query);
            conn.Open();

            cmd.Parameters.AddWithValue("@txtUname", txtUname.Text);
            cmd.Parameters.AddWithValue("@txtEmail", txtEmail.Text);
            cmd.Parameters.AddWithValue("@txtUserName", txtUsername.Text);
            cmd.Parameters.AddWithValue("@txtPassword", txtPassword.Text);
            cmd.Parameters.AddWithValue("@txtCpassword", txtCpassword.Text);

            if( txtPassword.Text != txtCpassword.Text)
            {
                lblErrorMessage.Visible = true;
            }
            else
            {
                lblErrorMessage.Visible = false;
            }

            cmd.ExecuteNonQuery();

            conn.Close();

            

        }
  
    }
}