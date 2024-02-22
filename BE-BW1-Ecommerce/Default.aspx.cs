using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.UI;

namespace BE_BW1_Ecommerce
{
    public partial class _Default : Page
    {   
        // al load della pagina recupero i dati dei prodotti dal database e li mostro in una card
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

        // al click del bottone aggiungo il prodotto al carrello 
        protected void addToCart_Click1(object sender, EventArgs e)
        {
            // recupero l'id del prodotto dal command argument del bottone 
            string productId = ((System.Web.UI.WebControls.LinkButton)sender).CommandArgument; 

            //se il carrello è vuoto lo inizializzo con una nuova lista di prodotti 
            if (Session["cart"] == null) 
            {
                Session["cart"] = new List<CartItem>(); 

            }
            // stabilisco la connessione al database e recupero i dati del prodotto dal database con una query
            SqlConnection conn = serverConnection.Connection();
            try
            {
                conn.Open();

                string query = $"SELECT IDGiocoDaTavolo, Titolo, Prezzo, Immagine FROM [Prodotto] WHERE IDGiocoDaTavolo = {productId}";


                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataReader reader = cmd.ExecuteReader();


                // se c'è un risultato nella query allora aggiungo il prodotto al carrello con i suoi dati
                if (reader.Read()) 
                {
                    // recupero il carrello dalla sessione e lo casto a List<CartItem> 
                    List<CartItem> cart = (List<CartItem>)Session["cart"]; 

                    // creo un nuovo prodotto e gli assegno i dati del prodotto recuperato dal database 
                    Prodotto prodotto = new Prodotto(); 
                    prodotto.Id = Convert.ToInt32(reader["IDGiocoDaTavolo"]); 

                    prodotto.Titolo = reader["Titolo"].ToString();
                    prodotto.Prezzo = Convert.ToDecimal(reader["Prezzo"]);
                    prodotto.Immagine = reader["Immagine"].ToString(); 

                    //cerco CartItem nel carrello con Find, se esiste già incremento la quantità, altrimenti ne creo uno nuovo
                    CartItem existingCartItem = cart.Find(i => i.Prodotto.Id == prodotto.Id);
                    if (existingCartItem != null) 
                    
                    { 
                        existingCartItem.Quantita++;
                    }
                    else
                    {
                    CartItem cartItem = new CartItem();
                    cartItem.Prodotto = prodotto;
                    cartItem.Quantita = 1; 

                    cart.Add(cartItem);
                    }

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
