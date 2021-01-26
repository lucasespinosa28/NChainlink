using System.Threading.Tasks;
using NChainlink.Models;

namespace NChainlink.Controllers
{
    public partial class Pricefeed
    {
        /// <summary>
        ///     Get the number of decimals present in the response value.
        /// </summary>
        /// <returns>
        ///     The number of decimals.
        /// </returns>
        public async Task<int> GetDecimalsAsync()
        {
            var DecimalsFunctionMessage = new Model.Decimals();
            var DecimalsHandler = Web.Eth.GetContractQueryHandler<Model.Decimals>();
            return await DecimalsHandler.QueryAsync<int>(Contract, DecimalsFunctionMessage);
        }
    }
}