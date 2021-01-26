using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("getRoundData")]
        public class RoundData : FunctionMessage
        {
            [Parameter("uint80", "_roundId")] public BigInteger RoundId { get; set; }
        }
    }
}