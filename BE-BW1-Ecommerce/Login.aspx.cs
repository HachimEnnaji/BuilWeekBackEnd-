using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_BW1_Ecommerce
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                txtPassword.Attributes["value"] = txtPassword.Text;
                pwError.Visible = false;
            }
        }

        protected void btnLogin_Click1(object sender, EventArgs e)
        {
            SqlConnection conn = serverConnection.Connection();
            try
            {
                conn.Open();
                string email = txtUsername.Text.ToString();
                string query = $"SELECT * FROM [User] WHERE Email = '{email}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    HttpCookie LoginCookie = new HttpCookie("LoginCookie");
                    LoginCookie.Values["username"] = reader["username"].ToString();
                    LoginCookie.Values["email"] = reader["email"].ToString();
                    LoginCookie.Values["nome"] = reader["nome"].ToString();
                    LoginCookie.Values["cognome"] = reader["cognome"].ToString();
                    LoginCookie.Expires = DateTime.Now.AddDays(10);
                    Response.Cookies.Add(LoginCookie);
                    Response.Redirect("Default");
                }
                else
                {
                    if(!string.IsNullOrEmpty(txtPassword.Text))
                    {
                        
                        HttpCookie EmailCookie = new HttpCookie("EmailCookie");
                        EmailCookie.Values["email"] = txtUsername.Text.ToString();
                        Response.Cookies.Add(EmailCookie);
                        lblRegistrati1.Visible = true;
                        LinkButton1.Visible = true;
                    }
                    else
                    {
                        pwError.Visible = true;
                    }
                }
            }
            catch (Exception ex)
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