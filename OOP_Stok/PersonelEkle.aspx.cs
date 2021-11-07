using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using EntityLayer;
using DataAcessLayer;
using BusinessLogicLayer;

namespace OOP_Stok
{
    public partial class PersonelEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                SqlCommand komut = new SqlCommand("Select * From TBLDEPARTMAN", baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownList1.DataValueField = "DEPARTMANID";
                DropDownList1.DataTextField = "DEPARTMANAD";
                DropDownList1.DataSource = dt;
                DropDownList1.DataBind();
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EntityPersonel prs = new EntityPersonel();
            prs.Personelad = TextBox1.Text;
            prs.Personelsoyad = TextBox2.Text;
            prs.Personelmaas = decimal.Parse(TextBox3.Text);
            prs.Personeldepartman = byte.Parse(DropDownList1.SelectedValue);
            BLLPersonel.BLLPersonelEkle(prs);
            Response.Redirect("Personel.aspx");
        }
    }
}