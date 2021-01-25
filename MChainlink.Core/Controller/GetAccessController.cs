using NChainlink;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<string> GeAccessControllerAsync()
        {
            var AccessControllerFunctionMessage = new Model.AccessController() { };
            var AccessControllerHandler = Web3.Eth.GetContractQueryHandler<Model.AccessController>();
            return await AccessControllerHandler.QueryAsync<string>(contract, AccessControllerFunctionMessage);
        }
    }
}