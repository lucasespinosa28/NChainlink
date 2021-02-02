using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the proposed aggregator address
        /// </summary>
      
        public Task<string> ProposedAggregatorQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Model.ProposeAggregatorFunction, string>(null, blockParameter);
        }
    }
}