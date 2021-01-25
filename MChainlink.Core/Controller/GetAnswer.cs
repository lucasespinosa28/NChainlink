using NChainlink;
using System.Threading.Tasks;
using System.Numerics;

namespace MChainlink
{
    public partial class Chainlink
    {
        public async Task<BigInteger> GetAnswerAsync(string roundId)
        {
            var AnswerFunctionMessage = new Model.Answer(){ 
                RoundId = BigInteger.Parse(roundId)
            };
            var AnswerHandler = Web3.Eth.GetContractQueryHandler<Model.Answer>();
            return await AnswerHandler.QueryAsync<BigInteger>(contract, AnswerFunctionMessage);
        }
    }
}