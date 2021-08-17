using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using productAPI.service;
using productAPI.models;

namespace productAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsFetch : ControllerBase
    {
        IOfferService offerService;
        public productsFetch(IOfferService offerService)
        {
            this.offerService = offerService;
        }

        [HttpGet]
        [Route("offers")]
        public List<Offer> Get()
        {
           return this.offerService.GetTodaysOffers();
        }


        [HttpGet]
        [Route("products")]
        public IActionResult GetAllProducts()
        {
            return Ok(this.offerService.GetAllProducts().OrderBy(x => x.Price).Take(3));
        }

        [HttpGet]
        [Route("product")]
        public IActionResult GetProductWithSecondLowestPrice()
        {
            return Ok(this.offerService.GetAllProducts().OrderBy(x => x.Price).Skip(1).Take(1));
        }
    }
}

