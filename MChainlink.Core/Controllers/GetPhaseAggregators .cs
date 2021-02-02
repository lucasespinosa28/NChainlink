using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Return the phase aggregators address
        /// </summary>
        public Task<string> PhaseAggregatorsQueryAsync(ushort returnValue1, BlockParameter blockParameter = null) =>
            ContractHandler.QueryAsync<Model.PhaseAggregatorsFunction, string>(new Model.PhaseAggregatorsFunction { ReturnValue1 = returnValue1 },
                blockParameter);
    }
}