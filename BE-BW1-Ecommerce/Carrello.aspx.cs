using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_BW1_Ecommerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   
            //recupero carrello dalla sessione e lo casto a List<CartItem> 
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            if (Session["Cart"] != null && cart.Count > 0) 
            {
                CartRepeater.DataSource = cart;
                CartRepeater.DataBind();

                decimal total = 0;
                foreach (CartItem cartItem in cart)
                {
                    total += cartItem.Prodotto.Prezzo * cartItem.Quantita;
                }
            Totale.InnerText = total.ToString("0.00") + "€";
            } 
            





        }
        // metodo per aggiornare la quantità del prodotto nel carrello
        protected void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int productId = Convert.ToInt32(button.CommandArgument); // recupero l'id del prodotto dal command argument del bottone

            // Recupera la quantità inserita dall'utente dal repeater
            RepeaterItem repeaterItem = (RepeaterItem)button.NamingContainer;
            TextBox txtQuantity = (TextBox)repeaterItem.FindControl("txtQuantity");
            int quantity;
            if (int.TryParse(txtQuantity.Text, out quantity))
            {
                List<CartItem> cart = (List<CartItem>)Session["cart"];
                //cerco articolo in cart e aggiorno quantità
                CartItem existingItem = cart.Find(i => i.Prodotto.Id == productId);
                if (existingItem != null)
                {
                    existingItem.Quantita = quantity;
                    existingItem.IsEqualZero(quantity);
                }

                // Rimuovi l'elemento dal carrello se la quantità è zero
                cart.RemoveAll(cartItem => cartItem.Quantita == 0);

                //salvo carello nella session
                Session["cart"] = cart;

                //aggiorno repeater con quantità
                CartRepeater.DataSource = cart;
                CartRepeater.DataBind();

                //per evitare il doppio click ciclo i prodotti nel carrello e aggiorno il totale 
                decimal total = 0;
                foreach (CartItem cartItem in cart)
                {
                    total += cartItem.Prodotto.Prezzo * cartItem.Quantita;
                }
                Totale.InnerText = total.ToString("0.00") + "€";

            }
            

        }
    }


}



