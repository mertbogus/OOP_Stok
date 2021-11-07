using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using EntityLayer;

namespace BusinessLogicLayer
{
    public class BLLSatis
    {
        public static List<EntitySatis> BLLSatisListele()
        {
            return DataAcessLayer.DALSATİS.SatisListele(); 
        }
    }
}
