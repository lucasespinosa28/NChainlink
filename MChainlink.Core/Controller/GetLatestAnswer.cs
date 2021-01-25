using NChainlink;
using System.Threading.Tasks;
using System.Numerics;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<BigInteger> GetLatestAnswerAsync()
        {
            var AnswerFunctionMessage = new Model.LatestAnswer(){ };
            var AnswerHandler = Web3.Eth.GetContractQueryHandler<Model.LatestAnswer>();
            return await AnswerHandler.QueryAsync<BigInteger>(contract, AnswerFunctionMessage);
        }
    }
}