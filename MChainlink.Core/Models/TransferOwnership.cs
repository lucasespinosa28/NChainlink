using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("transferOwnership")]
        public class TransferOwnershipFunction : FunctionMessage
        {
            [Parameter("address", "_to")] public virtual string To { get; set; }
        }
    }
}