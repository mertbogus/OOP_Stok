using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataAcessLayer;


namespace OOP_Stok
{
    public partial class UrunSorgula : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["baglanti"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection bgl = new SqlConnection(strcon);
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            using (var con = new SqlConnection(strcon))
            { 
                SqlDataAdapter dap = new SqlDataAdapter("pIOProductDetails",con);
                dap.SelectCommand.CommandType = CommandType.StoredProcedure;
                dap.SelectCommand.Parameters.AddWithValue("@Barcode", TextBox1.Text);
                dap.SelectCommand.Parameters.AddWithValue("@StoreCode", "M01");
                DataTable dt = new DataTable();
                dap.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }
    }
}
