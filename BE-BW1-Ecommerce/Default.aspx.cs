using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;

namespace BE_BW1_Ecommerce
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
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

        protected void addToCart_Click1(object sender, EventArgs e)
        {
            string productId = ((System.Web.UI.WebControls.LinkButton)sender).CommandArgument;
            Response.Write(productId);

            if (Session["cart"] == null)
            {
                Session["cart"] = new List<Prodotto>();

            }
            SqlConnection conn = serverConnection.Connection();
            try
            {
                conn.Open();

                string query = $"SELECT IDGiocoDaTavolo, Titolo, Prezzo FROM [Prodotto] WHERE IDGiocoDaTavolo = {productId}";

                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    List<Prodotto> cart = (List<Prodotto>)Session["cart"];

                    Prodotto prodotto = new Prodotto();

                    prodotto.Id = Convert.ToInt32(reader["IDGiocoDaTavolo"]);
                    prodotto.Titolo = reader["Titolo"].ToString();
                    prodotto.Prezzo = Convert.ToDecimal(reader["Prezzo"]);
                    cart.Add(prodotto);
                    Session["cart"] = cart;
                    Response.Redirect("Default");

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
