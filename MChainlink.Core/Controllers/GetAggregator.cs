using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get aggregator address
        /// </summary>
        /// <returns>
        ///     The aggregator address
        /// </returns>
        public async Task<string> GetAggregatorAsync()
        {
            var AggregatorFunctionMessage = new Model.Aggregator();
            var AggregatorHandler = Web.Eth.GetContractQueryHandler<Model.Aggregator>();
            return await AggregatorHandler.QueryAsync<string>(Contract, AggregatorFunctionMessage);
        }
    }
}