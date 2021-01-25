using NChainlink;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<int> GetDecimalsAsync()
        {
            var DecimalsFunctionMessage = new Model.Decimals() { };
            var DecimalsHandler = Web3.Eth.GetContractQueryHandler<Model.Decimals>();
            return await DecimalsHandler.QueryAsync<int>(contract, DecimalsFunctionMessage);
        }
    }
}