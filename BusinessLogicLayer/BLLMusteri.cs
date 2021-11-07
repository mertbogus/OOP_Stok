using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class BLLMusteri
    {
        public static List<EntityMusteri> BLLMusteriListesi()
        {
            return DataAcessLayer.DALMusteri.MusteriListele();
        }
        public static int BLLMusteriEkle(EntityMusteri mu)
        {
            if (mu.Musteriad != null && mu.Musteriad != "" && mu.Musterisoyad != null && mu.Musterisoyad != "")
            {
                return DALMusteri.MusteriEkle(mu);
            }
            else
            {
                return -1;
            }
        }
        public static bool BLLMusteriSil(byte id)
        {
            if (id!=0)
            {
                return DALMusteri.MusteriSil(id);
            }
            else
            {
                return false;
            }
        }
    }
}
