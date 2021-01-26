using System.Numerics;
using System.Threading.Tasks;
using NChainlink.Models;

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
        public async Task<BigInteger> GetVersionAsync()
        {
            var VersionFunctionMessage = new Model.Version();
            var VersionHandler = Web.Eth.GetContractQueryHandler<Model.Version>();
            return await VersionHandler.QueryAsync<BigInteger>(Contract, VersionFunctionMessage);
        }
    }
}