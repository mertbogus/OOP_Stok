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
    public partial class UrunEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntıtyUrun urn  = new EntıtyUrun();
            urn.Urunad = TextBox1.Text;
            urn.Urunfiyat = Convert.ToDecimal(TextBox2.Text);
            urn.Urunadet = Convert.ToInt32(TextBox3.Text);
            BLLURUN.BLLUrunEkle(urn);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Yeni Ürün Başarıyla Eklendi.')", true);
            Response.Redirect("Urunler.aspx");
        }
    }
}