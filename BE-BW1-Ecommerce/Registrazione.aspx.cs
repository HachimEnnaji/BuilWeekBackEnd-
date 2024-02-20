using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_BW1_Ecommerce
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                txtEmail.Text = Request.Cookies["EmailCookie"]["email"];
            }
        }

        protected void btnRegistra_Click(object sender, EventArgs e)
        {
            SqlConnection conn = serverConnection.Connection();
            try
            {
                conn.Open();
                string query = $"INSERT INTO [User](Email, Nome, Cognome, Username) VALUES ('{txtEmail.Text}', '{txtNome.Text}', '{txtCognome.Text}', '{txtUsername.Text}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Response.Redirect("Default");
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}