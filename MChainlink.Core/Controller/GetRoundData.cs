using NChainlink;
using System.Threading.Tasks;
using System.Numerics;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<Model.RoundDataOutput> GetRoundDataAsync(string roundId)
        {
            var RounDataFunctionMessage = new Model.RoundData(){
                RoundId = BigInteger.Parse(roundId)
            };
            var RounDataHandler = Web3.Eth.GetContractQueryHandler<Model.RoundData>();
            return await RounDataHandler.QueryDeserializingToObjectAsync<Model.RoundDataOutput>(RounDataFunctionMessage,contract);
        }
    }
}