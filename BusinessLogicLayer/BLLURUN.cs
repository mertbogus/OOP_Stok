using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAcessLayer;

namespace BusinessLogicLayer
{
    public class BLLURUN
    {
        public static List<EntıtyUrun> BLLUrunListele()
        {
            return DataAcessLayer.DALUrun.UrunListele();
        }
        public static int BLLUrunEkle(EntıtyUrun mu)
        {
            if (mu.Urunad!=null && mu.Urunad!="" && mu.Urunadet!=0 && mu.Urunfiyat>=1)
            {
                return DALUrun.UrunEkle(mu);
            }
            else
            {
                return -1;
            }
        }
    }
}
