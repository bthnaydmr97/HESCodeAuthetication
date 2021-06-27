using DataAccess;
using Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class HesCodeManager : IHesCodeService
    {
        IHesCodeDal _hesCodeDal;

        public HesCodeManager(IHesCodeDal hesCodeDal)
        {
            _hesCodeDal = hesCodeDal;
        }
        public List<HesCode> GetAll()
        {
            return _hesCodeDal.GetAll();
        }

        public List<HesCode> GetAllByStatus(string status)
        {
            return _hesCodeDal.GetAll(h => h.Status == status);
        }

        public HesCode GetByHesCode(string hesCode)
        {
            return _hesCodeDal.Get(h => h.Hes == hesCode);
        }

        
    }
}
