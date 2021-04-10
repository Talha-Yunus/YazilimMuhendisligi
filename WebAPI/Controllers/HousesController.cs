using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]//Attribute- class ile ilgili bilgi verme
    public class HousesController : ControllerBase
    {
        //Loosely coupled
        //naming convention
        //IoC Container -- Inversion of Control
        IHouseService _productService;

        public HousesController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Swagger
            //Dependency chain --

            Thread.Sleep(1000);

            var result = _houseService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _houseService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("getbytype")]
        public IActionResult GetByHouseType(string HouseType)
        {
            var result = _houseService.GetAllByHouseType(HouseType);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("gethousedetails")]
        public IActionResult GetProductDetails(string HouseType)
        {
            var result = _houseService.GetHouseDetails();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(House house)
        {
            var result = _houseService.Add(house);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
