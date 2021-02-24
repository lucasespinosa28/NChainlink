using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     The version representing the type of aggregator the proxy points to..
        /// </summary>
        /// <returns>
        ///     A int with version number.
        /// </returns>
        public Task<int> GetVersionAsync() => Contract.GetFunction("version").CallAsync<int>();
    }
}