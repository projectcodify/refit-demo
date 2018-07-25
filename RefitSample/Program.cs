using Refit;
using System;
using System.Threading.Tasks;

namespace RefitSample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var iexTradingClient = RestService.For<IIexTrading>("https://api.iextrading.com");

            var company = await iexTradingClient.GetCompanyAsync("AAPL");
        }
    }
}
