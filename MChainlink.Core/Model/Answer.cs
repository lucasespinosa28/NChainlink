using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace NChainlink
{
    public partial class Model
    {
        [Function("getAnswer", "uint256")]
        public class Answer : FunctionMessage
        {
            [Parameter("uint256", "_roundId", 1)]
            public BigInteger RoundId { get; set; }
        }
    }
}
