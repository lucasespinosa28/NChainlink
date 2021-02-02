using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get accessController contract address.
        /// </summary>
        /// <returns>
        ///     the accessController contract address.
        /// </returns>
        public Task<string> AccessControllerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Model.AccessControllerFunction, string>(null, blockParameter);
        }
    }
}