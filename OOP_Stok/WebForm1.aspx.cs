using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAcessLayer;
using BusinessLogicLayer;

namespace OOP_Stok
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityDepartman> dep = BLLDepartman.BLLDepartmanListele();
            Repeater1.DataSource = dep;
            Repeater1.DataBind();
        }
    }
}