using System.Numerics;
using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Event("NewRound")]
        public class NewRoundEventDto : IEventDTO
        {
            [Parameter("uint256", "roundId", 1, true)]
            public virtual BigInteger RoundId { get; set; }

            [Parameter("address", "startedBy", 2, true)]
            public virtual string StartedBy { get; set; }

            [Parameter("uint256", "startedAt", 3, false)]
            public virtual BigInteger StartedAt { get; set; }
        }
    }
}