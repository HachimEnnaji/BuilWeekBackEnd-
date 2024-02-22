using System;
using System.Web.UI;

namespace BE_BW1_Ecommerce
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //se nella session admin è collegato allora mostro la sezione admin
            if (Session["username"] != null && Session["username"].ToString() == "admin")
            {
                SezioneAdmin.Visible = true;
                AggiungiProdotto.Visible = true;
                Login.Visible = false;
                Logout.Visible = true;
            }
            else if (Request.Cookies["LoginCookie"] != null)
            {
                SezioneAdmin.Visible = false;
                Login.Visible = false;
                Logout.Visible = true;
            }
            else
            {
                SezioneAdmin.Visible = false;
                Login.Visible = true;
                Logout.Visible = false;
            }
        }

        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Session["cart"] = null;
            Response.Redirect(Request.RawUrl);
        }

        protected void Logout_Click(object sender, EventArgs e)
        {
            Session["username"] = null;
            Response.Redirect("Login");
        }
    }
}