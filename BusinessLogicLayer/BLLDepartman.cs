using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAcessLayer;

namespace BusinessLogicLayer
{
   public class BLLDepartman
    {
        public static List<EntityDepartman> BLLDepartmanListele()
        {
            return DataAcessLayer.DALDepartman.DepartmanListele();
        }
        public static int BLLDepartmanEkle(EntityDepartman dp)
        {
            if (dp.Departmanad!=null && dp.Departmanad!="")
            {
                return DataAcessLayer.DALDepartman.DepartmanEkle(dp);
            }
            else
            {
                return -1;
            }
        }
    }
}
