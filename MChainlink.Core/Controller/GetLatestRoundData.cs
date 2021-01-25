using NChainlink;
using System.Threading.Tasks;
using System.Numerics;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<Model.RoundDataOutput> GetLatestRoundDataAsync()
        {
            var RounDataFunctionMessage = new Model.LatestRoundData(){};
            var RounDataHandler = Web3.Eth.GetContractQueryHandler<Model.LatestRoundData>();
            return await RounDataHandler.QueryDeserializingToObjectAsync<Model.RoundDataOutput>(RounDataFunctionMessage,contract);
        }
    }
}