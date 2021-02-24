using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <returns>
        ///     A string with aggregator address
        /// </returns>
        public Task<string> GetProposedAggregatorAsync() => Contract.GetFunction("proposedAggregator").CallAsync<string>();
    }
}