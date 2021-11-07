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
    public partial class MusteriEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityMusteri mus = new EntityMusteri();
            mus.Musteriad = TextBox1.Text;
            mus.Musterisoyad = TextBox2.Text;
            BLLMusteri.BLLMusteriEkle(mus);
        }
    }
}