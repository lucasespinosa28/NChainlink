using Nethereum.ABI.FunctionEncoding.Attributes;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Event("OwnershipTransferred")]
        public class OwnershipTransferredEventDto : IEventDTO
        {
            [Parameter("address", "from", 1, true)]
            public virtual string From { get; set; }

            [Parameter("address", "to", 2, true)] public virtual string To { get; set; }
        }
    }
}