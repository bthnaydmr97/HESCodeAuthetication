using Business;
using DataAccess;
using Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//Attribute.
    public class HesCodesAutheticationController : ControllerBase
    {   
        
        IHesCodeService _hesCodeService;

        public HesCodesAutheticationController(IHesCodeService hesCodeService)
        {
            _hesCodeService = hesCodeService;
        }

        [HttpGet("getall")]
        public List<HesCode> GetAll()
        {
            var result = _hesCodeService.GetAll();
            return result;
        }

        [HttpGet("getbyhescode")]
        public HesCode GetByHesCode(string hesCode)
        {
            var result = _hesCodeService.GetByHesCode(hesCode);
            return result;
        }
        [HttpGet("getbyhesstatus")]
        public List<HesCode> GetAllByHesCodeStatus(string status)
        {
            var result = _hesCodeService.GetAllByStatus(status);
            return result;
        }
    }
}
