using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RefitSample
{
    public interface IIexTrading
    {
        [Get("/1.0/stock/{symbol}/company")]
        Task<Company> GetCompanyAsync(string symbol);
    }
}
