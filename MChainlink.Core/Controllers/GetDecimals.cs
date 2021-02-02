using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the number of decimals present in the response value.
        /// </summary>
        /// <returns>
        ///     The number of decimals.
        /// </returns>
        public Task<byte> DecimalsQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Model.DecimalsFunction, byte>(null, blockParameter);
        }
    }
}