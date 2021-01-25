using NChainlink;
using System.Numerics;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<short> GetPhaseIdAsync()
        {
            var OwnerOfFunctionMessage = new Model.PhaseId() { };
            var OwnerHandler = Web3.Eth.GetContractQueryHandler<Model.PhaseId>();
            return await OwnerHandler.QueryAsync<short>(contract, OwnerOfFunctionMessage);
        }
    }
}