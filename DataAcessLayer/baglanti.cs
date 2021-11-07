using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;


namespace DataAcessLayer
{
    public class baglanti
    {

        public static SqlConnection bgl = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString);
    }
}
