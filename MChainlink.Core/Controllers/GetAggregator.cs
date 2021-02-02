using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

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
        public Task<string> AggregatorQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Model.AggregatorFunction, string>(null, blockParameter);
        }
    }
}