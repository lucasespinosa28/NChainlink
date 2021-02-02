using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get contract owner address
        /// </summary>
        /// <returns>
        ///     return string with contract owner address
        /// </returns>
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Model.OwnerFunction, string>(null, blockParameter);
        }
    }
}