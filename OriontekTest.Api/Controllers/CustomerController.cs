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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            this._customerService = customerService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var customer = _customerService.GetAll().ToList();

            return Ok(customer);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _customerService.Find(id);

            return Ok(customer);
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] CustomerDto customer)
        {
            _customerService.Add(customer);

            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] CustomerDto customer)
        {
            _customerService.Update(customer.Id,customer);

            return Ok();
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            _customerService.Delete(id);

            return Ok();
        }
    }
}
