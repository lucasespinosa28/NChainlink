using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("proposedGetRoundData")]
        public class ProposedGetRoundData : FunctionMessage
        {
            [Parameter("uint80", "_roundId")] public BigInteger RoundId { get; set; }
        }
    }
}