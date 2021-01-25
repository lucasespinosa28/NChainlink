using NChainlink;
using System.Numerics;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<string> GetProposedAggregatorAsync()
        {
            var ProposedAggregatorOfFunctionMessage = new Model.ProposedAggregator() { };
            var ProposedAggregatorHandler = Web3.Eth.GetContractQueryHandler<Model.ProposedAggregator>();
            return await ProposedAggregatorHandler.QueryAsync<string>(contract, ProposedAggregatorOfFunctionMessage);
        }
    }
}