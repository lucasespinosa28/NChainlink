using NChainlink;
using System.Threading.Tasks;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<string> GetDescriptionAsync()
        {
            var descriptionFunctionMessage = new Model.Description() { };
            var descriptionHandler = Web3.Eth.GetContractQueryHandler<Model.Description>();
            return await descriptionHandler.QueryAsync<string>(contract, descriptionFunctionMessage);
        }
    }
}