using Nethereum.ABI.FunctionEncoding.Attributes;
using System.Numerics;

namespace NChainlink
{
    public partial class Model
    {
        [FunctionOutput]
        public class RoundDataOutput : IFunctionOutputDTO
        {
            [Parameter("uint80", "roundId", 1)]
            public BigInteger RoundId { get; set; }

            [Parameter("uint256", "answer", 2)]
            public BigInteger Answer { get; set; }

            [Parameter("uint256", "startedAt", 3)]
            public long StartedAt { get; set; }

            [Parameter("uint256", "updatedAt", 4)]
            public long UpdatedAt { get; set; }

            [Parameter("uint80", "answeredInRound", 5)]
            public BigInteger AnsweredInRound { get; set; }
        }
    }
}
