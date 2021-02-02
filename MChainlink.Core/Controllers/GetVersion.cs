using System.Numerics;
using System.Threading.Tasks;
using NChainlink.Models;
using Nethereum.RPC.Eth.DTOs;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     The version representing the type of aggregator the proxy points to..
        /// </summary>
        /// <returns>
        ///     The version number.
        /// </returns>
        public Task<BigInteger> VersionQueryAsync(Model.VersionFunction versionFunction,
            BlockParameter blockParameter = null) =>
            ContractHandler.QueryAsync<Model.VersionFunction, BigInteger>(versionFunction, blockParameter);

        public Task<BigInteger> VersionQueryAsync(BlockParameter blockParameter = null) => ContractHandler.QueryAsync<Model.VersionFunction, BigInteger>(null, blockParameter);
    }
}