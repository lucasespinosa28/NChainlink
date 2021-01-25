using NChainlink;
using System.Numerics;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<string> GetPhaseAggregatorsAsync(short input)
        {
            var PhaseAggregatorsFunctionMessage = new Model.PhaseAggregators() {
                Input = input
            };
            var PhaseAggregatorsHandler = Web3.Eth.GetContractQueryHandler<Model.PhaseAggregators>();
            return await PhaseAggregatorsHandler.QueryAsync<string>(contract, PhaseAggregatorsFunctionMessage);
        }
    }
}