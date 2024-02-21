using System;
using System.Data.SqlClient;
using System.Web;

namespace BE_BW1_Ecommerce
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {

                    // utilizzo la classe ServerConnection e nel try stabilisco la connessione
                    SqlConnection conn = serverConnection.Connection();
                    try
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("SELEZIONA_ID", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", Request.QueryString["ID"]);

                        SqlDataReader reader = cmd.ExecuteReader();



                        if (reader.Read()) //ciclo tutti i record 
                        {


                            Titolo.InnerHtml = reader["Titolo"].ToString();
                            Image1.ImageUrl = reader["Immagine"].ToString();
                            Dettaglio.InnerHtml = reader["Dettaglio"].ToString();


                            //  Per stampare i primi 4 caratteri compresa la virgola
                            // 1 metto leggo con reader storando il risultato dentro una variabile
                            // 2 storo dentro una variabile il risultato con il metodo Substring
                            decimal prezzoCompleto = Convert.ToDecimal(reader["Prezzo"]);
                            Prezzo.InnerHtml = prezzoCompleto.ToString("C");

                        }
                    }

                    catch (Exception ex)
                    {
                        Response.Write(ex.Message);
                    }
                }
                else
                {
                    Response.Write("id null");
                }

            }
            else
            {
                Response.Write("SONO NEL PRIMO IF");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie carrelloCookie = Request.Cookies["CarrelloCookie"];
            if (carrelloCookie != null)
            {
                carrelloCookie = new HttpCookie("CarrelloCookie");

            }

            carrelloCookie.Values["ID"] = Request.QueryString["ID"];


            carrelloCookie.Expires = DateTime.Now.AddDays(10);
            // Sovrascrivo o aggiungo il cookie alla risposta
            Response.Cookies.Add(carrelloCookie);
        }
    }
}
