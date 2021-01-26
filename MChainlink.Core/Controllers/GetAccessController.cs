using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get accessController contract address.
        /// </summary>
        /// <returns>
        ///     the accessController contract address.
        /// </returns>
        public async Task<string> GeAccessControllerAsync()
        {
            var AccessControllerFunctionMessage = new Model.AccessController();
            var AccessControllerHandler = Web.Eth.GetContractQueryHandler<Model.AccessController>();
            return await AccessControllerHandler.QueryAsync<string>(Contract, AccessControllerFunctionMessage);
        }
    }
}