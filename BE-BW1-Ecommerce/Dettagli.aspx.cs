using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE_BW1_Ecommerce
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //metodo per aggiungere prodotti al carrello
        protected void addToCart_Click(object sender, EventArgs e)
        {
            


            string productId = Request.QueryString["IDGiocoDaTavolo"]; //prendo l'id dall'url
            List<string> cart;
            if (Session["cart"] == null)
            {
                cart = new List<string>();
            }
            else
            {
                cart = (List<string>)Session["cart"];
            }
            cart.Add(productId);
            Session["cart"] = cart; // aggiorno sessione con carrello

        }


    }
}
