using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.DTO;
using Web.DTO.Model;

namespace Web.DAl
{
   public class _3TierArchitecure_DAL
    {
        SqlConnection con = new SqlConnection();
        public _3TierArchitecure_DAL()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con.Open();
        }
        public List<Custmer> GetAllCustmers()
        {

            SqlCommand cmd = new SqlCommand("select * from tbCustmer", con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            List<Custmer> custmer = new List<Custmer>();
            while (dr.Read())
            {
                Custmer cust = new Custmer();
                cust.CustmerId = Convert.ToInt32(dr[0]);
                cust.CustmerName = dr[1].ToString();
                cust.CustmerNumber = dr[2].ToString();
                cust.Country = dr[3].ToString();

                custmer.Add(cust);
            }
            dr.Close();
            cmd.Dispose();
            con.Close();
            return custmer;

        }
    }
}
