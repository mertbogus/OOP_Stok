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
    public partial class Urunler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntıtyUrun> urun = BLLURUN.BLLUrunListele();
            Repeater1.DataSource = urun;
            Repeater1.DataBind();
        }
    }
}