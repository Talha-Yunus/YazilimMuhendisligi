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
    public class HouseOfRentController : ControllerBase
    {
        IHouseOfRentService _houseOfRentService;

        public HouseOfRentController(IHouseOfRentService houseOfRentService)
        {
            _houseOfRentService = houseOfRentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            Thread.Sleep(1000);

            var result = _houseOfRentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _houseOfRentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbytype")]
        public IActionResult GetByHouseType(string HouseType)
        {
            var result = _houseOfRentService.GetAllByHouseType(HouseType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("gethousedetails")]
        public IActionResult GetHouseDetails(string HouseType)
        {
            var result = _houseOfRentService.GetRentDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(HouseOfRent houseOfRent)
        {
            var result = _houseOfRentService.Add(houseOfRent);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
