using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the description of the underlying aggregator that the proxy points to.
        /// </summary>
        /// <returns>
        ///     A string with description of the underlying aggregator.
        /// </returns>
        public Task<string> GetDescriptionAsync() => Contract.GetFunction("description").CallAsync<string>();
    }
}