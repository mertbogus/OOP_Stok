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
    public partial class SatisEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                SqlCommand komut = new SqlCommand("Select * From TBLURUN", baglanti.bgl);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DropDownListUrun.DataValueField = "URUNID";
                DropDownListUrun.DataTextField = "URUNAD";
                DropDownListUrun.DataSource = dt;
                DropDownListUrun.DataBind();

                //PersonelListesi
                SqlCommand komut2 = new SqlCommand("Select PERSONELID,PERSONELAD+' '+PERSONELSOYAD as 'PERSONEL' From TBLPERSONEL", baglanti.bgl);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                DropDownListPersonel.DataValueField = "PERSONELID";
                DropDownListPersonel.DataTextField = "PERSONEL";
                DropDownListPersonel.DataSource = dt2;
                DropDownListPersonel.DataBind();

                //MüşteriListesi
                SqlCommand komut3 = new SqlCommand("Select MUSTERİID,(MUSTERİAD+' '+MUSTERİSOYAD) as 'MUSTERİ' From TBLMUSTERİ", baglanti.bgl);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataTable dt3 = new DataTable();
                da3.Fill(dt3);
                DropDownListMusteri.DataValueField = "MUSTERİID";
                DropDownListMusteri.DataTextField = "MUSTERİ";
                DropDownListMusteri.DataSource = dt3;
                DropDownListMusteri.DataBind();
            }
        }
    }
}