using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Web.DTO.Model;

namespace Web.BAL.Repositry.Interface
{
   public interface Icustmer
    {
        List<Custmer> GetCustmers();
        List<Custmer> GetCustmerById(int ID);
        void InsertNewCustmer(Custmer cust);
        void UpadteCustmer(Custmer cust, int id);
        Custmer CustmerByID(int CustmerId);
        void DeleteCustmer(int CustmerId);
    }
}
