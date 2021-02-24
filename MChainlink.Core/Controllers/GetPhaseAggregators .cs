using System.Threading.Tasks;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     A string with  the phase aggregators address
        /// </summary>
        /// 
        public Task<string> GetPhaseAggregatorsAsync(int id) => Contract.GetFunction("phaseAggregators").CallAsync<string>(id);
    }
}