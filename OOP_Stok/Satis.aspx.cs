using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BusinessLogicLayer;
using DataAcessLayer;

namespace OOP_Stok
{
    public partial class Satis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntitySatis> urun = BLLSatis.BLLSatisListele(); 
            Repeater1.DataSource = urun;
            Repeater1.DataBind();
        }
    }
}