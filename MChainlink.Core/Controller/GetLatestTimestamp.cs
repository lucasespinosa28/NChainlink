using NChainlink;
using System.Threading.Tasks;
using System.Numerics;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<BigInteger> GetLatestTimestamp()
        {
            var LatestTimestampFunctionMessage = new Model.LatestTimestamp(){ };
            var LatestTimestampHandler = Web3.Eth.GetContractQueryHandler<Model.LatestTimestamp>();
            return await LatestTimestampHandler.QueryAsync<BigInteger>(contract, LatestTimestampFunctionMessage);
        }
    }
}