using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace NChainlink
{
    public partial class Model
    {
        [Function("getRoundData")]
        public class RoundData : FunctionMessage
        {
            [Parameter("uint80", "_roundId", 1)]
            public BigInteger RoundId { get; set; }
        }
    }
}
