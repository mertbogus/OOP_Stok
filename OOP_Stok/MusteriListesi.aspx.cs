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
    public partial class MusteriListesi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityMusteri> musteri = BLLMusteri.BLLMusteriListesi();
            Repeater1.DataSource = musteri;
            Repeater1.DataBind();
        }
    }
}