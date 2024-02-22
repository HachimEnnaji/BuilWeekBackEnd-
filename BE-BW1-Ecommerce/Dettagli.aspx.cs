using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                        Session["QuantityValue"] = 1;
                        SqlCommand cmd = new SqlCommand("SELEZIONA_ID", conn);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@ID", Request.QueryString["ID"]);

                        SqlDataReader reader = cmd.ExecuteReader();



                        if (reader.Read()) //ciclo tutti i record 
                        {


                            Titolo.InnerHtml = reader["Titolo"].ToString();
                            Titolone.InnerHtml = reader["Titolo"].ToString();
                            Editore.InnerHtml = reader["Editore"].ToString();
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

                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    Response.Redirect("Default");
                }

            }

        }




        protected void PlusButton(object sender, EventArgs e)
        {


            int currentValue = Convert.ToInt32(Session["QuantityValue"]);

            int newValue = currentValue + 1;

            Quantity.Value = newValue.ToString();

            Session["QuantityValue"] = newValue;



        }


        protected void MinButton(object sender, EventArgs e)
        {

            int currentValue = Convert.ToInt32(Session["QuantityValue"]);

            if (currentValue >= 2)
            {

                int newValue = currentValue - 1;

                Quantity.Value = newValue.ToString();

                Session["QuantityValue"] = newValue;
            }
        }


        //    //    //    /  //     //   //    //    //   //   //   //     //
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["cart"] == null)
            {
                Session["cart"] = new List<CartItem>();
            }

            SqlConnection conn = serverConnection.Connection();
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELEZIONA_ID", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", Request.QueryString["ID"]);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    List<CartItem> cart = (List<CartItem>)Session["cart"];

                    Prodotto prodotto = new Prodotto();
                    prodotto.Id = Convert.ToInt32(reader["IDGiocoDaTavolo"]);
                    prodotto.Titolo = reader["Titolo"].ToString();
                    prodotto.Prezzo = Convert.ToDecimal(reader["Prezzo"]);
                    prodotto.Immagine = reader["Immagine"].ToString();


                    int.TryParse(Quantity.Value, out int currentValue);
                    CartItem existingCartItem = cart.Find(i => i.Prodotto.Id == prodotto.Id);
                    if (existingCartItem != null)
                    {
                        existingCartItem.Quantita += currentValue;
                    }
                    else
                    {
                        CartItem cartItem = new CartItem();
                        cartItem.Prodotto = prodotto;
                        cartItem.Quantita = currentValue;
                        cart.Add(cartItem);
                    }

                    Session["cart"] = cart;

                    Response.Redirect(Request.RawUrl);
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

