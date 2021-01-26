using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NChainlink.Models
{
    public partial class Model
    {
        [FunctionOutput]
        public class RoundDataOutput : IFunctionOutputDTO
        {
            [Parameter("uint80", "roundId")] public BigInteger RoundId { get; set; }

            [Parameter("uint256", "answer", 2)] public BigInteger Answer { get; set; }

            [Parameter("uint256", "startedAt", 3)] public long StartedAt { get; set; }

            [Parameter("uint256", "updatedAt", 4)] public long UpdatedAt { get; set; }

            [Parameter("uint80", "answeredInRound", 5)]
            public BigInteger AnsweredInRound { get; set; }
        }
    }
}