using NChainlink;
using System.Numerics;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<BigInteger> GetVersionAsync()
        {
            var VersionFunctionMessage = new Model.Version() { };
            var VersionHandler = Web3.Eth.GetContractQueryHandler<Model.Version>();
            return await VersionHandler.QueryAsync<BigInteger>(contract, VersionFunctionMessage);
        }
    }
}