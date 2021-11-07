using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAcessLayer;
using BusinessLogicLayer;

namespace OOP_Stok
{
    public partial class MusteriSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToByte(Request.QueryString["musteriıd"]);
            EntityMusteri ent = new EntityMusteri();
            ent.Musteriıd = byte.Parse(x.ToString());
            BLLMusteri.BLLMusteriSil(ent.Musteriıd);
            Response.Redirect("MusteriListesi.aspx");
        }
    }
}