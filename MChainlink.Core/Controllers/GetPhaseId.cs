using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Return the current phase's ID.
        /// </summary>
        public async Task<short> GetPhaseIdAsync()
        {
            var OwnerOfFunctionMessage = new Model.PhaseId();
            var OwnerHandler = Web.Eth.GetContractQueryHandler<Model.PhaseId>();
            return await OwnerHandler.QueryAsync<short>(Contract, OwnerOfFunctionMessage);
        }
    }
}