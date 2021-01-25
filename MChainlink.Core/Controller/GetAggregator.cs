using NChainlink;
using System.Numerics;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<string> GetAggregatorAsync()
        {
            var AggregatorFunctionMessage = new Model.Aggregator() { };
            var AggregatorHandler = Web3.Eth.GetContractQueryHandler<Model.Aggregator>();
            return await AggregatorHandler.QueryAsync<string>(contract, AggregatorFunctionMessage);
        }
    }
}