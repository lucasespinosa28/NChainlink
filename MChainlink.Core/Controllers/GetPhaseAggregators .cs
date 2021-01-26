using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Return the phase aggregators address
        /// </summary>
        public async Task<string> GetPhaseAggregatorsAsync(short input)
        {
            var PhaseAggregatorsFunctionMessage = new Model.PhaseAggregators
            {
                Input = input
            };
            var PhaseAggregatorsHandler = Web.Eth.GetContractQueryHandler<Model.PhaseAggregators>();
            return await PhaseAggregatorsHandler.QueryAsync<string>(Contract, PhaseAggregatorsFunctionMessage);
        }
    }
}