using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get accessController contract address.
        /// </summary>
        /// <returns>
        ///     A string with address.
        /// </returns>
        public Task<string> GetAccessControllerAsync() => Contract.GetFunction("accessController").CallAsync<string>();
    }
}