
using InvestmentSearchApplication.BusinessLayer.Interfaces;
using InvestmentSearchApplication.BusinessLayer.ViewModels;
using InvestmentSearchApplication.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvestmentSearchApplication.BusinessLayer.Services
{
    public class InvestmentSearchService : IInvestmentSearchService
    {
        private readonly IInvestmentSearchRepository _investmentSearch;
        public InvestmentSearchService(IInvestmentSearchRepository investmentSearchRepository)
        {
            _investmentSearch = investmentSearchRepository;
        }

        public async Task<object> GetStockDetailsById(int id)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<List<Stock>> SearchStock(string stockName)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<bool> UserLogin(UserViewModel model)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}