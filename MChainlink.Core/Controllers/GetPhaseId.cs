using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Return the current phase's ID.
        /// </summary>
        public Task<int> GetPhaseIdAsync() => Contract.GetFunction("phaseId").CallAsync<int>();
    }
}