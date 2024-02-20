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
            List<Prodotto> cart = (List<Prodotto>)Session["Cart"];
            if (Session["Cart"] != null && cart.Count > 0)
            {
                CartRepeater.DataSource = cart;
                CartRepeater.DataBind();
            } 
            





        }


    }


}



