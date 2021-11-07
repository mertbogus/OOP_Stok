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
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListele()
        {
            List<EntityPersonel> personel = new List<EntityPersonel>();
            SqlCommand kmt = new SqlCommand("DEPARTMANLİST", baglanti.bgl);
            kmt.CommandType = CommandType.StoredProcedure;
            if (kmt.Connection.State!=ConnectionState.Open)
            {
                kmt.Connection.Open();
            }
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel prs = new EntityPersonel();
                prs.Personelid = Convert.ToInt32(dr["PERSONELID"].ToString());
                prs.Personelad = dr["PERSONELAD"].ToString();
                prs.Personelsoyad = dr["PERSONELSOYAD"].ToString();
                prs.Personeldepartman= Convert.ToByte(dr["PERSONELDEPARTMAN"].ToString());
                prs.Personelmaas = Convert.ToDecimal(dr["PERSONELMAAS"].ToString());
                prs.Fotograf= dr["PERSONELFOTOGRAF"].ToString();
                personel.Add(prs);
            }
            dr.Close();
            return personel;
        }
        public static int PersonelEkle(EntityPersonel personel)
        {
            SqlCommand komut = new SqlCommand("insert into TBLPERSONEL (PERSONELAD,PERSONELSOYAD,PERSONELDEPARTMAN,PERSONELMAAS) values (@p1,@p2,@p3,@p4)", baglanti.bgl);
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1", personel.Personelad);
            komut.Parameters.AddWithValue("@p2", personel.Personelsoyad);
            komut.Parameters.AddWithValue("@p3", personel.Personeldepartman);
            komut.Parameters.AddWithValue("@p4", personel.Personelmaas);
            return komut.ExecuteNonQuery();
        }
    }
}
