using Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface IHesCodeService
    {
        List<HesCode> GetAll();

        HesCode GetByHesCode(string hesCode);

        List<HesCode> GetAllByStatus(string status);
    }
}
