using System;
using System.Data.SqlClient;

namespace BE_BW1_Ecommerce
{
    public partial class Modifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login");
            }
            else
            {
                string id = Request.QueryString["ID"];
                if (id != null)
                {
                    SqlConnection conn = serverConnection.Connection();
                    try
                    {
                        conn.Open();
                        string query = $"SELECT * FROM [Prodotto] WHERE IDGiocoDaTavolo = {id}";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            txtTitolo.Text = reader["Titolo"].ToString();

                            //prendi il prezzo e lo converti in decimal con due cifre dopo lo 0 senza la valuta
                            decimal prezzoCompleto = Convert.ToDecimal(reader["Prezzo"]);
                            txtPrezzo.Text = prezzoCompleto.ToString().Substring(1);




                            txtDescrizione.Text = reader["Dettaglio"].ToString();
                            txtEditore.Text = reader["Editore"].ToString();
                            txtImmagine.Text = reader["Immagine"].ToString();
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


        protected void btnModifica_Click(object sender, EventArgs e)
        {

        }
    }
}