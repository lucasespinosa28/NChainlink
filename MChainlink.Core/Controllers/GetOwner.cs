using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get contract owner address
        /// </summary>
        /// <returns>
        ///     A string with contract owner address
        /// </returns>
        public Task<string> GetOwnerAsync() => Contract.GetFunction("owner").CallAsync<string>();
    }
}