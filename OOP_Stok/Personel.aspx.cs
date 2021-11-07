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
    public partial class Personel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<EntityPersonel> personel = BLLPersonel.BLLPersonelListele();
            Repeater1.DataSource = personel;
            Repeater1.DataBind();

        }
    }
}