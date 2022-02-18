using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OriontekTest.Business.Dtos;
using OriontekTest.Business.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OriontekTest.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            this._addressService = addressService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var address = _addressService.GetAll().ToList();

            return Ok(address);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var address = _addressService.Find(id);

            return Ok(address);
        }

        [HttpGet("GetAllByCustomerId")]
        public IActionResult GetAllByCustomerId(int customerId)
        {
            var CustomerAddress = _addressService.GetAllByCustomerId(customerId);

            return Ok(CustomerAddress);
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] AddressDto address)
        {
            _addressService.Add(address);

            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] AddressDto address)
        {
            _addressService.Update(address.Id, address);

            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _addressService.Delete(id);

            return Ok();
        }
    }
}
