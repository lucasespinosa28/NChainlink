using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get aggregator address
        /// </summary>
        /// <returns>
        ///     The aggregator address
        /// </returns>
        public Task<string> GetAggregatorAsync() => Contract.GetFunction("aggregator").CallAsync<string>();
    }
}