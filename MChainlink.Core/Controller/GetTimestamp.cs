using NChainlink;
using System.Threading.Tasks;
using System.Numerics;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<BigInteger> GetTimestamp(string roundId)
        {
            var TimestampFunctionMessage = new Model.Timestamp (){
                RoundId = BigInteger.Parse(roundId)
            };
            var TimestampHandler = Web3.Eth.GetContractQueryHandler<Model.Timestamp>();
            return await TimestampHandler.QueryAsync<BigInteger>(contract, TimestampFunctionMessage);
        }
    }
}