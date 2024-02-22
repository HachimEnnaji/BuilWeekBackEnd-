using System;
using System.Data.SqlClient;

namespace BE_BW1_Ecommerce
{
    public partial class AggiungiProdotto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login");
            }

        }

        protected void Aggiungi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = serverConnection.Connection();
            try
            {
                conn.Open();
                string query = "INSERT INTO Prodotto(Titolo, Prezzo, Dettaglio, Editore, Immagine) VALUES ( @Titolo, @Prezzo, @Dettaglio,@Editore, @Immagine)";

                SqlCommand cmd = new SqlCommand(query, conn);


                cmd.Parameters.AddWithValue("@Titolo", titolo.Text);
                cmd.Parameters.AddWithValue("@Prezzo", prezzo.Text);
                cmd.Parameters.AddWithValue("@Dettaglio", descrizione.Text);
                cmd.Parameters.AddWithValue("@Editore", editore.Text);
                cmd.Parameters.AddWithValue("@Immagine", immagine.Text);

                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                conn.Close();
                Response.Redirect("Admin");
            }
        }
    }
}