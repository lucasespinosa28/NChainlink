using NChainlink;
using System.Numerics;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<Model.RoundDataOutput> GetProposedGetRoundDataAsync(string roundId)
        {
            var ProposedAggregatorOfFunctionMessage = new Model.ProposedGetRoundData()
            {
                RoundId = BigInteger.Parse(roundId)
            };
            var ProposedAggregatorHandler = Web3.Eth.GetContractQueryHandler<Model.ProposedGetRoundData>();
            return await ProposedAggregatorHandler.QueryDeserializingToObjectAsync<Model.RoundDataOutput>(ProposedAggregatorOfFunctionMessage, contract);
        }
    }
}