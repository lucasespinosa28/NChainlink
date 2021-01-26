using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("proposedLatestRoundData")]
        public class ProposedLatestRoundData : FunctionMessage
        {
        }
    }
}