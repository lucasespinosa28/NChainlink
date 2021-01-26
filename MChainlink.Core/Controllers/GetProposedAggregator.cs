using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the proposed aggregator addresss
        /// </summary>
        public async Task<string> GetProposedAggregatorAsync()
        {
            var ProposedAggregatorOfFunctionMessage = new Model.ProposedAggregator();
            var ProposedAggregatorHandler = Web.Eth.GetContractQueryHandler<Model.ProposedAggregator>();
            return await ProposedAggregatorHandler.QueryAsync<string>(Contract, ProposedAggregatorOfFunctionMessage);
        }
    }
}