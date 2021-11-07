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
    public class DALDepartman
    {
        public static List<EntityDepartman> DepartmanListele()
        {
            List<EntityDepartman> dg = new List<EntityDepartman>();
            SqlCommand kmt = new SqlCommand("Select * From TBLDEPARTMAN", baglanti.bgl);
            if (kmt.Connection.State!=ConnectionState.Open)
            {
                kmt.Connection.Open();
            }
            SqlDataReader dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                EntityDepartman deger = new EntityDepartman();
                deger.Departmanid = Convert.ToByte(dr["DEPARTMANID"].ToString());
                deger.Departmanad = dr["DEPARTMANAD"].ToString();
                dg.Add(deger);
            }
            dr.Close();
            return dg;
        }
        public static int DepartmanEkle(EntityDepartman p)
        {
            SqlCommand komut = new SqlCommand("insert into TBLDEPARTMAN (DEPARTMANAD) values (@p1)", baglanti.bgl);
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("@p1",p.Departmanad);
            return komut.ExecuteNonQuery();
        }
    }
}
