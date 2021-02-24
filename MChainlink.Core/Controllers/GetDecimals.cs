using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///    Get the number of decimals present in the response value.
        /// </summary>
        /// <returns>
        ///   An int with number of decimals.
        /// </returns>
        public Task<int> GetDecimalsAsync() => Contract.GetFunction("decimals").CallAsync<int>();
    }
}