using System;
using System.Data.SqlClient;

namespace BE_BW1_Ecommerce
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login");
            }
            else
            {
                string username = Session["username"].ToString();
                demo.InnerHtml = username;
                SqlConnection conn = serverConnection.Connection();
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM [Prodotto]";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    cardRepeater.DataSource = reader;
                    cardRepeater.DataBind();

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

        protected void Delete_Click(object sender, EventArgs e)
        {
            string productId = ((System.Web.UI.WebControls.LinkButton)sender).CommandArgument;
            SqlConnection conn = serverConnection.Connection();
            try
            {
                conn.Open();
                string query = $"DELETE FROM [Prodotto] WHERE IDGiocoDaTavolo = {productId}";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                Response.Redirect("Admin");
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