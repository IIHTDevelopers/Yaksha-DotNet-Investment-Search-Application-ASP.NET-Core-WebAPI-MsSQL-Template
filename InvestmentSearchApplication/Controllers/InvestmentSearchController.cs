using InvestmentSearchApplication.BusinessLayer.Interfaces;
using InvestmentSearchApplication.BusinessLayer.ViewModels;
using InvestmentSearchApplication.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InsurancePolicyManagement.Controllers
{
    [ApiController]
    public class InvestmentSearchController : ControllerBase
    {
        private readonly IInvestmentSearchService _investmentSearchService;
        public InvestmentSearchController(IInvestmentSearchService investmentSearch)
        {
            _investmentSearchService = investmentSearch;
        }

        [HttpPost]
        [Route("/api/auth/login")]
        [AllowAnonymous]
        public async Task<IActionResult> UserLogin([FromBody] UserViewModel model)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/api/stocks/search")]
        [AllowAnonymous]
        public async Task<IActionResult> SearchStock([FromQuery] string stockName)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("/api/stocks/details")]
        [AllowAnonymous]
        public async Task<IActionResult> GetStockById([FromQuery] int stockId)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}