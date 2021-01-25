using NChainlink;
using System.Numerics;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<Model.RoundDataOutput> GetProposedLatestRoundData()
        {
            var ProposedAggregatorOfFunctionMessage = new Model.ProposedLatestRoundData() { };
            var ProposedAggregatorHandler = Web3.Eth.GetContractQueryHandler <Model.ProposedLatestRoundData>();
            return await ProposedAggregatorHandler.QueryDeserializingToObjectAsync<Model.RoundDataOutput>(ProposedAggregatorOfFunctionMessage, contract);
        }
    }
}