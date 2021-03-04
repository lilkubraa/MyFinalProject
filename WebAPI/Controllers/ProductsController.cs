﻿using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController] //C# DA --> ATTRIBUTE -- JAVADA-> ANNOTATION
    public class ProductsController : ControllerBase
       
    {
        IProductService _productService;
        //Loosely coupled
        //naming convention
        //IOC Container ---- Inversion of control - bellekteki bir yer liste gibi  degişimin kontrolü
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(("getall")]
        public IActionResult GetAll()
        { 
	
            //swagger
            //Dependency chain bagımlılık ...
           
            var result = _productService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet(("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            BadRequest(result);
        }


        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
