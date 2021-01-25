using NChainlink;
using System.Numerics;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<string> GetOwnerAsync()
        {
            var OwnerFunctionMessage = new Model.Owner() { };
            var OwnerHandler = Web3.Eth.GetContractQueryHandler<Model.Owner>();
            return await OwnerHandler.QueryAsync<string>(contract, OwnerFunctionMessage);
        }
    }
}