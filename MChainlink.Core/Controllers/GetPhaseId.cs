using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Return the current phase's ID.
        /// </summary>
        public Task<ushort> PhaseIdQueryAsync(Model.PhaseIdFunction phaseIdFunction = null,BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<Model.PhaseIdFunction, ushort>(phaseIdFunction, blockParameter);
        }
    }
}