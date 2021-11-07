using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataAcessLayer
{
   public class DALUrun
    {
        public static List<EntıtyUrun> UrunListele()
        {
            List<EntıtyUrun> ur = new List<EntıtyUrun>();
            SqlCommand kmt = new SqlCommand("Select * From TBLURUN", baglanti.bgl);
            if (kmt.Connection.State != ConnectionState.Open)
            {
                kmt.Connection.Open();
            }
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                EntıtyUrun deger = new EntıtyUrun();
                deger.Urunid = Convert.ToInt32(dr["URUNID"].ToString());
                deger.Urunad = dr["URUNAD"].ToString();
                deger.Urunfiyat = Convert.ToDecimal(dr["URUNFİYAT"].ToString());
                deger.Urunadet =Convert.ToInt32( dr["URUNADET"].ToString());
                ur.Add(deger);
            }
            dr.Close();
            return ur;
        }
        public static int UrunEkle(EntıtyUrun ms)
        {
            SqlCommand komut = new SqlCommand("insert into TBLURUN (URUNAD,URUNFİYAT,URUNADET) values (@p1,@p2,@P3)", baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ms.Urunad);
            komut.Parameters.AddWithValue("@p2", ms.Urunfiyat);
            komut.Parameters.AddWithValue("@p3", ms.Urunadet);
            return komut.ExecuteNonQuery();
        }
    }
}
