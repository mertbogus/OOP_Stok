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
    public class DALSATİS
    {
        public static List<EntitySatis> SatisListele()
        {
            List<EntitySatis> ms = new List<EntitySatis>();
            SqlCommand komut = new SqlCommand("SATISLAR ", baglanti.bgl);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                EntitySatis sts = new EntitySatis();
                sts.Satisid = Convert.ToInt32(dr["SATİSID"].ToString());
                sts.Urunad = dr["URUNAD"].ToString();
                sts.Personelad = dr["PERSONEL"].ToString();
                //sts.Personelsoyad= dr["PERSONELSOYAD"].ToString();
                sts.Musteriad = dr["MUSTERİ"].ToString();
                //sts.Musterisoyad = dr["MUSTERİSOYAD"].ToString();
                sts.Fiyat = Convert.ToDecimal(dr["TUTAR"].ToString());
                ms.Add(sts);
            }
            dr.Close();
            return ms;
        }
    }
}
