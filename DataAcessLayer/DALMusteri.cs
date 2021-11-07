using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;

namespace DataAcessLayer
{
    public class DALMusteri
    {
        public static List<EntityMusteri> MusteriListele()
        {
            List<EntityMusteri> ms = new List<EntityMusteri>();
            SqlCommand komut = new SqlCommand("Select * From TBLMUSTERİ", baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntityMusteri mus = new EntityMusteri();
                mus.Musteriıd =Convert.ToByte(dr["MUSTERİID"].ToString());
                mus.Musteriad = dr["MUSTERİAD"].ToString();
                mus.Musterisoyad= dr["MUSTERİSOYAD"].ToString();
                ms.Add(mus);
            }
            dr.Close();
            return ms;
        }
        public static int MusteriEkle(EntityMusteri ms)
        {
            SqlCommand komut = new SqlCommand("insert into TBLMUSTERİ (MUSTERİAD,MUSTERİSOYAD) values (@p1,@p2)", baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", ms.Musteriad);
            komut.Parameters.AddWithValue("@p2", ms.Musterisoyad);
            return komut.ExecuteNonQuery();
        }
        public static bool MusteriSil(byte id)
        {
            SqlCommand komut = new SqlCommand("delete from  TBLMUSTERİ where MUSTERİID=@p1", baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", id);

            return komut.ExecuteNonQuery()>0;
        }
    }
}
