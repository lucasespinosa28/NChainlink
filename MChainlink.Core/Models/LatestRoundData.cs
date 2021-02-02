using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("latestRoundData", typeof(LatestRoundDataOutputDto))]
        public class LatestRoundDataFunction : FunctionMessage
        {
        }

        [FunctionOutput]
        public class LatestRoundDataOutputDto : IFunctionOutputDTO
        {
            [Parameter("uint80", "roundId")] public virtual BigInteger RoundId { get; set; }

            [Parameter("int256", "answer", 2)] public virtual BigInteger Answer { get; set; }

            [Parameter("uint256", "startedAt", 3)] public virtual BigInteger StartedAt { get; set; }

            [Parameter("uint256", "updatedAt", 4)] public virtual BigInteger UpdatedAt { get; set; }

            [Parameter("uint80", "answeredInRound", 5)]
            public virtual BigInteger AnsweredInRound { get; set; }
        }
    }
}