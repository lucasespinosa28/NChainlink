using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("proposeAggregator")]
        public class ProposeAggregatorRequestFunction : FunctionMessage
        {
            [Parameter("address", "_aggregator")] public virtual string Aggregator { get; set; }
        }

        [Function("proposedAggregator", "address")]
        public class ProposeAggregatorFunction : FunctionMessage
        {
        }
    }
}