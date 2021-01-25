using NChainlink;
using System.Threading.Tasks;
using System.Numerics;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<BigInteger> GetLatestRoundAsync()
        {
            var LatestRoundFunctionMessage = new Model.LatestRound(){ };
            var LatestRoundHandler = Web3.Eth.GetContractQueryHandler<Model.LatestRound>();
            return await LatestRoundHandler.QueryAsync<BigInteger>(contract, LatestRoundFunctionMessage);
        }
    }
}