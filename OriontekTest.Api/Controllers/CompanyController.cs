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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var company = _companyService.GetAll();

            return Ok(company);
        }

        [HttpGet("GetAllActive")]
        public IActionResult GetAllActive()
        {
            var company = _companyService.GetAllActive();

            return Ok(company);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            var company = _companyService.Find(id);

            return Ok(company);
        }

        [HttpPost("Create")]
        public IActionResult Create([FromBody] CompanyDto company)
        {
            _companyService.Add(company);

            return Ok();
        }

        [HttpPut("Update")]
        public IActionResult Update([FromBody] CompanyDto company)
        {
            _companyService.Update(company.Id, company);

            return Ok();
        }
    }
}
