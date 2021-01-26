using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the description of the underlying aggregator that the proxy points to.
        /// </summary>
        /// <returns>
        ///     The description of the underlying aggregator.
        /// </returns>
        public async Task<string> GetDescriptionAsync()
        {
            var DescriptionFunctionMessage = new Model.Description();
            var DescriptionHandler = Web.Eth.GetContractQueryHandler<Model.Description>();
            return await DescriptionHandler.QueryAsync<string>(Contract, DescriptionFunctionMessage);
        }
    }
}