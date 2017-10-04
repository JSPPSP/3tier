using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.BAL.Repositry.Interface;
using Web.DTO.Model;
using Web.DAl;
namespace Web.BAL.Repositry
{
    public class CustmerRepositry : Icustmer
    {
        private readonly _3TierArchitecure_DAL _3TierArchitecure_DAL;

        public Custmer CustmerByID(int CustmerId)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustmer(int CustmerId)
        {
            throw new NotImplementedException();
        }

        public List<Custmer> GetCustmerById(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Custmer> GetCustmers()
        {
            List<Custmer> cust = _3TierArchitecure_DAL.GetAllCustmers();
            return cust;
        }

        public void InsertNewCustmer(Custmer cust)
        {
            throw new NotImplementedException();
        }

        public void UpadteCustmer(Custmer cust, int id)
        {
            throw new NotImplementedException();
        }
    }
}
