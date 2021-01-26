using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get contract owner address
        /// </summary>
        /// <returns>
        ///     return string with contract owner address
        /// </returns>
        public async Task<string> GetOwnerAsync()
        {
            var OwnerFunctionMessage = new Model.Owner();
            var OwnerHandler = Web.Eth.GetContractQueryHandler<Model.Owner>();
            return await OwnerHandler.QueryAsync<string>(Contract, OwnerFunctionMessage);
        }
    }
}