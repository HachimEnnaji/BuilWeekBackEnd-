using System;
using System.Data.SqlClient;

namespace BE_BW1_Ecommerce
{
    public partial class Modifica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // da controllare che ci sia loggato solo l'admin altrimenti access forbidden
            if (Session["username"] == null)
            {
                Response.Redirect("Login");
            }
            else
            {
                if (!IsPostBack)
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
                                txtPrezzo.Text = prezzoCompleto.ToString();
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
        }

        protected void btnModifica_Click(object sender, EventArgs e)
        {
            //prendi i dati dalla form e fai l'update
            string id = Request.QueryString["ID"];
            SqlConnection conn = serverConnection.Connection();
            try
            {
                conn.Open();

                string query = "UPDATE [Prodotto] SET Titolo = @Titolo, Prezzo = @Prezzo, Dettaglio = @Dettaglio, Editore = @Editore, Immagine = @Immagine WHERE IDGiocoDaTavolo = @ID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Titolo", txtTitolo.Text);
                cmd.Parameters.AddWithValue("@Prezzo", txtPrezzo.Text);
                cmd.Parameters.AddWithValue("@Dettaglio", txtDescrizione.Text);
                cmd.Parameters.AddWithValue("@Editore", txtEditore.Text);
                cmd.Parameters.AddWithValue("@Immagine", txtImmagine.Text);
                cmd.Parameters.AddWithValue("@ID", id);
                System.Diagnostics.Debug.WriteLine(txtTitolo.Text, txtPrezzo.Text, txtDescrizione.Text);
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