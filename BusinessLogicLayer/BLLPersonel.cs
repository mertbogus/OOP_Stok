using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class BLLPersonel
    {
      public static  List<EntityPersonel> BLLPersonelListele()
        {
            return DataAcessLayer.DALPersonel.PersonelListele();
        }
        public static int BLLPersonelEkle(EntityPersonel ps)
        {
            if (ps.Personelad!=null && ps.Personelad!= "" && ps.Personelad != "" && ps.Personeldepartman != 0 && ps.Personelmaas != 0 )
            {
                return DALPersonel.PersonelEkle(ps);
            }
            else
            {
                return -1;
            }
        }
    }
}
