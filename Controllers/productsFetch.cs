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
        public List<Offer> Get()
        {
           return this.offerService.GetTodaysOffers();
        }

    }
}

