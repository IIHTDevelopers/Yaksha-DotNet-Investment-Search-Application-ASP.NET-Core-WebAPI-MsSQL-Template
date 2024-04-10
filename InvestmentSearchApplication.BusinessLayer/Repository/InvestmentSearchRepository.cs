using InvestmentSearchApplication.BusinessLayer.Interfaces;
using InvestmentSearchApplication.BusinessLayer.ViewModels;
using InvestmentSearchApplication.DataLayer;
using InvestmentSearchApplication.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentSearchApplication.BusinessLayer.Repository
{
    public class InvestmentSearchRepository : IInvestmentSearchRepository
    {
        private readonly InvestmentSearchDbContext _dbContext;
        public InvestmentSearchRepository(InvestmentSearchDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> UserLogin(UserViewModel model)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<List<Stock>> SearchStock(string stockName)
        {
            //Write your code here
            throw new NotImplementedException();
        }

        public async Task<object> GetStockDetailsById(int id)
        {
            //Write your code here
            throw new NotImplementedException();
        }
    }
}