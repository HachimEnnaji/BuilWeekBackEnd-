using System;
using System.Web.UI;

namespace BE_BW1_Ecommerce
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se nella session admin è collegato allora mostro la sezione admin
            if (Session["username"] != null)
            {
                SezioneAdmin.Visible = true;
            }
            else
            {
                SezioneAdmin.Visible = false;
            }
        }

        protected void SezioneAdmin_Click(object sender, EventArgs e)
        {

        }
    }
}