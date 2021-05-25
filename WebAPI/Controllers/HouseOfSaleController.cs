using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseOfSaleController : ControllerBase
    {
        IHouseOfSaleService _houseOfSaleService;

        public HouseOfSaleController(IHouseOfSaleService houseOfSaleService)
        {
            _houseOfSaleService = houseOfSaleService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            Thread.Sleep(1000);

            var result = _houseOfSaleService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _houseOfSaleService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbytype")]
        public IActionResult GetByHouseType(string HouseType)
        {
            var result = _houseOfSaleService.GetAllByHouseType(HouseType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getsaledetails")]
        public IActionResult GetSaleDetails(string HouseType)
        {
            var result = _houseOfSaleService.GetSaleDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(HouseOfSale houseOfSale)
        {
            var result = _houseOfSaleService.Add(houseOfSale);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
