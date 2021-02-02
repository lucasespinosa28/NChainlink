using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NChainlink.Models
{
    public partial class Model
    {
        [Function("phaseAggregators", "address")]
        public class PhaseAggregatorsFunction : FunctionMessage
        {
            [Parameter("uint16", "")] public virtual ushort ReturnValue1 { get; set; }
        }
    }
}