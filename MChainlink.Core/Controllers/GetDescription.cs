using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the description of the underlying aggregator that the proxy points to.
        /// </summary>
        /// <returns>
        ///     The description of the underlying aggregator.
        /// </returns>
        public Task<string> DescriptionQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Model.DescriptionFunction, string>(null, blockParameter);
        }
    }
}